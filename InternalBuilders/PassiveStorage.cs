﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokkanPassiveGenerator.InternalBuilders
{
    public class PassiveStorage
    {
        public Dictionary<string, PassiveCreator> Passives = new Dictionary<string, PassiveCreator>();
        public string Error { get; set; }

        public void LoadPassives()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"D:\Visual Studio Projects\DokkanPassiveGenerator\InternalBuilders\Passives.json"))
                {
                    string jsonFile = sr.ReadToEnd();
                    JSONObject jsonObject = JsonConvert.DeserializeObject<JSONObject>(jsonFile);

                    for (int i = 0; i < jsonObject.members.Length; i++)
                    {
                        var member = jsonObject.members[i];

                        var classObj = new PassiveCreator();

                        classObj.CardName = member.CardName;
                        classObj.HP = member.HP;
                        classObj.ATK = member.ATK;
                        classObj.DEF = member.DEF;
                        classObj.LeaderSkillName = member.LeaderSkillName;
                        classObj.LeaderSkillBuff = member.LeaderSkillBuff;
                        classObj.PassiveATK = member.PassiveATK;
                        classObj.PassiveDEF = member.PassiveDEF;
                        classObj.Support = member.Support;

                        Passives.Add(classObj.CardName, classObj);
                    }
                }
            }
            catch (Exception ex) { Error = ex.Message; }
        }
    }

}
