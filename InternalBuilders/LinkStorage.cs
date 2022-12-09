using System.Collections.Generic;

namespace DokkanPassiveGenerator.InternalBuilders
{
    public class LinkStorage
    {
        public Dictionary<string, Tuple> Links = new Dictionary<string, Tuple>();
    }

    public class Tuple 
    {
        public double ATK { get; set; }
        public double DEF { get; set; }
        public Tuple (double ATK, double DEF) 
        {
            this.ATK = ATK;
            this.DEF = DEF;
        }
    }
}
