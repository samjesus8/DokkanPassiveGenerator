using DokkanPassiveGenerator.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
