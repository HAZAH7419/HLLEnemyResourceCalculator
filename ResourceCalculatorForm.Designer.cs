using EnemyResourceCalculator.AbilityControls;

namespace EnemyResourceCalculator
{
    partial class ResourceCalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceCalculatorForm));
            this.btnStartMatch = new System.Windows.Forms.Button();
            this.lblMatchCountdown = new System.Windows.Forms.Label();
            this.matchTimerUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMunitions = new System.Windows.Forms.Label();
            this.lblManpower = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblbxMunitions = new System.Windows.Forms.Label();
            this.lblbxManpower = new System.Windows.Forms.Label();
            this.lblbxFuel = new System.Windows.Forms.Label();
            this.lblMunitionsRate = new System.Windows.Forms.Label();
            this.lblManpowerRate = new System.Windows.Forms.Label();
            this.lblFuelRate = new System.Windows.Forms.Label();
            this.gbResourceGroup = new System.Windows.Forms.GroupBox();
            this.lblbxPrecisionStrike = new System.Windows.Forms.Label();
            this.lblPrecisionStrike = new System.Windows.Forms.Label();
            this.lblBombingRun = new System.Windows.Forms.Label();
            this.lblbxBombingRun = new System.Windows.Forms.Label();
            this.abilityCooldownTimer = new System.Windows.Forms.Timer(this.components);
            this.lblKatyushaStrike = new System.Windows.Forms.Label();
            this.lblbxKatyushaStrike = new System.Windows.Forms.Label();
            this.lblbxStrafingRun = new System.Windows.Forms.Label();
            this.lblStrafingRun = new System.Windows.Forms.Label();
            this.bombingRunTimer = new System.Windows.Forms.Timer(this.components);
            this.btnUseBombingRun = new System.Windows.Forms.Button();
            this.btnUsePrecisionStrike = new System.Windows.Forms.Button();
            this.btnUseKatyushaStrike = new System.Windows.Forms.Button();
            this.btnUseStrafingRun = new System.Windows.Forms.Button();
            this.precisionStrikeTimer = new System.Windows.Forms.Timer(this.components);
            this.katyushaStrikeTimer = new System.Windows.Forms.Timer(this.components);
            this.strafingRunTimer = new System.Windows.Forms.Timer(this.components);
            this.lblAirhead = new System.Windows.Forms.Label();
            this.lblbxAirhead = new System.Windows.Forms.Label();
            this.btnUseAirhead = new System.Windows.Forms.Button();
            this.airheadTimer = new System.Windows.Forms.Timer(this.components);
            this.gbMunitions = new System.Windows.Forms.GroupBox();
            this.gbManpower = new System.Windows.Forms.GroupBox();
            this.rbUS = new System.Windows.Forms.RadioButton();
            this.rbGerman = new System.Windows.Forms.RadioButton();
            this.rbRussian = new System.Windows.Forms.RadioButton();
            this.rbBritish = new System.Windows.Forms.RadioButton();
            this.gbEnemyFaction = new System.Windows.Forms.GroupBox();
            this.gbFuel = new System.Windows.Forms.GroupBox();
            this.lblbxCounterHeavy2 = new System.Windows.Forms.Label();
            this.lblbxCounterHeavy1 = new System.Windows.Forms.Label();
            this.btnUseIS1 = new System.Windows.Forms.Button();
            this.btnUseHalfTrack = new System.Windows.Forms.Button();
            this.lblbxIS1 = new System.Windows.Forms.Label();
            this.lblHalfTrack = new System.Windows.Forms.Label();
            this.lblbxHalfTrack = new System.Windows.Forms.Label();
            this.btnUseFirefly = new System.Windows.Forms.Button();
            this.btnUseChurchill = new System.Windows.Forms.Button();
            this.btnUseSupplyTruck = new System.Windows.Forms.Button();
            this.btnUsePanther = new System.Windows.Forms.Button();
            this.lblPanther = new System.Windows.Forms.Label();
            this.lblbxPanther = new System.Windows.Forms.Label();
            this.btnUseTiger = new System.Windows.Forms.Button();
            this.lblTiger = new System.Windows.Forms.Label();
            this.lblbxFirefly = new System.Windows.Forms.Label();
            this.lblFirefly = new System.Windows.Forms.Label();
            this.lblbxTiger = new System.Windows.Forms.Label();
            this.lblbxChurchill = new System.Windows.Forms.Label();
            this.lblIS1 = new System.Windows.Forms.Label();
            this.lblChurchill = new System.Windows.Forms.Label();
            this.lblbxSupplyTruck = new System.Windows.Forms.Label();
            this.lblSupplyTruck = new System.Windows.Forms.Label();
            this.btnUseTransportTruck = new System.Windows.Forms.Button();
            this.lblbxTransportTruck = new System.Windows.Forms.Label();
            this.lblTransportTruck = new System.Windows.Forms.Label();
            this.btnUseReconTank = new System.Windows.Forms.Button();
            this.lblbxReconTank = new System.Windows.Forms.Label();
            this.lblReconTank = new System.Windows.Forms.Label();
            this.btnUseMedTank = new System.Windows.Forms.Button();
            this.lblbxMedTank = new System.Windows.Forms.Label();
            this.lblMedTank = new System.Windows.Forms.Label();
            this.btnUseLightTank = new System.Windows.Forms.Button();
            this.lblbxLightTank = new System.Windows.Forms.Label();
            this.lblLightTank = new System.Windows.Forms.Label();
            this.btnUseJumbo75 = new System.Windows.Forms.Button();
            this.lblbxJumbo75 = new System.Windows.Forms.Label();
            this.lblJumbo75 = new System.Windows.Forms.Label();
            this.btnUseJumbo76 = new System.Windows.Forms.Button();
            this.lblbxJumbo76 = new System.Windows.Forms.Label();
            this.lblJumbo76 = new System.Windows.Forms.Label();
            this.jumbo75Timer = new System.Windows.Forms.Timer(this.components);
            this.jumbo76Timer = new System.Windows.Forms.Timer(this.components);
            this.tigerTimer = new System.Windows.Forms.Timer(this.components);
            this.pantherTimer = new System.Windows.Forms.Timer(this.components);
            this.is1Timer = new System.Windows.Forms.Timer(this.components);
            this.fireflyTimer = new System.Windows.Forms.Timer(this.components);
            this.churchillTimer = new System.Windows.Forms.Timer(this.components);
            this.reconTimer = new System.Windows.Forms.Timer(this.components);
            this.lightTimer = new System.Windows.Forms.Timer(this.components);
            this.medTimer = new System.Windows.Forms.Timer(this.components);
            this.halfTrackTimer = new System.Windows.Forms.Timer(this.components);
            this.transportTimer = new System.Windows.Forms.Timer(this.components);
            this.supplyTimer = new System.Windows.Forms.Timer(this.components);
            this.chkAssumeEncouraged = new System.Windows.Forms.CheckBox();
            this.chkNoPanther = new System.Windows.Forms.CheckBox();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.chkArtyGun = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.resourceUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.encouragedTimer = new System.Windows.Forms.Timer(this.components);
            this.encouragedActiveTimer = new System.Windows.Forms.Timer(this.components);
            this.artilleryActiveTimer = new System.Windows.Forms.Timer(this.components);
            this.gbResourceGroup.SuspendLayout();
            this.gbMunitions.SuspendLayout();
            this.gbManpower.SuspendLayout();
            this.gbEnemyFaction.SuspendLayout();
            this.gbFuel.SuspendLayout();
            this.gbConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartMatch
            // 
            this.btnStartMatch.Location = new System.Drawing.Point(289, 316);
            this.btnStartMatch.Name = "btnStartMatch";
            this.btnStartMatch.Size = new System.Drawing.Size(236, 53);
            this.btnStartMatch.TabIndex = 6;
            this.btnStartMatch.Text = "Start Match";
            this.btnStartMatch.UseVisualStyleBackColor = true;
            this.btnStartMatch.Click += new System.EventHandler(this.btnStartMatch_Click);
            // 
            // lblMatchCountdown
            // 
            this.lblMatchCountdown.BackColor = System.Drawing.SystemColors.Window;
            this.lblMatchCountdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatchCountdown.Location = new System.Drawing.Point(289, 385);
            this.lblMatchCountdown.Name = "lblMatchCountdown";
            this.lblMatchCountdown.Size = new System.Drawing.Size(236, 53);
            this.lblMatchCountdown.TabIndex = 7;
            this.lblMatchCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matchTimerUpdateTimer
            // 
            this.matchTimerUpdateTimer.Interval = 250;
            this.matchTimerUpdateTimer.Tick += new System.EventHandler(this.matchTimerUpdateTimer_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(289, 316);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(236, 53);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMunitions
            // 
            this.lblMunitions.AutoSize = true;
            this.lblMunitions.Location = new System.Drawing.Point(105, 10);
            this.lblMunitions.Name = "lblMunitions";
            this.lblMunitions.Size = new System.Drawing.Size(61, 15);
            this.lblMunitions.TabIndex = 1;
            this.lblMunitions.Text = "Munitions";
            // 
            // lblManpower
            // 
            this.lblManpower.AutoSize = true;
            this.lblManpower.Location = new System.Drawing.Point(369, 10);
            this.lblManpower.Name = "lblManpower";
            this.lblManpower.Size = new System.Drawing.Size(64, 15);
            this.lblManpower.TabIndex = 3;
            this.lblManpower.Text = "Manpower";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(651, 10);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(29, 15);
            this.lblFuel.TabIndex = 5;
            this.lblFuel.Text = "Fuel";
            this.lblFuel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblbxMunitions
            // 
            this.lblbxMunitions.BackColor = System.Drawing.SystemColors.Window;
            this.lblbxMunitions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxMunitions.Location = new System.Drawing.Point(60, 25);
            this.lblbxMunitions.Name = "lblbxMunitions";
            this.lblbxMunitions.Size = new System.Drawing.Size(146, 28);
            this.lblbxMunitions.TabIndex = 8;
            this.lblbxMunitions.Text = "500";
            this.lblbxMunitions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblbxManpower
            // 
            this.lblbxManpower.BackColor = System.Drawing.SystemColors.Window;
            this.lblbxManpower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxManpower.Location = new System.Drawing.Point(329, 25);
            this.lblbxManpower.Name = "lblbxManpower";
            this.lblbxManpower.Size = new System.Drawing.Size(146, 28);
            this.lblbxManpower.TabIndex = 9;
            this.lblbxManpower.Text = "500";
            this.lblbxManpower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblbxFuel
            // 
            this.lblbxFuel.BackColor = System.Drawing.SystemColors.Window;
            this.lblbxFuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxFuel.Location = new System.Drawing.Point(589, 25);
            this.lblbxFuel.Name = "lblbxFuel";
            this.lblbxFuel.Size = new System.Drawing.Size(146, 28);
            this.lblbxFuel.TabIndex = 10;
            this.lblbxFuel.Text = "500";
            this.lblbxFuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMunitionsRate
            // 
            this.lblMunitionsRate.AutoSize = true;
            this.lblMunitionsRate.Location = new System.Drawing.Point(212, 32);
            this.lblMunitionsRate.Name = "lblMunitionsRate";
            this.lblMunitionsRate.Size = new System.Drawing.Size(35, 15);
            this.lblMunitionsRate.TabIndex = 11;
            this.lblMunitionsRate.Text = "30/m";
            // 
            // lblManpowerRate
            // 
            this.lblManpowerRate.AutoSize = true;
            this.lblManpowerRate.Location = new System.Drawing.Point(481, 32);
            this.lblManpowerRate.Name = "lblManpowerRate";
            this.lblManpowerRate.Size = new System.Drawing.Size(35, 15);
            this.lblManpowerRate.TabIndex = 12;
            this.lblManpowerRate.Text = "30/m";
            // 
            // lblFuelRate
            // 
            this.lblFuelRate.AutoSize = true;
            this.lblFuelRate.Location = new System.Drawing.Point(741, 32);
            this.lblFuelRate.Name = "lblFuelRate";
            this.lblFuelRate.Size = new System.Drawing.Size(35, 15);
            this.lblFuelRate.TabIndex = 13;
            this.lblFuelRate.Text = "30/m";
            // 
            // gbResourceGroup
            // 
            this.gbResourceGroup.Controls.Add(this.lblFuelRate);
            this.gbResourceGroup.Controls.Add(this.lblManpowerRate);
            this.gbResourceGroup.Controls.Add(this.lblMunitionsRate);
            this.gbResourceGroup.Controls.Add(this.lblbxFuel);
            this.gbResourceGroup.Controls.Add(this.lblbxMunitions);
            this.gbResourceGroup.Controls.Add(this.lblbxManpower);
            this.gbResourceGroup.Controls.Add(this.lblFuel);
            this.gbResourceGroup.Controls.Add(this.lblManpower);
            this.gbResourceGroup.Controls.Add(this.lblMunitions);
            this.gbResourceGroup.Location = new System.Drawing.Point(0, 12);
            this.gbResourceGroup.Name = "gbResourceGroup";
            this.gbResourceGroup.Size = new System.Drawing.Size(800, 74);
            this.gbResourceGroup.TabIndex = 15;
            this.gbResourceGroup.TabStop = false;
            this.gbResourceGroup.Text = "Resources";
            // 
            // lblbxPrecisionStrike
            // 
            this.lblbxPrecisionStrike.BackColor = System.Drawing.Color.LightGray;
            this.lblbxPrecisionStrike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxPrecisionStrike.Location = new System.Drawing.Point(152, 12);
            this.lblbxPrecisionStrike.Name = "lblbxPrecisionStrike";
            this.lblbxPrecisionStrike.Size = new System.Drawing.Size(53, 28);
            this.lblbxPrecisionStrike.TabIndex = 14;
            this.lblbxPrecisionStrike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecisionStrike
            // 
            this.lblPrecisionStrike.AutoSize = true;
            this.lblPrecisionStrike.Location = new System.Drawing.Point(59, 19);
            this.lblPrecisionStrike.Name = "lblPrecisionStrike";
            this.lblPrecisionStrike.Size = new System.Drawing.Size(87, 15);
            this.lblPrecisionStrike.TabIndex = 14;
            this.lblPrecisionStrike.Text = "Precision Strike";
            // 
            // lblBombingRun
            // 
            this.lblBombingRun.AutoSize = true;
            this.lblBombingRun.Location = new System.Drawing.Point(60, 51);
            this.lblBombingRun.Name = "lblBombingRun";
            this.lblBombingRun.Size = new System.Drawing.Size(80, 15);
            this.lblBombingRun.TabIndex = 16;
            this.lblBombingRun.Text = "Bombing Run";
            // 
            // lblbxBombingRun
            // 
            this.lblbxBombingRun.BackColor = System.Drawing.Color.LightGray;
            this.lblbxBombingRun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxBombingRun.Location = new System.Drawing.Point(152, 44);
            this.lblbxBombingRun.Name = "lblbxBombingRun";
            this.lblbxBombingRun.Size = new System.Drawing.Size(53, 31);
            this.lblbxBombingRun.TabIndex = 17;
            this.lblbxBombingRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // abilityCooldownTimer
            // 
            this.abilityCooldownTimer.Interval = 60000;
            this.abilityCooldownTimer.Tick += new System.EventHandler(this.abilityCooldownTimer_Tick);
            // 
            // lblKatyushaStrike
            // 
            this.lblKatyushaStrike.AutoSize = true;
            this.lblKatyushaStrike.Location = new System.Drawing.Point(59, 121);
            this.lblKatyushaStrike.Name = "lblKatyushaStrike";
            this.lblKatyushaStrike.Size = new System.Drawing.Size(87, 15);
            this.lblKatyushaStrike.TabIndex = 18;
            this.lblKatyushaStrike.Text = "Katyusha Strike";
            this.lblKatyushaStrike.Visible = false;
            // 
            // lblbxKatyushaStrike
            // 
            this.lblbxKatyushaStrike.BackColor = System.Drawing.Color.LightGray;
            this.lblbxKatyushaStrike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxKatyushaStrike.Location = new System.Drawing.Point(152, 113);
            this.lblbxKatyushaStrike.Name = "lblbxKatyushaStrike";
            this.lblbxKatyushaStrike.Size = new System.Drawing.Size(53, 31);
            this.lblbxKatyushaStrike.TabIndex = 19;
            this.lblbxKatyushaStrike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbxKatyushaStrike.Visible = false;
            // 
            // lblbxStrafingRun
            // 
            this.lblbxStrafingRun.BackColor = System.Drawing.Color.LightGray;
            this.lblbxStrafingRun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxStrafingRun.Location = new System.Drawing.Point(152, 81);
            this.lblbxStrafingRun.Name = "lblbxStrafingRun";
            this.lblbxStrafingRun.Size = new System.Drawing.Size(53, 28);
            this.lblbxStrafingRun.TabIndex = 20;
            this.lblbxStrafingRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStrafingRun
            // 
            this.lblStrafingRun.AutoSize = true;
            this.lblStrafingRun.Location = new System.Drawing.Point(60, 87);
            this.lblStrafingRun.Name = "lblStrafingRun";
            this.lblStrafingRun.Size = new System.Drawing.Size(72, 15);
            this.lblStrafingRun.TabIndex = 21;
            this.lblStrafingRun.Text = "Strafing Run";
            // 
            // bombingRunTimer
            // 
            this.bombingRunTimer.Interval = 250;
            this.bombingRunTimer.Tick += new System.EventHandler(this.bombingRunTimer_Tick);
            // 
            // btnUseBombingRun
            // 
            this.btnUseBombingRun.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseBombingRun.Location = new System.Drawing.Point(152, 45);
            this.btnUseBombingRun.Name = "btnUseBombingRun";
            this.btnUseBombingRun.Size = new System.Drawing.Size(53, 29);
            this.btnUseBombingRun.TabIndex = 22;
            this.btnUseBombingRun.Text = "READY";
            this.btnUseBombingRun.UseVisualStyleBackColor = false;
            this.btnUseBombingRun.Visible = false;
            this.btnUseBombingRun.Click += new System.EventHandler(this.btnUseBombingRun_Click);
            // 
            // btnUsePrecisionStrike
            // 
            this.btnUsePrecisionStrike.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUsePrecisionStrike.Location = new System.Drawing.Point(152, 12);
            this.btnUsePrecisionStrike.Name = "btnUsePrecisionStrike";
            this.btnUsePrecisionStrike.Size = new System.Drawing.Size(53, 29);
            this.btnUsePrecisionStrike.TabIndex = 23;
            this.btnUsePrecisionStrike.Text = "READY";
            this.btnUsePrecisionStrike.UseVisualStyleBackColor = false;
            this.btnUsePrecisionStrike.Visible = false;
            this.btnUsePrecisionStrike.Click += new System.EventHandler(this.btnUsePrecisionStrike_Click);
            // 
            // btnUseKatyushaStrike
            // 
            this.btnUseKatyushaStrike.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseKatyushaStrike.Location = new System.Drawing.Point(152, 114);
            this.btnUseKatyushaStrike.Name = "btnUseKatyushaStrike";
            this.btnUseKatyushaStrike.Size = new System.Drawing.Size(53, 29);
            this.btnUseKatyushaStrike.TabIndex = 24;
            this.btnUseKatyushaStrike.Text = "READY";
            this.btnUseKatyushaStrike.UseVisualStyleBackColor = false;
            this.btnUseKatyushaStrike.Visible = false;
            this.btnUseKatyushaStrike.Click += new System.EventHandler(this.btnUseKatyushaStrike_Click);
            // 
            // btnUseStrafingRun
            // 
            this.btnUseStrafingRun.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseStrafingRun.Location = new System.Drawing.Point(152, 80);
            this.btnUseStrafingRun.Name = "btnUseStrafingRun";
            this.btnUseStrafingRun.Size = new System.Drawing.Size(53, 29);
            this.btnUseStrafingRun.TabIndex = 25;
            this.btnUseStrafingRun.Text = "READY";
            this.btnUseStrafingRun.UseVisualStyleBackColor = false;
            this.btnUseStrafingRun.Visible = false;
            this.btnUseStrafingRun.Click += new System.EventHandler(this.btnUseStrafingRun_Click);
            // 
            // precisionStrikeTimer
            // 
            this.precisionStrikeTimer.Interval = 250;
            this.precisionStrikeTimer.Tick += new System.EventHandler(this.precisionStrikeTimer_Tick);
            // 
            // katyushaStrikeTimer
            // 
            this.katyushaStrikeTimer.Interval = 250;
            this.katyushaStrikeTimer.Tick += new System.EventHandler(this.katyushaStrikeTimer_Tick);
            // 
            // strafingRunTimer
            // 
            this.strafingRunTimer.Interval = 250;
            this.strafingRunTimer.Tick += new System.EventHandler(this.strafingRunTimer_Tick);
            // 
            // lblAirhead
            // 
            this.lblAirhead.AutoSize = true;
            this.lblAirhead.Location = new System.Drawing.Point(46, 22);
            this.lblAirhead.Name = "lblAirhead";
            this.lblAirhead.Size = new System.Drawing.Size(48, 15);
            this.lblAirhead.TabIndex = 26;
            this.lblAirhead.Text = "Airhead";
            // 
            // lblbxAirhead
            // 
            this.lblbxAirhead.BackColor = System.Drawing.Color.LightGray;
            this.lblbxAirhead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxAirhead.Location = new System.Drawing.Point(139, 15);
            this.lblbxAirhead.Name = "lblbxAirhead";
            this.lblbxAirhead.Size = new System.Drawing.Size(53, 28);
            this.lblbxAirhead.TabIndex = 27;
            this.lblbxAirhead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUseAirhead
            // 
            this.btnUseAirhead.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseAirhead.Location = new System.Drawing.Point(139, 14);
            this.btnUseAirhead.Name = "btnUseAirhead";
            this.btnUseAirhead.Size = new System.Drawing.Size(53, 29);
            this.btnUseAirhead.TabIndex = 28;
            this.btnUseAirhead.Text = "READY";
            this.btnUseAirhead.UseVisualStyleBackColor = false;
            this.btnUseAirhead.Visible = false;
            this.btnUseAirhead.Click += new System.EventHandler(this.btnUseAirhead_Click);
            // 
            // airheadTimer
            // 
            this.airheadTimer.Interval = 250;
            this.airheadTimer.Tick += new System.EventHandler(this.airheadTimer_Tick);
            // 
            // gbMunitions
            // 
            this.gbMunitions.Controls.Add(this.btnUseStrafingRun);
            this.gbMunitions.Controls.Add(this.btnUseKatyushaStrike);
            this.gbMunitions.Controls.Add(this.btnUsePrecisionStrike);
            this.gbMunitions.Controls.Add(this.btnUseBombingRun);
            this.gbMunitions.Controls.Add(this.lblStrafingRun);
            this.gbMunitions.Controls.Add(this.lblbxKatyushaStrike);
            this.gbMunitions.Controls.Add(this.lblbxStrafingRun);
            this.gbMunitions.Controls.Add(this.lblKatyushaStrike);
            this.gbMunitions.Controls.Add(this.lblbxBombingRun);
            this.gbMunitions.Controls.Add(this.lblBombingRun);
            this.gbMunitions.Controls.Add(this.lblPrecisionStrike);
            this.gbMunitions.Controls.Add(this.lblbxPrecisionStrike);
            this.gbMunitions.Location = new System.Drawing.Point(0, 92);
            this.gbMunitions.Name = "gbMunitions";
            this.gbMunitions.Size = new System.Drawing.Size(236, 218);
            this.gbMunitions.TabIndex = 29;
            this.gbMunitions.TabStop = false;
            this.gbMunitions.Text = "Munitions";
            // 
            // gbManpower
            // 
            this.gbManpower.Controls.Add(this.btnUseAirhead);
            this.gbManpower.Controls.Add(this.lblbxAirhead);
            this.gbManpower.Controls.Add(this.lblAirhead);
            this.gbManpower.Location = new System.Drawing.Point(289, 92);
            this.gbManpower.Name = "gbManpower";
            this.gbManpower.Size = new System.Drawing.Size(236, 218);
            this.gbManpower.TabIndex = 30;
            this.gbManpower.TabStop = false;
            this.gbManpower.Text = "Manpower";
            // 
            // rbUS
            // 
            this.rbUS.AutoSize = true;
            this.rbUS.Checked = true;
            this.rbUS.Location = new System.Drawing.Point(8, 57);
            this.rbUS.Name = "rbUS";
            this.rbUS.Size = new System.Drawing.Size(39, 19);
            this.rbUS.TabIndex = 31;
            this.rbUS.TabStop = true;
            this.rbUS.Text = "US";
            this.rbUS.UseVisualStyleBackColor = true;
            this.rbUS.CheckedChanged += new System.EventHandler(this.rbUS_CheckedChanged);
            // 
            // rbGerman
            // 
            this.rbGerman.AutoSize = true;
            this.rbGerman.Location = new System.Drawing.Point(8, 82);
            this.rbGerman.Name = "rbGerman";
            this.rbGerman.Size = new System.Drawing.Size(67, 19);
            this.rbGerman.TabIndex = 32;
            this.rbGerman.Text = "German";
            this.rbGerman.UseVisualStyleBackColor = true;
            this.rbGerman.CheckedChanged += new System.EventHandler(this.rbGerman_CheckedChanged);
            // 
            // rbRussian
            // 
            this.rbRussian.AutoSize = true;
            this.rbRussian.Location = new System.Drawing.Point(8, 107);
            this.rbRussian.Name = "rbRussian";
            this.rbRussian.Size = new System.Drawing.Size(65, 19);
            this.rbRussian.TabIndex = 33;
            this.rbRussian.Text = "Russian";
            this.rbRussian.UseVisualStyleBackColor = true;
            this.rbRussian.CheckedChanged += new System.EventHandler(this.rbRussian_CheckedChanged);
            // 
            // rbBritish
            // 
            this.rbBritish.AutoSize = true;
            this.rbBritish.Location = new System.Drawing.Point(8, 32);
            this.rbBritish.Name = "rbBritish";
            this.rbBritish.Size = new System.Drawing.Size(58, 19);
            this.rbBritish.TabIndex = 34;
            this.rbBritish.Text = "British";
            this.rbBritish.UseVisualStyleBackColor = true;
            this.rbBritish.CheckedChanged += new System.EventHandler(this.rbBritish_CheckedChanged);
            // 
            // gbEnemyFaction
            // 
            this.gbEnemyFaction.Controls.Add(this.rbBritish);
            this.gbEnemyFaction.Controls.Add(this.rbRussian);
            this.gbEnemyFaction.Controls.Add(this.rbGerman);
            this.gbEnemyFaction.Controls.Add(this.rbUS);
            this.gbEnemyFaction.Location = new System.Drawing.Point(0, 316);
            this.gbEnemyFaction.Name = "gbEnemyFaction";
            this.gbEnemyFaction.Size = new System.Drawing.Size(236, 131);
            this.gbEnemyFaction.TabIndex = 35;
            this.gbEnemyFaction.TabStop = false;
            this.gbEnemyFaction.Text = "Enemy Faction";
            // 
            // gbFuel
            // 
            this.gbFuel.Controls.Add(this.lblbxCounterHeavy2);
            this.gbFuel.Controls.Add(this.lblbxCounterHeavy1);
            this.gbFuel.Controls.Add(this.btnUseIS1);
            this.gbFuel.Controls.Add(this.btnUseHalfTrack);
            this.gbFuel.Controls.Add(this.lblbxIS1);
            this.gbFuel.Controls.Add(this.lblHalfTrack);
            this.gbFuel.Controls.Add(this.lblbxHalfTrack);
            this.gbFuel.Controls.Add(this.btnUseFirefly);
            this.gbFuel.Controls.Add(this.btnUseChurchill);
            this.gbFuel.Controls.Add(this.btnUseSupplyTruck);
            this.gbFuel.Controls.Add(this.btnUsePanther);
            this.gbFuel.Controls.Add(this.lblPanther);
            this.gbFuel.Controls.Add(this.lblbxPanther);
            this.gbFuel.Controls.Add(this.btnUseTiger);
            this.gbFuel.Controls.Add(this.lblTiger);
            this.gbFuel.Controls.Add(this.lblbxFirefly);
            this.gbFuel.Controls.Add(this.lblFirefly);
            this.gbFuel.Controls.Add(this.lblbxTiger);
            this.gbFuel.Controls.Add(this.lblbxChurchill);
            this.gbFuel.Controls.Add(this.lblIS1);
            this.gbFuel.Controls.Add(this.lblChurchill);
            this.gbFuel.Controls.Add(this.lblbxSupplyTruck);
            this.gbFuel.Controls.Add(this.lblSupplyTruck);
            this.gbFuel.Controls.Add(this.btnUseTransportTruck);
            this.gbFuel.Controls.Add(this.lblbxTransportTruck);
            this.gbFuel.Controls.Add(this.lblTransportTruck);
            this.gbFuel.Controls.Add(this.btnUseReconTank);
            this.gbFuel.Controls.Add(this.lblbxReconTank);
            this.gbFuel.Controls.Add(this.lblReconTank);
            this.gbFuel.Controls.Add(this.btnUseMedTank);
            this.gbFuel.Controls.Add(this.lblbxMedTank);
            this.gbFuel.Controls.Add(this.lblMedTank);
            this.gbFuel.Controls.Add(this.btnUseLightTank);
            this.gbFuel.Controls.Add(this.lblbxLightTank);
            this.gbFuel.Controls.Add(this.lblLightTank);
            this.gbFuel.Controls.Add(this.btnUseJumbo75);
            this.gbFuel.Controls.Add(this.lblbxJumbo75);
            this.gbFuel.Controls.Add(this.lblJumbo75);
            this.gbFuel.Controls.Add(this.btnUseJumbo76);
            this.gbFuel.Controls.Add(this.lblbxJumbo76);
            this.gbFuel.Controls.Add(this.lblJumbo76);
            this.gbFuel.Location = new System.Drawing.Point(564, 92);
            this.gbFuel.Name = "gbFuel";
            this.gbFuel.Size = new System.Drawing.Size(236, 275);
            this.gbFuel.TabIndex = 31;
            this.gbFuel.TabStop = false;
            this.gbFuel.Text = "Fuel";
            // 
            // lblbxCounterHeavy2
            // 
            this.lblbxCounterHeavy2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblbxCounterHeavy2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxCounterHeavy2.Location = new System.Drawing.Point(198, 49);
            this.lblbxCounterHeavy2.Name = "lblbxCounterHeavy2";
            this.lblbxCounterHeavy2.Size = new System.Drawing.Size(19, 27);
            this.lblbxCounterHeavy2.TabIndex = 60;
            this.lblbxCounterHeavy2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblbxCounterHeavy1
            // 
            this.lblbxCounterHeavy1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblbxCounterHeavy1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxCounterHeavy1.Location = new System.Drawing.Point(198, 17);
            this.lblbxCounterHeavy1.Name = "lblbxCounterHeavy1";
            this.lblbxCounterHeavy1.Size = new System.Drawing.Size(19, 27);
            this.lblbxCounterHeavy1.TabIndex = 29;
            this.lblbxCounterHeavy1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUseIS1
            // 
            this.btnUseIS1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseIS1.Location = new System.Drawing.Point(139, 16);
            this.btnUseIS1.Name = "btnUseIS1";
            this.btnUseIS1.Size = new System.Drawing.Size(53, 29);
            this.btnUseIS1.TabIndex = 59;
            this.btnUseIS1.Text = "READY";
            this.btnUseIS1.UseVisualStyleBackColor = false;
            this.btnUseIS1.Visible = false;
            this.btnUseIS1.Click += new System.EventHandler(this.btnUseIS1_Click);
            // 
            // btnUseHalfTrack
            // 
            this.btnUseHalfTrack.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseHalfTrack.Location = new System.Drawing.Point(139, 241);
            this.btnUseHalfTrack.Name = "btnUseHalfTrack";
            this.btnUseHalfTrack.Size = new System.Drawing.Size(53, 29);
            this.btnUseHalfTrack.TabIndex = 29;
            this.btnUseHalfTrack.Text = "READY";
            this.btnUseHalfTrack.UseVisualStyleBackColor = false;
            this.btnUseHalfTrack.Visible = false;
            this.btnUseHalfTrack.Click += new System.EventHandler(this.btnUseHalfTrack_Click);
            // 
            // lblbxIS1
            // 
            this.lblbxIS1.BackColor = System.Drawing.Color.LightGray;
            this.lblbxIS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxIS1.Location = new System.Drawing.Point(139, 17);
            this.lblbxIS1.Name = "lblbxIS1";
            this.lblbxIS1.Size = new System.Drawing.Size(53, 28);
            this.lblbxIS1.TabIndex = 57;
            this.lblbxIS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbxIS1.Visible = false;
            // 
            // lblHalfTrack
            // 
            this.lblHalfTrack.AutoSize = true;
            this.lblHalfTrack.Location = new System.Drawing.Point(49, 249);
            this.lblHalfTrack.Name = "lblHalfTrack";
            this.lblHalfTrack.Size = new System.Drawing.Size(59, 15);
            this.lblHalfTrack.TabIndex = 46;
            this.lblHalfTrack.Text = "Half Track";
            // 
            // lblbxHalfTrack
            // 
            this.lblbxHalfTrack.BackColor = System.Drawing.Color.LightGray;
            this.lblbxHalfTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxHalfTrack.Location = new System.Drawing.Point(139, 242);
            this.lblbxHalfTrack.Name = "lblbxHalfTrack";
            this.lblbxHalfTrack.Size = new System.Drawing.Size(53, 28);
            this.lblbxHalfTrack.TabIndex = 29;
            this.lblbxHalfTrack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUseFirefly
            // 
            this.btnUseFirefly.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseFirefly.Location = new System.Drawing.Point(139, 47);
            this.btnUseFirefly.Name = "btnUseFirefly";
            this.btnUseFirefly.Size = new System.Drawing.Size(53, 29);
            this.btnUseFirefly.TabIndex = 56;
            this.btnUseFirefly.Text = "READY";
            this.btnUseFirefly.UseVisualStyleBackColor = false;
            this.btnUseFirefly.Visible = false;
            this.btnUseFirefly.Click += new System.EventHandler(this.btnUseFirefly_Click);
            // 
            // btnUseChurchill
            // 
            this.btnUseChurchill.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseChurchill.Location = new System.Drawing.Point(139, 17);
            this.btnUseChurchill.Name = "btnUseChurchill";
            this.btnUseChurchill.Size = new System.Drawing.Size(53, 29);
            this.btnUseChurchill.TabIndex = 53;
            this.btnUseChurchill.Text = "READY";
            this.btnUseChurchill.UseVisualStyleBackColor = false;
            this.btnUseChurchill.Visible = false;
            this.btnUseChurchill.Click += new System.EventHandler(this.btnUseChurchill_Click);
            // 
            // btnUseSupplyTruck
            // 
            this.btnUseSupplyTruck.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseSupplyTruck.Location = new System.Drawing.Point(139, 209);
            this.btnUseSupplyTruck.Name = "btnUseSupplyTruck";
            this.btnUseSupplyTruck.Size = new System.Drawing.Size(53, 29);
            this.btnUseSupplyTruck.TabIndex = 29;
            this.btnUseSupplyTruck.Text = "READY";
            this.btnUseSupplyTruck.UseVisualStyleBackColor = false;
            this.btnUseSupplyTruck.Visible = false;
            this.btnUseSupplyTruck.Click += new System.EventHandler(this.btnUseSupplyTruck_Click);
            // 
            // btnUsePanther
            // 
            this.btnUsePanther.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUsePanther.Location = new System.Drawing.Point(139, 47);
            this.btnUsePanther.Name = "btnUsePanther";
            this.btnUsePanther.Size = new System.Drawing.Size(53, 29);
            this.btnUsePanther.TabIndex = 50;
            this.btnUsePanther.Text = "READY";
            this.btnUsePanther.UseVisualStyleBackColor = false;
            this.btnUsePanther.Visible = false;
            this.btnUsePanther.Click += new System.EventHandler(this.btnUsePanther_Click);
            // 
            // lblPanther
            // 
            this.lblPanther.AutoSize = true;
            this.lblPanther.Location = new System.Drawing.Point(49, 54);
            this.lblPanther.Name = "lblPanther";
            this.lblPanther.Size = new System.Drawing.Size(48, 15);
            this.lblPanther.TabIndex = 48;
            this.lblPanther.Text = "Panther";
            this.lblPanther.Visible = false;
            // 
            // lblbxPanther
            // 
            this.lblbxPanther.BackColor = System.Drawing.Color.LightGray;
            this.lblbxPanther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxPanther.Location = new System.Drawing.Point(139, 47);
            this.lblbxPanther.Name = "lblbxPanther";
            this.lblbxPanther.Size = new System.Drawing.Size(53, 28);
            this.lblbxPanther.TabIndex = 49;
            this.lblbxPanther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbxPanther.Visible = false;
            // 
            // btnUseTiger
            // 
            this.btnUseTiger.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseTiger.Location = new System.Drawing.Point(139, 17);
            this.btnUseTiger.Name = "btnUseTiger";
            this.btnUseTiger.Size = new System.Drawing.Size(53, 29);
            this.btnUseTiger.TabIndex = 47;
            this.btnUseTiger.Text = "READY";
            this.btnUseTiger.UseVisualStyleBackColor = false;
            this.btnUseTiger.Visible = false;
            this.btnUseTiger.Click += new System.EventHandler(this.btnUseTiger_Click);
            // 
            // lblTiger
            // 
            this.lblTiger.AutoSize = true;
            this.lblTiger.Location = new System.Drawing.Point(49, 22);
            this.lblTiger.Name = "lblTiger";
            this.lblTiger.Size = new System.Drawing.Size(33, 15);
            this.lblTiger.TabIndex = 36;
            this.lblTiger.Text = "Tiger";
            this.lblTiger.Visible = false;
            // 
            // lblbxFirefly
            // 
            this.lblbxFirefly.BackColor = System.Drawing.Color.LightGray;
            this.lblbxFirefly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxFirefly.Location = new System.Drawing.Point(139, 47);
            this.lblbxFirefly.Name = "lblbxFirefly";
            this.lblbxFirefly.Size = new System.Drawing.Size(53, 28);
            this.lblbxFirefly.TabIndex = 54;
            this.lblbxFirefly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbxFirefly.Visible = false;
            // 
            // lblFirefly
            // 
            this.lblFirefly.AutoSize = true;
            this.lblFirefly.Location = new System.Drawing.Point(49, 55);
            this.lblFirefly.Name = "lblFirefly";
            this.lblFirefly.Size = new System.Drawing.Size(39, 15);
            this.lblFirefly.TabIndex = 55;
            this.lblFirefly.Text = "Firefly";
            this.lblFirefly.Visible = false;
            // 
            // lblbxTiger
            // 
            this.lblbxTiger.BackColor = System.Drawing.Color.LightGray;
            this.lblbxTiger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxTiger.Location = new System.Drawing.Point(139, 16);
            this.lblbxTiger.Name = "lblbxTiger";
            this.lblbxTiger.Size = new System.Drawing.Size(53, 28);
            this.lblbxTiger.TabIndex = 47;
            this.lblbxTiger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbxTiger.Visible = false;
            // 
            // lblbxChurchill
            // 
            this.lblbxChurchill.BackColor = System.Drawing.Color.LightGray;
            this.lblbxChurchill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxChurchill.Location = new System.Drawing.Point(139, 16);
            this.lblbxChurchill.Name = "lblbxChurchill";
            this.lblbxChurchill.Size = new System.Drawing.Size(53, 28);
            this.lblbxChurchill.TabIndex = 52;
            this.lblbxChurchill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbxChurchill.Visible = false;
            // 
            // lblIS1
            // 
            this.lblIS1.AutoSize = true;
            this.lblIS1.Location = new System.Drawing.Point(49, 22);
            this.lblIS1.Name = "lblIS1";
            this.lblIS1.Size = new System.Drawing.Size(27, 15);
            this.lblIS1.TabIndex = 58;
            this.lblIS1.Text = "IS-1";
            this.lblIS1.Visible = false;
            // 
            // lblChurchill
            // 
            this.lblChurchill.AutoSize = true;
            this.lblChurchill.Location = new System.Drawing.Point(49, 22);
            this.lblChurchill.Name = "lblChurchill";
            this.lblChurchill.Size = new System.Drawing.Size(55, 15);
            this.lblChurchill.TabIndex = 51;
            this.lblChurchill.Text = "Churchill";
            this.lblChurchill.Visible = false;
            // 
            // lblbxSupplyTruck
            // 
            this.lblbxSupplyTruck.BackColor = System.Drawing.Color.LightGray;
            this.lblbxSupplyTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxSupplyTruck.Location = new System.Drawing.Point(139, 210);
            this.lblbxSupplyTruck.Name = "lblbxSupplyTruck";
            this.lblbxSupplyTruck.Size = new System.Drawing.Size(53, 28);
            this.lblbxSupplyTruck.TabIndex = 29;
            this.lblbxSupplyTruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSupplyTruck
            // 
            this.lblSupplyTruck.AutoSize = true;
            this.lblSupplyTruck.Location = new System.Drawing.Point(49, 217);
            this.lblSupplyTruck.Name = "lblSupplyTruck";
            this.lblSupplyTruck.Size = new System.Drawing.Size(74, 15);
            this.lblSupplyTruck.TabIndex = 45;
            this.lblSupplyTruck.Text = "Supply Truck";
            // 
            // btnUseTransportTruck
            // 
            this.btnUseTransportTruck.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseTransportTruck.Location = new System.Drawing.Point(139, 178);
            this.btnUseTransportTruck.Name = "btnUseTransportTruck";
            this.btnUseTransportTruck.Size = new System.Drawing.Size(53, 29);
            this.btnUseTransportTruck.TabIndex = 29;
            this.btnUseTransportTruck.Text = "READY";
            this.btnUseTransportTruck.UseVisualStyleBackColor = false;
            this.btnUseTransportTruck.Visible = false;
            this.btnUseTransportTruck.Click += new System.EventHandler(this.btnUseTransportTruck_Click);
            // 
            // lblbxTransportTruck
            // 
            this.lblbxTransportTruck.BackColor = System.Drawing.Color.LightGray;
            this.lblbxTransportTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxTransportTruck.Location = new System.Drawing.Point(139, 179);
            this.lblbxTransportTruck.Name = "lblbxTransportTruck";
            this.lblbxTransportTruck.Size = new System.Drawing.Size(53, 28);
            this.lblbxTransportTruck.TabIndex = 44;
            this.lblbxTransportTruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransportTruck
            // 
            this.lblTransportTruck.AutoSize = true;
            this.lblTransportTruck.Location = new System.Drawing.Point(49, 185);
            this.lblTransportTruck.Name = "lblTransportTruck";
            this.lblTransportTruck.Size = new System.Drawing.Size(87, 15);
            this.lblTransportTruck.TabIndex = 41;
            this.lblTransportTruck.Text = "Transport Truck";
            // 
            // btnUseReconTank
            // 
            this.btnUseReconTank.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseReconTank.Location = new System.Drawing.Point(139, 147);
            this.btnUseReconTank.Name = "btnUseReconTank";
            this.btnUseReconTank.Size = new System.Drawing.Size(53, 29);
            this.btnUseReconTank.TabIndex = 40;
            this.btnUseReconTank.Text = "READY";
            this.btnUseReconTank.UseVisualStyleBackColor = false;
            this.btnUseReconTank.Visible = false;
            this.btnUseReconTank.Click += new System.EventHandler(this.btnUseReconTank_Click);
            // 
            // lblbxReconTank
            // 
            this.lblbxReconTank.BackColor = System.Drawing.Color.LightGray;
            this.lblbxReconTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxReconTank.Location = new System.Drawing.Point(139, 148);
            this.lblbxReconTank.Name = "lblbxReconTank";
            this.lblbxReconTank.Size = new System.Drawing.Size(53, 28);
            this.lblbxReconTank.TabIndex = 39;
            this.lblbxReconTank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReconTank
            // 
            this.lblReconTank.AutoSize = true;
            this.lblReconTank.Location = new System.Drawing.Point(49, 155);
            this.lblReconTank.Name = "lblReconTank";
            this.lblReconTank.Size = new System.Drawing.Size(67, 15);
            this.lblReconTank.TabIndex = 38;
            this.lblReconTank.Text = "Recon Tank";
            // 
            // btnUseMedTank
            // 
            this.btnUseMedTank.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseMedTank.Location = new System.Drawing.Point(139, 116);
            this.btnUseMedTank.Name = "btnUseMedTank";
            this.btnUseMedTank.Size = new System.Drawing.Size(53, 29);
            this.btnUseMedTank.TabIndex = 37;
            this.btnUseMedTank.Text = "READY";
            this.btnUseMedTank.UseVisualStyleBackColor = false;
            this.btnUseMedTank.Visible = false;
            this.btnUseMedTank.Click += new System.EventHandler(this.btnUseMedTank_Click);
            // 
            // lblbxMedTank
            // 
            this.lblbxMedTank.BackColor = System.Drawing.Color.LightGray;
            this.lblbxMedTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxMedTank.Location = new System.Drawing.Point(139, 116);
            this.lblbxMedTank.Name = "lblbxMedTank";
            this.lblbxMedTank.Size = new System.Drawing.Size(53, 28);
            this.lblbxMedTank.TabIndex = 36;
            this.lblbxMedTank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMedTank
            // 
            this.lblMedTank.AutoSize = true;
            this.lblMedTank.Location = new System.Drawing.Point(49, 123);
            this.lblMedTank.Name = "lblMedTank";
            this.lblMedTank.Size = new System.Drawing.Size(58, 15);
            this.lblMedTank.TabIndex = 35;
            this.lblMedTank.Text = "Med Tank";
            // 
            // btnUseLightTank
            // 
            this.btnUseLightTank.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseLightTank.Location = new System.Drawing.Point(139, 83);
            this.btnUseLightTank.Name = "btnUseLightTank";
            this.btnUseLightTank.Size = new System.Drawing.Size(53, 29);
            this.btnUseLightTank.TabIndex = 34;
            this.btnUseLightTank.Text = "READY";
            this.btnUseLightTank.UseVisualStyleBackColor = false;
            this.btnUseLightTank.Visible = false;
            this.btnUseLightTank.Click += new System.EventHandler(this.btnUseLightTank_Click);
            // 
            // lblbxLightTank
            // 
            this.lblbxLightTank.BackColor = System.Drawing.Color.LightGray;
            this.lblbxLightTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxLightTank.Location = new System.Drawing.Point(139, 83);
            this.lblbxLightTank.Name = "lblbxLightTank";
            this.lblbxLightTank.Size = new System.Drawing.Size(53, 28);
            this.lblbxLightTank.TabIndex = 33;
            this.lblbxLightTank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLightTank
            // 
            this.lblLightTank.AutoSize = true;
            this.lblLightTank.Location = new System.Drawing.Point(49, 90);
            this.lblLightTank.Name = "lblLightTank";
            this.lblLightTank.Size = new System.Drawing.Size(61, 15);
            this.lblLightTank.TabIndex = 32;
            this.lblLightTank.Text = "Light Tank";
            // 
            // btnUseJumbo75
            // 
            this.btnUseJumbo75.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseJumbo75.Location = new System.Drawing.Point(139, 47);
            this.btnUseJumbo75.Name = "btnUseJumbo75";
            this.btnUseJumbo75.Size = new System.Drawing.Size(53, 29);
            this.btnUseJumbo75.TabIndex = 31;
            this.btnUseJumbo75.Text = "READY";
            this.btnUseJumbo75.UseVisualStyleBackColor = false;
            this.btnUseJumbo75.Visible = false;
            this.btnUseJumbo75.Click += new System.EventHandler(this.btnUseJumbo75_Click);
            // 
            // lblbxJumbo75
            // 
            this.lblbxJumbo75.BackColor = System.Drawing.Color.LightGray;
            this.lblbxJumbo75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxJumbo75.Location = new System.Drawing.Point(139, 48);
            this.lblbxJumbo75.Name = "lblbxJumbo75";
            this.lblbxJumbo75.Size = new System.Drawing.Size(53, 28);
            this.lblbxJumbo75.TabIndex = 30;
            this.lblbxJumbo75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJumbo75
            // 
            this.lblJumbo75.AutoSize = true;
            this.lblJumbo75.Location = new System.Drawing.Point(49, 54);
            this.lblJumbo75.Name = "lblJumbo75";
            this.lblJumbo75.Size = new System.Drawing.Size(58, 15);
            this.lblJumbo75.TabIndex = 29;
            this.lblJumbo75.Text = "Jumbo 75";
            // 
            // btnUseJumbo76
            // 
            this.btnUseJumbo76.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUseJumbo76.Location = new System.Drawing.Point(139, 15);
            this.btnUseJumbo76.Name = "btnUseJumbo76";
            this.btnUseJumbo76.Size = new System.Drawing.Size(53, 29);
            this.btnUseJumbo76.TabIndex = 28;
            this.btnUseJumbo76.Text = "READY";
            this.btnUseJumbo76.UseVisualStyleBackColor = false;
            this.btnUseJumbo76.Visible = false;
            this.btnUseJumbo76.Click += new System.EventHandler(this.btnUseJumbo76_Click);
            // 
            // lblbxJumbo76
            // 
            this.lblbxJumbo76.BackColor = System.Drawing.Color.LightGray;
            this.lblbxJumbo76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbxJumbo76.Location = new System.Drawing.Point(139, 15);
            this.lblbxJumbo76.Name = "lblbxJumbo76";
            this.lblbxJumbo76.Size = new System.Drawing.Size(53, 28);
            this.lblbxJumbo76.TabIndex = 27;
            this.lblbxJumbo76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJumbo76
            // 
            this.lblJumbo76.AutoSize = true;
            this.lblJumbo76.Location = new System.Drawing.Point(49, 22);
            this.lblJumbo76.Name = "lblJumbo76";
            this.lblJumbo76.Size = new System.Drawing.Size(58, 15);
            this.lblJumbo76.TabIndex = 26;
            this.lblJumbo76.Text = "Jumbo 76";
            // 
            // jumbo75Timer
            // 
            this.jumbo75Timer.Interval = 250;
            this.jumbo75Timer.Tick += new System.EventHandler(this.jumbo75Timer_Tick);
            // 
            // jumbo76Timer
            // 
            this.jumbo76Timer.Interval = 250;
            this.jumbo76Timer.Tick += new System.EventHandler(this.jumbo76Timer_Tick);
            // 
            // tigerTimer
            // 
            this.tigerTimer.Interval = 250;
            this.tigerTimer.Tick += new System.EventHandler(this.tigerTimer_Tick);
            // 
            // pantherTimer
            // 
            this.pantherTimer.Interval = 250;
            this.pantherTimer.Tick += new System.EventHandler(this.pantherTimer_Tick);
            // 
            // is1Timer
            // 
            this.is1Timer.Interval = 250;
            this.is1Timer.Tick += new System.EventHandler(this.is1Timer_Tick);
            // 
            // fireflyTimer
            // 
            this.fireflyTimer.Interval = 250;
            this.fireflyTimer.Tick += new System.EventHandler(this.fireflyTimer_Tick);
            // 
            // churchillTimer
            // 
            this.churchillTimer.Interval = 250;
            this.churchillTimer.Tick += new System.EventHandler(this.churchillTimer_Tick);
            // 
            // reconTimer
            // 
            this.reconTimer.Interval = 250;
            this.reconTimer.Tick += new System.EventHandler(this.reconTimer_Tick);
            // 
            // lightTimer
            // 
            this.lightTimer.Interval = 250;
            this.lightTimer.Tick += new System.EventHandler(this.lightTimer_Tick);
            // 
            // medTimer
            // 
            this.medTimer.Interval = 250;
            this.medTimer.Tick += new System.EventHandler(this.medTimer_Tick);
            // 
            // halfTrackTimer
            // 
            this.halfTrackTimer.Interval = 250;
            this.halfTrackTimer.Tick += new System.EventHandler(this.halfTrackTimer_Tick);
            // 
            // transportTimer
            // 
            this.transportTimer.Interval = 250;
            this.transportTimer.Tick += new System.EventHandler(this.transportTimer_Tick);
            // 
            // supplyTimer
            // 
            this.supplyTimer.Interval = 250;
            this.supplyTimer.Tick += new System.EventHandler(this.supplyTimer_Tick);
            // 
            // chkAssumeEncouraged
            // 
            this.chkAssumeEncouraged.AutoSize = true;
            this.chkAssumeEncouraged.Location = new System.Drawing.Point(6, 17);
            this.chkAssumeEncouraged.Name = "chkAssumeEncouraged";
            this.chkAssumeEncouraged.Size = new System.Drawing.Size(134, 19);
            this.chkAssumeEncouraged.TabIndex = 36;
            this.chkAssumeEncouraged.Text = "Assume Encouraged";
            this.toolTip1.SetToolTip(this.chkAssumeEncouraged, "Assumes Encouraged is being used efficiently and automatically doubles node outpu" +
        "t every 10 minutes. ");
            this.chkAssumeEncouraged.UseVisualStyleBackColor = true;
            this.chkAssumeEncouraged.CheckedChanged += new System.EventHandler(this.chkAssumeEncouraged_CheckedChanged);
            // 
            // chkNoPanther
            // 
            this.chkNoPanther.AutoSize = true;
            this.chkNoPanther.Enabled = false;
            this.chkNoPanther.Location = new System.Drawing.Point(6, 35);
            this.chkNoPanther.Name = "chkNoPanther";
            this.chkNoPanther.Size = new System.Drawing.Size(86, 19);
            this.chkNoPanther.TabIndex = 37;
            this.chkNoPanther.Text = "No Panther";
            this.toolTip1.SetToolTip(this.chkNoPanther, "Elminates the Panther control");
            this.chkNoPanther.UseVisualStyleBackColor = true;
            this.chkNoPanther.CheckedChanged += new System.EventHandler(this.chkNoPanther_CheckedChanged);
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.chkArtyGun);
            this.gbConfig.Controls.Add(this.chkAssumeEncouraged);
            this.gbConfig.Controls.Add(this.chkNoPanther);
            this.gbConfig.Location = new System.Drawing.Point(564, 368);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Size = new System.Drawing.Size(236, 79);
            this.gbConfig.TabIndex = 38;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Config";
            // 
            // chkArtyGun
            // 
            this.chkArtyGun.AutoSize = true;
            this.chkArtyGun.Location = new System.Drawing.Point(6, 54);
            this.chkArtyGun.Name = "chkArtyGun";
            this.chkArtyGun.Size = new System.Drawing.Size(82, 19);
            this.chkArtyGun.TabIndex = 38;
            this.chkArtyGun.Text = "1 Arty Gun";
            this.toolTip1.SetToolTip(this.chkArtyGun, "Lowers munitions by 3 every 12 seconds starting after 3 minutes.");
            this.chkArtyGun.UseVisualStyleBackColor = true;
            this.chkArtyGun.CheckedChanged += new System.EventHandler(this.chkArtyGun_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "INFO";
            // 
            // resourceUpdateTimer
            // 
            this.resourceUpdateTimer.Interval = 60000;
            this.resourceUpdateTimer.Tick += new System.EventHandler(this.resourceUpdateTimer_Tick);
            // 
            // encouragedTimer
            // 
            this.encouragedTimer.Interval = 600000;
            this.encouragedTimer.Tick += new System.EventHandler(this.encouragedTimer_Tick);
            // 
            // encouragedActiveTimer
            // 
            this.encouragedActiveTimer.Interval = 120000;
            this.encouragedActiveTimer.Tick += new System.EventHandler(this.encouragedActiveTimer_Tick);
            // 
            // artilleryActiveTimer
            // 
            this.artilleryActiveTimer.Interval = 3000;
            this.artilleryActiveTimer.Tick += new System.EventHandler(this.artilleryActiveTimer_Tick);
            // 
            // ResourceCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.gbConfig);
            this.Controls.Add(this.gbFuel);
            this.Controls.Add(this.gbEnemyFaction);
            this.Controls.Add(this.gbManpower);
            this.Controls.Add(this.gbMunitions);
            this.Controls.Add(this.gbResourceGroup);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMatchCountdown);
            this.Controls.Add(this.btnStartMatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResourceCalculatorForm";
            this.Text = "Enemy Resource Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbResourceGroup.ResumeLayout(false);
            this.gbResourceGroup.PerformLayout();
            this.gbMunitions.ResumeLayout(false);
            this.gbMunitions.PerformLayout();
            this.gbManpower.ResumeLayout(false);
            this.gbManpower.PerformLayout();
            this.gbEnemyFaction.ResumeLayout(false);
            this.gbEnemyFaction.PerformLayout();
            this.gbFuel.ResumeLayout(false);
            this.gbFuel.PerformLayout();
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnStartMatch;
        private Label lblMatchCountdown;
        public System.Windows.Forms.Timer matchTimerUpdateTimer;
        private Button btnReset;
        private Label lblMunitions;
        private Label lblManpower;
        private Label lblFuel;
        private Label lblbxMunitions;
        private Label lblbxManpower;
        private Label lblbxFuel;
        private Label lblMunitionsRate;
        private Label lblManpowerRate;
        private Label lblFuelRate;
        private GroupBox gbResourceGroup;
        private Label lblbxPrecisionStrike;
        private Label lblPrecisionStrike;
        private Label lblBombingRun;
        private Label lblbxBombingRun;
        public System.Windows.Forms.Timer abilityCooldownTimer;
        private Label lblKatyushaStrike;
        private Label lblbxKatyushaStrike;
        private Label lblbxStrafingRun;
        private Label lblStrafingRun;
        public System.Windows.Forms.Timer bombingRunTimer;
        private Button btnUseBombingRun;
        private Button btnUsePrecisionStrike;
        private Button btnUseKatyushaStrike;
        private Button btnUseStrafingRun;
        public System.Windows.Forms.Timer precisionStrikeTimer;
        public System.Windows.Forms.Timer katyushaStrikeTimer;
        public System.Windows.Forms.Timer strafingRunTimer;
        private Label lblAirhead;
        private Label lblbxAirhead;
        private Button btnUseAirhead;
        public System.Windows.Forms.Timer airheadTimer;
        private GroupBox gbMunitions;
        private GroupBox gbManpower;
        private RadioButton rbUS;
        private RadioButton rbGerman;
        private RadioButton rbRussian;
        private RadioButton rbBritish;
        private GroupBox gbEnemyFaction;
        private GroupBox gbFuel;
        private Label lblTransportTruck;
        private Button btnUseReconTank;
        private Label lblbxReconTank;
        private Label lblReconTank;
        private Button btnUseMedTank;
        private Label lblbxMedTank;
        private Label lblMedTank;
        private Button btnUseLightTank;
        private Label lblbxLightTank;
        private Label lblLightTank;
        private Button btnUseJumbo75;
        private Label lblbxJumbo75;
        private Label lblJumbo75;
        private Button btnUseJumbo76;
        private Label lblbxJumbo76;
        private Label lblJumbo76;
        private Button btnUseTransportTruck;
        private Label lblbxTransportTruck;
        private Button btnUseSupplyTruck;
        private Label lblbxSupplyTruck;
        private Label lblSupplyTruck;
        private Button btnUseHalfTrack;
        private Label lblHalfTrack;
        private Label lblbxHalfTrack;
        public System.Windows.Forms.Timer jumbo75Timer;
        public System.Windows.Forms.Timer jumbo76Timer;
        public System.Windows.Forms.Timer tigerTimer;
        public System.Windows.Forms.Timer pantherTimer;
        public System.Windows.Forms.Timer is1Timer;
        public System.Windows.Forms.Timer fireflyTimer;
        public System.Windows.Forms.Timer churchillTimer;
        public System.Windows.Forms.Timer reconTimer;
        public System.Windows.Forms.Timer lightTimer;
        public System.Windows.Forms.Timer medTimer;
        public System.Windows.Forms.Timer halfTrackTimer;
        public System.Windows.Forms.Timer transportTimer;
        public System.Windows.Forms.Timer supplyTimer;
        private Label lblTiger;
        private Label lblbxTiger;
        private Button btnUseTiger;
        private Label lblPanther;
        private Label lblbxPanther;
        private Button btnUsePanther;
        private Label lblChurchill;
        private Label lblbxChurchill;
        private Button btnUseChurchill;
        private Label lblbxFirefly;
        private Label lblFirefly;
        private Button btnUseFirefly;
        private Label lblbxIS1;
        private Label lblIS1;
        private Button btnUseIS1;
        private CheckBox chkAssumeEncouraged;
        private CheckBox chkNoPanther;
        private GroupBox gbConfig;
        private ToolTip toolTip1;
        public System.Windows.Forms.Timer resourceUpdateTimer;
        private System.Windows.Forms.Timer encouragedTimer;
        private System.Windows.Forms.Timer encouragedActiveTimer;
        private Label lblbxCounterHeavy2;
        private Label lblbxCounterHeavy1;
        private CheckBox chkArtyGun;
        private System.Windows.Forms.Timer artilleryActiveTimer;
    }
}