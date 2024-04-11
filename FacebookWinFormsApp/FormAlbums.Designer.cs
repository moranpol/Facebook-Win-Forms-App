namespace BasicFacebookFeatures
{
    partial class FormAlbums
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
            this.albumsListBox = new System.Windows.Forms.ListBox();
            this.albumPhotosFListBox = new System.Windows.Forms.ListBox();
            this.PhotopictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.photoLikesLabel = new System.Windows.Forms.Label();
            this.photoCommentsListView = new System.Windows.Forms.ListView();
            this.backToProfileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.albumCommentsListView = new System.Windows.Forms.ListView();
            this.albumLikesLabel = new System.Windows.Forms.Label();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.savePhotoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhotopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // albumsListBox
            // 
            this.albumsListBox.FormattingEnabled = true;
            this.albumsListBox.ItemHeight = 20;
            this.albumsListBox.Location = new System.Drawing.Point(40, 46);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(405, 724);
            this.albumsListBox.TabIndex = 0;
            this.albumsListBox.SelectedIndexChanged += new System.EventHandler(this.albumsListBox_SelectedIndexChanged);
            // 
            // albumPhotosFListBox
            // 
            this.albumPhotosFListBox.FormattingEnabled = true;
            this.albumPhotosFListBox.ItemHeight = 20;
            this.albumPhotosFListBox.Location = new System.Drawing.Point(491, 46);
            this.albumPhotosFListBox.Name = "albumPhotosFListBox";
            this.albumPhotosFListBox.Size = new System.Drawing.Size(405, 364);
            this.albumPhotosFListBox.TabIndex = 1;
            this.albumPhotosFListBox.SelectedIndexChanged += new System.EventHandler(this.albumPhotosFListBox_SelectedIndexChanged);
            // 
            // PhotopictureBox
            // 
            this.PhotopictureBox.Location = new System.Drawing.Point(959, 46);
            this.PhotopictureBox.Name = "PhotopictureBox";
            this.PhotopictureBox.Size = new System.Drawing.Size(389, 364);
            this.PhotopictureBox.TabIndex = 2;
            this.PhotopictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(954, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Photo\'s Likes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(953, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Photo\'s Comments:";
            // 
            // photoLikesLabel
            // 
            this.photoLikesLabel.AutoSize = true;
            this.photoLikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.photoLikesLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.photoLikesLabel.Location = new System.Drawing.Point(1121, 433);
            this.photoLikesLabel.Name = "photoLikesLabel";
            this.photoLikesLabel.Size = new System.Drawing.Size(0, 29);
            this.photoLikesLabel.TabIndex = 5;
            // 
            // photoCommentsListView
            // 
            this.photoCommentsListView.HideSelection = false;
            this.photoCommentsListView.Location = new System.Drawing.Point(958, 528);
            this.photoCommentsListView.Name = "photoCommentsListView";
            this.photoCommentsListView.Size = new System.Drawing.Size(336, 242);
            this.photoCommentsListView.TabIndex = 6;
            this.photoCommentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // backToProfileButton
            // 
            this.backToProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backToProfileButton.Location = new System.Drawing.Point(1225, 801);
            this.backToProfileButton.Name = "backToProfileButton";
            this.backToProfileButton.Size = new System.Drawing.Size(205, 40);
            this.backToProfileButton.TabIndex = 7;
            this.backToProfileButton.Text = "Back To Profile";
            this.backToProfileButton.UseVisualStyleBackColor = true;
            this.backToProfileButton.Click += new System.EventHandler(this.backToProfileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(486, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Album\'s Likes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(486, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Album\'s Comments:";
            // 
            // albumCommentsListView
            // 
            this.albumCommentsListView.HideSelection = false;
            this.albumCommentsListView.Location = new System.Drawing.Point(491, 528);
            this.albumCommentsListView.Name = "albumCommentsListView";
            this.albumCommentsListView.Size = new System.Drawing.Size(336, 242);
            this.albumCommentsListView.TabIndex = 10;
            this.albumCommentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // albumLikesLabel
            // 
            this.albumLikesLabel.AutoSize = true;
            this.albumLikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.albumLikesLabel.Location = new System.Drawing.Point(658, 433);
            this.albumLikesLabel.Name = "albumLikesLabel";
            this.albumLikesLabel.Size = new System.Drawing.Size(0, 25);
            this.albumLikesLabel.TabIndex = 11;
            // 
            // statisticsButton
            // 
            this.statisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.statisticsButton.Location = new System.Drawing.Point(1000, 801);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(205, 40);
            this.statisticsButton.TabIndex = 23;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.UseVisualStyleBackColor = true;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // savePhotoButton
            // 
            this.savePhotoButton.Enabled = false;
            this.savePhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.savePhotoButton.Location = new System.Drawing.Point(1225, 433);
            this.savePhotoButton.Name = "savePhotoButton";
            this.savePhotoButton.Size = new System.Drawing.Size(205, 40);
            this.savePhotoButton.TabIndex = 24;
            this.savePhotoButton.Text = "Save Photo";
            this.savePhotoButton.UseVisualStyleBackColor = true;
            this.savePhotoButton.Click += new System.EventHandler(this.savePhotoButton_Click);
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1462, 880);
            this.Controls.Add(this.savePhotoButton);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.albumLikesLabel);
            this.Controls.Add(this.albumCommentsListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backToProfileButton);
            this.Controls.Add(this.photoCommentsListView);
            this.Controls.Add(this.photoLikesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhotopictureBox);
            this.Controls.Add(this.albumPhotosFListBox);
            this.Controls.Add(this.albumsListBox);
            this.Name = "FormAlbums";
            this.Text = "AlbumsForm";
            ((System.ComponentModel.ISupportInitialize)(this.PhotopictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox albumsListBox;
        private System.Windows.Forms.ListBox albumPhotosFListBox;
        private System.Windows.Forms.PictureBox PhotopictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label photoLikesLabel;
        private System.Windows.Forms.ListView photoCommentsListView;
        private System.Windows.Forms.Button backToProfileButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView albumCommentsListView;
        private System.Windows.Forms.Label albumLikesLabel;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button savePhotoButton;
    }
}