using DokkanPassiveGenerator.InternalBuilders;
using System;
using System.Windows.Forms;

namespace DokkanPassiveGenerator.Forms
{
    public partial class PassiveManager : Form
    {
        public PassiveStorage storage = new PassiveStorage();
        public LinksLoad linkStorage = new LinksLoad();
        public PassiveManager()
        {
            InitializeComponent();
        }

        private void loadPassiveButton_Click(object sender, EventArgs e)
        {
            var nameToSearch = passiveSelectorBox.SelectedItem.ToString();
            if (storage.Passives.ContainsKey(nameToSearch))
            {
                var tempSearch = storage.Passives.TryGetValue(nameToSearch, out var info);

                string output = "Passive Details: \r\n\r\n" +
                                "Card Name: " + info.CardName + "\r\n" +
                                "Rarity: " + info.Rarity + "\r\n" +
                                "HP: " + info.HP + "\r\n" +
                                "ATK: " + info.ATK + "\r\n" +
                                "DEF: " + info.DEF + "\r\n" +
                                "Leader Name: " + info.LeaderSkillName + "\r\n" +
                                "Leader Buff: " + info.LeaderSkillBuff + "\r\n" +
                                "Passive ATK: " + info.PassiveATK + "\r\n" +
                                "Passive DEF: " + info.PassiveDEF + "\r\n" +
                                "Optional Buffs \r\n" +
                                "Support: " + info.Support + "\r\n" +
                                "Links: " + string.Join(", ", info.Links);

                passiveDetailsBox.Text = output;
            }
        }

        private void PassiveManager_Load(object sender, EventArgs e)
        {
            //Loading passives
            bool loadProcess = storage.LoadPassives();
            if (loadProcess == true)
            {
                foreach (var member in storage.Passives)
                {
                    passiveSelectorBox.Items.Add(member.Value.CardName);
                    deletePassiveBox.Items.Add(member.Value.CardName);
                }
            }
            else
            {
                //Error Message
                string errorMsg = "Something went wrong \r\n" +
                                  "Error: " + storage.Error;
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Loading Links
            linkStorage.LoadLinks();

            foreach (var link in linkStorage.Links)
            {
                linkSelector.Items.Add(link.Key);
            }
        }

        private void linkSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string linkName = linkSelector.Text;
            var linkSearch = linkStorage.Links.TryGetValue(linkName, out var linkDetails);

            string output = "Link Details for " + linkName + "\r\n\r\n" +
                            "ATK - " + linkDetails.ATK.ToString() + "% \r\n" +
                            "DEF - " + linkDetails.DEF.ToString() + "%";

            linksOutputBox.Text = output;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string nameToSearch = deletePassiveBox.Text;
            var tempSearch = storage.Passives.TryGetValue(nameToSearch, out var passiveToDelete);

            var passives = new PassiveCreator();
            passives.DeletePassive(passiveToDelete);
        }
    }
}
