using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotCLI
{
    class Game
    {
        IEnumerable<Mission> missionList;

        void Initialize()
        {
            missionList = Mission.GetSampleData();

            var lowLevelMissions = missionList.Where(m => m.LevelMax < 40);
        }

        void Start()
        {

        }




    }
}
