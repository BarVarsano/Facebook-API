using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApplication
{
    public partial class MainForm : Form
    {
        private User m_LoggedInUser;
        private LoginResult m_Result;
        private bool m_IsProfilePicturePickerTabEntered = false;
        private bool m_IsFacebookPlayerTabEntered = false;
        private bool m_IsExistFechersTabEntered = false;

        public MainForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_Result = FacebookService.Login(
                "1943925395885587",
                "public_profile",
                "user_friends",
                "publish_actions",
                "user_photos",
                "user_posts",
                "publish_actions",
                "user_likes",
                "user_birthday");

                if (!string.IsNullOrEmpty(m_Result.AccessToken))
                {
                    m_LoggedInUser = m_Result.LoggedInUser;
                    fetchUserInfo();
                    setLogedInUserVisibleControllers(true);
                }
                else
                {
                    MessageBox.Show(m_Result.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("לא הצליח להתחבר:" + ex.Message);
            }
        }

        private void fetchUserInfo()
        {
            try
            {
                nameLable.Text = "שלום " + m_LoggedInUser.FirstName + "!";
                profilePictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                FacebookService.Logout(onLogout);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void onLogout()
        {
            setLogedInUserVisibleControllers(false);
        }

        private void setLogedInUserVisibleControllers(bool i_IsLoggedIn)
        {
            nameLable.Visible = i_IsLoggedIn;
            TabsWindow.Visible = i_IsLoggedIn;
            loginButton.Visible = !i_IsLoggedIn;
            logoutButton.Visible = i_IsLoggedIn;
            profilePictureBox.Visible = i_IsLoggedIn;
        }

        private void loadFacebookPlayerController()
        {
            try
            {
                facebookPlayerController.LoadSongs(m_LoggedInUser.PostedLinks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("בעיה בטעינת הנגן:" + ex.Message);
            }
        }

        private void facebookPlayerTab_Enter(object sender, EventArgs e)
        {
            if (!m_IsFacebookPlayerTabEntered)
            {
                m_IsFacebookPlayerTabEntered = true;
                new Thread(loadFacebookPlayerController).Start();
            }
            else
            {
                facebookPlayerController.ContinuePlaying();
            }
        }

        private void facebookPlayerTab_Leave(object sender, EventArgs e)
        {
            facebookPlayerController.StopPlaying();
        }

        private void profilePicturePickerTab_Enter(object sender, EventArgs e)
        {
            if (!m_IsProfilePicturePickerTabEntered)
            {
                m_IsProfilePicturePickerTabEntered = true;
                loadProfilePicturePickerTab();
            }
        }

        private void loadProfilePicturePickerTab()
        {
            try
            {
                profilePicturePickerTab1.LoadProfilePicturePicker(m_LoggedInUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("בעיה בטעינת בחירת תמונת הפרופיל" + ex.Message);
            }
        }

        private void existFechersTab_Enter(object sender, EventArgs e)
        {
            if (!m_IsExistFechersTabEntered)
            {
                m_IsExistFechersTabEntered = true;

                new Thread(loadLikedPages).Start();
                new Thread(loadBirthdays).Start();
                new Thread(loadPostSatuse).Start();
                new Thread(loadAppriends).Start();
            }
        }

        private void loadLikedPages()
        {
            try
            {
                likedPagesViewer.LoadPages(m_LoggedInUser.LikedPages);
            }
            catch (Exception)
            {
              ///  MessageBox.Show("בעיה בטעינת דפים שאהבתי" + ex.Message);
            }
        }

        private void loadBirthdays()
        {
            try
            {
                birthdaysController.LoadBirthdays(m_LoggedInUser.Friends);
            }
            catch (Exception ex)
            {
                MessageBox.Show("בעיה בטעינת ימי הולדת של חברים" + ex.Message);
            }
        }

        private void loadPostSatuse()
        {
            try
            {
                postSatusController.LoadUserInfo(m_LoggedInUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("בעיה בטעינת פרסום פוסט:" + ex.Message);
            }
        }

        private void loadAppriends()
        {
            userBindingSource.DataSource = m_LoggedInUser.Friends;
        }
    }
}
