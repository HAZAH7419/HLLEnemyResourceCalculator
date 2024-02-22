using System.Configuration;

namespace EnemyResourceCalculator
{
    public partial class ResourceCalculatorForm : Form
    {

        TimingCalculator TimingCalculator { get; set; } = new TimingCalculator();
        Resources Resources = new Resources();
        AbilityListDeclaration AbilityList = new AbilityListDeclaration();
        CommanderAbility CommanderAbilities = new CommanderAbility();
        DateTime MatchStartClick { get; set; } = DateTime.MinValue;
        DateTime AbilityClickAt { get;set; } = DateTime.MinValue;

        private int Fuel = 500;
        private int Munitions = 500;
        private int Manpower = 500;
        private int Rate = 30;
        private int Heavy1Counter = 0;
        private int Heavy2Counter = 0;
        private int FullNodesUp = 5310; // 90 Seconds into the match
        private int StartArtillery = 5220;

        public ResourceCalculatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblbxCounterHeavy1.Text = Heavy1Counter.ToString();
            lblbxCounterHeavy2.Text = Heavy2Counter.ToString();
        }

        private void btnStartMatch_Click(object sender, EventArgs e)
        {
            btnStartMatch.Visible= false;
            btnReset.Visible = true;
            lblbxMunitions.Text = Munitions.ToString();
            lblbxManpower.Text = Manpower.ToString();
            lblbxFuel.Text = Fuel.ToString();
            StartAbilityClicks();
            UpdateTimerControls();
            DisableRadioButtons();
        }

        private void StartAbilityClicks ()
        {
            MatchStartClick = DateTime.Now;
            foreach(var abilityTimer in AbilityList.Abilities)
            {
                abilityTimer.Timer = DateTime.Now;
            }
        }
        
        private void UpdateTimerControls()
        {
            matchTimerUpdateTimer.Start();
            resourceUpdateTimer.Start();
            precisionStrikeTimer.Start();
            strafingRunTimer.Start();
            airheadTimer.Start();
            lightTimer.Start();
            medTimer.Start();
            reconTimer.Start();
            supplyTimer.Start();
            transportTimer.Start();
            halfTrackTimer.Start();

            if(chkAssumeEncouraged.Checked)
            {
                encouragedTimer.Start();
            }

            if (rbUS.Checked)
            {
                bombingRunTimer.Start();
                jumbo76Timer.Start();
                jumbo75Timer.Start();
            }
            else if(rbGerman.Checked && chkNoPanther.Checked)
            {
                bombingRunTimer.Start();
                tigerTimer.Start();
            }
            else if (rbGerman.Checked && !chkNoPanther.Checked)
            {
                bombingRunTimer.Start();
                tigerTimer.Start();
                pantherTimer.Start();
            }
            else if(rbBritish.Checked)
            {
                bombingRunTimer.Start();
                churchillTimer.Start();
                fireflyTimer.Start();
            }
            else if(rbRussian.Checked)
            {
                katyushaStrikeTimer.Start();
                is1Timer.Start();
            }

        }

        private void matchTimerUpdateTimer_Tick(object sender, EventArgs e)
        {
            var ( remainingSeconds, displayTime) = TimingCalculator.Calculate(MatchStartClick, null);

            if (remainingSeconds < 1)
            {
                lblMatchCountdown.Text = "MATCH ENDED";
                lblMatchCountdown.BackColor = Color.Red;
            }
            else if( remainingSeconds < FullNodesUp) // 90 seconds
            {
                Resources.IsFullNodes = true;
                lblMatchCountdown.Text = displayTime;
            }
            else if ( remainingSeconds < StartArtillery) // After warmup
            {
                artilleryActiveTimer.Start();
            }
            else
            {
                lblMatchCountdown.Text = displayTime;
            }
        }

