namespace Hyper.Forms
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
            this.questionLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // questionLabel1
            // 
            this.questionLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionLabel1.AutoSize = true;
            this.questionLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.questionLabel1.Location = new System.Drawing.Point(270, 100);
            this.questionLabel1.Name = "questionLabel1";
            this.questionLabel1.Size = new System.Drawing.Size(265, 25);
            this.questionLabel1.TabIndex = 0;
            this.questionLabel1.Text = "What would you like to do today?";
            this.questionLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(57, 198);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(128, 128);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "View Leaderboards";
            this.metroButton1.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.questionLabel1);
            this.Name = "Main";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Welcome, ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel questionLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}