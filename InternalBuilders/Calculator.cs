using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokkanPassiveGenerator.InternalBuilders
{
    public class Calculator
    {
        //User Input
        public int HP { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public int LeaderSkillBuff { get; set; }
        public int PassiveATK { get; set; }
        public int PassiveDEF { get; set; }
        public int Support { get; set; }

        //Constants
        private double KiMultiplierTUR = 1.5;
        private double KiMultiplierLR = 2.0;

        private double SAMultiplierTUR = 5.05;

        private double SAMultiplierLRC = 4.95;
        private double SAMultiplierLRMC = 6.45;

        //Output Variables
        public string ResultATK { get; set; }

        public Calculator(int hp, int atk, int def, int leaderValue, int passiveATK, int passiveDEF, int support) 
        {
            this.HP = hp;
            this.ATK = atk;
            this.DEF = def;
            this.LeaderSkillBuff = leaderValue;
            this.PassiveATK = passiveATK;
            this.PassiveDEF = passiveDEF;
            this.Support = support;

            this.ResultATK = GetATKTUR(this.ATK, this.LeaderSkillBuff, this.PassiveATK, this.Support);
        }

        public string GetATKTUR(int ATK, double Leader, double passiveATK, double Support) 
        {
            double ATKBase = 0;
            double ATKWithSupport = 0;

            Leader = Leader / 100;
            Support = Support / 100;
            passiveATK = passiveATK / 100;

            var step1 = ATK * (1 + Leader + Leader);
            var step2 = step1 * (1 + passiveATK);

            var supportStep = step2 * (1 + Support);

            var step3 = step2 * KiMultiplierTUR;
            ATKBase = step3 * SAMultiplierTUR; //FINAL ATK STAT WITH NO BUFFS

            var supportStep1 = supportStep * KiMultiplierTUR;
            ATKWithSupport = supportStep1 * SAMultiplierTUR; //FINAL ATK STAT WITH SUPPORT

            string output = "ATK Stat with NO Buffs - " + ATKBase.ToString("N0") + "\r\n" +
                            "ATK Stat with Support - " + ATKWithSupport.ToString("N0") + " " + (Support * 100) + " % Support";
            return output;
        }
    }
}
