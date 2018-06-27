using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace ProfilePicturePicker
{
    public partial class ProfilePicturePickerController : UserControl
    {
        private User m_LoggedInUser;

        public ProfilePicturePickerController()
        {
            InitializeComponent();
        }

        public void LoadProfilePicturePicker(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            setAlbumsToAlbumViewer();
        }

        private void setAlbumsToAlbumViewer()
        {
            try
            {
                new Thread(fetchAlbums).Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show("לא ניתן לפתוח אלבומים" + ex.Message);
            }
        }

        private void fetchAlbums()
        {
            albumViewer.Albums = m_LoggedInUser.Albums;
        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            List<PhotoWrapper> selectedPhotos = albumViewer.GetSelectedPhotos();
            int howManyAreSelected = selectedPhotos.Count;
            if (howManyAreSelected == 0)
            {
                MessageBox.Show("לא נבחרו תמונות!");
            }
            else if (howManyAreSelected + photosToUpload.HowManyPhotos > 5)
            {
                MessageBox.Show("עלייך לבחור 5 תמונות סך הכל!");
            }
            else
            {
                addPhotos(selectedPhotos);
            }
        }

        private void addPhotos(List<PhotoWrapper> i_SelectedPhotos)
        {
            foreach (PhotoWrapper fbPhoto in i_SelectedPhotos)
            {
                photosToUpload.AddPhoto(fbPhoto);
            }

            albumViewer.ClearSelectedPhotos();
            if (photosToUpload.HowManyPhotos == 5)
            {
                CreatAlbumButton.Visible = true;
            }
        }

        private void creatAlbumButton_Click(object sender, EventArgs e)
        {
            Album newAlbum = m_LoggedInUser.CreateAlbum("עזרו לי למצוא תמונת פרופיל חדשה! " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), "תנו Like לתמונה שאהבתם!", @"{value: ""EVERYONE""}");
            foreach (byte[] photoToUpload in photosToUpload.GetAllPhotos())
            {
                newAlbum.UploadPhoto(photoToUpload, "תעזרו לי לבחור!");
            }

            m_LoggedInUser.ReFetch();
            setAlbumsToAlbumViewer();
            MessageBox.Show("האלבום נוצר בהצלחה!");
            CreatAlbumButton.Visible = false;
            photosToUpload.ClearPhotos();
        }

        private void createAlbum()
        {
            Album newAlbum = m_LoggedInUser.CreateAlbum("עזרו לי למצוא תמונת פרופיל חדשה! " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), "תנו Like לתמונה שאהבתם!", @"{value: ""EVERYONE""}");
            foreach (byte[] photoToUpload in photosToUpload.GetAllPhotos())
            {
                newAlbum.UploadPhoto(photoToUpload);
            }

            m_LoggedInUser.ReFetch();
            setAlbumsToAlbumViewer();
            MessageBox.Show("האלבום נוצר בהצלחה!");
            CreatAlbumButton.Visible = false;
            photosToUpload.ClearPhotos();
        }
    }
}
