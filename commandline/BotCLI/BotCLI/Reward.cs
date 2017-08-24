using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotCLI
{
    public enum RewardEnum
    {
        Ore1,
        Ore2,
        XP,
        Bots,
        Equipment,
        Location,
        SkillBoost,
        Power,
        Unlock
    }

    class Reward
    {
        public string Name;
        public int Amount;
        public RewardEnum RewardType;

        // What does the XP apply to? A skill?  Which skill?

    }
}
