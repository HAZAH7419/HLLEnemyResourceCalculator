using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyResourceCalculator
{
    class TimingCalculator
    {
        private const double MATCH_TIME_IN_SECONDS = 5400d;

        public DateTime MatchStartTimer(DateTime matchStart)
        {
            return matchStart.AddSeconds(MATCH_TIME_IN_SECONDS);
        }

        public DateTime AbilityStartTimer(DateTime abilityStart, double cooldown)
        {
            return abilityStart.AddSeconds(cooldown);
        }

        public (double, string) Calculate(DateTime clickTime, CommanderAbility? ability)
        {
            var formatString = "hh:mm:ss";
            var timerClick = new DateTime();
            var timeUntilExpired = new TimeSpan();
            var remainingSeconds = 0d;

            if (ability != null)
            {
                formatString = "mm:ss";
                timerClick = AbilityStartTimer(clickTime, ability.Cooldown);
            }
            else
            {
                formatString = "hh:mm:ss";
                timerClick = MatchStartTimer(clickTime);
            }
             
             timeUntilExpired = timerClick - DateTime.Now;
             remainingSeconds = Math.Round(timeUntilExpired.TotalSeconds);

            TimeSpan time = TimeSpan.FromSeconds(remainingSeconds);
            DateTime dateTime = DateTime.Today.Add(time);
            var displayTime = dateTime.ToString(formatString);

            return (remainingSeconds, displayTime);


        }
    }
}
