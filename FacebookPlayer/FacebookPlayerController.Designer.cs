namespace FacebookPlayer
{
    public partial class FacebookPlayerController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookPlayerController));
            this.allSongsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eraseButton = new System.Windows.Forms.Button();
            this.addNewPlaylistButton = new System.Windows.Forms.Button();
            this.playListNameTextBox = new System.Windows.Forms.TextBox();
            this.PlayListTreeViewer = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.SongsPlayer = new FacebookPlayer.SongPlayerController();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // allSongsListBox
            // 
            this.allSongsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.allSongsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allSongsListBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.allSongsListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.allSongsListBox.FormattingEnabled = true;
            this.allSongsListBox.Location = new System.Drawing.Point(293, 52);
            this.allSongsListBox.Name = "allSongsListBox";
            this.allSongsListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allSongsListBox.Size = new System.Drawing.Size(866, 91);
            this.allSongsListBox.TabIndex = 17;
            this.allSongsListBox.DoubleClick += new System.EventHandler(this.allSongsListBox_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1024, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "השירים שלי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(109, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "רשימות השמעה";
            // 
            // eraseButton
            // 
            this.eraseButton.BackColor = System.Drawing.Color.Transparent;
            this.eraseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraseButton.BackgroundImage")));
            this.eraseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraseButton.FlatAppearance.BorderSize = 0;
            this.eraseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.eraseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraseButton.Location = new System.Drawing.Point(-6, -2);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(52, 45);
            this.eraseButton.TabIndex = 23;
            this.eraseButton.UseVisualStyleBackColor = false;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // addNewPlaylistButton
            // 
            this.addNewPlaylistButton.BackColor = System.Drawing.Color.Transparent;
            this.addNewPlaylistButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNewPlaylistButton.BackgroundImage")));
            this.addNewPlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewPlaylistButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addNewPlaylistButton.FlatAppearance.BorderSize = 0;
            this.addNewPlaylistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.addNewPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewPlaylistButton.Location = new System.Drawing.Point(0, 0);
            this.addNewPlaylistButton.Name = "addNewPlaylistButton";
            this.addNewPlaylistButton.Size = new System.Drawing.Size(40, 38);
            this.addNewPlaylistButton.TabIndex = 25;
            this.addNewPlaylistButton.UseVisualStyleBackColor = false;
            this.addNewPlaylistButton.Click += new System.EventHandler(this.addNewPlaylistButton_Click);
            // 
            // playListNameTextBox
            // 
            this.playListNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(99)))), ((int)(((byte)(155)))));
            this.playListNameTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.playListNameTextBox.ForeColor = System.Drawing.Color.White;
            this.playListNameTextBox.Location = new System.Drawing.Point(46, 18);
            this.playListNameTextBox.Name = "playListNameTextBox";
            this.playListNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playListNameTextBox.Size = new System.Drawing.Size(238, 21);
            this.playListNameTextBox.TabIndex = 26;
            this.playListNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PlayListTreeViewer
            // 
            this.PlayListTreeViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.PlayListTreeViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayListTreeViewer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PlayListTreeViewer.ForeColor = System.Drawing.SystemColors.Info;
            this.PlayListTreeViewer.HideSelection = false;
            this.PlayListTreeViewer.Location = new System.Drawing.Point(0, 149);
            this.PlayListTreeViewer.Name = "PlayListTreeViewer";
            this.PlayListTreeViewer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PlayListTreeViewer.RightToLeftLayout = true;
            this.PlayListTreeViewer.Scrollable = false;
            this.PlayListTreeViewer.Size = new System.Drawing.Size(287, 417);
            this.PlayListTreeViewer.TabIndex = 27;
            this.PlayListTreeViewer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlayListTreeViewer_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(106, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "הוסף רשימת השמעה חדשה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(462, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(697, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "בחר רשימת השמעה אליה תרצה להוסיף שיר ולחץ עליו פעמיים,להפעלת השיר לחץ עליו פעמיים" +
    " ברשימת ההשמעה";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.playListNameTextBox);
            this.panel1.Controls.Add(this.addNewPlaylistButton);
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 42);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.eraseButton);
            this.panel2.Location = new System.Drawing.Point(1, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 42);
            this.panel2.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(89, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "בחר שיר או רשימה ומחק אותה";
            // 
            // SongsPlayer
            // 
            this.SongsPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.SongsPlayer.Location = new System.Drawing.Point(293, 149);
            this.SongsPlayer.Name = "SongsPlayer";
            this.SongsPlayer.Size = new System.Drawing.Size(866, 417);
            this.SongsPlayer.TabIndex = 19;
            this.SongsPlayer.Visible = false;
            // 
            // FacebookPlayerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PlayListTreeViewer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SongsPlayer);
            this.Controls.Add(this.allSongsListBox);
            this.Controls.Add(this.label1);
            this.Name = "FacebookPlayerController";
            this.Size = new System.Drawing.Size(1163, 585);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SongPlayerController SongsPlayer;
        private System.Windows.Forms.ListBox allSongsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.Button addNewPlaylistButton;
        private System.Windows.Forms.TextBox playListNameTextBox;
        private System.Windows.Forms.TreeView PlayListTreeViewer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}