        private void resourceUpdateTimer_Tick(object sender, EventArgs e)
        {
            Rate = CalculateRate();

            //update the count of the resources
            Fuel = Fuel + Rate;
            Munitions = Munitions + Rate;
            Manpower = Manpower + Rate;

            //display the resource count in the form
            lblbxMunitions.Text = (Munitions).ToString();
            lblbxManpower.Text = (Manpower).ToString();
            lblbxFuel.Text = (Fuel).ToString();

            if(Resources.IsFullNodes )
            {
                if (Resources.IsEncouraged)
                {
                    lblbxMunitions.BackColor = Color.LightGreen;
                    lblbxManpower.BackColor = Color.LightGreen;
                    lblbxFuel.BackColor = Color.LightGreen;
                }
                else
                {
                    lblbxMunitions.BackColor = Color.LightYellow;
                    lblbxManpower.BackColor = Color.LightYellow;
                    lblbxFuel.BackColor = Color.LightYellow;
                }
            }
            else
            {
                lblbxMunitions.BackColor = Color.White;
                lblbxManpower.BackColor = Color.White;
                lblbxFuel.BackColor = Color.White;
            }
        }

        private void abilityCooldownTimer_Tick(object sender, EventArgs e)
        {

            var activeAbilities = AbilityList.Abilities.Where(a => a.IsActive);
            var abilityClick = new DateTime();
            var timeUntilExpired = new TimeSpan();
            var remainingSeconds = 0d;

            foreach (var ability in activeAbilities)
            {
                abilityClick = TimingCalculator.AbilityStartTimer(MatchStartClick, ability.Cooldown);
                timeUntilExpired = abilityClick - DateTime.Now;
                remainingSeconds = Math.Round(timeUntilExpired.TotalSeconds);

                TimeSpan time = TimeSpan.FromSeconds(remainingSeconds);
                DateTime dateTime = DateTime.Today.Add(time);
                var displayTime = dateTime.ToString("mm:ss");

                ability.DisplayTime= displayTime;
                showTimers(ability, remainingSeconds);
            }

        }

        private void showTimers(CommanderAbility ability, double remainingSeconds)
        {
            switch(ability.Name)
            {
                case CommanderAbility.AbilityName.BombingRun:
                    lblbxBombingRun.Text = (remainingSeconds <= 0) ? "Ready" : ability.DisplayTime;
                    lblbxBombingRun.BackColor = (lblbxBombingRun.Text == "Ready") ? Color.LightGreen : Color.LightGray;
                    break;
                case CommanderAbility.AbilityName.PrecisionStrike:
                    lblbxPrecisionStrike.Text = (remainingSeconds <= 0) ? "Ready" : ability.DisplayTime;
                    lblbxBombingRun.BackColor = (lblbxPrecisionStrike.Text == "Ready") ? Color.LightGreen : Color.LightGray;
                    break;
                case CommanderAbility.AbilityName.KatyushaStrike:
                    lblbxKatyushaStrike.Text = (remainingSeconds <= 0) ? "Ready" : ability.DisplayTime;
                    lblbxBombingRun.BackColor = (lblbxKatyushaStrike.Text == "Ready") ? Color.LightGreen : Color.LightGray;
                    break;
                case CommanderAbility.AbilityName.StrafingRun:
                    lblbxStrafingRun.Text = (remainingSeconds <= 0) ? "Ready" : ability.DisplayTime;
                    lblbxBombingRun.BackColor = (lblbxStrafingRun.Text == "Ready") ? Color.LightGreen : Color.LightGray;
                    break;

            }
        }

        private void UpdateResourceCount()
        {
            lblbxMunitions.Text = Munitions.ToString();
            lblbxManpower.Text = Manpower.ToString();
            lblbxFuel.Text = Fuel.ToString();
        }

