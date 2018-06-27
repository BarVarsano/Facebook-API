using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace PostStatus
{
    public partial class PostSatusController : UserControl
    {
        private User m_LoggedInUser = null;

        public PostSatusController()
        {
            InitializeComponent();
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser == null)
            {
                throw new Exception("לא הוכנס משתמש!");
            }
            else
            {
                try
                {
                    m_LoggedInUser.PostStatus(postTextBox.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }

        public void LoadUserInfo(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            try
            {
                profilePictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
            }
            catch(Exception ex)
            {
                MessageBox.Show("לא מצליח לטעון תמונה" + ex.Message);
            }
        }
    }
}
