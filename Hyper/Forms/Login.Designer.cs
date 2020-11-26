namespace Hyper.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsernameBox = new MetroFramework.Controls.MetroTextBox();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.apikeyhelpbutton = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroProgressSpinner1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.UsernameBox.CustomButton.Image = null;
            this.UsernameBox.CustomButton.Location = new System.Drawing.Point(403, 1);
            this.UsernameBox.CustomButton.Name = "";
            this.UsernameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UsernameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameBox.CustomButton.TabIndex = 1;
            this.UsernameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameBox.CustomButton.UseSelectable = true;
            this.UsernameBox.CustomButton.Visible = false;
            this.UsernameBox.Lines = new string[0];
            this.UsernameBox.Location = new System.Drawing.Point(20, 601);
            this.UsernameBox.MaxLength = 32767;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PasswordChar = '\0';
            this.UsernameBox.PromptText = "Minecraft Username";
            this.UsernameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameBox.SelectedText = "";
            this.UsernameBox.SelectionLength = 0;
            this.UsernameBox.SelectionStart = 0;
            this.UsernameBox.ShortcutsEnabled = true;
            this.UsernameBox.Size = new System.Drawing.Size(425, 23);
            this.UsernameBox.TabIndex = 0;
            this.UsernameBox.UseSelectable = true;
            this.UsernameBox.WaterMark = "Minecraft Username";
            this.UsernameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.AutoSize = true;
            this.LoginButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.LoginButton.Location = new System.Drawing.Point(20, 658);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(425, 29);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LoginButton.UseSelectable = true;
            this.LoginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(374, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(20, 629);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '•';
            this.metroTextBox1.PromptText = "Hypixel API Key";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(396, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Hypixel API Key";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // apikeyhelpbutton
            // 
            this.apikeyhelpbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.apikeyhelpbutton.Location = new System.Drawing.Point(422, 629);
            this.apikeyhelpbutton.Name = "apikeyhelpbutton";
            this.apikeyhelpbutton.Size = new System.Drawing.Size(23, 23);
            this.apikeyhelpbutton.TabIndex = 3;
            this.apikeyhelpbutton.Text = "?";
            this.apikeyhelpbutton.UseSelectable = true;
            this.apikeyhelpbutton.Click += new System.EventHandler(this.apikeyhelpbutton_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroCheckBox1.Location = new System.Drawing.Point(20, 581);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(26, 17);
            this.metroCheckBox1.TabIndex = 4;
            this.metroCheckBox1.Text = " ";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 579);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Remember me";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressSpinner1.Image = ((System.Drawing.Image)(resources.GetObject("metroProgressSpinner1.Image")));
            this.metroProgressSpinner1.Location = new System.Drawing.Point(200, 280);
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(64, 64);
            this.metroProgressSpinner1.TabIndex = 6;
            this.metroProgressSpinner1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.ClientSize = new System.Drawing.Size(460, 710);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.apikeyhelpbutton);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UsernameBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 710);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 710);
            this.Name = "Login";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroProgressSpinner1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox UsernameBox;
        private MetroFramework.Controls.MetroButton LoginButton;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton apikeyhelpbutton;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox metroProgressSpinner1;
    }
}