        private int CalculateRate()
        {
            if(Resources.IsFullNodes)
            {
                if(Resources.IsEncouraged)
                {
                    lblMunitionsRate.Text = $"{Resources.EncouragedRate}/m";
                    lblManpowerRate.Text = $"{Resources.EncouragedRate}/m";
                    lblFuelRate.Text = $"{Resources.EncouragedRate}/m";
                    return Resources.EncouragedRate;
                }
                else
                {
                    lblMunitionsRate.Text = $"{Resources.FullRate}/m";
                    lblManpowerRate.Text = $"{Resources.FullRate}/m";
                    lblFuelRate.Text = $"{Resources.FullRate}/m";
                    return Resources.FullRate;
                }
            }
            else
            {
                return Resources.DefaultRate;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
            ResetTimers();
            EnableRadioButtons();
        }

        // Stops timers
        private void ResetTimers()
        {
            matchTimerUpdateTimer.Stop();
            bombingRunTimer.Stop();
            precisionStrikeTimer.Stop();
            airheadTimer.Stop();
            abilityCooldownTimer.Stop();
            strafingRunTimer.Stop();
            katyushaStrikeTimer.Stop();
            jumbo76Timer.Stop();
            jumbo75Timer.Stop();
            lightTimer.Stop();
            medTimer.Stop();
            reconTimer.Stop();  
            transportTimer.Stop();
            supplyTimer.Stop();
            halfTrackTimer.Stop();
            tigerTimer.Stop();
            pantherTimer.Stop();
            churchillTimer.Stop();
            fireflyTimer.Stop();
            is1Timer.Stop();

            encouragedTimer.Stop();
        }

        private void ResetValues()
        {

            // Creates new Resources Instance
            Resources = new Resources();

            ResetAbilities();

            // Resets Resource Values
            Munitions = Resources.Munitions;
            Manpower = Resources.Manpower;
            Fuel = Resources.Fuel;
            Rate = Resources.DefaultRate;

            //Resets Counters
            Heavy1Counter = 0;
            Heavy2Counter = 0;
            lblbxCounterHeavy1.Text = "0";
            lblbxCounterHeavy2.Text = "0";

            // Resets Resource Text values
            lblMunitionsRate.Text = "30/m";
            lblManpowerRate.Text = "30/m";
            lblFuelRate.Text = "30/m";
            lblbxMunitions.Text = "500";
            lblbxManpower.Text = "500";
            lblbxFuel.Text = "500";
           
            // Resets Match Timer Text Value
            lblMatchCountdown.Text = "";
            lblMatchCountdown.BackColor = Color.White;
            lblbxMunitions.BackColor = Color.White;
            lblbxManpower.BackColor = Color.White;
            lblbxFuel.BackColor = Color.White;

            //Resets button visibility
            btnReset.Visible = false;
            btnStartMatch.Visible = true;
        }

        public void ResetAbilities()
        {
            // Resets Ability Text Values
            lblbxPrecisionStrike.Text = "";
            lblbxAirhead.Visible = true;
            btnUsePrecisionStrike.Visible = false;
            lblbxStrafingRun.Text = "";
            lblbxStrafingRun.Visible = true;
            btnUseStrafingRun.Visible= false;
            lblbxAirhead.Text = "";
            lblbxAirhead.Visible= true;
            btnUseAirhead.Visible= false;
            lblbxLightTank.Text = "";
            lblbxLightTank.Visible = true;
            btnUseLightTank.Visible = false;
            lblbxMedTank.Text = "";
            lblbxMedTank.Visible= true;
            btnUseMedTank.Visible = false;
            lblbxReconTank.Text = "";
            lblbxReconTank.Visible = true;
            btnUseReconTank.Visible= false;
            lblbxTransportTruck.Text = "";
            lblbxTransportTruck.Visible= true;
            btnUseTransportTruck.Visible = false;
            lblbxSupplyTruck.Text = "";
            lblbxSupplyTruck.Visible= true;
            btnUseSupplyTruck.Visible = false;
            lblbxHalfTrack.Text = "";
            lblbxHalfTrack.Visible= true;
            btnUseHalfTrack.Visible = false;
            
            if (rbUS.Checked)
            {
                lblbxJumbo76.Text = "";
                lblbxJumbo76.Visible= true;
                btnUseJumbo76.Visible= false;
                lblbxJumbo75.Text = "";
                lblbxJumbo75.Visible = true;
                btnUseJumbo75.Visible = false;

                lblbxBombingRun.Text = "";
                btnUseBombingRun.Visible = false;
                lblbxBombingRun.Visible = true;

                lblbxCounterHeavy2.Visible = true;
            }
            else if (rbGerman.Checked && chkNoPanther.Checked)
            {
                lblbxTiger.Text = "";
                lblbxTiger.Visible= true;
                btnUseTiger.Visible = false;

                lblbxBombingRun.Text = "";
                btnUseBombingRun.Visible = false;
                lblbxBombingRun.Visible = true;

                lblbxCounterHeavy2.Visible = false;
            }
            else if (rbGerman.Checked && !chkNoPanther.Checked)
            {
                lblbxTiger.Text = "";
                lblbxTiger.Visible = true;
                btnUseTiger.Visible = false;
                lblbxPanther.Text = "";
                lblbxPanther.Visible = true;
                btnUsePanther.Visible = false;

                lblbxBombingRun.Text = "";
                btnUseBombingRun.Visible = false;
                lblbxBombingRun.Visible = true;

                lblbxCounterHeavy2.Visible = true;
            }
            else if (rbBritish.Checked)
            {
                lblbxChurchill.Text = "";
                lblbxChurchill.Visible= true;
                btnUseChurchill.Visible= false;
                lblbxFirefly.Text = "";
                lblbxFirefly.Visible= true;
                btnUseFirefly.Visible = false;

                lblbxBombingRun.Text = "";
                btnUseBombingRun.Visible = false;
                lblbxBombingRun.Visible = true;

                lblbxCounterHeavy2.Visible = true;
            }
            else if (rbRussian.Checked)
            {
                lblbxKatyushaStrike.Text = "";
                lblbxKatyushaStrike.Visible = true;
                btnUseKatyushaStrike.Visible = false;

                lblbxIS1.Text= "";
                lblbxIS1.Visible= true;
                btnUseIS1.Visible = false;

                lblbxCounterHeavy2.Visible = false;
            }
        }

        public void bombingRunTimer_Tick(object sender, EventArgs e)
        {

            var bombingRun = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.BombingRun);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(bombingRun.Timer, bombingRun);

            if (remainingSeconds < 1)
            {
                lblbxBombingRun.Text = "";
                lblbxBombingRun.Visible = false;
                btnUseBombingRun.Visible = true;

            }
            else
            {
                lblbxBombingRun.Text = displayTime;
            }
        }

