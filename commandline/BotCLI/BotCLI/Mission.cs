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


    }

}
