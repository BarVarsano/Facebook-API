using FacebookPlayer;

namespace FacebookApplication
{
    public partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabsWindow = new System.Windows.Forms.TabControl();
            this.FacebookPlayerTab = new System.Windows.Forms.TabPage();
            this.facebookPlayerController = new FacebookPlayer.FacebookPlayerController();
            this.ProfilePicturePickerTab = new System.Windows.Forms.TabPage();
            this.profilePicturePickerTab1 = new ProfilePicturePicker.ProfilePicturePickerController();
            this.existFecherTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.checkInListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.postSatusController = new PostStatus.PostSatusController();
            this.label2 = new System.Windows.Forms.Label();
            this.birthdaysController = new FriendsBirthday.FriendsBirthdayController();
            this.label1 = new System.Windows.Forms.Label();
            this.likedPagesViewer = new LikedPages.LikedPagesController();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.nameLable = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            this.TabsWindow.SuspendLayout();
            this.FacebookPlayerTab.SuspendLayout();
            this.ProfilePicturePickerTab.SuspendLayout();
            this.existFecherTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            birthdayLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            birthdayLabel.Location = new System.Drawing.Point(152, 248);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(63, 13);
            birthdayLabel.TabIndex = 7;
            birthdayLabel.Text = "יום הולדת:";
            // 
            // TabsWindow
            // 
            this.TabsWindow.Controls.Add(this.FacebookPlayerTab);
            this.TabsWindow.Controls.Add(this.ProfilePicturePickerTab);
            this.TabsWindow.Controls.Add(this.existFecherTab);
            this.TabsWindow.Location = new System.Drawing.Point(3, 112);
            this.TabsWindow.Name = "TabsWindow";
            this.TabsWindow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabsWindow.RightToLeftLayout = true;
            this.TabsWindow.SelectedIndex = 0;
            this.TabsWindow.Size = new System.Drawing.Size(1176, 611);
            this.TabsWindow.TabIndex = 17;
            this.TabsWindow.Visible = false;
            // 
            // FacebookPlayerTab
            // 
            this.FacebookPlayerTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FacebookPlayerTab.Controls.Add(this.facebookPlayerController);
            this.FacebookPlayerTab.Location = new System.Drawing.Point(4, 22);
            this.FacebookPlayerTab.Name = "FacebookPlayerTab";
            this.FacebookPlayerTab.Padding = new System.Windows.Forms.Padding(3);
            this.FacebookPlayerTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FacebookPlayerTab.Size = new System.Drawing.Size(1168, 585);
            this.FacebookPlayerTab.TabIndex = 0;
            this.FacebookPlayerTab.Text = "Facebook Player";
            this.FacebookPlayerTab.Enter += new System.EventHandler(this.facebookPlayerTab_Enter);
            this.FacebookPlayerTab.Leave += new System.EventHandler(this.facebookPlayerTab_Leave);
            // 
            // facebookPlayerController
            // 
            this.facebookPlayerController.Location = new System.Drawing.Point(2, 3);
            this.facebookPlayerController.Name = "facebookPlayerController";
            this.facebookPlayerController.Size = new System.Drawing.Size(1163, 579);
            this.facebookPlayerController.TabIndex = 0;
            // 
            // ProfilePicturePickerTab
            // 
            this.ProfilePicturePickerTab.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ProfilePicturePickerTab.Controls.Add(this.profilePicturePickerTab1);
            this.ProfilePicturePickerTab.Location = new System.Drawing.Point(4, 22);
            this.ProfilePicturePickerTab.Name = "ProfilePicturePickerTab";
            this.ProfilePicturePickerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProfilePicturePickerTab.Size = new System.Drawing.Size(1168, 585);
            this.ProfilePicturePickerTab.TabIndex = 1;
            this.ProfilePicturePickerTab.Text = "Profile Picture Picker";
            this.ProfilePicturePickerTab.Enter += new System.EventHandler(this.profilePicturePickerTab_Enter);
            // 
            // profilePicturePickerTab1
            // 
            this.profilePicturePickerTab1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.profilePicturePickerTab1.Location = new System.Drawing.Point(6, 6);
            this.profilePicturePickerTab1.Name = "profilePicturePickerTab1";
            this.profilePicturePickerTab1.Size = new System.Drawing.Size(1156, 561);
            this.profilePicturePickerTab1.TabIndex = 0;
            // 
            // existFecherTab
            // 
            this.existFecherTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.existFecherTab.Controls.Add(this.label4);
            this.existFecherTab.Controls.Add(this.panel1);
            this.existFecherTab.Controls.Add(this.checkInListBox);
            this.existFecherTab.Controls.Add(this.label3);
            this.existFecherTab.Controls.Add(this.postSatusController);
            this.existFecherTab.Controls.Add(this.label2);
            this.existFecherTab.Controls.Add(this.birthdaysController);
            this.existFecherTab.Controls.Add(this.label1);
            this.existFecherTab.Controls.Add(this.likedPagesViewer);
            this.existFecherTab.Location = new System.Drawing.Point(4, 22);
            this.existFecherTab.Name = "existFecherTab";
            this.existFecherTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.existFecherTab.Size = new System.Drawing.Size(1168, 585);
            this.existFecherTab.TabIndex = 2;
            this.existFecherTab.Text = "Exist Fechers";
            this.existFecherTab.Enter += new System.EventHandler(this.existFechersTab_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(624, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "חברים באפליקציה";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(birthdayLabel);
            this.panel1.Controls.Add(this.birthdayLabel1);
            this.panel1.Controls.Add(this.imageLargePictureBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(368, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 272);
            this.panel1.TabIndex = 7;
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.birthdayLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.birthdayLabel1.Location = new System.Drawing.Point(16, 248);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(100, 23);
            this.birthdayLabel1.TabIndex = 8;
            this.birthdayLabel1.Text = "label4";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(16, 40);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(200, 200);
            this.imageLargePictureBox.TabIndex = 5;
            this.imageLargePictureBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.nameTextBox.Location = new System.Drawing.Point(16, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 13);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkInListBox
            // 
            this.checkInListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.checkInListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkInListBox.DataSource = this.userBindingSource;
            this.checkInListBox.DisplayMember = "Name";
            this.checkInListBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkInListBox.ForeColor = System.Drawing.SystemColors.Info;
            this.checkInListBox.FormattingEnabled = true;
            this.checkInListBox.Location = new System.Drawing.Point(648, 64);
            this.checkInListBox.Name = "checkInListBox";
            this.checkInListBox.Size = new System.Drawing.Size(176, 247);
            this.checkInListBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(664, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "פרסם סטטוס!";
            // 
            // postSatusController
            // 
            this.postSatusController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.postSatusController.Location = new System.Drawing.Point(368, 368);
            this.postSatusController.Name = "postSatusController";
            this.postSatusController.Size = new System.Drawing.Size(456, 216);
            this.postSatusController.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(119, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ימי הולדת השבוע!";
            // 
            // birthdaysController
            // 
            this.birthdaysController.Location = new System.Drawing.Point(16, 70);
            this.birthdaysController.Name = "birthdaysController";
            this.birthdaysController.Size = new System.Drawing.Size(306, 386);
            this.birthdaysController.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(953, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "הדפים שאהבתי!";
            // 
            // likedPagesViewer
            // 
            this.likedPagesViewer.BackColor = System.Drawing.Color.Gainsboro;
            this.likedPagesViewer.Location = new System.Drawing.Point(872, 70);
            this.likedPagesViewer.Name = "likedPagesViewer";
            this.likedPagesViewer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.likedPagesViewer.Size = new System.Drawing.Size(253, 386);
            this.likedPagesViewer.TabIndex = 0;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(565, 12);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(100, 89);
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButton.BackgroundImage")));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.Location = new System.Drawing.Point(525, 29);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(174, 43);
            this.loginButton.TabIndex = 0;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutButton.BackgroundImage")));
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Location = new System.Drawing.Point(12, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(102, 95);
            this.logoutButton.TabIndex = 18;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLable.Location = new System.Drawing.Point(666, 47);
            this.nameLable.Name = "nameLable";
            this.nameLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameLable.Size = new System.Drawing.Size(75, 25);
            this.nameLable.TabIndex = 19;
            this.nameLable.Text = "label4";
            this.nameLable.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1187, 725);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.TabsWindow);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.loginButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.TabsWindow.ResumeLayout(false);
            this.FacebookPlayerTab.ResumeLayout(false);
            this.ProfilePicturePickerTab.ResumeLayout(false);
            this.existFecherTab.ResumeLayout(false);
            this.existFecherTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.TabControl TabsWindow;
        private System.Windows.Forms.TabPage FacebookPlayerTab;
        private System.Windows.Forms.TabPage ProfilePicturePickerTab;
        private System.Windows.Forms.TabPage existFecherTab;
        private ProfilePicturePicker.ProfilePicturePickerController profilePicturePickerTab1;
        private LikedPages.LikedPagesController likedPagesViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FriendsBirthday.FriendsBirthdayController birthdaysController;
        private System.Windows.Forms.Label label3;
        private PostStatus.PostSatusController postSatusController;
        private System.Windows.Forms.Button logoutButton;
        private FacebookPlayerController facebookPlayerController;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.ListBox checkInListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label label4;
    }
}