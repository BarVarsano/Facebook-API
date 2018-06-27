using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookPlayerLogics
{
    public class FacebookSharedSong : PlayListSong
    {
        private Link m_FacebookSongLink; 

        public FacebookSharedSong(Link i_FacebookSongLink) : base(i_FacebookSongLink.URL)
        {
            m_SongName = i_FacebookSongLink.Name;
            m_FacebookSongLink = i_FacebookSongLink;
        }
        
        public DateTime? UploadedDate
        {
            get
            {
                return m_FacebookSongLink.CreatedTime;
            }
        }

        public int NumberOfComments
        {
            get
            {
                return m_FacebookSongLink.Comments.Count;
            }
        }

        public int NumberOfLikes
        {
            get
            {
                return m_FacebookSongLink.LikedBy.Count;
            }
        }
    }
}
