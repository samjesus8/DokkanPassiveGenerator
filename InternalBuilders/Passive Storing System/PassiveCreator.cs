﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DokkanPassiveGenerator.InternalBuilders
{
    public class PassiveCreator
    {
        public string CardName { get; set; }
        public string Rarity { get; set; }
        public int HP { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public string LeaderSkillName { get; set; }
        public int LeaderSkillBuff { get; set; }
        public int PassiveATK { get; set; }
        public int PassiveDEF { get; set; }
        public int Support { get; set; }
        public string[] Links { get; set; }

        public string Error { get; set; }

        public PassiveCreator(string cardName, string rarity, int hp, int atk, int def, string leaderName, int leaderValue, int passiveATK, int passiveDEF, int support, string[] links) 
        {
            this.CardName = cardName;
            this.Rarity = rarity;
            this.HP = hp;
            this.ATK = atk;
            this.DEF = def;
            this.LeaderSkillName = leaderName;
            this.LeaderSkillBuff = leaderValue;
            this.PassiveATK = passiveATK;
            this.PassiveDEF = passiveDEF;
            this.Support = support;
            this.Links = links;
        }

        public PassiveCreator() { }

        public bool StorePassive(PassiveCreator classObj) 
        {
            string myDocsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string docsLocation = Path.Combine(myDocsPath, "Passive Generator Files");

            try 
            {
                var path = docsLocation + "/Passives.json";
                var json = File.ReadAllText(path);

                var jsonObj = JObject.Parse(json);
                var members = jsonObj["members"].ToObject<List<PassiveCreator>>();
                members.Add(classObj);

                jsonObj["members"] = JArray.FromObject(members);

                File.WriteAllText(path, jsonObj.ToString());
                return true;
            }
            catch (Exception ex) 
            {
                Error = ex.Message;
                return false;
            }
        }

        public bool DeletePassive(PassiveCreator classObj) 
        {
            string myDocsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string docsLocation = Path.Combine(myDocsPath, "Passive Generator Files");

            try 
            {
                var path = docsLocation + "/Passives.json";
                var json = File.ReadAllText(path);

                var jsonObj = JObject.Parse(json);
                var members = jsonObj["members"].ToObject<List<PassiveCreator>>();

                var search = members.FirstOrDefault(m => m.CardName == classObj.CardName);
                if (search != null)
                {
                    members.Remove(search);

                    jsonObj["members"] = JArray.FromObject(members);
                    File.WriteAllText(path, jsonObj.ToString());
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex) 
            {
                Error = ex.Message;
                return false;
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
        public string CardName { get; set; }
        public string Rarity { get; set; }
        public int HP { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public string LeaderSkillName { get; set; }
        public int LeaderSkillBuff { get; set; }
        public int PassiveATK { get; set; }
        public int PassiveDEF { get; set; }
        public int Support { get; set; }
        public string[] Links { get; set; }
    }
}
