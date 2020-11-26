using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hypixel.NET;
using MetroFramework.Forms;

namespace Hyper.Forms
{
    public partial class Login : MetroForm
    {
        bool rememberMe;
        public Main main;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] loginInfo = ReadCredentials();
            if (loginInfo != null)
            {
                if (loginInfo.Length > 3)
                {
                    if (loginInfo[2].ToLower() == "true")
                    {
                        metroTextBox1.Text = loginInfo[0];
                        metroTextBox1.Enabled = false;
                        UsernameBox.Text = loginInfo[1];
                        UsernameBox.Enabled = false;
                        AttemptLogin(loginInfo[1], loginInfo[0]);
                        metroTextBox1.Enabled = true;
                        UsernameBox.Enabled = true;
                    }
                }
                else
                {
                    metroProgressSpinner1.Visible = false;
                }
            }
            else
            {
                metroProgressSpinner1.Visible = false;
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void apikeyhelpbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Run \"/api new\" on the Hypixel server and input the code.");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
                AttemptLogin(UsernameBox.Text, metroTextBox1.Text);
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e) => rememberMe = !rememberMe;

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void StoreCredentials(string key, string username)
        {
            string[] lines = { key.EncodeBase64(), username.EncodeBase64(), rememberMe.ToString().ToLower().EncodeBase64() }; // TODO: dont store key and username in plain text.
            System.IO.File.WriteAllLines(@".\login", lines);
            Console.WriteLine("Stored credentials.");
        }

        private string[] ReadCredentials()
        {
            if (System.IO.File.Exists(@".\login"))
            {
                string[] lines = System.IO.File.ReadAllLines(@".\login");
                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = lines[i].DecodeBase64();
                }
                return lines;
            }
            return null;
        }

        private async void AttemptLogin(string username, string key)
        {
            metroProgressSpinner1.Visible = true;
            if (username != "" && !username.Contains(" "))
            {
                if (key != "" && key.Contains("-") && !key.Contains(" "))
                {
                    var hypixel = new HypixelApi(key, 30);
                    Hypixel.NET.PlayerApi.GetPlayerData playerRequest = null;
                    try
                    {
                        playerRequest = await Task.Run(() => hypixel.GetUserByPlayerName(username));

                        string result;
                        if (playerRequest.WasSuccessful) result = playerRequest.Player.DisplayName;
                        else result = "An error occurred while making a request to the Hypixel Server. \nCause: " + playerRequest.Cause;

                        if (!result.Contains("error"))
                        {
                            metroProgressSpinner1.Visible = false;
                            if (rememberMe) StoreCredentials(key, username);

                            main = new Main();
                            main.Text += username;
                            main.username = username;
                            main.key = key;
                            main.login = this;
                            main.Show();
                            Hide();
                        }
                        else
                        {
                            metroProgressSpinner1.Visible = false;
                            MessageBox.Show(result);
                        }
                    }
                    catch (Exception exception)
                    {
                        metroProgressSpinner1.Visible = false;
                        MessageBox.Show("An error occurred while making a request to the Hypixel Server.\nCause: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        
                    }
                }
                else
                {
                    metroProgressSpinner1.Visible = false;
                    MessageBox.Show("An error occurred while logging in! [INVALID_APIKEY]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
            else
            {
                metroProgressSpinner1.Visible = false;
                MessageBox.Show("An error occurred while logging in! [INVALID_USERNAME]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
