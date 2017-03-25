using System;

namespace BotCLI
{
    public class BotSpawner
    {
        // How many bots can we spawn from this max?
        // How many are there now?
        // How fast do they spawn?
        // What is the fastest they can spawn?
        // Starting values for both?

        public string Name { get; set; }

        public int SpawnTimeStartSecs { get; set; }
        public int SpawnTimeMinSecs { get; set; }
        public int SpawnTimeCurrent { get; set; }
        public float SpawnTimeBaseCost { get; set; }
        public float SpawnTimeCostFactor { get; set; }

        public int BotsStart { get; set; }
        public int BotsMax { get; set; }

        public float BotsCostBase { get; set; }
        public float BotsCostFactor { get; set; }

        public int LevelCurrent { get; set; }
        public int LevelMax { get; set; }

        bool hasMaxed = false;
        // Has this spawner been maxed out?  This is for acheivements
        // user could drop it back down, so we need to know if they maxed
        public bool HasMaxed
        {
            get { return HasMaxed; }
        }

        int botsCurrent;
        public int BotsCurrent { get { return botsCurrent; } }

        // What is the type of bot we are supposed to be spawning here?
        BotTypeEnum botType;

        public BotTypeEnum BotType
        {
            get
            {
                return botType;
            }
        }

        public BotSpawner(BotTypeEnum botType)
        {
            this.botType = botType;
            this.botsCurrent = 1;
        }

        // Called per frame to do anything we need
        public void Tick()
        {
            SpawnTimeCurrent--;

            if (SpawnTimeCurrent <= 0)
            {
                if (BotsCurrent < BotsMax)
                {
                    Spawn();
                }
            }
        }

        public void Spawn()
        {
            Bot newBot = new Bot(this.botType);

        }

    }
}