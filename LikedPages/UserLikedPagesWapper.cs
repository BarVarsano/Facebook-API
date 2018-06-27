using System;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace LikedPages
{
    public class UserLikedPagesWrapper
    {
        private string m_Name;
        private Image m_ImageSmall;

        public UserLikedPagesWrapper(Page i_LikePage)
        {
            m_Name = i_LikePage.Name;
            m_ImageSmall = i_LikePage.ImageSmall;
        }

        public Image PageImage
        {
            get
            {
                return m_ImageSmall;
            }
        }

        public string NamePage
        {
            get
            {
                return m_Name;
            }
        }
    }
}
