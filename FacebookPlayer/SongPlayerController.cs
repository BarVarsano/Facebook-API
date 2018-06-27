using System;
using System.Windows.Forms;
using FacebookPlayerLogics;

namespace FacebookPlayer
{
    public partial class SongPlayerController : UserControl
    {
        private IPlayerComponent m_CurrentSong;

        public SongPlayerController()
        {
            InitializeComponent();
            mediaPlayer.WebBrowserShortcutsEnabled = false;
        }

        public void Stop()
        {
            mediaPlayer.Url = new Uri("https://www.google.co.il/");
        }

        public void Play(IPlayerComponent i_NewSong)
        {
            bool isVideoMode = i_NewSong.Mode == eSongMode.Video;

            m_CurrentSong = i_NewSong;
            showMode(isVideoMode);
            showMinimalSongInfo();
            showSongAddOnsInfo();
        }

        public IPlayerComponent GetCurrentSong()
        {
            return m_CurrentSong;
        }

        private void showMode(bool i_IsVideo)
        {
            VideoPictureBox.Visible = !i_IsVideo;
            mediaPlayer.Visible = i_IsVideo;
            switchToVideoButton.Visible = !i_IsVideo;
            switchToAudioButton.Visible = i_IsVideo;
        }

        private void showMinimalSongInfo()
        {
            songNameTextBox.Text = m_CurrentSong.Name;
            mediaPlayer.Url = new Uri(m_CurrentSong.URL);
        }

        private void showSongAddOnsInfo()
        {
            FacebookSharedSong fss = m_CurrentSong as FacebookSharedSong;
            if (fss != null)
            {
                showFacebookSharedSongInfo(fss);
            }
            else
            {
                showFacebookInfoControllers(false);
            }
        }

        private void showFacebookSharedSongInfo(FacebookSharedSong i_FacebookSharedSong)
        {
            showFacebookInfoControllers(true);
            CommentsNumberLable.Text = i_FacebookSharedSong.NumberOfComments.ToString();
            LikesNumberLabel.Text = i_FacebookSharedSong.NumberOfLikes.ToString();
            if (i_FacebookSharedSong.UploadedDate.HasValue)
            {
                uploadDateLable.Text = i_FacebookSharedSong.UploadedDate.HasValue ? i_FacebookSharedSong.UploadedDate.Value.ToShortDateString() : "לא זמין";
            }
        }

        private void showFacebookInfoControllers(bool i_isFacebookInfo)
        {
            uploadDateLable.Visible = i_isFacebookInfo;
            CommentsNumberLable.Visible = i_isFacebookInfo;
            LikesNumberLabel.Visible = i_isFacebookInfo;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.Refresh();
        }

        private void switchToAudioButton_Click(object sender, EventArgs e)
        {
            showMode(false);
            m_CurrentSong.Mode = eSongMode.Audio;
            mediaPlayer.Url = new Uri(m_CurrentSong.URL);
        }

        private void switchToVideoButton_Click(object sender, EventArgs e)
        {
            showMode(true);
            m_CurrentSong.Mode = eSongMode.Video;
            mediaPlayer.Url = new Uri(m_CurrentSong.URL);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.Refresh();
            mediaPlayer.Stop();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Stop();
        }
    }
}
