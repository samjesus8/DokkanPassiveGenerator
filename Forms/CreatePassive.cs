using DokkanPassiveGenerator.InternalBuilders;
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
            //Parsing all the user input into the class

            passiveEngine.CardName = cardNameBox.Text;
            passiveEngine.HP = int.Parse(hpBox.Text);
            passiveEngine.ATK = int.Parse(atkBox.Text);
            passiveEngine.DEF= int.Parse(defBox.Text);
            passiveEngine.LeaderSkillName = leaderNameBox.Text;
            passiveEngine.LeaderSkillBuff = int.Parse(leaderBuffBox.Text);
            passiveEngine.PassiveATK = int.Parse(passiveATKBox.Text);
            passiveEngine.PassiveDEF = int.Parse(passiveDEFBox.Text);
            passiveEngine.Support = int.Parse(supportBox.Text);

            string output = "Passive Details: \r\n" +
                            "Card Name: " + passiveEngine.CardName + "\r\n" +
                            "HP: " + passiveEngine.HP + "\r\n" +
                            "ATK: " + passiveEngine.ATK + "\r\n" +
                            "DEF: " + passiveEngine.DEF + "\r\n" +
                            "Leader Name: " + passiveEngine.LeaderSkillName + "\r\n" +
                            "Leader Buff: " + passiveEngine.LeaderSkillBuff + "\r\n" +
                            "Passive ATK: " + passiveEngine.PassiveATK + "\r\n" +
                            "Passive DEF: " + passiveEngine.PassiveDEF + "\r\n" +
                            "Optional Buffs \r\n" +
                            "Support: " + passiveEngine.Support + "\r\n";

            outputBox.Text = output;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            passiveEngine.StorePassive(passiveEngine);
        }

        private void declineButton_Click(object sender, EventArgs e)
        {

        }
    }
}
