using System;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace LikedPages
{
    public partial class LikedPagesController : UserControl
    {
        private BindingList<UserLikedPagesWrapper> m_Pages;

        public LikedPagesController()
        {
            InitializeComponent();
            m_Pages = new BindingList<UserLikedPagesWrapper>();
            likedPagesDataGridView.DataSource = m_Pages;
        }

        public void LoadPages(FacebookObjectCollection<Page> i_Pages)
        {
            UserLikedPagesWrapper current;
            foreach (Page userPage in i_Pages)
            {
                try
                {
                    current = new UserLikedPagesWrapper(userPage);
                    likedPagesDataGridView.Invoke(new Action(() =>
                    {
                        m_Pages.Add(current);
                    }));
                }
                catch
                {
                }
            }
        }

        private void likedPagesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }
    }
}
