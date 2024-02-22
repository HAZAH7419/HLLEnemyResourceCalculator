using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyResourceCalculator
{
    public class CommanderAbility
    {
        public AbilityName Name { get; set; }
        public double Cooldown { get; set; }
        public bool IsReady { get; set; }
        public bool IsAllowed { get; set; }
        public bool IsActive { get; set; }
        public int Cost { get; set; }
        public Type ResourceType { get; set; }
        public FactionType Faction { get; set; } 
        public string? DisplayTime { get; set; }
        public DateTime Timer { get; set; } = DateTime.MinValue;

        public enum Type
        {
            Munitions,
            Manpower,
            Fuel
        }

        public enum AbilityName
        {
            BombingRun,
            KatyushaStrike,
            PrecisionStrike,
            StrafingRun,
            Encouraged,
            Airhead,
            HalfTrack,
            LightTank,
            MediumTank,
            ReconTank,
            Panther,
            Tiger,
            Jumbo75,
            Jumbo76,
            Churchill,
            IS1,
            Firefly,
            SupplyTruck,
            TransportTruck
        }

        public enum FactionType
        {
            US,
            German,
            British,
            Russian,
            All
        }
    }
}
