namespace BasicFacebookFeatures
{
    partial class FormPosts
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
            this.backToProfileButton = new System.Windows.Forms.Button();
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.postRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.postLikesLabel = new System.Windows.Forms.Label();
            this.commentsListView = new System.Windows.Forms.ListView();
            this.newPostRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.publishButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.datePostLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.radioButtonSortByTime = new System.Windows.Forms.RadioButton();
            this.radioButtonSortByLikes = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backToProfileButton
            // 
            this.backToProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backToProfileButton.Location = new System.Drawing.Point(825, 526);
            this.backToProfileButton.Margin = new System.Windows.Forms.Padding(2);
            this.backToProfileButton.Name = "backToProfileButton";
            this.backToProfileButton.Size = new System.Drawing.Size(137, 26);
            this.backToProfileButton.TabIndex = 8;
            this.backToProfileButton.Text = "Back To Profile";
            this.backToProfileButton.UseVisualStyleBackColor = true;
            this.backToProfileButton.Click += new System.EventHandler(this.backToProfileButton_Click);
            // 
            // postsListBox
            // 
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.Location = new System.Drawing.Point(28, 40);
            this.postsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(239, 446);
            this.postsListBox.TabIndex = 9;
            this.postsListBox.SelectedIndexChanged += new System.EventHandler(this.postsListBox_SelectedIndexChanged);
            // 
            // postRichTextBox
            // 
            this.postRichTextBox.Location = new System.Drawing.Point(295, 65);
            this.postRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.postRichTextBox.Name = "postRichTextBox";
            this.postRichTextBox.Size = new System.Drawing.Size(293, 196);
            this.postRichTextBox.TabIndex = 10;
            this.postRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(298, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Post\'s Likes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(298, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Post\'s Comments:";
            // 
            // postLikesLabel
            // 
            this.postLikesLabel.AutoSize = true;
            this.postLikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.postLikesLabel.Location = new System.Drawing.Point(383, 280);
            this.postLikesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.postLikesLabel.Name = "postLikesLabel";
            this.postLikesLabel.Size = new System.Drawing.Size(0, 17);
            this.postLikesLabel.TabIndex = 13;
            // 
            // commentsListView
            // 
            this.commentsListView.HideSelection = false;
            this.commentsListView.Location = new System.Drawing.Point(295, 353);
            this.commentsListView.Margin = new System.Windows.Forms.Padding(2);
            this.commentsListView.Name = "commentsListView";
            this.commentsListView.Size = new System.Drawing.Size(293, 133);
            this.commentsListView.TabIndex = 14;
            this.commentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // newPostRichTextBox
            // 
            this.newPostRichTextBox.Location = new System.Drawing.Point(637, 287);
            this.newPostRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newPostRichTextBox.Name = "newPostRichTextBox";
            this.newPostRichTextBox.Size = new System.Drawing.Size(246, 163);
            this.newPostRichTextBox.TabIndex = 15;
            this.newPostRichTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(635, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Write New Post:";
            // 
            // publishButton
            // 
            this.publishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.publishButton.Location = new System.Drawing.Point(637, 457);
            this.publishButton.Margin = new System.Windows.Forms.Padding(2);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(100, 26);
            this.publishButton.TabIndex = 17;
            this.publishButton.Text = "Publish";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(298, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Post:";
            // 
            // datePostLabel
            // 
            this.datePostLabel.AutoSize = true;
            this.datePostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.datePostLabel.Location = new System.Drawing.Point(410, 40);
            this.datePostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datePostLabel.Name = "datePostLabel";
            this.datePostLabel.Size = new System.Drawing.Size(0, 17);
            this.datePostLabel.TabIndex = 19;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(639, 65);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(206, 179);
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            // 
            // radioButtonSortByTime
            // 
            this.radioButtonSortByTime.AutoSize = true;
            this.radioButtonSortByTime.Location = new System.Drawing.Point(28, 12);
            this.radioButtonSortByTime.Name = "radioButtonSortByTime";
            this.radioButtonSortByTime.Size = new System.Drawing.Size(85, 17);
            this.radioButtonSortByTime.TabIndex = 22;
            this.radioButtonSortByTime.TabStop = true;
            this.radioButtonSortByTime.Text = "Sort By Time";
            this.radioButtonSortByTime.UseVisualStyleBackColor = true;
            this.radioButtonSortByTime.CheckedChanged += new System.EventHandler(this.radioButtonSortByTime_CheckedChanged);
            // 
            // radioButtonSortByLikes
            // 
            this.radioButtonSortByLikes.AutoSize = true;
            this.radioButtonSortByLikes.Location = new System.Drawing.Point(169, 12);
            this.radioButtonSortByLikes.Name = "radioButtonSortByLikes";
            this.radioButtonSortByLikes.Size = new System.Drawing.Size(87, 17);
            this.radioButtonSortByLikes.TabIndex = 23;
            this.radioButtonSortByLikes.TabStop = true;
            this.radioButtonSortByLikes.Text = "Sort By Likes";
            this.radioButtonSortByLikes.UseVisualStyleBackColor = true;
            this.radioButtonSortByLikes.CheckedChanged += new System.EventHandler(this.radioButtonSortByLikes_CheckedChanged);
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 560);
            this.Controls.Add(this.radioButtonSortByLikes);
            this.Controls.Add(this.radioButtonSortByTime);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.datePostLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPostRichTextBox);
            this.Controls.Add(this.commentsListView);
            this.Controls.Add(this.postLikesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postRichTextBox);
            this.Controls.Add(this.postsListBox);
            this.Controls.Add(this.backToProfileButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPosts";
            this.Text = "FormPosts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToProfileButton;
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.RichTextBox postRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label postLikesLabel;
        private System.Windows.Forms.ListView commentsListView;
        private System.Windows.Forms.RichTextBox newPostRichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label datePostLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton radioButtonSortByTime;
        private System.Windows.Forms.RadioButton radioButtonSortByLikes;
    }
}