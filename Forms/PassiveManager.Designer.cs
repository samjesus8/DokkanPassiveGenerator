namespace DokkanPassiveGenerator.Forms
{
    partial class PassiveManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassiveManager));
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadPassiveButton = new System.Windows.Forms.Button();
            this.passiveDetailsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passiveSelectorBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linksOutputBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkSelector = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deletePassiveBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("NSimSun", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Aqua;
            this.label13.Location = new System.Drawing.Point(437, 577);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(387, 27);
            this.label13.TabIndex = 4;
            this.label13.Text = "Copyright ©SamuelJesuthas";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.loadPassiveButton);
            this.groupBox1.Controls.Add(this.passiveDetailsBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passiveSelectorBox);
            this.groupBox1.Font = new System.Drawing.Font("NSimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 293);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passive Selector";
            // 
            // loadPassiveButton
            // 
            this.loadPassiveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadPassiveButton.Location = new System.Drawing.Point(322, 55);
            this.loadPassiveButton.Name = "loadPassiveButton";
            this.loadPassiveButton.Size = new System.Drawing.Size(75, 23);
            this.loadPassiveButton.TabIndex = 5;
            this.loadPassiveButton.Text = "Load";
            this.loadPassiveButton.UseVisualStyleBackColor = true;
            this.loadPassiveButton.Click += new System.EventHandler(this.loadPassiveButton_Click);
            // 
            // passiveDetailsBox
            // 
            this.passiveDetailsBox.Location = new System.Drawing.Point(6, 84);
            this.passiveDetailsBox.Multiline = true;
            this.passiveDetailsBox.Name = "passiveDetailsBox";
            this.passiveDetailsBox.ReadOnly = true;
            this.passiveDetailsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.passiveDetailsBox.Size = new System.Drawing.Size(391, 198);
            this.passiveDetailsBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 11);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passive Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 11);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your Passive";
            // 
            // passiveSelectorBox
            // 
            this.passiveSelectorBox.FormattingEnabled = true;
            this.passiveSelectorBox.Location = new System.Drawing.Point(6, 30);
            this.passiveSelectorBox.Name = "passiveSelectorBox";
            this.passiveSelectorBox.Size = new System.Drawing.Size(391, 19);
            this.passiveSelectorBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.linksOutputBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.linkSelector);
            this.groupBox2.Font = new System.Drawing.Font("NSimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox2.Location = new System.Drawing.Point(12, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 293);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Links Viewer";
            // 
            // linksOutputBox
            // 
            this.linksOutputBox.Location = new System.Drawing.Point(6, 90);
            this.linksOutputBox.Multiline = true;
            this.linksOutputBox.Name = "linksOutputBox";
            this.linksOutputBox.Size = new System.Drawing.Size(391, 192);
            this.linksOutputBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 11);
            this.label4.TabIndex = 2;
            this.label4.Text = "Link Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 11);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select a Link";
            // 
            // linkSelector
            // 
            this.linkSelector.FormattingEnabled = true;
            this.linkSelector.Location = new System.Drawing.Point(6, 35);
            this.linkSelector.Name = "linkSelector";
            this.linkSelector.Size = new System.Drawing.Size(391, 19);
            this.linkSelector.Sorted = true;
            this.linkSelector.TabIndex = 0;
            this.linkSelector.SelectedIndexChanged += new System.EventHandler(this.linkSelector_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.deleteButton);
            this.groupBox3.Controls.Add(this.deletePassiveBox);
            this.groupBox3.Font = new System.Drawing.Font("NSimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox3.Location = new System.Drawing.Point(421, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 293);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Passives";
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Location = new System.Drawing.Point(172, 60);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deletePassiveBox
            // 
            this.deletePassiveBox.FormattingEnabled = true;
            this.deletePassiveBox.Location = new System.Drawing.Point(6, 30);
            this.deletePassiveBox.Name = "deletePassiveBox";
            this.deletePassiveBox.Size = new System.Drawing.Size(391, 19);
            this.deletePassiveBox.TabIndex = 0;
            // 
            // PassiveManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DokkanPassiveGenerator.Properties.Resources.goku_dragon_ball_super_ultra_instinct_b3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 612);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PassiveManager";
            this.Text = "Passive Manager";
            this.Load += new System.EventHandler(this.PassiveManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loadPassiveButton;
        private System.Windows.Forms.TextBox passiveDetailsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox passiveSelectorBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox linksOutputBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox linkSelector;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox deletePassiveBox;
    }
}