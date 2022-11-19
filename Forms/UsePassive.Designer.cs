namespace DokkanPassiveGenerator.Forms
{
    partial class UsePassive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsePassive));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passiveSelectorBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passiveDetailsBox = new System.Windows.Forms.TextBox();
            this.usePassiveButton = new System.Windows.Forms.Button();
            this.passiveOutputBox = new System.Windows.Forms.TextBox();
            this.loadPassiveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadPassiveButton);
            this.groupBox1.Controls.Add(this.usePassiveButton);
            this.groupBox1.Controls.Add(this.passiveDetailsBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passiveSelectorBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passive Selector";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passiveOutputBox);
            this.groupBox2.Location = new System.Drawing.Point(421, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 517);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // passiveSelectorBox
            // 
            this.passiveSelectorBox.FormattingEnabled = true;
            this.passiveSelectorBox.Location = new System.Drawing.Point(6, 71);
            this.passiveSelectorBox.Name = "passiveSelectorBox";
            this.passiveSelectorBox.Size = new System.Drawing.Size(391, 21);
            this.passiveSelectorBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your Passive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passive Details";
            // 
            // passiveDetailsBox
            // 
            this.passiveDetailsBox.Location = new System.Drawing.Point(6, 145);
            this.passiveDetailsBox.Multiline = true;
            this.passiveDetailsBox.Name = "passiveDetailsBox";
            this.passiveDetailsBox.ReadOnly = true;
            this.passiveDetailsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.passiveDetailsBox.Size = new System.Drawing.Size(391, 307);
            this.passiveDetailsBox.TabIndex = 3;
            // 
            // usePassiveButton
            // 
            this.usePassiveButton.Location = new System.Drawing.Point(324, 471);
            this.usePassiveButton.Name = "usePassiveButton";
            this.usePassiveButton.Size = new System.Drawing.Size(75, 40);
            this.usePassiveButton.TabIndex = 4;
            this.usePassiveButton.Text = "Use Passive";
            this.usePassiveButton.UseVisualStyleBackColor = true;
            this.usePassiveButton.Click += new System.EventHandler(this.usePassiveButton_Click);
            // 
            // passiveOutputBox
            // 
            this.passiveOutputBox.Location = new System.Drawing.Point(6, 19);
            this.passiveOutputBox.Multiline = true;
            this.passiveOutputBox.Name = "passiveOutputBox";
            this.passiveOutputBox.ReadOnly = true;
            this.passiveOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.passiveOutputBox.Size = new System.Drawing.Size(391, 474);
            this.passiveOutputBox.TabIndex = 0;
            // 
            // loadPassiveButton
            // 
            this.loadPassiveButton.Location = new System.Drawing.Point(322, 98);
            this.loadPassiveButton.Name = "loadPassiveButton";
            this.loadPassiveButton.Size = new System.Drawing.Size(75, 23);
            this.loadPassiveButton.TabIndex = 5;
            this.loadPassiveButton.Text = "Load";
            this.loadPassiveButton.UseVisualStyleBackColor = true;
            this.loadPassiveButton.Click += new System.EventHandler(this.loadPassiveButton_Click);
            // 
            // UsePassive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UsePassive";
            this.Text = "UsePassive";
            this.Load += new System.EventHandler(this.UsePassive_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button usePassiveButton;
        private System.Windows.Forms.TextBox passiveDetailsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox passiveSelectorBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox passiveOutputBox;
        private System.Windows.Forms.Button loadPassiveButton;
    }
}