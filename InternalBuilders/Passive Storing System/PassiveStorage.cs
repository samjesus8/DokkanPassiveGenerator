using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DokkanPassiveGenerator.InternalBuilders
{
    public class PassiveStorage
    {
        public Dictionary<string, PassiveCreator> Passives = new Dictionary<string, PassiveCreator>();
        public string Error { get; set; }

        public bool LoadPassives()
        {
            string myDocsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string docsLocation = Path.Combine(myDocsPath, "Passive Generator Files");

            try
            {
                using (StreamReader sr = new StreamReader(docsLocation + "/Passives.json"))
                {
                    string jsonFile = sr.ReadToEnd();
                    JSONObject jsonObject = JsonConvert.DeserializeObject<JSONObject>(jsonFile);

                    for (int i = 0; i < jsonObject.members.Length; i++)
                    {
                        var member = jsonObject.members[i];

                        var classObj = new PassiveCreator();

                        classObj.CardName = member.CardName;
                        classObj.Rarity = member.Rarity;
                        classObj.HP = member.HP;
                        classObj.ATK = member.ATK;
                        classObj.DEF = member.DEF;
                        classObj.LeaderSkillName = member.LeaderSkillName;
                        classObj.LeaderSkillBuff = member.LeaderSkillBuff;
                        classObj.PassiveATK = member.PassiveATK;
                        classObj.PassiveDEF = member.PassiveDEF;
                        classObj.Support = member.Support;
                        classObj.Links = member.Links;

                        Passives.Add(classObj.CardName, classObj);
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

}
