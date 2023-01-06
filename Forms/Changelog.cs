using System;
using System.Windows.Forms;

namespace DokkanPassiveGenerator.Forms
{
    public partial class Changelog : Form
    {
        public Changelog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Changelog_Load(object sender, EventArgs e)
        {
            string changelog = "V1.0.2: \r\n" +
                               "-Added EZAs to the Calculator. You can now select the 'TUR (EZA)/LR (EZA)' options and they will calculate your stats at the EZA level \r\n\r\n" +
                               "-Upon pressing the 'Accept' button when storing a passive, if it was a success the whole form will reset allowing the user to input another passive without reloading the window \r\n\r\n" +
                               "-When deleting a passive, a confirmation message will show to let the user know whether the operation was a success or failure \r\n\r\n" +
                               "-Any Drop-Down lists have been set to read-only to prevent any misinput \r\n\r\n" +
                               
                               "=============================================================== \r\n\r\n" +
                               
                               "V1.0.1: \r\n" +
                               "-Introducing the Changelog Window which will load on start-up of the application. This will show what happened in every update \r\n\r\n" +
                               "-Addressed the same name issue (Issue #1 on GitHub) where an error would occur when trying to store/load 2 passives with the same name. When you press either the " +
                               "'Create Passive' or 'Accept' button a check will run to see if the Card Name alerady exists in the JSON file \r\n\r\n" +
                               "-When pressing the 'Accept' button with zero input, a check has also been put in to ensure all the boxes are filled in \r\n\r\n" +
                               "-Eliminated the need to press the 'Load' button when trying to load a passive's details, it will happen whenever you pick a passive from the drop-down \r\n\r\n" +
                               "-Cleaned up the formatting of the output text when using a passive. Each section is now more organised and more pleasing to read \r\n\r\n" +

                               "=============================================================== \r\n\r\n" +

                               "V1.0.0: \r\n" +
                               "-This is the first 100% working release of the Windows version of the Dokkan Passive Generator featured in the Cooler Discord Bot \r\n\r\n";

            outputBox.Text = changelog;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
        }
    }
}
