using Newtonsoft.Json;
using System;
using System.IO;

namespace DokkanPassiveGenerator.InternalBuilders
{
    public class LinksLoad : LinkStorage
    {
        public string LinkName { get; set; }
        public double ATK { get; set; }
        public double DEF { get; set; }

        public string Error { get; set; }

        public LinksLoad() 
        {
            
        }

        public bool LoadLinks() 
        {
            try 
            {
                using (StreamReader sr = new StreamReader(@"D:\Visual Studio Projects\DokkanPassiveGenerator\InternalBuilders\Links.json"))
                {
                    string json = sr.ReadToEnd();
                    JSONObjectLinks obj = JsonConvert.DeserializeObject<JSONObjectLinks>(json);

                    for (int i = 0; i < obj.members.Length; i++)
                    {
                        Links.Add(obj.members[i].LinkName, new Tuple(obj.members[i].ATK, obj.members[i].DEF));
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }
    }

    public class JSONObjectLinks 
    {
        public string LinksCategory { get; set; }
        public Members[] members { get; set; }
    }

    public class Members 
    {
        public string LinkName { get; set; }
        public double ATK { get; set; }
        public double DEF { get; set; }
    }
}
