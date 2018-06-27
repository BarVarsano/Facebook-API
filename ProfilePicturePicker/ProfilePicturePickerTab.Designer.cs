namespace ProfilePicturePicker
{
    public partial class ProfilePicturePickerController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePicturePickerController));
            this.AddPhotoButton = new System.Windows.Forms.Button();
            this.CreatAlbumButton = new System.Windows.Forms.Button();
            this.photosToUpload = new ProfilePicturePicker.PhotosToUploadController();
            this.albumViewer = new ProfilePicturePicker.AlbumViewerController();
            this.SuspendLayout();
            // 
            // AddPhotoButton
            // 
            this.AddPhotoButton.BackColor = System.Drawing.Color.Transparent;
            this.AddPhotoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPhotoButton.BackgroundImage")));
            this.AddPhotoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPhotoButton.FlatAppearance.BorderSize = 0;
            this.AddPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPhotoButton.Location = new System.Drawing.Point(709, 43);
            this.AddPhotoButton.Name = "AddPhotoButton";
            this.AddPhotoButton.Size = new System.Drawing.Size(68, 68);
            this.AddPhotoButton.TabIndex = 4;
            this.AddPhotoButton.UseVisualStyleBackColor = false;
            this.AddPhotoButton.Click += new System.EventHandler(this.addPhotoButton_Click);
            // 
            // CreatAlbumButton
            // 
            this.CreatAlbumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.CreatAlbumButton.FlatAppearance.BorderSize = 0;
            this.CreatAlbumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatAlbumButton.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CreatAlbumButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreatAlbumButton.Location = new System.Drawing.Point(264, 350);
            this.CreatAlbumButton.Name = "CreatAlbumButton";
            this.CreatAlbumButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CreatAlbumButton.Size = new System.Drawing.Size(254, 98);
            this.CreatAlbumButton.TabIndex = 6;
            this.CreatAlbumButton.Text = "צור אלבום!";
            this.CreatAlbumButton.UseVisualStyleBackColor = false;
            this.CreatAlbumButton.Visible = false;
            this.CreatAlbumButton.Click += new System.EventHandler(this.creatAlbumButton_Click);
            // 
            // photosToUpload
            // 
            this.photosToUpload.Location = new System.Drawing.Point(150, 45);
            this.photosToUpload.Name = "photosToUpload";
            this.photosToUpload.Size = new System.Drawing.Size(535, 299);
            this.photosToUpload.TabIndex = 5;
            // 
            // albumViewer
            // 
            this.albumViewer.Location = new System.Drawing.Point(768, 11);
            this.albumViewer.Name = "albumViewer";
            this.albumViewer.Size = new System.Drawing.Size(360, 543);
            this.albumViewer.TabIndex = 3;
            // 
            // ProfilePicturePickerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(189)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.CreatAlbumButton);
            this.Controls.Add(this.AddPhotoButton);
            this.Controls.Add(this.photosToUpload);
            this.Controls.Add(this.albumViewer);
            this.Name = "ProfilePicturePickerTab";
            this.Size = new System.Drawing.Size(1156, 572);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddPhotoButton;
        private PhotosToUploadController photosToUpload;
        private ProfilePicturePicker.AlbumViewerController albumViewer;
        private System.Windows.Forms.Button CreatAlbumButton;
    }
}
