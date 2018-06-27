using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FriendsBirthday
{
    public class UserBirthdayWapprer
    {
        private User m_User;

        public UserBirthdayWapprer(User i_User)
        {
            m_User = i_User;
        }

        public Image ImageNormal
        {
            get
            {
                return m_User.ImageNormal;
            }
        }

        public string UserName
        {
            get
            {
                return m_User.Name;
            }
        }

        public string BirthDay
        {
            get
            {
                return m_User.Birthday;
            }
        }
    }
}
