using System;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace ProfilePicturePicker
{
    public partial class AlbumViewerController : UserControl
    {
        private FacebookObjectCollection<Album> m_Albums;
        private Thread m_LoadAlbumsPhotosThread;

        public AlbumViewerController()
        {
            InitializeComponent();
        }

        public List<PhotoWrapper> GetSelectedPhotos()
        {
            return photosSelector.GetSelectedPhotos();
        }

        public void ClearSelectedPhotos()
        {
            photosSelector.ClearSelectedPhotos();
        }

        public FacebookObjectCollection<Album> Albums
        {
            set
            {
                albumsComboBox.Invoke(new Action(() =>
                {
                    m_Albums = value;
                    albumsComboBox.DataSource = m_Albums;
                    albumsComboBox.DisplayMember = "Name";
                }));
            }
        }

        private void albumsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (m_LoadAlbumsPhotosThread != null && m_LoadAlbumsPhotosThread.ThreadState.Equals(ThreadState.Running))
            {
                m_LoadAlbumsPhotosThread.Abort();
            }

            m_LoadAlbumsPhotosThread = new Thread(setPhotosToPhotosSelector);
            m_LoadAlbumsPhotosThread.Start();
        }

        private void setPhotosToPhotosSelector()
        {
            Album selectedAlbum = null;
            albumsComboBox.Invoke(new Action(() => { selectedAlbum = albumsComboBox.SelectedItem as Album; }));
            
            if (selectedAlbum != null)
            {
                photosSelector.SetPhotos = selectedAlbum.Photos;
            }
            else
            {
                throw new Exception("לא נמצא אלבום!");
            }
        }
           
        private void orderByLikesButton_Click(object sender, EventArgs e)
        {
            photosSelector.SortingStrategy = (p1, p2) => p1.LikesCount < p2.LikesCount;
            photosSelector.Sort();
        }

        private void orderByCommentsButton_Click(object sender, EventArgs e)
        {
            photosSelector.SortingStrategy = (p1, p2) => p1.CommentsCount < p2.CommentsCount;
            photosSelector.Sort();
        }

        private void orderByTimeButton_Click(object sender, EventArgs e)
        {
            photosSelector.SortingStrategy = (p1, p2) => p1.CreatedTime().CompareTo(p2.CreatedTime()) < 0;
            photosSelector.Sort();
        }
    }
}
