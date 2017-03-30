using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotCLI
{
    class Quests
    {
        public List<Quest> QuestList;
    }

    class Quest
    {
        public string QuestTitle;
        public Reward QuestReward;
        public Requirement QuestRequirements;
    }
}
