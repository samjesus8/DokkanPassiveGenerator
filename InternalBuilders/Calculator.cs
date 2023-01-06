namespace DokkanPassiveGenerator.InternalBuilders
{
    public class Calculator
    {
        private LinksLoad _LinkEngine = new LinksLoad();

        //User Input
        public string Rarity { get; set; }
        public int HP { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public int LeaderSkillBuff { get; set; }
        public int PassiveATK { get; set; }
        public int PassiveDEF { get; set; }
        public int Support { get; set; }
        public string[] Links { get; set; }

        //Constants
        private double KiMultiplierTUR = 1.5;
        private double KiMultiplierLR = 2.0;

        private double SAMultiplierTUR = 5.05;
        private double SAMultiplierLRC = 4.95;
        private double SAMultiplierLRMC = 6.45;

        private double EZATURSAMultiplier = 6.05;
        private double EZALRSAMultiplierC = 5.25;
        private double EZALRSAMultiplierMC = 6.95;

        private double NormalRaise = 0.3; //30% Raise
        private double GreatRaise = 0.5; //50% Raise
        private double MassiveRaise = 1.0; //100% Raise

        //Output Variables
        public string ResultATK { get; set; }
        public string ResultDEF { get; set; }

        public Calculator(string rarity, int hp, int atk, int def, int leaderValue, int passiveATK, int passiveDEF, int support, string[] links) 
        {
            this.Rarity = rarity;
            this.HP = hp;
            this.ATK = atk;
            this.DEF = def;
            this.LeaderSkillBuff = leaderValue;
            this.PassiveATK = passiveATK;
            this.PassiveDEF = passiveDEF;
            this.Support = support;
            this.Links = links;

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
            else if (Rarity == "TUR (EZA)") 
            {
                this.ResultATK = GetATKTUREZA(this.ATK, this.LeaderSkillBuff, this.PassiveATK, this.Support);
                this.ResultDEF = GetDEF(this.DEF, this.LeaderSkillBuff, this.PassiveDEF, this.Support);
            }
            else if (Rarity == "LR (EZA)") 
            {
                this.ResultATK = GetATKLREZA(this.ATK, this.LeaderSkillBuff, this.PassiveATK, this.Support);
                this.ResultDEF = GetDEF(this.DEF, this.LeaderSkillBuff, this.PassiveDEF, this.Support);
            }
        }

        public string GetATKTUR(int ATK, double Leader, double passiveATK, double Support) 
        {
            double ATKBase = 0;
            double ATKWithSupport = 0;
            double ATKWithLinks = 0;

            double LinksATKMultiplier = 0;

            Leader = Leader / 100;
            Support = Support / 100;
            passiveATK = passiveATK / 100;

            var step1 = ATK * (1 + Leader + Leader);
            var step2 = step1 * (1 + passiveATK);

            var supportStep = step2 * (1 + Support);

            var step3 = step2 * KiMultiplierTUR;
            var step4 = step3 * SAMultiplierTUR; //FINAL ATK STAT WITH NO BUFFS
            ATKBase = step4 * (1 + NormalRaise);

            //SUPPORT

            var supportStep1 = supportStep * KiMultiplierTUR;
            var supportStep2 = supportStep1 * SAMultiplierTUR; //FINAL ATK STAT WITH SUPPORT
            ATKWithSupport = supportStep2 * (1 + NormalRaise);

            //LINKS

            _LinkEngine.LoadLinks();

            for (int i = 0; i < Links.Length; i++) 
            {
                if (_LinkEngine.Links.ContainsKey(Links[i])) 
                {
                    _LinkEngine.Links.TryGetValue(Links[i], out var TempLink);
                    LinksATKMultiplier = LinksATKMultiplier + TempLink.ATK;
                }
            }
            LinksATKMultiplier = LinksATKMultiplier / 100;
            ATKWithLinks = ATKBase * (1 + LinksATKMultiplier);

            //TOTAL ATK STATS

            double TotalATKNormal = step4 * (1 + Support + LinksATKMultiplier) * (1 + NormalRaise);
            double TotalATKGreat = step4 * (1 + Support + LinksATKMultiplier) * (1 + GreatRaise);
            double TotalATKMassive = step4 * (1 + Support + LinksATKMultiplier) * (1 + MassiveRaise);

            string output = "ATK Stats (Support/Links Individually Calculated) \r\n" +
                            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔ \r\n" +
                            "ATK Stat (Base) - " + ATKBase.ToString("N0") + "\r\n" +
                            "ATK Stat with Support - " + ATKWithSupport.ToString("N0") + " (" + (Support * 100) + "% Support) \r\n" +
                            "ATK Stat with Links - " + ATKWithLinks.ToString("N0") + "\r\n\r\n" +
                            "Total ATK Stat (SUPPORT + LINKS) \r\n" +
                            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔ \r\n" +
                            "Normal Raise - " + TotalATKNormal.ToString("N0") + "\r\n" +
                            "Great Raise = " + TotalATKGreat.ToString("N0") + "\r\n" +
                            "Massive Raise - " + TotalATKMassive.ToString("N0") + "\r\n";
            return output;
        }
        public string GetATKLR(int ATK, double Leader, double passiveATK, double Support) 
        {
            double LinksATKMultiplier = 0;

            double ATKBaseC = 0;
            double ATKBaseMC = 0;

            double ATKWithSupportC = 0;
            double ATKWithSupportMC = 0;

            double ATKWithLinksC = 0;
            double ATKWithLinksMC = 0;

            Leader = Leader / 100;
            Support = Support / 100;
            passiveATK = passiveATK / 100;

            var step1 = ATK * (1 + Leader + Leader);
            var step2 = step1 * (1 + passiveATK);

            var supportStep = step2 * (1 + Support);

            var step3 = step2 * KiMultiplierLR;

            var step4C = step3 * SAMultiplierLRC; //ATK Stat at 12 KI - Colossal DMG
            var step4MC = step3 * SAMultiplierLRMC; //ATK Stat at 24 KI - Mega-Colossal DMG

            ATKBaseC = step4C * (1 + NormalRaise);
            ATKBaseMC = step4MC * (1 + NormalRaise);

            //SUPPORT

            var supportStep1 = supportStep * KiMultiplierLR;

            var supportStepC = supportStep1 * SAMultiplierLRC;
            var supportStepMC = supportStep1 * SAMultiplierLRMC;

            ATKWithSupportC = supportStepC * (1 + NormalRaise);
            ATKWithSupportMC = supportStepMC * (1 + NormalRaise);

            //LINKS

            _LinkEngine.LoadLinks();

            for (int i = 0; i < Links.Length; i++)
            {
                if (_LinkEngine.Links.ContainsKey(Links[i]))
                {
                    _LinkEngine.Links.TryGetValue(Links[i], out var TempLink);
                    LinksATKMultiplier = LinksATKMultiplier + TempLink.ATK;
                }
            }
            LinksATKMultiplier = LinksATKMultiplier / 100;
            ATKWithLinksC = ATKBaseC * (1 + LinksATKMultiplier);
            ATKWithLinksMC = ATKBaseMC * (1 + LinksATKMultiplier);

            //TOTAL

            double TotalATKNormalC = step4C * (1 + Support + LinksATKMultiplier) * (1 + NormalRaise);
            double TotalATKNormalMC = step4MC * (1 + Support + LinksATKMultiplier) * (1 + NormalRaise);

            double TotalATKGreatC = step4C * (1 + Support + LinksATKMultiplier) * (1 + GreatRaise);
            double TotalATKGreatMC = step4MC * (1 + Support + LinksATKMultiplier) * (1 + GreatRaise);

            double TotalATKMassiveC = step4C * (1 + Support + LinksATKMultiplier) * (1 + MassiveRaise);
            double TotalATKMassiveMC = step4MC * (1 + Support + LinksATKMultiplier) * (1 + MassiveRaise);

            string output = "ATK Stats (Support/Links Individually Calculated) \r\n" +
                            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔ \r\n" +
                            "ATK Stat (Base 12 KI - Colossal) - " + ATKBaseC.ToString("N0") + "\r\n" +
                            "ATK Stat (Base 24 KI - Mega-Colossal) - " + ATKBaseMC.ToString("N0") + "\r\n\r\n" +
                            "ATK Stat with Support (12 KI - Colossal) - " + ATKWithSupportC.ToString("N0") + " (" + (Support * 100) + "% Support) \r\n" +
                            "ATK Stat with Support (24 KI - Mega-Colossal) - " + ATKWithSupportMC.ToString("N0") + "\r\n\r\n" +
                            "ATK Stat with Links (12 KI - Colossal) - " + ATKWithLinksC.ToString("N0") + "\r\n" +
                            "ATK Stat with Links (24 KI - Mega-Colossal) - " + ATKWithLinksMC.ToString("N0") + "\r\n\r\n" +
                            "TOTAL ATK STAT (SUPPORT + LINKS) \r\n" +
                            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔ \r\n" +
                            "Normal Raise (12 KI - Colossal) - " + TotalATKNormalC.ToString("N0") + "\r\n" +
                            "Normal Raise (24 KI - Mega-Colossal) - " + TotalATKNormalMC.ToString("N0") + "\r\n\r\n" +
                            "Great Raise (12 KI - Colossal) - " + TotalATKGreatC.ToString("N0") + "\r\n" +
                            "Great Raise (24 KI - Mega-Colossal) - " + TotalATKGreatMC.ToString("N0") + "\r\n\r\n" +
                            "Massive Raise (12 KI - Colossal) - " + TotalATKMassiveC.ToString("N0") + "\r\n" +
                            "Massive Raise (24 KI - Mega-Colossal) - " + TotalATKMassiveMC.ToString("N0");
            return output;
        }
        public string GetATKTUREZA(int ATK, double Leader, double passiveATK, double Support) 
        {
            double ATKBase = 0;
            double ATKWithSupport = 0;
            double ATKWithLinks = 0;

            double LinksATKMultiplier = 0;

            Leader = Leader / 100;
            Support = Support / 100;
            passiveATK = passiveATK / 100;

            var step1 = ATK * (1 + Leader + Leader);
            var step2 = step1 * (1 + passiveATK);

            var supportStep = step2 * (1 + Support);

            var step3 = step2 * KiMultiplierTUR;
            var step4 = step3 * EZATURSAMultiplier; //FINAL ATK STAT WITH NO BUFFS
            ATKBase = step4 * (1 + NormalRaise);

            //SUPPORT

            var supportStep1 = supportStep * KiMultiplierTUR;
            var supportStep2 = supportStep1 * EZATURSAMultiplier; //FINAL ATK STAT WITH SUPPORT
            ATKWithSupport = supportStep2 * (1 + NormalRaise);

            //LINKS

            _LinkEngine.LoadLinks();

            for (int i = 0; i < Links.Length; i++)
            {
                if (_LinkEngine.Links.ContainsKey(Links[i]))
                {
                    _LinkEngine.Links.TryGetValue(Links[i], out var TempLink);
                    LinksATKMultiplier = LinksATKMultiplier + TempLink.ATK;
                }
            }
            LinksATKMultiplier = LinksATKMultiplier / 100;
            ATKWithLinks = ATKBase * (1 + LinksATKMultiplier);

            //TOTAL ATK STATS

            double TotalATKNormal = step4 * (1 + Support + LinksATKMultiplier) * (1 + NormalRaise);
            double TotalATKGreat = step4 * (1 + Support + LinksATKMultiplier) * (1 + GreatRaise);
            double TotalATKMassive = step4 * (1 + Support + LinksATKMultiplier) * (1 + MassiveRaise);

            string output = "ATK Stats (Support/Links Individually Calculated) \r\n" +
                            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔ \r\n" +
                            "ATK Stat (Base) - " + ATKBase.ToString("N0") + "\r\n" +
                            "ATK Stat with Support - " + ATKWithSupport.ToString("N0") + " (" + (Support * 100) + "% Support) \r\n" +
                            "ATK Stat with Links - " + ATKWithLinks.ToString("N0") + "\r\n\r\n" +
                            "Total ATK Stat (SUPPORT + LINKS) \r\n" +
                            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔ \r\n" +
                            "Normal Raise - " + TotalATKNormal.ToString("N0") + "\r\n" +
                            "Great Raise = " + TotalATKGreat.ToString("N0") + "\r\n" +
                            "Massive Raise - " + TotalATKMassive.ToString("N0") + "\r\n";
            return output;
        }
        public string GetATKLREZA(int ATK, double Leader, double passiveATK, double Support) 
        {
            double LinksATKMultiplier = 0;

            double ATKBaseC = 0;
            double ATKBaseMC = 0;

            double ATKWithSupportC = 0;
            double ATKWithSupportMC = 0;

            double ATKWithLinksC = 0;
            double ATKWithLinksMC = 0;

            Leader = Leader / 100;
            Support = Support / 100;
            passiveATK = passiveATK / 100;

            var step1 = ATK * (1 + Leader + Leader);
            var step2 = step1 * (1 + passiveATK);

            var supportStep = step2 * (1 + Support);

            var step3 = step2 * KiMultiplierLR;

            var step4C = step3 * EZALRSAMultiplierC; //ATK Stat at 12 KI - Colossal DMG
            var step4MC = step3 * EZALRSAMultiplierMC; //ATK Stat at 24 KI - Mega-Colossal DMG

            ATKBaseC = step4C * (1 + NormalRaise);
            ATKBaseMC = step4MC * (1 + NormalRaise);

            //SUPPORT

            var supportStep1 = supportStep * KiMultiplierLR;

            var supportStepC = supportStep1 * EZALRSAMultiplierC;
            var supportStepMC = supportStep1 * EZALRSAMultiplierMC;

            ATKWithSupportC = supportStepC * (1 + NormalRaise);
            ATKWithSupportMC = supportStepMC * (1 + NormalRaise);

            //LINKS

            _LinkEngine.LoadLinks();

            for (int i = 0; i < Links.Length; i++)
            {
                if (_LinkEngine.Links.ContainsKey(Links[i]))
                {
                    _LinkEngine.Links.TryGetValue(Links[i], out var TempLink);
                    LinksATKMultiplier = LinksATKMultiplier + TempLink.ATK;
                }
            }
            LinksATKMultiplier = LinksATKMultiplier / 100;
            ATKWithLinksC = ATKBaseC * (1 + LinksATKMultiplier);
            ATKWithLinksMC = ATKBaseMC * (1 + LinksATKMultiplier);

            //TOTAL

            double TotalATKNormalC = step4C * (1 + Support + LinksATKMultiplier) * (1 + NormalRaise);
            double TotalATKNormalMC = step4MC * (1 + Support + LinksATKMultiplier) * (1 + NormalRaise);

            double TotalATKGreatC = step4C * (1 + Support + LinksATKMultiplier) * (1 + GreatRaise);
            double TotalATKGreatMC = step4MC * (1 + Support + LinksATKMultiplier) * (1 + GreatRaise);

            double TotalATKMassiveC = step4C * (1 + Support + LinksATKMultiplier) * (1 + MassiveRaise);
            double TotalATKMassiveMC = step4MC * (1 + Support + LinksATKMultiplier) * (1 + MassiveRaise);

            string output = "ATK Stats (Support/Links Individually Calculated) \r\n" +
                            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔ \r\n" +
                            "ATK Stat (Base 12 KI - Colossal) - " + ATKBaseC.ToString("N0") + "\r\n" +
                            "ATK Stat (Base 24 KI - Mega-Colossal) - " + ATKBaseMC.ToString("N0") + "\r\n\r\n" +
                            "ATK Stat with Support (12 KI - Colossal) - " + ATKWithSupportC.ToString("N0") + " (" + (Support * 100) + "% Support) \r\n" +
                            "ATK Stat with Support (24 KI - Mega-Colossal) - " + ATKWithSupportMC.ToString("N0") + "\r\n\r\n" +
                            "ATK Stat with Links (12 KI - Colossal) - " + ATKWithLinksC.ToString("N0") + "\r\n" +
                            "ATK Stat with Links (24 KI - Mega-Colossal) - " + ATKWithLinksMC.ToString("N0") + "\r\n\r\n" +
                            "TOTAL ATK STAT (SUPPORT + LINKS) \r\n" +
                            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔ \r\n" +
                            "Normal Raise (12 KI - Colossal) - " + TotalATKNormalC.ToString("N0") + "\r\n" +
                            "Normal Raise (24 KI - Mega-Colossal) - " + TotalATKNormalMC.ToString("N0") + "\r\n\r\n" +
                            "Great Raise (12 KI - Colossal) - " + TotalATKGreatC.ToString("N0") + "\r\n" +
                            "Great Raise (24 KI - Mega-Colossal) - " + TotalATKGreatMC.ToString("N0") + "\r\n\r\n" +
                            "Massive Raise (12 KI - Colossal) - " + TotalATKMassiveC.ToString("N0") + "\r\n" +
                            "Massive Raise (24 KI - Mega-Colossal) - " + TotalATKMassiveMC.ToString("N0");
            return output;
        }
        public string GetDEF(int DEF, double Leader, double passiveDEF, double Support) 
        {
            double DEFPreSuper = 0;
            double DEFSupport = 0;
            double DEFLinks = 0;

            double LinksDEFMultiplier = 0;

            Leader = Leader / 100;
            passiveDEF = passiveDEF / 100;
            Support = Support / 100;

            var step1 = DEF * (1 + Leader + Leader); //Multiply DEF by Leader X2
            DEFPreSuper = step1 * (1 + passiveDEF); //Multiply by Passive

            //SUPPORT

            DEFSupport = DEFPreSuper * (1 + Support);

            //LINKS

            _LinkEngine.LoadLinks();

            for (int i = 0; i < Links.Length; i++)
            {
                if (_LinkEngine.Links.ContainsKey(Links[i]))
                {
                    _LinkEngine.Links.TryGetValue(Links[i], out var TempLink);
                    LinksDEFMultiplier = LinksDEFMultiplier + TempLink.DEF;
                }
            }
            LinksDEFMultiplier = LinksDEFMultiplier / 100;
            DEFLinks = DEFPreSuper * (1 + LinksDEFMultiplier);

            double NormalDEFTotal = DEFPreSuper * (1 + Support + LinksDEFMultiplier); //Raises DEF by 1 Turn
            double GreatDEFTotal = DEFPreSuper * (1 + Support + LinksDEFMultiplier); //Greatly Raises DEF by 1 Turn
            double MassiveDEFTotal = DEFPreSuper * (1 + Support + LinksDEFMultiplier); //Massively Raises DEF by 1 Turn

            double NormalDEFRaise = NormalDEFTotal * (1 + NormalRaise);
            double GreatDEFRaise = GreatDEFTotal * (1 + GreatRaise);
            double MassiveDEFRaise = MassiveDEFTotal * (1 + MassiveRaise);

            string output = "DEF Stats (Support/Links Individually Calculated) \r\n" +
                            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔ \r\n" +
                            "DEF Pre Super - " + DEFPreSuper.ToString("N0") + "\r\n" +
                            "DEF With Support (Pre SA) - " + DEFSupport.ToString("N0") + " (" + (Support * 100) + "% Support) \r\n" +
                            "DEF With Links (Pre SA) - " + DEFLinks.ToString("N0") + "\r\n\r\n" +
                            "DEF Stats Post Super (SUPPORT + LINKS) \r\n" +
                            "▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔ \r\n" +
                            "Normal Raise (30%) - " + NormalDEFRaise.ToString("N0") + "\r\n" +
                            "Great Raise (50%) - " + GreatDEFRaise.ToString("N0") + "\r\n" +
                            "Massive Raise (100%) - " + MassiveDEFRaise.ToString("N0") + "\r\n";

            return output;
        }
    }
}
