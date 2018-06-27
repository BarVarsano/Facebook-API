using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPlayerLogics
{
    public class PlayList : IPlayerComponent
    {
        public event Action<IPlayerComponent> OnComponentAdded;

        public event Action<IPlayerComponent> OnComponentRemoved;

        private string m_PlaylistName;
        private BindingList<IPlayerComponent> m_PlayListComponents;

        public PlayList(string i_PlayListName)
        {
            m_PlaylistName = i_PlayListName;
            m_PlayListComponents = new BindingList<IPlayerComponent>();
        }

        public string Name
        {
            get
            {
                return m_PlaylistName;
            }
        }

        public eSongMode Mode
        {
            get
            {
                throw new GetModeException("Playlist doesnt have mode!");
            }

            set
            {
                throw new GetURLException("Playlist doesnt have mode!");
            }
        }

        public string URL
        {
            get
            {
                throw new GetURLException("Playlist doesnt have URL!");
            }
        }

        public void AddComponent(IPlayerComponent i_ComponentToAdd)
        {
            m_PlayListComponents.Add(i_ComponentToAdd);
            OnComponentAdded.Invoke(i_ComponentToAdd);
        }
        
        public void RemoveComponent(IPlayerComponent i_ComponentToRemove)
        {
            m_PlayListComponents.Remove(i_ComponentToRemove);
            OnComponentRemoved.Invoke(i_ComponentToRemove);
        }

        public bool IsContains(IPlayerComponent i_Component)
        {
            bool isContains = false;
            if (this == i_Component)
            {
                isContains = true;
            }
            else
            {
                foreach (IPlayerComponent component in m_PlayListComponents)
                {
                    if (component.IsContains(i_Component))
                    {
                        isContains = true;
                        break;
                    }
                }
            }

            return isContains;
        }
    }
}
