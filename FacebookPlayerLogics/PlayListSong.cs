using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPlayerLogics
{
    public abstract class PlayListSong : IPlayerComponent
    {
        protected string m_SongName;
        private URLSong m_SongURL;
        private eSongMode m_CurrentMode;

        public event Action<IPlayerComponent> OnComponentAdded;

        public event Action<IPlayerComponent> OnComponentRemoved;

        public PlayListSong(string i_URL)
        {
            m_SongURL = URLSongFactory.CreateURLSong(i_URL);

            if (m_SongURL == null)
            {
                throw new Exception("The app doesnt support this kind of links: " + i_URL);
            }

            m_CurrentMode = eSongMode.Video;
        }

        public string Name
        {
            get
            {
                return m_SongName;
            }

            set
            {
                m_SongName = value;
            }
        }

        public eSongMode Mode
        {
            get
            {
                return m_CurrentMode;
            }

            set
            {
                m_CurrentMode = value;
            }
        }

        public string URL
        {
            get
            {
                return m_CurrentMode == eSongMode.Audio ? m_SongURL.AudioURL : m_SongURL.VideoURL;
            }
        }

        public void AddComponent(IPlayerComponent i_ComponentToAdd)
        {
            throw new AddComponentException("Can not add to a Song");
        }

        public void RemoveComponent(IPlayerComponent i_ComponentToRemove)
        {
            throw new RemoveComponentException("Can not remove from a Song");
        }

        public bool IsContains(IPlayerComponent i_Component)
        {
            bool isContains = false;

            if (this == i_Component)
            {
                isContains = true;
            }

            return isContains;
        }
    }
}
