﻿using DokkanPassiveGenerator.InternalBuilders;
using System;
using System.Windows.Forms;

namespace DokkanPassiveGenerator.Forms
{
    public partial class CreatePassive : Form
    {
        public PassiveCreator passiveEngine = new PassiveCreator();

        public CreatePassive()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            bool sameNameCheck = CheckSameName(cardNameBox.Text);

            if(cardNameBox.Text == "" || hpBox.Text == "" || atkBox.Text == "" || defBox.Text == "" ||
                   leaderNameBox.Text == "" || leaderBuffBox.Text == "" || passiveATKBox.Text == "" ||
                        passiveDEFBox.Text == "" || supportBox.Text == "") 
            {
                MessageBox.Show("You need to fill out all the required inputs before pressing this button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(sameNameCheck == false) 
            {
                MessageBox.Show("A Passive with the same name alerady exists. Please enter a different name for the Card Name input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                string[] tempLinks = new string[linkSelector.CheckedItems.Count];
                for(int i = 0; i < linkSelector.CheckedItems.Count; i++) 
                {
                    string linkName = linkSelector.CheckedItems[i].ToString();
                    tempLinks[i] = linkName;
                }

                //Parsing all the user input into the class

                passiveEngine.CardName = cardNameBox.Text;
                passiveEngine.Rarity = rarityBox.Text;
                passiveEngine.HP = int.Parse(hpBox.Text);
                passiveEngine.ATK = int.Parse(atkBox.Text);
                passiveEngine.DEF = int.Parse(defBox.Text);
                passiveEngine.LeaderSkillName = leaderNameBox.Text;
                passiveEngine.LeaderSkillBuff = int.Parse(leaderBuffBox.Text);
                passiveEngine.PassiveATK = int.Parse(passiveATKBox.Text);
                passiveEngine.PassiveDEF = int.Parse(passiveDEFBox.Text);
                passiveEngine.Support = int.Parse(supportBox.Text);
                passiveEngine.Links = tempLinks;


                string output = "Passive Details: \r\n" +
                                "Card Name: " + passiveEngine.CardName + "\r\n" +
                                "Rarity: " + passiveEngine.Rarity + "\r\n" +
                                "HP: " + passiveEngine.HP + "\r\n" +
                                "ATK: " + passiveEngine.ATK + "\r\n" +
                                "DEF: " + passiveEngine.DEF + "\r\n" +
                                "Leader Name: " + passiveEngine.LeaderSkillName + "\r\n" +
                                "Leader Buff: " + passiveEngine.LeaderSkillBuff + "\r\n" +
                                "Passive ATK: " + passiveEngine.PassiveATK + "\r\n" +
                                "Passive DEF: " + passiveEngine.PassiveDEF + "\r\n" +
                                "Optional Buffs \r\n" +
                                "Support: " + passiveEngine.Support + "\r\n" +
                                "Links: " + string.Join(", " , tempLinks);

                outputBox.Text = output;
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            bool sameNameCheck = CheckSameName(cardNameBox.Text);

            if (cardNameBox.Text == "" || hpBox.Text == "" || atkBox.Text == "" || defBox.Text == "" ||
                leaderNameBox.Text == "" || leaderBuffBox.Text == "" || passiveATKBox.Text == "" ||
                passiveDEFBox.Text == "" || supportBox.Text == "")
            {
                MessageBox.Show("You need to fill out all the required inputs before pressing this button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sameNameCheck == false) 
            {
                MessageBox.Show("A Passive with the same name alerady exists. Please enter a different name for the Card Name input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                bool storeProcess = passiveEngine.StorePassive(passiveEngine);
                if (storeProcess == true)
                {
                    //Success Message
                    MessageBox.Show("Successfully stored Passive!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear all inputs
                    ClearAllInputs();
                    outputBox.Clear();
                }
                else
                {
                    //Error Message
                    string errorMsg = "Something went wrong \r\n" +
                                      "Error: " + passiveEngine.Error;
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
        }

        private void CreatePassive_Load(object sender, EventArgs e)
        {
            var LinkStorage = new LinksLoad(); //Loads the Link Dictionary
            bool linkProcess = LinkStorage.LoadLinks();

            if (linkProcess == true) 
            {
                foreach (var Link in LinkStorage.Links)
                {
                    linkSelector.Items.Add(Link.Key);
                }
            }

            else 
            {
                MessageBox.Show("Links Failed to load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckSameName(string name) 
        {
            var passivesStorage = new PassiveStorage();
            passivesStorage.LoadPassives();

            foreach (var nameToCheck in passivesStorage.Passives) 
            {
                if (name == nameToCheck.Value.CardName) 
                {
                    return false;
                }
                else 
                {
                    return true;
                }
            }

            return true;
        }
        private void ClearAllInputs() 
        {
            cardNameBox.Clear();
            rarityBox.ResetText();
            hpBox.Clear();
            defBox.Clear();
            atkBox.Clear();
            leaderNameBox.Clear();
            leaderBuffBox.Clear();
            passiveATKBox.Clear();
            passiveDEFBox.Clear();
            supportBox.Clear();
            linkSelector.ClearSelected();
        }
    }
}
