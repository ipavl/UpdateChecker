namespace UpdateChecker
{
    partial class Updater
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
            this.cmdCheck = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdCheck
            // 
            this.cmdCheck.Location = new System.Drawing.Point(12, 37);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(231, 26);
            this.cmdCheck.TabIndex = 0;
            this.cmdCheck.Text = "Check for Updates";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(82, 12);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(90, 13);
            this.lblCurrent.TabIndex = 1;
            this.lblCurrent.Text = "Current version: 0";
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 75);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.cmdCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Updater";
            this.Text = "Update Checker";
            this.Load += new System.EventHandler(this.Updater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.Label lblCurrent;
    }
}

