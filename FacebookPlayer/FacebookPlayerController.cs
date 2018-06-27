using System;
using System.ComponentModel;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookPlayerLogics;

namespace FacebookPlayer
{
    public partial class FacebookPlayerController : UserControl
    {
        private const string k_AddSongErrorMessage = "לא ניתן להוסיף שיר בתוך שיר,בחר רשימה";
        private const string k_AddPlaylistErrorMessage = "לא ניתן להוסיף רשימה בתוך שיר,בחר רשימה";
        private BindingList<PlayListSong> m_Songs;
        private PlayList m_UsersPlaylist;

        public FacebookPlayerController()
        {
            InitializeComponent();
            eraseButton.BringToFront();
            createPlaylist();
            m_Songs = new BindingList<PlayListSong>();
            allSongsListBox.DataSource = m_Songs;
            allSongsListBox.DisplayMember = "Name";
        }

        private void createPlaylist()
        {
            m_UsersPlaylist = new PlayList("רשימת ההשמעה שלי");
            TreeNodeProxy m_UsersPlaylistnode = new TreeNodeProxy(m_UsersPlaylist.Name) { Tag = m_UsersPlaylist };
            PlayListTreeViewer.Nodes.Add(m_UsersPlaylistnode);
        }

        private void facebookPlayerTab_Enter(object sender, EventArgs e)
        {
        }

        public void LoadSongs(FacebookObjectCollection<Link> i_PostedLinks)
        {
            PlayListSong currentSong;
            foreach (Link link in i_PostedLinks)
            {
                if (link.URL != null)
                {
                    try
                    {
                        currentSong = new FacebookSharedSong(link);
                        allSongsListBox.Invoke(new Action(() => { m_Songs.Add(currentSong); }));
                    }
                    catch
                    {
                        ///in case cant create do nothing
                    }
                }
            }
        }

        public void StopPlaying()
        {
            SongsPlayer.Stop();
        }

        public void ContinuePlaying()
        {
            if (PlayListTreeViewer.SelectedNode != null)
            {
                PlayListSong song = PlayListTreeViewer.SelectedNode.Tag as PlayListSong;
                if (song != null)
                {
                    SongsPlayer.Play(song);
                    SongsPlayer.Visible = true;
                }
            }
        }

        private void addNewPlaylistButton_Click(object sender, EventArgs e)
        {
            string newPlayListName = playListNameTextBox.Text;

            if (!string.IsNullOrEmpty(newPlayListName))
            {
                CheckSelectedAndAdd(new PlayList(newPlayListName), k_AddPlaylistErrorMessage);
            }
            else
            {
                ShowMessageBox("עלייך להכניס לפחות תו אחד!");
                playListNameTextBox.Focus();
            }
        }

        private void allSongsListBox_DoubleClick(object sender, EventArgs e)
        {
            CheckSelectedAndAdd((IPlayerComponent)allSongsListBox.SelectedItem, k_AddSongErrorMessage);
        }

        private void CheckSelectedAndAdd(IPlayerComponent i_ComponentToAdd, string k_ErrorMessage)
        {
            if (PlayListTreeViewer.SelectedNode != null)
            {
                addIPlayComponentToPlayList(i_ComponentToAdd, (IPlayerComponent)PlayListTreeViewer.SelectedNode.Tag, k_ErrorMessage);
                playListNameTextBox.Text = string.Empty;
            }
            else
            {
                ShowMessageBox("עלייך לבחור לאן להוסיף!");
            }
        }

        private void addIPlayComponentToPlayList(IPlayerComponent ComponentToAdd, IPlayerComponent selectedPlaylist, string errorMessage)
        {
            try
            {
                selectedPlaylist.AddComponent(ComponentToAdd);
            }
            catch (AddComponentException)
            {
                ShowMessageBox(errorMessage);
            }
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            IPlayerComponent componentToRemoveFrom;
            IPlayerComponent componentToRemove;

            if (PlayListTreeViewer.SelectedNode != null)
            {
                if (PlayListTreeViewer.SelectedNode.Parent != null)
                {
                    componentToRemoveFrom = (IPlayerComponent)PlayListTreeViewer.SelectedNode.Parent.Tag;
                    componentToRemove = (IPlayerComponent)PlayListTreeViewer.SelectedNode.Tag;
                    if (componentToRemove.IsContains(SongsPlayer.GetCurrentSong()))
                    {
                        SongsPlayer.Stop();
                        SongsPlayer.Visible = false;
                    }

                    componentToRemoveFrom.RemoveComponent(componentToRemove);
                }
                else
                {
                    ShowMessageBox("לא ניתן למחוק את כל הרשימות");
                }
            }
            else
            {
                ShowMessageBox("עלייך לבחור מה למחוק");
            }
        }

        private void PlayListTreeViewer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IPlayerComponent song = PlayListTreeViewer.SelectedNode.Tag as IPlayerComponent;
            try
            {
                SongsPlayer.Play(song);
                if (SongsPlayer.Visible == false)
                {
                    SongsPlayer.Visible = true;
                }
            }
            catch(GetModeException)
            {
                ShowMessageBox("עלייך לבחור שיר!");
            }
        }

        private void ShowMessageBox(string i_Message)
        {
            MessageBox.Show(i_Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }
    }
}
