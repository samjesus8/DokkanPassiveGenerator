using DokkanPassiveGenerator.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace DokkanPassiveGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void createPassiveButton_Click(object sender, EventArgs e)
        {
            CreatePassive CreateForm = new CreatePassive();
            CreateForm.Show();
        }

        private void usePassiveButton_Click(object sender, EventArgs e)
        {
            UsePassive UseForm = new UsePassive();
            UseForm.Show();
        }

        private void managePassiveButton_Click(object sender, EventArgs e)
        {
            PassiveManager Manager = new PassiveManager();
            Manager.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string myDocsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string docsLocation = Path.Combine(myDocsPath, "Passive Generator Files");

            if (!Directory.Exists(docsLocation)) 
            {
                LoadFiles();
            }

            var changelog = new Changelog();
            changelog.Show();
        }

        private string LoadFiles() 
        {
            string myDocsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string docsLocation = Path.Combine(myDocsPath, "Passive Generator Files");

            if (!Directory.Exists(docsLocation)) 
            {
                Directory.CreateDirectory(docsLocation);
            }

            File.Copy(System.AppDomain.CurrentDomain.BaseDirectory + "/InternalBuilders/Links.json", docsLocation + "/Links.json", false);
            File.Copy(System.AppDomain.CurrentDomain.BaseDirectory + "/InternalBuilders/Passives.json", docsLocation + "/Passives.json", false);

            return docsLocation;
        }
    }
}
