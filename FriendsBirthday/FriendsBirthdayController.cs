using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FriendsBirthday
{
    public partial class FriendsBirthdayController : UserControl
    {
        private BindingList<UserBirthdayWapprer> m_Friends;

        public FriendsBirthdayController()
        {
            InitializeComponent();
            m_Friends = new BindingList<UserBirthdayWapprer>();
            birthDaysDataGridView.DataSource = m_Friends;
        }

        public void LoadBirthdays(FacebookObjectCollection<User> i_Friends)
        {
            string[] formats = { "MM/dd/yyyy" };
            DateTime currentDateTime = DateTime.Now;
            DateTime currentFriendBirthday;
            
            foreach (User friend in i_Friends)
            {
                if (friend.Birthday != null && DateTime.TryParseExact(friend.Birthday, formats, new System.Globalization.CultureInfo("en-US"), System.Globalization.DateTimeStyles.None, out currentFriendBirthday))
                {
                    currentFriendBirthday = currentFriendBirthday.AddYears(currentDateTime.Year - currentFriendBirthday.Year);
                    if (isInTheNextWeek(currentFriendBirthday))
                    {
                        birthDaysDataGridView.Invoke(new Action(() => m_Friends.Add(new UserBirthdayWapprer(friend))));
                    }
                }
            }

            if (m_Friends.Count == 0)
            {
                MessageBox.Show("לאף חבר אין יום הולדת השבוע :(");
            }
        }

        private bool isInTheNextWeek(DateTime currentFriendBirthday)
        {
            return currentFriendBirthday.CompareTo(DateTime.Now) >= 0 &&
                   currentFriendBirthday.CompareTo(DateTime.Now.AddDays(7)) <= 0;
        }
    }
}
