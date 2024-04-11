using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPosts : Form, INewPostObserver
    {
        private FacebookWrapper.LoginResult m_LoginResult;
        private NewPostSubject m_NewPostSubject = new NewPostSubject();

        public FormPosts()
        {
            InitializeComponent();
            m_LoginResult = FormMain.GetLoginResult();
            postRichTextBox.ReadOnly = true;
            m_NewPostSubject.Attach(this);
            loadPosts();
        }

        private void loadPosts()
        {
            Thread v_LoadPostsThread = new Thread(() =>
            {
                List<Post> v_Posts = new List<Post>(m_LoginResult.LoggedInUser.Posts);
                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(() =>
                    {
                        updatePostsListBox(v_Posts);
                    }));
                } 
            });
            v_LoadPostsThread.Start();
        }

        private void updatePostsListBox(List<Post> i_Posts)
        {
            postsListBox.Items.Clear(); 
            if (m_LoginResult.LoggedInUser.Posts == null)
            {
                postsListBox.Text = "Not Found";
            }
            else
            {
                foreach (var v_Post in i_Posts)
                {
                    postsListBox.Items.Add(v_Post.ToString());
                }
            }
        }

        private void backToProfileButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormProfile v_FormProfile = new FormProfile();
            v_FormProfile.ShowDialog();
        }

        private void postsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox v_ListBox = (ListBox)sender;
            object v_SelectedPost = v_ListBox.SelectedItem;
            clearItms();

            if (v_SelectedPost == null)
            {
                return;
            }

            Post v_Post = m_LoginResult.LoggedInUser.Posts[v_ListBox.SelectedIndex];
            postRichTextBox.Text = v_Post.Message;
            datePostLabel.Text = v_Post.CreatedTime.ToString();
            pictureBox.ImageLocation = v_Post.PictureURL;

            try 
            {
                postLikesLabel.Text = v_Post.LikedBy == null ? "Not Found" : v_Post.LikedBy.Count.ToString();
            }
            catch (Exception)
            {
                postLikesLabel.Text = "Not Found";
            }

            try
            {
                foreach (Comment v_Comment in v_Post.Comments)
                {
                    commentsListView.Items.Add(v_Comment.ToString());
                }
            }
            catch (Exception) 
            {
                commentsListView.Items.Add("Not Found");
            }
        }

        private void clearItms()
        {
            postRichTextBox.Clear();
            datePostLabel.Text = "";
            postLikesLabel.Text = "";
            commentsListView.Clear();
            pictureBox.ImageLocation = null;
            newPostRichTextBox.Text = "";
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            try
            {
                Status v_PostedStatus = m_LoginResult.LoggedInUser.PostStatus(newPostRichTextBox.Text);
                MessageBox.Show("Status posted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                m_NewPostSubject.Notify();
            }
            catch (Exception)
            {
                MessageBox.Show($"Error posting status: Problem Occurred (Facebook API)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NotifyNewPost()
        {
            List<Post> v_Posts = new List<Post>(m_LoginResult.LoggedInUser.Posts);
            updatePostsListBox(v_Posts);
        }

        private void radioButtonSortByTime_CheckedChanged(object sender, EventArgs e)
        {
            List<Post> v_Posts = new List<Post>(m_LoginResult.LoggedInUser.Posts);
            SortStrategy v_Sort = new SortStrategy(eCompareTypes.Time);
            v_Sort.Sort(v_Posts);
            updatePostsListBox(v_Posts);
        }

        private void radioButtonSortByLikes_CheckedChanged(object sender, EventArgs e)
        {
            List<Post> v_Posts = new List<Post>(m_LoginResult.LoggedInUser.Posts);
            SortStrategy v_Sort = new SortStrategy(eCompareTypes.Likes);
            v_Sort.Sort(v_Posts);
            updatePostsListBox(v_Posts);
        }
    }
}
