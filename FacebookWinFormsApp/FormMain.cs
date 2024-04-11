using FacebookWrapper;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_Token = "748624740071515";
        private static readonly object sr_Lock = new object();
        private static FacebookWrapper.LoginResult s_LoginResult;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (s_LoginResult == null)
            {
                lock (sr_Lock)
                {
                    if (s_LoginResult == null)
                    {
                        login();
                    }
                }
            }

            FormProfile v_FormProfile = new FormProfile();
            v_FormProfile.ShowDialog();
            this.Dispose();
        }

        private void login()
        {
            s_LoginResult = FacebookService.Login(
                k_Token,
                "email",
                "public_profile",
                "user_likes",
                "user_events",
                "user_photos",
                "user_videos",
                "user_friends",
                "user_posts",
                "user_birthday",
                "user_hometown"
                );

            if (string.IsNullOrEmpty(s_LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {s_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                buttonLogin.Enabled = false;
            }
        }

        public static FacebookWrapper.LoginResult GetLoginResult()
        {
            if (s_LoginResult == null)
            {
                lock (sr_Lock)
                {
                    if (s_LoginResult == null)
                    {
                        MessageBox.Show($"Login has not been performed yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return s_LoginResult;
        }
    }
}