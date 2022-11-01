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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("MV Boli", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 124);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dokkan Passive Generator\r\nMain Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createPassiveButton
            // 
            this.createPassiveButton.Location = new System.Drawing.Point(107, 205);
            this.createPassiveButton.Name = "createPassiveButton";
            this.createPassiveButton.Size = new System.Drawing.Size(189, 91);
            this.createPassiveButton.TabIndex = 1;
            this.createPassiveButton.Text = "Create Passive";
            this.createPassiveButton.UseVisualStyleBackColor = true;
            this.createPassiveButton.Click += new System.EventHandler(this.createPassiveButton_Click);
            // 
            // usePassiveButton
            // 
            this.usePassiveButton.Location = new System.Drawing.Point(306, 205);
            this.usePassiveButton.Name = "usePassiveButton";
            this.usePassiveButton.Size = new System.Drawing.Size(189, 91);
            this.usePassiveButton.TabIndex = 2;
            this.usePassiveButton.Text = "Use Passive";
            this.usePassiveButton.UseVisualStyleBackColor = true;
            this.usePassiveButton.Click += new System.EventHandler(this.usePassiveButton_Click);
            // 
            // managePassiveButton
            // 
            this.managePassiveButton.Location = new System.Drawing.Point(501, 205);
            this.managePassiveButton.Name = "managePassiveButton";
            this.managePassiveButton.Size = new System.Drawing.Size(189, 91);
            this.managePassiveButton.TabIndex = 3;
            this.managePassiveButton.Text = "Manage Passives";
            this.managePassiveButton.UseVisualStyleBackColor = true;
            this.managePassiveButton.Click += new System.EventHandler(this.managePassiveButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.managePassiveButton);
            this.Controls.Add(this.usePassiveButton);
            this.Controls.Add(this.createPassiveButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Dokkan Passive Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createPassiveButton;
        private System.Windows.Forms.Button usePassiveButton;
        private System.Windows.Forms.Button managePassiveButton;
    }
}

