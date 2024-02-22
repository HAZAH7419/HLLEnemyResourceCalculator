using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnemyResourceCalculator.CommanderAbility;

namespace EnemyResourceCalculator
{
    public class AbilityListDeclaration
    {
        public List<CommanderAbility> Abilities = new List<CommanderAbility>()
        {
            new CommanderAbility {Name = AbilityName.BombingRun, Cooldown = 600d, IsReady = false, IsAllowed = true, Cost = 300, ResourceType = CommanderAbility.Type.Munitions, Faction = FactionType.All, IsActive = true },
            new CommanderAbility {Name = AbilityName.KatyushaStrike, Cooldown = 300d, IsReady = false, IsAllowed = true, Cost = 300, ResourceType = CommanderAbility.Type.Munitions, Faction = FactionType.Russian, IsActive = true },
            new CommanderAbility {Name = AbilityName.PrecisionStrike, Cooldown = 1200d, IsReady = false, IsAllowed = true, Cost = 250, ResourceType = CommanderAbility.Type.Munitions, Faction = FactionType.All, IsActive = true },
            new CommanderAbility {Name = AbilityName.StrafingRun, Cooldown = 250d, IsReady = false, IsAllowed = true, Cost = 150, ResourceType = CommanderAbility.Type.Munitions, Faction = FactionType.All, IsActive = true },
            new CommanderAbility {Name = AbilityName.Encouraged, Cooldown = 600d, IsReady = false, IsAllowed = true, Cost = 400, ResourceType = CommanderAbility.Type.Manpower, Faction = FactionType.All, IsActive = true },
            new CommanderAbility {Name = AbilityName.Airhead, Cooldown = 600d, IsReady = false, IsAllowed = true, Cost = 400, ResourceType = CommanderAbility.Type.Manpower, Faction = FactionType.All, IsActive = true },
            new CommanderAbility {Name = AbilityName.HalfTrack, Cooldown = 300d, IsReady = false, IsAllowed = true, Cost = 300, ResourceType = CommanderAbility.Type.Fuel, Faction = FactionType.All, IsActive = true },
            new CommanderAbility {Name = AbilityName.LightTank, Cooldown = 90d, IsReady = false, IsAllowed = true, Cost = 150, ResourceType = CommanderAbility.Type.Fuel, Faction = FactionType.All, IsActive = true },
            new CommanderAbility {Name = AbilityName.MediumTank, Cooldown = 250d, IsReady = false, IsAllowed = true, Cost = 200, ResourceType = CommanderAbility.Type.Fuel, Faction = FactionType.All, IsActive = true },
            new CommanderAbility {Name = AbilityName.Jumbo75, Cooldown = 250d, IsReady = false, IsAllowed = true, Cost = 500, ResourceType = CommanderAbility.Type.Fuel, Faction = FactionType.US, IsActive = true },
            new CommanderAbility {Name = AbilityName.Jumbo76, Cooldown = 300d, IsReady = false, IsAllowed = true, Cost = 600, ResourceType = CommanderAbility.Type.Fuel, Faction = FactionType.US, IsActive = true },
            new CommanderAbility {Name = AbilityName.Churchill, Cooldown = 300d, IsReady = false, IsAllowed = true, Cost = 600, ResourceType = CommanderAbility.Type.Fuel, Faction = FactionType.British, IsActive = true },
            new CommanderAbility {Name = AbilityName.Firefly, Cooldown = 300d, IsReady = false, IsAllowed = true, Cost = 600, ResourceType = CommanderAbility.Type.Fuel, Faction = FactionType.British, IsActive = true },
            new CommanderAbility {Name = AbilityName.IS1, Cooldown = 300d, IsReady = false, IsAllowed = true, Cost = 600, ResourceType = CommanderAbility.Type.Fuel, Faction = FactionType.Russian, IsActive = true },
            new CommanderAbility {Name = AbilityName.Tiger, Cooldown = 300d, IsReady = false, IsAllowed = true, Cost = 600, ResourceType = CommanderAbility.Type.Fuel, Faction = FactionType.German, IsActive = true },
            new CommanderAbility {Name = AbilityName.Panther, Cooldown = 300d, IsReady = false, IsAllowed = true, Cost = 600, ResourceType = CommanderAbility.Type.Fuel, Faction = FactionType.German, IsActive = true },
            new CommanderAbility {Name = AbilityName.ReconTank, Cooldown = 90d, IsReady = false, IsAllowed = true, Cost = 100, ResourceType = CommanderAbility.Type.Fuel, Faction = FactionType.All, IsActive = true },
            new CommanderAbility {Name = AbilityName.SupplyTruck, Cooldown = 90d, IsReady = false, IsAllowed = true, Cost = 100, ResourceType = CommanderAbility.Type.Fuel, Faction = FactionType.All, IsActive = true },
            new CommanderAbility {Name = AbilityName.TransportTruck, Cooldown = 90d, IsReady = false, IsAllowed = true, Cost = 100, ResourceType = CommanderAbility.Type.Fuel, Faction = FactionType.All, IsActive = true },

        };
    }
}
