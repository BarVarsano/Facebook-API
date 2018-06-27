using System.Windows.Forms;

namespace FacebookPlayer
{
    public partial class SongPlayerController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongPlayerController));
            this.LikesNumberLabel = new System.Windows.Forms.Label();
            this.CommentsNumberLable = new System.Windows.Forms.Label();
            this.switchToAudioButton = new System.Windows.Forms.Button();
            this.mediaPlayer = new System.Windows.Forms.WebBrowser();
            this.commentPictureBox = new System.Windows.Forms.PictureBox();
            this.likePictureBox = new System.Windows.Forms.PictureBox();
            this.VideoPictureBox = new System.Windows.Forms.PictureBox();
            this.switchToVideoButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.songNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadDateLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LikesNumberLabel
            // 
            this.LikesNumberLabel.AutoSize = true;
            this.LikesNumberLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LikesNumberLabel.ForeColor = System.Drawing.Color.White;
            this.LikesNumberLabel.Location = new System.Drawing.Point(125, 32);
            this.LikesNumberLabel.Name = "LikesNumberLabel";
            this.LikesNumberLabel.Size = new System.Drawing.Size(41, 13);
            this.LikesNumberLabel.TabIndex = 38;
            this.LikesNumberLabel.Text = "label4";
            // 
            // CommentsNumberLable
            // 
            this.CommentsNumberLable.AutoSize = true;
            this.CommentsNumberLable.BackColor = System.Drawing.Color.Transparent;
            this.CommentsNumberLable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.CommentsNumberLable.ForeColor = System.Drawing.Color.White;
            this.CommentsNumberLable.Location = new System.Drawing.Point(745, 32);
            this.CommentsNumberLable.Name = "CommentsNumberLable";
            this.CommentsNumberLable.Size = new System.Drawing.Size(41, 13);
            this.CommentsNumberLable.TabIndex = 37;
            this.CommentsNumberLable.Text = "label2";
            // 
            // switchToAudioButton
            // 
            this.switchToAudioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.switchToAudioButton.FlatAppearance.BorderSize = 0;
            this.switchToAudioButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.switchToAudioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.switchToAudioButton.Location = new System.Drawing.Point(3, 3);
            this.switchToAudioButton.Name = "switchToAudioButton";
            this.switchToAudioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchToAudioButton.Size = new System.Drawing.Size(93, 35);
            this.switchToAudioButton.TabIndex = 30;
            this.switchToAudioButton.Text = "נסה Audio!";
            this.switchToAudioButton.UseVisualStyleBackColor = false;
            this.switchToAudioButton.Click += new System.EventHandler(this.switchToAudioButton_Click);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Location = new System.Drawing.Point(98, 73);
            this.mediaPlayer.MinimumSize = new System.Drawing.Size(20, 20);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.ScriptErrorsSuppressed = true;
            this.mediaPlayer.Size = new System.Drawing.Size(665, 338);
            this.mediaPlayer.TabIndex = 24;
            // 
            // commentPictureBox
            // 
            this.commentPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.commentPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("commentPictureBox.BackgroundImage")));
            this.commentPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.commentPictureBox.Location = new System.Drawing.Point(728, 32);
            this.commentPictureBox.Name = "commentPictureBox";
            this.commentPictureBox.Size = new System.Drawing.Size(35, 35);
            this.commentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentPictureBox.TabIndex = 29;
            this.commentPictureBox.TabStop = false;
            // 
            // likePictureBox
            // 
            this.likePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.likePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("likePictureBox.BackgroundImage")));
            this.likePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.likePictureBox.Location = new System.Drawing.Point(102, 32);
            this.likePictureBox.Name = "likePictureBox";
            this.likePictureBox.Size = new System.Drawing.Size(35, 35);
            this.likePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.likePictureBox.TabIndex = 28;
            this.likePictureBox.TabStop = false;
            // 
            // VideoPictureBox
            // 
            this.VideoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VideoPictureBox.Image")));
            this.VideoPictureBox.ImageLocation = string.Empty;
            this.VideoPictureBox.Location = new System.Drawing.Point(101, 73);
            this.VideoPictureBox.Name = "VideoPictureBox";
            this.VideoPictureBox.Size = new System.Drawing.Size(665, 338);
            this.VideoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VideoPictureBox.TabIndex = 23;
            this.VideoPictureBox.TabStop = false;
            // 
            // switchToVideoButton
            // 
            this.switchToVideoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.switchToVideoButton.FlatAppearance.BorderSize = 0;
            this.switchToVideoButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchToVideoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.switchToVideoButton.Location = new System.Drawing.Point(3, 3);
            this.switchToVideoButton.Name = "switchToVideoButton";
            this.switchToVideoButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchToVideoButton.Size = new System.Drawing.Size(93, 35);
            this.switchToVideoButton.TabIndex = 39;
            this.switchToVideoButton.Text = "נסה Video!";
            this.switchToVideoButton.UseVisualStyleBackColor = false;
            this.switchToVideoButton.Visible = false;
            this.switchToVideoButton.Click += new System.EventHandler(this.switchToVideoButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartButton.BackgroundImage")));
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartButton.FlatAppearance.BorderSize = 0;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Location = new System.Drawing.Point(783, 3);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(35, 34);
            this.restartButton.TabIndex = 40;
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(824, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 32);
            this.closeButton.TabIndex = 41;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // songNameTextBox
            // 
            this.songNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.songNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songNameTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.songNameTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songNameTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.songNameTextBox.Location = new System.Drawing.Point(208, 0);
            this.songNameTextBox.Multiline = true;
            this.songNameTextBox.Name = "songNameTextBox";
            this.songNameTextBox.ReadOnly = true;
            this.songNameTextBox.Size = new System.Drawing.Size(450, 48);
            this.songNameTextBox.TabIndex = 42;
            this.songNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(443, 51);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "עלה בתאריך";
            // 
            // uploadDateLable
            // 
            this.uploadDateLable.AutoSize = true;
            this.uploadDateLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uploadDateLable.Location = new System.Drawing.Point(369, 54);
            this.uploadDateLable.Name = "uploadDateLable";
            this.uploadDateLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uploadDateLable.Size = new System.Drawing.Size(35, 13);
            this.uploadDateLable.TabIndex = 36;
            this.uploadDateLable.Text = "label3";
            this.uploadDateLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SongPlayerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VideoPictureBox);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.songNameTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.switchToVideoButton);
            this.Controls.Add(this.LikesNumberLabel);
            this.Controls.Add(this.CommentsNumberLable);
            this.Controls.Add(this.uploadDateLable);
            this.Controls.Add(this.switchToAudioButton);
            this.Controls.Add(this.commentPictureBox);
            this.Controls.Add(this.likePictureBox);
            this.Controls.Add(this.label1);
            this.Name = "SongPlayerController";
            this.Size = new System.Drawing.Size(866, 411);
            ((System.ComponentModel.ISupportInitialize)(this.commentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LikesNumberLabel;
        private System.Windows.Forms.Label CommentsNumberLable;
        private System.Windows.Forms.Button switchToAudioButton;
        private System.Windows.Forms.PictureBox commentPictureBox;
        private System.Windows.Forms.PictureBox likePictureBox;
        private System.Windows.Forms.WebBrowser mediaPlayer;
        private System.Windows.Forms.PictureBox VideoPictureBox;
        private System.Windows.Forms.Button switchToVideoButton;
        private System.Windows.Forms.Button restartButton;
        private Button closeButton;
        private TextBox songNameTextBox;
        private Label label1;
        private Label uploadDateLable;
    }
}
