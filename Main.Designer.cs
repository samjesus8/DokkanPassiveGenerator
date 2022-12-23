namespace DokkanPassiveGenerator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.createPassiveButton = new System.Windows.Forms.Button();
            this.usePassiveButton = new System.Windows.Forms.Button();
            this.managePassiveButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 29.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dokkan Passive Generator\r\nMain Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createPassiveButton
            // 
            this.createPassiveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createPassiveButton.Font = new System.Drawing.Font("NSimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPassiveButton.ForeColor = System.Drawing.Color.White;
            this.createPassiveButton.Location = new System.Drawing.Point(80, 196);
            this.createPassiveButton.Margin = new System.Windows.Forms.Padding(2);
            this.createPassiveButton.Name = "createPassiveButton";
            this.createPassiveButton.Size = new System.Drawing.Size(142, 74);
            this.createPassiveButton.TabIndex = 1;
            this.createPassiveButton.Text = "Create Passive";
            this.createPassiveButton.UseVisualStyleBackColor = false;
            this.createPassiveButton.Click += new System.EventHandler(this.createPassiveButton_Click);
            // 
            // usePassiveButton
            // 
            this.usePassiveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usePassiveButton.Font = new System.Drawing.Font("NSimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usePassiveButton.ForeColor = System.Drawing.Color.White;
            this.usePassiveButton.Location = new System.Drawing.Point(230, 196);
            this.usePassiveButton.Margin = new System.Windows.Forms.Padding(2);
            this.usePassiveButton.Name = "usePassiveButton";
            this.usePassiveButton.Size = new System.Drawing.Size(142, 74);
            this.usePassiveButton.TabIndex = 2;
            this.usePassiveButton.Text = "Use Passive";
            this.usePassiveButton.UseVisualStyleBackColor = false;
            this.usePassiveButton.Click += new System.EventHandler(this.usePassiveButton_Click);
            // 
            // managePassiveButton
            // 
            this.managePassiveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.managePassiveButton.Font = new System.Drawing.Font("NSimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managePassiveButton.ForeColor = System.Drawing.Color.White;
            this.managePassiveButton.Location = new System.Drawing.Point(376, 196);
            this.managePassiveButton.Margin = new System.Windows.Forms.Padding(2);
            this.managePassiveButton.Name = "managePassiveButton";
            this.managePassiveButton.Size = new System.Drawing.Size(142, 74);
            this.managePassiveButton.TabIndex = 3;
            this.managePassiveButton.Text = "Manage Passives";
            this.managePassiveButton.UseVisualStyleBackColor = false;
            this.managePassiveButton.Click += new System.EventHandler(this.managePassiveButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("NSimSun", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Aqua;
            this.label13.Location = new System.Drawing.Point(201, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(387, 27);
            this.label13.TabIndex = 4;
            this.label13.Text = "Copyright ©SamuelJesuthas";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DokkanPassiveGenerator.Properties.Resources.goku_dragon_ball_super_ultra_instinct_b3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.managePassiveButton);
            this.Controls.Add(this.usePassiveButton);
            this.Controls.Add(this.createPassiveButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Dokkan Passive Generator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createPassiveButton;
        private System.Windows.Forms.Button usePassiveButton;
        private System.Windows.Forms.Button managePassiveButton;
        private System.Windows.Forms.Label label13;
    }
}

