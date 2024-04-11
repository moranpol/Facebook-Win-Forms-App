using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormProfile : Form
    {
        private FacebookWrapper.LoginResult m_LoginResult;
        
        public FormProfile()
        {
            InitializeComponent();
            m_LoginResult = FormMain.GetLoginResult();
            userBindingSource.DataSource = m_LoginResult.LoggedInUser;

            if (m_LoginResult.LoggedInUser.Friends == null)
            {
                friendsListBox.Text = "Not Found";
            }
            else
            {
                foreach (var v_Friend in m_LoginResult.LoggedInUser.Friends)
                {
                    friendsListBox.Items.Add(v_Friend.Name);
                }
            }
            
            if (m_LoginResult.LoggedInUser.LikedPages == null)
            {
                pagesListBox.Text = "Not Found";
            }
            else
            {
                foreach (var v_Page in m_LoginResult.LoggedInUser.LikedPages)
                {
                    pagesListBox.Items.Add(v_Page.Name);
                }
            }
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox v_ListBox = (ListBox)sender;
            object v_SelectedFriend = v_ListBox.SelectedItem;

            if (v_SelectedFriend == null)
            {
                friendsPictureBox.ImageLocation = "";
                return;
            }

            string v_FriendName = v_SelectedFriend.ToString();
            friendsPictureBox.ImageLocation =m_LoginResult.LoggedInUser.Friends.Find(i_Friend => i_Friend.Name == v_FriendName).PictureNormalURL;
        }

        private void pagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox v_ListBox = (ListBox)sender;
            object v_SelectedPage = v_ListBox.SelectedItem;

            if (v_SelectedPage == null)
            {
                pagesPictureBox.ImageLocation = "";
                return;
            }

            string v_PageName = v_SelectedPage.ToString();
            pagesPictureBox.ImageLocation = m_LoginResult.LoggedInUser.LikedPages.Find(i_Page => i_Page.Name == v_PageName).PictureNormalURL;
        }

        private void albumsButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormAlbums v_FormAlbums = new FormAlbums();
            v_FormAlbums.ShowDialog();
            
        }

        private void postsButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormPosts v_FormPosts = new FormPosts();
            v_FormPosts.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            this.Dispose();
            FormMain v_FormMain = new FormMain();
            v_FormMain.ShowDialog();
        }
    }
}
