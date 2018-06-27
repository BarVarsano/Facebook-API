using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace ProfilePicturePicker
{
    public partial class PhotosSelectorController : UserControl
    {
        private BindingList<PhotoWrapper> m_Photos;

        public Func<PhotoWrapper, PhotoWrapper, bool> SortingStrategy { private get; set; }

        public PhotosSelectorController()
        {
            InitializeComponent();
            m_Photos = new BindingList<PhotoWrapper>();
            SortingStrategy = null;
            photosDataGridView.DataSource = m_Photos;
            setPhotosDataGridViewColumnsHeaders();
        }

        private void setPhotosDataGridViewColumnsHeaders()
        {
            photosDataGridView.Columns["LikesCount"].Width = 60;
            photosDataGridView.Columns["LikesCount"].HeaderText = "Likes";
            photosDataGridView.Columns["CommentsCount"].Width = 60;
            photosDataGridView.Columns["CommentsCount"].HeaderText = "Comments";
            photosDataGridView.Columns["ResizedImage"].Width = 150;
            photosDataGridView.Columns["ResizedImage"].HeaderText = "תמונה";
            photosDataGridView.Columns["IsSelected"].Width = 30;
            photosDataGridView.Columns["IsSelected"].HeaderText = "בחר";
        }

        public FacebookObjectCollection<Photo> SetPhotos
        {
            set
            {
                PhotoWrapper current;
                photosDataGridView.Invoke(new Action(() => { m_Photos.Clear(); }));

                foreach (Photo photo in value)
                {
                    current = new PhotoWrapper(photo, 150);
                    photosDataGridView.Invoke(new Action(() => { m_Photos.Add(current); }));
                }
            }
        }

        public void ClearSelectedPhotos()
        {
            foreach (PhotoWrapper photo in m_Photos)
            {
                if (photo.IsSelected)
                {
                    photo.IsSelected = false;
                }
            }

            photosDataGridView.Refresh();
        }

        public List<PhotoWrapper> GetSelectedPhotos()
        {
            List<PhotoWrapper> photos = new List<PhotoWrapper>();

            foreach (PhotoWrapper photo in m_Photos)
            {
                if(photo.IsSelected)
                {
                    photos.Add(photo);
                }
            }

            return photos;
        }

        public void Sort()
        {
            PhotoWrapper temp;

            for (int x = 0; x < m_Photos.Count; x++)
            {
                for (int y = 0; y < m_Photos.Count - 1; y++)

                {
                    if (SortingStrategy.Invoke(m_Photos[y], m_Photos[y + 1]))
                    {
                        temp = m_Photos[y];
                        m_Photos[y] = m_Photos[y + 1];
                        m_Photos[y + 1] = temp;
                    }
                }
            }
        }
    }
}
