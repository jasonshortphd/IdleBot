using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotCLI
{
    public enum BotTypeEnum
    {
        // Simple seeker, not good for combat
        Seeker,
        // Basic combat bot
        Combat,
        // Laser is very useful against large boss enemy
        Laser,
        // Repair bots around it
        Repair,
        // Shields bots around it
        Shield,
        // Breaks apart enemy using nanobot disassemblers
        Disassembler,
        // Coordinates other bots nearby to make all more effective
        Controller,
        // Non sentiant AI - Baddest helper we can build (expensive)
        NSAI                
    }

    class Bot
    {
        public int Power { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Shields { get; set; }
        public int Sensors { get; set; }
        public int Collectors { get; set; }

        // Specials - not all have these, and none have ALL of them
        public int CriticalDamageBuff { get; set; }
        public int DamageBuff { get; set; }
        public int RepairBuff { get; set; }
        public int ShieldBuff { get; set; }
        public int PowerBuff { get; set; }
        public int SpeedBuff { get; set; }

        public BotTypeEnum BotType { get; set; }

        public Bot(BotTypeEnum typeOfBot)
        {
            this.BotType = typeOfBot;
        }
    }
}
