using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotCLI
{
    public enum QuestTypeEnum
    {
        Standard,
        Optional,
        Hard,
        Combat,
        Build,
        Train
    }

    class Quest
    {
        public string Title;
        public List<Reward> Rewards;
        public List<Requirement> Requirements;
        public QuestTypeEnum QuestType;
    }
}
