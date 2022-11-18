﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DokkanPassiveGenerator.InternalBuilders
{
    public class PassiveCreator
    {
        public string CardName { get; set; }
        public int HP { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public string LeaderSkillName { get; set; }
        public int LeaderSkillBuff { get; set; }
        public int PassiveATK { get; set; }
        public int PassiveDEF { get; set; }
        public int Support { get; set; }

        public string Error { get; set; }

        public PassiveCreator(string cardName, int hp, int atk, int def, string leaderName, int leaderValue, int passiveATK, int passiveDEF, int support) 
        {
            this.CardName = cardName;
            this.HP = hp;
            this.ATK = atk;
            this.DEF = def;
            this.LeaderSkillName = leaderName;
            this.LeaderSkillBuff = leaderValue;
            this.PassiveATK = passiveATK;
            this.PassiveDEF = passiveDEF;
            this.Support = support;
        }

        public PassiveCreator() { }

        public void StorePassive(PassiveCreator classObj) 
        {
            try 
            {
                var path = @"D:\Visual Studio Projects\DokkanPassiveGenerator\InternalBuilders\Passives.json";
                var json = File.ReadAllText(path);

                var jsonObj = JObject.Parse(json);
                var members = jsonObj["members"].ToObject<List<PassiveCreator>>();
                members.Add(classObj);

                jsonObj["members"] = JArray.FromObject(members);

                File.WriteAllText(path, jsonObj.ToString());
            }
            catch (Exception ex) 
            {
                Error = ex.Message;
            }
        }
    }

    class JSONObject 
    {
        public string userPassives { get; set; }
        public Member[] members { get; set; }
    }

    class Member 
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public string leaderName { get; set; }
        public int leaderValue { get; set; }
        public int passiveATK { get; set; }
        public int passiveDEF { get; set;}
        public int support { get; set; }
    }
}
