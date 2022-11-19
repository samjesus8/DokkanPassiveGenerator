using DokkanPassiveGenerator.InternalBuilders;
using System;
using System.Windows.Forms;

namespace DokkanPassiveGenerator.Forms
{
    public partial class UsePassive : Form
    {
        public PassiveCreator passiveEngine = new PassiveCreator();
        public PassiveStorage storage = new PassiveStorage();

        public UsePassive()
        {
            InitializeComponent();
        }

        private void usePassiveButton_Click(object sender, EventArgs e)
        {
            var passiveName = passiveSelectorBox.SelectedItem.ToString();
            var tempVaribale = storage.Passives.TryGetValue(passiveName, out var info);

            var calculator = new Calculator(info.HP, info.ATK, info.DEF, info.LeaderSkillBuff, info.PassiveATK, info.PassiveDEF, info.Support);

            string output = "Stats for unit " + info.CardName + "\r\n\r\n" +
                            calculator.ResultATK;

            passiveOutputBox.Text = output;
        }

        private void UsePassive_Load(object sender, EventArgs e)
        {
            storage.LoadPassives();

            foreach (var member in storage.Passives) 
            {
                passiveSelectorBox.Items.Add(member.Value.CardName);
            }
        }

        private void loadPassiveButton_Click(object sender, EventArgs e)
        {
            var nameToSearch = passiveSelectorBox.SelectedItem.ToString();
            if (storage.Passives.ContainsKey(nameToSearch)) 
            {
                var tempSearch = storage.Passives.TryGetValue(nameToSearch, out var info);

                string output = "Passive Details: \r\n" +
                                "Card Name: " + info.CardName + "\r\n" +
                                "HP: " + info.HP + "\r\n" +
                                "ATK: " + info.ATK + "\r\n" +
                                "DEF: " + info.DEF + "\r\n" +
                                "Leader Name: " + info.LeaderSkillName + "\r\n" +
                                "Leader Buff: " + info.LeaderSkillBuff + "\r\n" +
                                "Passive ATK: " + info.PassiveATK + "\r\n" +
                                "Passive DEF: " + info.PassiveDEF + "\r\n" +
                                "Optional Buffs \r\n" +
                                "Support: " + info.Support + "\r\n";

                passiveDetailsBox.Text = output;
            }
        }
    }
}
