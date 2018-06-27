namespace ProfilePicturePicker
{
    public partial class AlbumViewerController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumViewerController));
            this.albumsComboBox = new System.Windows.Forms.ComboBox();
            this.orderByLikesButton = new System.Windows.Forms.Button();
            this.orderByCommentsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.photosSelector = new ProfilePicturePicker.PhotosSelectorController();
            this.orderByTimeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // albumsComboBox
            // 
            this.albumsComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.albumsComboBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.albumsComboBox.ForeColor = System.Drawing.SystemColors.Info;
            this.albumsComboBox.FormattingEnabled = true;
            this.albumsComboBox.Location = new System.Drawing.Point(3, 5);
            this.albumsComboBox.Name = "albumsComboBox";
            this.albumsComboBox.Size = new System.Drawing.Size(324, 21);
            this.albumsComboBox.TabIndex = 0;
            this.albumsComboBox.SelectionChangeCommitted += new System.EventHandler(this.albumsComboBox_SelectionChangeCommitted);
            // 
            // orderByLikesButton
            // 
            this.orderByLikesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderByLikesButton.BackColor = System.Drawing.Color.Transparent;
            this.orderByLikesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orderByLikesButton.BackgroundImage")));
            this.orderByLikesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderByLikesButton.FlatAppearance.BorderSize = 0;
            this.orderByLikesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderByLikesButton.Location = new System.Drawing.Point(219, 512);
            this.orderByLikesButton.Name = "orderByLikesButton";
            this.orderByLikesButton.Size = new System.Drawing.Size(40, 35);
            this.orderByLikesButton.TabIndex = 2;
            this.orderByLikesButton.UseVisualStyleBackColor = false;
            this.orderByLikesButton.Click += new System.EventHandler(this.orderByLikesButton_Click);
            // 
            // orderByCommentsButton
            // 
            this.orderByCommentsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderByCommentsButton.BackColor = System.Drawing.Color.Transparent;
            this.orderByCommentsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orderByCommentsButton.BackgroundImage")));
            this.orderByCommentsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderByCommentsButton.FlatAppearance.BorderSize = 0;
            this.orderByCommentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderByCommentsButton.Location = new System.Drawing.Point(173, 512);
            this.orderByCommentsButton.Name = "orderByCommentsButton";
            this.orderByCommentsButton.Size = new System.Drawing.Size(40, 35);
            this.orderByCommentsButton.TabIndex = 3;
            this.orderByCommentsButton.UseVisualStyleBackColor = false;
            this.orderByCommentsButton.Click += new System.EventHandler(this.orderByCommentsButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(265, 523);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "סדר לפי";
            // 
            // photosSelector
            // 
            this.photosSelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.photosSelector.Location = new System.Drawing.Point(0, 32);
            this.photosSelector.Name = "photosSelector";
            this.photosSelector.Size = new System.Drawing.Size(330, 474);
            this.photosSelector.TabIndex = 1;
            // 
            // orderByTimeButton
            // 
            this.orderByTimeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderByTimeButton.BackColor = System.Drawing.Color.Transparent;
            this.orderByTimeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orderByTimeButton.BackgroundImage")));
            this.orderByTimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderByTimeButton.FlatAppearance.BorderSize = 0;
            this.orderByTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderByTimeButton.Location = new System.Drawing.Point(128, 512);
            this.orderByTimeButton.Name = "orderByTimeButton";
            this.orderByTimeButton.Size = new System.Drawing.Size(40, 35);
            this.orderByTimeButton.TabIndex = 5;
            this.orderByTimeButton.UseVisualStyleBackColor = false;
            this.orderByTimeButton.Click += new System.EventHandler(this.orderByTimeButton_Click);
            // 
            // AlbumViewerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderByTimeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderByCommentsButton);
            this.Controls.Add(this.orderByLikesButton);
            this.Controls.Add(this.photosSelector);
            this.Controls.Add(this.albumsComboBox);
            this.Name = "AlbumViewerController";
            this.Size = new System.Drawing.Size(335, 552);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox albumsComboBox;
        private PhotosSelectorController photosSelector;
        private System.Windows.Forms.Button orderByLikesButton;
        private System.Windows.Forms.Button orderByCommentsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderByTimeButton;
    }
}
