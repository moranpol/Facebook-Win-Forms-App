using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormAlbums : Form
    {
        private FacebookWrapper.LoginResult m_LoginResult;
        private FacebookObjectCollection<Photo> m_AlbumPhotos;
        private Photo m_Photo;

        public FormAlbums()
        {
            InitializeComponent();
            m_LoginResult = FormMain.GetLoginResult();
            m_AlbumPhotos = null;
            m_Photo = null;

            if (m_LoginResult.LoggedInUser.Albums == null)
            {
                albumsListBox.Text = "Not Found";
            }
            else
            {
                foreach (var v_Album in m_LoginResult.LoggedInUser.Albums)
                {
                    albumsListBox.Items.Add(v_Album.Name);
                }
            }

            albumPhotosFListBox.Text = "Album Photos List";
        }

        private void albumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox v_ListBox = (ListBox)sender;
            object v_SelectedAlbum = v_ListBox.SelectedItem;
            clearItms();

            if (v_SelectedAlbum == null)
            {
                m_AlbumPhotos = null;
                return;
            }

            string v_AlbumName = v_SelectedAlbum.ToString();
            Album v_Album = m_LoginResult.LoggedInUser.Albums.Find(i_Album => i_Album.Name == v_AlbumName);
            m_AlbumPhotos = v_Album.Photos;

            foreach (Photo v_Photo in m_AlbumPhotos)
            {
                albumPhotosFListBox.Items.Add(v_Photo.ToString());
            }

            albumLikesLabel.Text = v_Album.LikedBy.Count.ToString();

            foreach (Comment v_Comment in v_Album.Comments)
            {
                albumCommentsListView.Items.Add(v_Comment.ToString());
            }
        }

        private void clearItms()
        {
            albumPhotosFListBox.Items.Clear();
            PhotopictureBox.ImageLocation = "";
            photoLikesLabel.Text = "";
            albumLikesLabel.Text = "";
            photoCommentsListView.Items.Clear();
            albumCommentsListView.Items.Clear();
            m_Photo = null;
            savePhotoButton.Enabled = false;
        }

        private void albumPhotosFListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox v_ListBox = (ListBox)sender;
            object v_SelectedPhoto = v_ListBox.SelectedItem;
            savePhotoButton.Enabled = true;

            if (v_SelectedPhoto == null)
            {
                PhotopictureBox.ImageLocation = "";
                return;
            }

            m_Photo = m_AlbumPhotos[v_ListBox.SelectedIndex];
            PhotopictureBox.ImageLocation = m_Photo.PictureAlbumURL;
            photoLikesLabel.Text = m_Photo.LikedBy.Count.ToString();
            
            foreach (Comment v_Comment in m_Photo.Comments)
            {
                photoCommentsListView.Items.Add(v_Comment.ToString());
            }
        }

        private void backToProfileButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormProfile v_FormProfile = new FormProfile();
            v_FormProfile.ShowDialog();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            FormAlbumStatistics v_FormLikedPagesStatistics = new FormAlbumStatistics();
            v_FormLikedPagesStatistics.ShowDialog();
        }

        private void savePhotoButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog v_SaveFileDialog = new SaveFileDialog())
            {
                v_SaveFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                v_SaveFileDialog.Title = "Save Photo";
                v_SaveFileDialog.CheckFileExists = false;
                v_SaveFileDialog.CheckPathExists = true;

                if (v_SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string v_SelectedFilePath = v_SaveFileDialog.FileName;
                    string v_PhotoUrl = m_Photo.PictureNormalURL.ToString();

                    try
                    {
                        using (WebClient v_WebClient = new WebClient())
                        {
                            byte[] imageData = v_WebClient.DownloadData(v_PhotoUrl);
                            File.WriteAllBytes(v_SelectedFilePath, imageData);
                            MessageBox.Show("Photo saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving photo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
