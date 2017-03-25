using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotCLI
{
    public enum MissionTypeEnum
    {
        Search,
        Combat,
        Collect
    }

    class Mission
    {
        string Title { get; set; }

        MissionTypeEnum MissionType { get; set; } 

        int Level { get; set; }

        internal int LevelMax { get; set; }

        int DamagePerTurn { get; set; }

        int CooldownTurns { get; set; }

        int RewardMoney { get; set; }

        int RewardXP { get; set; }

        public static List<Mission> GetSampleData()
        {
            return new List<Mission>()
            {
               new Mission(){ Title="Test Collect", MissionType = MissionTypeEnum.Collect, LevelMax = 40, DamagePerTurn = 100, CooldownTurns = 300, RewardMoney = 100, RewardXP = 100 },
               new Mission(){ Title="Test Combat", MissionType = MissionTypeEnum.Combat, LevelMax = 40, DamagePerTurn = 100, CooldownTurns = 300, RewardMoney = 100, RewardXP = 100 },
               new Mission(){ Title="Test Search", MissionType = MissionTypeEnum.Search, LevelMax = 40, DamagePerTurn = 100, CooldownTurns = 300, RewardMoney = 100, RewardXP = 100 }
            };
        }

    }


}
