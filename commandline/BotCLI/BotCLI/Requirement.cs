using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotCLI
{
    public enum RequirementEnum
    {
        Attack,
        Defend,
        Build,
        Create,
        Training,

    }

    class Requirement
    {
        public string Title;

        public int RequiredNum;
        public int CurrentNum;

        public RequirementEnum RequirementType;
    }
}