        private void btnUseBombingRun_Click(object sender, EventArgs e)
        {
            var bombingRun = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.BombingRun);
            bombingRun.Timer = DateTime.Now;
            bombingRunTimer.Start();
            btnUseBombingRun.Visible = false;
            lblbxBombingRun.Visible = true;
            Munitions = Munitions - bombingRun.Cost;
            UpdateResourceCount();

        }

        private void precisionStrikeTimer_Tick(object sender, EventArgs e)
        {
            var precisionStrike = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.PrecisionStrike);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(precisionStrike.Timer, precisionStrike);

            if (remainingSeconds < 1)
            {
                lblbxPrecisionStrike.Text = "";
                lblbxPrecisionStrike.Visible = false;
                btnUsePrecisionStrike.Visible = true;

            }
            else
            {
                lblbxPrecisionStrike.Text = displayTime;
            }
        }

        private void btnUsePrecisionStrike_Click(object sender, EventArgs e)
        {
            var precisionStrike = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.PrecisionStrike);
            precisionStrike.Timer = DateTime.Now;
            precisionStrikeTimer.Start();
            btnUsePrecisionStrike.Visible = false;
            lblbxPrecisionStrike.Visible = true;
            Munitions = Munitions - precisionStrike.Cost;
            UpdateResourceCount();


        }

        private void airheadTimer_Tick(object sender, EventArgs e)
        {
            var airhead = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Airhead);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(airhead.Timer, airhead);

            if (remainingSeconds < 1)
            {
                lblbxAirhead.Text = "";
                lblbxAirhead.Visible = false;
                btnUseAirhead.Visible = true;

            }
            else
            {
                lblbxAirhead.Text = displayTime;
            }

        }

        private void btnUseAirhead_Click(object sender, EventArgs e)
        {
            var airhead = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Airhead);
            airhead.Timer = DateTime.Now;
            airheadTimer.Start();
            btnUseAirhead.Visible = false;
            lblbxAirhead.Visible = true;
            Manpower = Manpower - airhead.Cost;
            UpdateResourceCount();


        }

        private void strafingRunTimer_Tick(object sender, EventArgs e)
        {
            var strafingRun = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.StrafingRun);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(strafingRun.Timer, strafingRun);

            if (remainingSeconds < 1)
            {
                lblbxStrafingRun.Text = "";
                lblbxStrafingRun.Visible = false;
                btnUseStrafingRun.Visible = true;

            }
            else
            {
                lblbxStrafingRun.Text = displayTime;
            }

        }

        private void btnUseStrafingRun_Click(object sender, EventArgs e)
        {
            var strafingRun = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.StrafingRun);
            strafingRun.Timer = DateTime.Now;
            strafingRunTimer.Start();
            btnUseStrafingRun.Visible = false;
            lblbxStrafingRun.Visible = true;
            Munitions = Munitions - strafingRun.Cost;
            UpdateResourceCount();
        }

        private void katyushaStrikeTimer_Tick(object sender, EventArgs e)
        {
            var katyushaStrike = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.KatyushaStrike);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(katyushaStrike.Timer, katyushaStrike);

            if (remainingSeconds < 1)
            {
                lblbxKatyushaStrike.Text = "";
                lblbxKatyushaStrike.Visible = false;
                btnUseKatyushaStrike.Visible = true;

            }
            else
            {
                lblbxKatyushaStrike.Text = displayTime;
            }
        }

        private void btnUseKatyushaStrike_Click(object sender, EventArgs e)
        {
            var katyusha = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.KatyushaStrike);
            katyusha.Timer = DateTime.Now;
            katyushaStrikeTimer.Start();
            btnUseKatyushaStrike.Visible = false;
            lblbxKatyushaStrike.Visible = true;
            Munitions = Munitions - katyusha.Cost;
            UpdateResourceCount();
        }

        private void ShowHideAbilities(CommanderAbility.FactionType faction)
        {

            switch (faction)
            {
                case CommanderAbility.FactionType.British:
                    ToggleUSAssets(false);
                    ToggleGermanAssets(false);
                    ToggleRussianhAssets(false);
                    ToggleBritishAssets(true);
                    lblbxCounterHeavy2.Visible = true;
                    chkNoPanther.Enabled= false;
                    break;
                case CommanderAbility.FactionType.US:
                    ToggleGermanAssets(false);
                    ToggleBritishAssets(false);
                    ToggleRussianhAssets(false);
                    ToggleUSAssets(true);
                    lblbxCounterHeavy2.Visible = true;
                    chkNoPanther.Enabled = false;
                    break;
                case CommanderAbility.FactionType.German:
                    ToggleUSAssets(false);
                    ToggleBritishAssets(false);
                    ToggleRussianhAssets(false);
                    ToggleGermanAssets(true);
                    lblbxCounterHeavy2.Visible = true;
                    chkNoPanther.Enabled = true;
                    break;
                case CommanderAbility.FactionType.Russian:
                    ToggleUSAssets(false);
                    ToggleGermanAssets(false);
                    ToggleBritishAssets(false);
                    ToggleRussianhAssets(true);
                    lblbxCounterHeavy2.Visible = false;
                    chkNoPanther.Enabled = false;
                    break;

            }
        }

        private void ToggleUSAssets(bool toggle)
        {
            lblBombingRun.Visible = toggle;
            lblbxBombingRun.Visible = toggle;

            lblJumbo76.Visible = toggle;
            lblbxJumbo76.Visible = toggle;
            lblJumbo75.Visible = toggle;
            lblbxJumbo75.Visible = toggle;

            lblbxCounterHeavy2.Visible = toggle;
        }

        private void ToggleGermanAssets(bool toggle)
        {
            lblBombingRun.Visible = toggle;
            lblbxBombingRun.Visible = toggle;

            lblTiger.Visible = toggle;
            lblbxTiger.Visible = toggle;
            lblPanther.Visible = toggle;
            lblbxPanther.Visible = toggle;

            lblbxCounterHeavy2.Visible = toggle;
        }

        private void ToggleBritishAssets(bool toggle)
        {
            lblBombingRun.Visible = toggle;
            lblbxBombingRun.Visible = toggle;

            lblChurchill.Visible = toggle;
            lblbxChurchill.Visible = toggle;
            lblFirefly.Visible = toggle;
            lblbxFirefly.Visible = toggle;

            lblbxCounterHeavy2.Visible = toggle;
        }

        private void ToggleRussianhAssets(bool toggle)
        {
            lblKatyushaStrike.Visible = toggle;
            lblbxKatyushaStrike.Visible = toggle;

            lblIS1.Visible = toggle;
            lblbxIS1.Visible = toggle;
        }

        private void DisableRadioButtons()
        {
            rbUS.Enabled = false;
            rbBritish.Enabled = false;
            rbGerman.Enabled = false;
            rbRussian.Enabled = false;
            chkAssumeEncouraged.Enabled = false;
            chkArtyGun.Enabled = false;
            chkNoPanther.Enabled = false;
        }

        private void EnableRadioButtons()
        {
            rbUS.Enabled = true;
            rbBritish.Enabled = true;
            rbGerman.Enabled = true;
            rbRussian.Enabled = true;
            chkAssumeEncouraged.Enabled = true;
            chkArtyGun.Enabled= true;
            chkNoPanther.Enabled = true;
        }

        private void jumbo76Timer_Tick(object sender, EventArgs e)
        {
            var jumbo76 = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Jumbo76);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(jumbo76.Timer, jumbo76);

            if (remainingSeconds < 1)
            {
                lblbxJumbo76.Text = "";
                lblbxJumbo76.Visible = false;
                btnUseJumbo76.Visible = true;

            }
            else
            {
                lblbxJumbo76.Text = displayTime;
            }
        }

        private void btnUseJumbo76_Click(object sender, EventArgs e)
        {
            Heavy1Counter++;
            lblbxCounterHeavy1.Text = Heavy1Counter.ToString();
            var jumbo76 = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Jumbo76);
            jumbo76.Timer = DateTime.Now;
            jumbo76Timer.Start();
            btnUseJumbo76.Visible = false;
            lblbxJumbo76.Visible = true;
            Fuel = Fuel - jumbo76.Cost;
            UpdateResourceCount();
        }

        private void jumbo75Timer_Tick(object sender, EventArgs e)
        {
            var jumbo75 = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Jumbo75);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(jumbo75.Timer, jumbo75);

            if (remainingSeconds < 1)
            {
                lblbxJumbo75.Text = "";
                lblbxJumbo75.Visible = false;
                btnUseJumbo75.Visible = true;

            }
            else
            {
                lblbxJumbo75.Text = displayTime;
            }
        }

        private void btnUseJumbo75_Click(object sender, EventArgs e)
        {
            Heavy2Counter++;
            lblbxCounterHeavy2.Text = Heavy2Counter.ToString();
            var jumbo75 = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Jumbo75);
            jumbo75.Timer = DateTime.Now;
            jumbo75Timer.Start();
            btnUseJumbo75.Visible = false;
            lblbxJumbo75.Visible = true;
            Fuel = Fuel - jumbo75.Cost;
            UpdateResourceCount();
        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            var lightTank = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.LightTank);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(lightTank.Timer, lightTank);

            if (remainingSeconds < 1)
            {
                lblbxLightTank.Text = "";
                lblbxLightTank.Visible = false;
                btnUseLightTank.Visible = true;

            }
            else
            {
                lblbxLightTank.Text = displayTime;
            }
        }

        private void btnUseLightTank_Click(object sender, EventArgs e)
        {
            var lightTank = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.LightTank);
            lightTank.Timer = DateTime.Now;
            lightTimer.Start();
            btnUseLightTank.Visible = false;
            lblbxLightTank.Visible = true;
            Fuel = Fuel - lightTank.Cost;
            UpdateResourceCount();
        }

        private void medTimer_Tick(object sender, EventArgs e)
        {
            var medTank = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.MediumTank);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(medTank.Timer, medTank);

            if (remainingSeconds < 1)
            {
                lblbxMedTank.Text = "";
                lblbxMedTank.Visible = false;
                btnUseMedTank.Visible = true;

            }
            else
            {
                lblbxMedTank.Text = displayTime;
            }
        }

        private void btnUseMedTank_Click(object sender, EventArgs e)
        {
            var medTank = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.MediumTank);
            medTank.Timer = DateTime.Now;
            medTimer.Start();
            btnUseMedTank.Visible = false;
            lblbxMedTank.Visible = true;
            Fuel = Fuel - medTank.Cost;
            UpdateResourceCount();
        }

        private void reconTimer_Tick(object sender, EventArgs e)
        {
            var reconTank = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.ReconTank);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(reconTank.Timer, reconTank);

            if (remainingSeconds < 1)
            {
                lblbxReconTank.Text = "";
                lblbxReconTank.Visible = false;
                btnUseReconTank.Visible = true;

            }
            else
            {
                lblbxReconTank.Text = displayTime;
            }
        }

        private void btnUseReconTank_Click(object sender, EventArgs e)
        {
            var reconTank = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.ReconTank);
            reconTank.Timer = DateTime.Now;
            reconTimer.Start();
            btnUseReconTank.Visible = false;
            lblbxReconTank.Visible = true;
            Fuel = Fuel - reconTank.Cost;
            UpdateResourceCount();
        }

        private void transportTimer_Tick(object sender, EventArgs e)
        {
            var transport = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.TransportTruck);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(transport.Timer, transport);

            if (remainingSeconds < 1)
            {
                lblbxTransportTruck.Text = "";
                lblbxTransportTruck.Visible = false;
                btnUseTransportTruck.Visible = true;

            }
            else
            {
                lblbxTransportTruck.Text = displayTime;
            }
        }

        private void btnUseTransportTruck_Click(object sender, EventArgs e)
        {
            var transport = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.TransportTruck);
            transport.Timer = DateTime.Now;
            transportTimer.Start();
            btnUseTransportTruck.Visible = false;
            lblbxTransportTruck.Visible = true;
            Fuel = Fuel - transport.Cost;
            UpdateResourceCount();
        }

        private void supplyTimer_Tick(object sender, EventArgs e)
        {
            var supply = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.SupplyTruck);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(supply.Timer, supply);

            if (remainingSeconds < 1)
            {
                lblbxSupplyTruck.Text = "";
                lblbxSupplyTruck.Visible = false;
                btnUseSupplyTruck.Visible = true;

            }
            else
            {
                lblbxSupplyTruck.Text = displayTime;
            }
        }

        private void btnUseSupplyTruck_Click(object sender, EventArgs e)
        {
            var supply = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.SupplyTruck);
            supply.Timer = DateTime.Now;
            supplyTimer.Start();
            btnUseSupplyTruck.Visible = false;
            lblbxSupplyTruck.Visible = true;
            Fuel = Fuel - supply.Cost;
            UpdateResourceCount();
        }

        private void halfTrackTimer_Tick(object sender, EventArgs e)
        {
            var halfTrack = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.HalfTrack);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(halfTrack.Timer, halfTrack);

            if (remainingSeconds < 1)
            {
                lblbxHalfTrack.Text = "";
                lblbxHalfTrack.Visible = false;
                btnUseHalfTrack.Visible = true;

            }
            else
            {
                lblbxHalfTrack.Text = displayTime;
            }
        }

        private void btnUseHalfTrack_Click(object sender, EventArgs e)
        {
            var halfTrack = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.HalfTrack);
            halfTrack.Timer = DateTime.Now;
            halfTrackTimer.Start();
            btnUseHalfTrack.Visible = false;
            lblbxHalfTrack.Visible = true;
            Fuel = Fuel - halfTrack.Cost;
            UpdateResourceCount();
        }

        private void tigerTimer_Tick(object sender, EventArgs e)
        {
            var tiger = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Tiger);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(tiger.Timer, tiger);

            if (remainingSeconds < 1)
            {
                lblbxTiger.Text = "";
                lblbxTiger.Visible = false;
                btnUseTiger.Visible = true;

            }
            else
            {
                lblbxTiger.Text = displayTime;
            }
        }

        private void btnUseTiger_Click(object sender, EventArgs e)
        {
            Heavy1Counter++;
            lblbxCounterHeavy1.Text = Heavy1Counter.ToString();
            var tiger = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Tiger);
            tiger.Timer = DateTime.Now;
            tigerTimer.Start();
            btnUseTiger.Visible = false;
            lblbxTiger.Visible = true;
            Fuel = Fuel - tiger.Cost;
            UpdateResourceCount();
        }

        private void pantherTimer_Tick(object sender, EventArgs e)
        {
            var panther = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Panther);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(panther.Timer, panther);

            if (remainingSeconds < 1)
            {
                lblbxPanther.Text = "";
                lblbxPanther.Visible = false;
                btnUsePanther.Visible = true;

            }
            else
            {
                lblbxPanther.Text = displayTime;
            }
        }

        private void btnUsePanther_Click(object sender, EventArgs e)
        {
            Heavy2Counter++;
            lblbxCounterHeavy2.Text = Heavy2Counter.ToString();
            var panther = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Panther);
            panther.Timer = DateTime.Now;
            pantherTimer.Start();
            btnUsePanther.Visible = false;
            lblbxPanther.Visible = true;
            Fuel = Fuel - panther.Cost;
            UpdateResourceCount();
        }

        private void churchillTimer_Tick(object sender, EventArgs e)
        {
            var churchill = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Churchill);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(churchill.Timer, churchill);

            if (remainingSeconds < 1)
            {
                lblbxChurchill.Text = "";
                lblbxChurchill.Visible = false;
                btnUseChurchill.Visible = true;

            }
            else
            {
                lblbxChurchill.Text = displayTime;
            }
        }

        private void btnUseChurchill_Click(object sender, EventArgs e)
        {
            Heavy1Counter++;
            lblbxCounterHeavy1.Text = Heavy1Counter.ToString();
            var churchill = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Churchill);
            churchill.Timer = DateTime.Now;
            churchillTimer.Start();
            btnUseChurchill.Visible = false;
            lblbxChurchill.Visible = true;
            Fuel = Fuel - churchill.Cost;
            UpdateResourceCount();
        }

        private void fireflyTimer_Tick(object sender, EventArgs e)
        {
            var fireFly = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Firefly);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(fireFly.Timer, fireFly);

            if (remainingSeconds < 1)
            {
                lblbxFirefly.Text = "";
                lblbxFirefly.Visible = false;
                btnUseFirefly.Visible = true;

            }
            else
            {
                lblbxFirefly.Text = displayTime;
            }
        }

        private void btnUseFirefly_Click(object sender, EventArgs e)
        {
            Heavy2Counter++;
            lblbxCounterHeavy2.Text = Heavy2Counter.ToString();
            var fireFly = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.Firefly);
            fireFly.Timer = DateTime.Now;
            fireflyTimer.Start();
            btnUseFirefly.Visible = false;
            lblbxFirefly.Visible = true;
            Fuel = Fuel - fireFly.Cost;
            UpdateResourceCount();
        }

        private void is1Timer_Tick(object sender, EventArgs e)
        {
            var is1 = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.IS1);
            var (remainingSeconds, displayTime) = TimingCalculator.Calculate(is1.Timer, is1);

            if (remainingSeconds < 1)
            {
                lblbxIS1.Text = "";
                lblbxIS1.Visible = false;
                btnUseIS1.Visible = true;

            }
            else
            {
                lblbxIS1.Text = displayTime;
            }
        }

        private void btnUseIS1_Click(object sender, EventArgs e)
        {
            Heavy1Counter++;
            lblbxCounterHeavy1.Text = Heavy1Counter.ToString();
            var is1 = AbilityList.Abilities.FirstOrDefault(a => a.Name == CommanderAbility.AbilityName.IS1);
            is1.Timer = DateTime.Now;
            is1Timer.Start();
            btnUseIS1.Visible = false;
            lblbxIS1.Visible = true;
            Fuel = Fuel - is1.Cost;
            UpdateResourceCount();
        }

        private void rbBritish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBritish.Checked)
            {
                ShowHideAbilities(CommanderAbility.FactionType.British);
            }
        }

        private void rbUS_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUS.Checked)
            {
                ShowHideAbilities(CommanderAbility.FactionType.US);
            }
        }

        private void rbGerman_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGerman.Checked)
            {
                ShowHideAbilities(CommanderAbility.FactionType.German);

                if(chkNoPanther.Checked)
                {
                    lblPanther.Visible= false;
                    lblbxPanther.Visible = false;
                }
            }
        }

        private void rbRussian_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRussian.Checked)
            {
                ShowHideAbilities(CommanderAbility.FactionType.Russian);
            }
        }

        private void chkNoPanther_CheckedChanged(object sender, EventArgs e)
        {
            if(chkNoPanther.Checked && rbGerman.Checked)
            {
                lblbxPanther.Visible = false;
                lblPanther.Visible = false;
                lblbxCounterHeavy2.Visible = false;
            }
            else
            {
                lblbxPanther.Visible = true;
                lblPanther.Visible = true;
                lblbxCounterHeavy2.Visible = true;
            }
        }

        private void chkAssumeEncouraged_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void encouragedTimer_Tick(object sender, EventArgs e)
        {
            encouragedActiveTimer.Start();
            Resources.IsEncouraged = true;
        }

        private void encouragedActiveTimer_Tick(object sender, EventArgs e)
        {
            Resources.IsEncouraged = false;
            encouragedActiveTimer.Stop();
        }

        private void chkArtyGun_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void artilleryTimer_Tick(object sender, EventArgs e)
        {
 
        }

        private void artilleryActiveTimer_Tick(object sender, EventArgs e)
        {
            if (chkArtyGun.Checked)
            {
                Munitions = Munitions - 3;
            }
        }
    }
}