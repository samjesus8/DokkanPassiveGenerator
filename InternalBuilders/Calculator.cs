namespace DokkanPassiveGenerator.InternalBuilders
{
    public class Calculator
    {
        //User Input
        public string Rarity { get; set; }
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

        private double DEFRaise = 0.3; //30% Raise
        private double GreatDEFRaise = 0.5; //50% Raise
        private double MassiveDEFRaise = 1.0; //100% Raise

        //Output Variables
        public string ResultATK { get; set; }
        public string ResultDEF { get; set; }

        public Calculator(string rarity, int hp, int atk, int def, int leaderValue, int passiveATK, int passiveDEF, int support) 
        {
            this.Rarity = rarity;
            this.HP = hp;
            this.ATK = atk;
            this.DEF = def;
            this.LeaderSkillBuff = leaderValue;
            this.PassiveATK = passiveATK;
            this.PassiveDEF = passiveDEF;
            this.Support = support;

            if (Rarity == "TUR") 
            {
                this.ResultATK = GetATKTUR(this.ATK, this.LeaderSkillBuff, this.PassiveATK, this.Support);
                this.ResultDEF = GetDEF(this.DEF, this.LeaderSkillBuff, this.PassiveDEF, this.Support);
            }
            else if (Rarity == "LR") 
            {
                this.ResultATK = GetATKLR(this.ATK, this.LeaderSkillBuff, this.PassiveATK, this.Support);
                this.ResultDEF = GetDEF(this.DEF, this.LeaderSkillBuff, this.PassiveDEF, this.Support);
            }
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

            string output = "ATK Stats \r\n\r\n" +
                            "ATK Stat with NO Buffs - " + ATKBase.ToString("N0") + "\r\n" +
                            "ATK Stat with Support - " + ATKWithSupport.ToString("N0") + " (" + (Support * 100) + " % Support)";
            return output;
        }
        public string GetATKLR(int ATK, double Leader, double passiveATK, double Support) 
        {
            double ATKBaseC = 0;
            double ATKBaseMC = 0;

            double ATKWithSupportC = 0;
            double ATKWithSupportMC = 0;

            Leader = Leader / 100;
            Support = Support / 100;
            passiveATK = passiveATK / 100;

            var step1 = ATK * (1 + Leader + Leader);
            var step2 = step1 * (1 + passiveATK);

            var supportStep = step2 * (1 + Support);

            var step3 = step2 * KiMultiplierLR;

            ATKBaseC = step3 * SAMultiplierLRC; //ATK Stat at 12 KI - Colossal DMG
            ATKBaseMC = step3 * SAMultiplierLRMC; //ATK Stat at 24 KI - Mega-Colossal DMG

            var supportStep1 = supportStep * KiMultiplierLR;

            ATKWithSupportC = supportStep1 * SAMultiplierLRC;
            ATKWithSupportMC = supportStep1 * SAMultiplierLRMC;

            string output = "ATK Stats \r\n\r\n" +
                            "ATK Stat with NO Buffs (12 KI - Colossal) - " + ATKBaseC.ToString("N0") + "\r\n" +
                            "ATK Stat with NO Buffs (24 KI - Mega-Colossal) - " + ATKBaseMC.ToString("N0") + "\r\n\r\n" +
                            "ATK Stat with Support (12 KI - Colossal) - " + ATKWithSupportC.ToString("N0") + " (" + (Support * 100) + " % Support) \r\n" +
                            "ATK Stat with Support (24 KI - Mega-Colossal) - " + ATKWithSupportMC.ToString("N0") + " (" + (Support * 100) + " % Support)";
            return output;
        }
        public string GetDEF(int DEF, double Leader, double passiveDEF, double Support) 
        {
            double DEFPreSuper = 0;
            double DEFSupport = 0;

            Leader = Leader / 100;
            passiveDEF = passiveDEF / 100;
            Support = Support / 100;

            var step1 = DEF * (1 + Leader + Leader); //Multiply DEF by Leader X2
            DEFPreSuper = step1 * (1 + passiveDEF); //Multiply by Passive

            DEFSupport = DEFPreSuper * (1 + Support);

            double NormalDEFRaise = DEFPreSuper * (1 + this.DEFRaise); //Raises DEF by 1 Turn
            double GreatDEFRaise = DEFPreSuper * (1 + this.GreatDEFRaise); //Greatly Raises DEF by 1 Turn
            double MassiveDEFRaise = DEFPreSuper * (1 + this.MassiveDEFRaise); //Massively Raises DEF by 1 Turn

            string output = "DEF Stats \r\n\r\n" +
                            "DEF Pre Super - " + DEFPreSuper.ToString("N0") + "\r\n" +
                            "DEF With Support - " + DEFSupport.ToString("N0") + " (" + (Support * 100) + " % Support) \r\n\r\n" +
                            "Defense Stats on Super \r\n\r\n" +
                            "Normal Raise (30%) - " + NormalDEFRaise.ToString("N0") + "\r\n" +
                            "Great Raise (50%) - " + GreatDEFRaise.ToString("N0") + "\r\n" +
                            "Massive Raise (100%) - " + MassiveDEFRaise.ToString("N0") + "\r\n";

            return output;
        }
    }
}
