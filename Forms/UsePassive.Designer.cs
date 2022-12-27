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
            this.usePassiveButton = new System.Windows.Forms.Button();
            this.passiveDetailsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passiveSelectorBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passiveOutputBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.usePassiveButton);
            this.groupBox1.Controls.Add(this.passiveDetailsBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passiveSelectorBox);
            this.groupBox1.Font = new System.Drawing.Font("NSimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passive Selector";
            // 
            // usePassiveButton
            // 
            this.usePassiveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usePassiveButton.Location = new System.Drawing.Point(324, 471);
            this.usePassiveButton.Name = "usePassiveButton";
            this.usePassiveButton.Size = new System.Drawing.Size(75, 40);
            this.usePassiveButton.TabIndex = 4;
            this.usePassiveButton.Text = "Use Passive";
            this.usePassiveButton.UseVisualStyleBackColor = true;
            this.usePassiveButton.Click += new System.EventHandler(this.usePassiveButton_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 11);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passive Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 11);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your Passive";
            // 
            // passiveSelectorBox
            // 
            this.passiveSelectorBox.FormattingEnabled = true;
            this.passiveSelectorBox.Location = new System.Drawing.Point(6, 71);
            this.passiveSelectorBox.Name = "passiveSelectorBox";
            this.passiveSelectorBox.Size = new System.Drawing.Size(391, 19);
            this.passiveSelectorBox.TabIndex = 0;
            this.passiveSelectorBox.SelectedIndexChanged += new System.EventHandler(this.passiveSelectorBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.passiveOutputBox);
            this.groupBox2.Font = new System.Drawing.Font("NSimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox2.Location = new System.Drawing.Point(421, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 517);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // passiveOutputBox
            // 
            this.passiveOutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passiveOutputBox.Location = new System.Drawing.Point(6, 19);
            this.passiveOutputBox.Multiline = true;
            this.passiveOutputBox.Name = "passiveOutputBox";
            this.passiveOutputBox.ReadOnly = true;
            this.passiveOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.passiveOutputBox.Size = new System.Drawing.Size(425, 474);
            this.passiveOutputBox.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("NSimSun", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Aqua;
            this.label13.Location = new System.Drawing.Point(471, 532);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(387, 27);
            this.label13.TabIndex = 4;
            this.label13.Text = "Copyright ©SamuelJesuthas";
            // 
            // UsePassive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DokkanPassiveGenerator.Properties.Resources.wallpapersden_com_ultra_goku_cool_2020_minimal_3840x2160;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 564);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "UsePassive";
            this.Text = "Use Passive";
            this.Load += new System.EventHandler(this.UsePassive_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label13;
    }
}