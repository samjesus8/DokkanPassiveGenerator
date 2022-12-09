namespace DokkanPassiveGenerator.Forms
{
    partial class CreatePassive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePassive));
            this.label1 = new System.Windows.Forms.Label();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.rarityBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.supportBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.passiveDEFBox = new System.Windows.Forms.TextBox();
            this.passiveATKBox = new System.Windows.Forms.TextBox();
            this.leaderBuffBox = new System.Windows.Forms.TextBox();
            this.leaderNameBox = new System.Windows.Forms.TextBox();
            this.defBox = new System.Windows.Forms.TextBox();
            this.atkBox = new System.Windows.Forms.TextBox();
            this.hpBox = new System.Windows.Forms.TextBox();
            this.cardNameBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.declineButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.linkSelector = new System.Windows.Forms.CheckedListBox();
            this.inputGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dokkan Passive Generator";
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.linkSelector);
            this.inputGroupBox.Controls.Add(this.rarityBox);
            this.inputGroupBox.Controls.Add(this.label12);
            this.inputGroupBox.Controls.Add(this.createButton);
            this.inputGroupBox.Controls.Add(this.label11);
            this.inputGroupBox.Controls.Add(this.supportBox);
            this.inputGroupBox.Controls.Add(this.label10);
            this.inputGroupBox.Controls.Add(this.passiveDEFBox);
            this.inputGroupBox.Controls.Add(this.passiveATKBox);
            this.inputGroupBox.Controls.Add(this.leaderBuffBox);
            this.inputGroupBox.Controls.Add(this.leaderNameBox);
            this.inputGroupBox.Controls.Add(this.defBox);
            this.inputGroupBox.Controls.Add(this.atkBox);
            this.inputGroupBox.Controls.Add(this.hpBox);
            this.inputGroupBox.Controls.Add(this.cardNameBox);
            this.inputGroupBox.Controls.Add(this.label9);
            this.inputGroupBox.Controls.Add(this.label8);
            this.inputGroupBox.Controls.Add(this.label7);
            this.inputGroupBox.Controls.Add(this.label6);
            this.inputGroupBox.Controls.Add(this.label5);
            this.inputGroupBox.Controls.Add(this.label4);
            this.inputGroupBox.Controls.Add(this.label3);
            this.inputGroupBox.Controls.Add(this.label2);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 41);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(378, 514);
            this.inputGroupBox.TabIndex = 1;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "User Input";
            // 
            // rarityBox
            // 
            this.rarityBox.FormattingEnabled = true;
            this.rarityBox.Items.AddRange(new object[] {
            "TUR",
            "LR",
            "TUR (EZA)",
            "LR (EZA)"});
            this.rarityBox.Location = new System.Drawing.Point(5, 109);
            this.rarityBox.Name = "rarityBox";
            this.rarityBox.Size = new System.Drawing.Size(100, 21);
            this.rarityBox.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Rarity";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(297, 472);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 36);
            this.createButton.TabIndex = 19;
            this.createButton.Text = "Create Passive";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Links";
            // 
            // supportBox
            // 
            this.supportBox.Location = new System.Drawing.Point(235, 67);
            this.supportBox.Name = "supportBox";
            this.supportBox.Size = new System.Drawing.Size(100, 20);
            this.supportBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Support";
            // 
            // passiveDEFBox
            // 
            this.passiveDEFBox.Location = new System.Drawing.Point(5, 442);
            this.passiveDEFBox.Name = "passiveDEFBox";
            this.passiveDEFBox.Size = new System.Drawing.Size(100, 20);
            this.passiveDEFBox.TabIndex = 15;
            // 
            // passiveATKBox
            // 
            this.passiveATKBox.Location = new System.Drawing.Point(5, 391);
            this.passiveATKBox.Name = "passiveATKBox";
            this.passiveATKBox.Size = new System.Drawing.Size(100, 20);
            this.passiveATKBox.TabIndex = 14;
            // 
            // leaderBuffBox
            // 
            this.leaderBuffBox.Location = new System.Drawing.Point(5, 344);
            this.leaderBuffBox.Name = "leaderBuffBox";
            this.leaderBuffBox.Size = new System.Drawing.Size(100, 20);
            this.leaderBuffBox.TabIndex = 13;
            // 
            // leaderNameBox
            // 
            this.leaderNameBox.Location = new System.Drawing.Point(5, 294);
            this.leaderNameBox.Name = "leaderNameBox";
            this.leaderNameBox.Size = new System.Drawing.Size(131, 20);
            this.leaderNameBox.TabIndex = 12;
            // 
            // defBox
            // 
            this.defBox.Location = new System.Drawing.Point(5, 246);
            this.defBox.Name = "defBox";
            this.defBox.Size = new System.Drawing.Size(100, 20);
            this.defBox.TabIndex = 11;
            // 
            // atkBox
            // 
            this.atkBox.Location = new System.Drawing.Point(5, 196);
            this.atkBox.Name = "atkBox";
            this.atkBox.Size = new System.Drawing.Size(100, 20);
            this.atkBox.TabIndex = 10;
            // 
            // hpBox
            // 
            this.hpBox.Location = new System.Drawing.Point(5, 149);
            this.hpBox.Name = "hpBox";
            this.hpBox.Size = new System.Drawing.Size(100, 20);
            this.hpBox.TabIndex = 9;
            // 
            // cardNameBox
            // 
            this.cardNameBox.Location = new System.Drawing.Point(5, 67);
            this.cardNameBox.Name = "cardNameBox";
            this.cardNameBox.Size = new System.Drawing.Size(131, 20);
            this.cardNameBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Passive DEF (Total % Value)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Passive ATK (Total % Value)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Leader Skill Buff";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Leader Skill Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Base DEF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Base ATK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Base HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Card Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.declineButton);
            this.groupBox2.Controls.Add(this.acceptButton);
            this.groupBox2.Controls.Add(this.outputBox);
            this.groupBox2.Location = new System.Drawing.Point(396, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 514);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(87, 472);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(75, 36);
            this.declineButton.TabIndex = 2;
            this.declineButton.Text = "Decline";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(6, 472);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 36);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(6, 19);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputBox.Size = new System.Drawing.Size(393, 447);
            this.outputBox.TabIndex = 0;
            // 
            // linkSelector
            // 
            this.linkSelector.CheckOnClick = true;
            this.linkSelector.FormattingEnabled = true;
            this.linkSelector.Location = new System.Drawing.Point(189, 172);
            this.linkSelector.Name = "linkSelector";
            this.linkSelector.ScrollAlwaysVisible = true;
            this.linkSelector.Size = new System.Drawing.Size(183, 199);
            this.linkSelector.Sorted = true;
            this.linkSelector.TabIndex = 21;
            // 
            // CreatePassive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 589);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreatePassive";
            this.Text = "CreatePassive";
            this.Load += new System.EventHandler(this.CreatePassive_Load);
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox passiveDEFBox;
        private System.Windows.Forms.TextBox passiveATKBox;
        private System.Windows.Forms.TextBox leaderBuffBox;
        private System.Windows.Forms.TextBox leaderNameBox;
        private System.Windows.Forms.TextBox defBox;
        private System.Windows.Forms.TextBox atkBox;
        private System.Windows.Forms.TextBox hpBox;
        private System.Windows.Forms.TextBox cardNameBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox supportBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.ComboBox rarityBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox linkSelector;
    }
}