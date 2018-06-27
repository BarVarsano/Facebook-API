using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ProfilePicturePicker
{
    public partial class PhotosToUploadController : UserControl
    {
        private const int k_NumberOfPhotos = 5;
        private int m_HowManyPhotos;
        private PhotoWrapper[] m_Photos;
        private PictureBox[] m_picturBoxs;

        public PhotosToUploadController()
        {
            InitializeComponent();
            ClearPhotos();
            setPictureBoxes();
        }

        private void setPictureBoxes()
        {
            m_picturBoxs = new PictureBox[k_NumberOfPhotos];
            m_picturBoxs[0] = selectedPictureBox1;
            m_picturBoxs[1] = selectedPictureBox2;
            m_picturBoxs[2] = selectedPictureBox3;
            m_picturBoxs[3] = selectedPictureBox4;
            m_picturBoxs[4] = selectedPictureBox5;
        }

        public void AddPhoto(PhotoWrapper i_Photo)
        {
            if (m_HowManyPhotos == 5) 
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                m_Photos[m_HowManyPhotos] = i_Photo;
                m_picturBoxs[m_HowManyPhotos].Visible = true;
                m_picturBoxs[m_HowManyPhotos++].Image = i_Photo.ResizedImage;
            }
        }

        public int HowManyPhotos
        {
            get
            {
                return m_HowManyPhotos;
            }
        }

        public List<byte[]> GetAllPhotos()
        {
            List<byte[]> photos = null;

            if(m_HowManyPhotos == k_NumberOfPhotos)
            {
                photos = new List<byte[]>();
                for (int i = 0; i < k_NumberOfPhotos; i++)
                {
                    photos.Add(imageToByteArray(m_Photos[i].GetNormalImage()));
                }
            }

            return photos;
        }

        private byte[] imageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        public void ClearPhotos()
        {
            m_HowManyPhotos = 0;
            m_Photos = new PhotoWrapper[k_NumberOfPhotos];
        }
    }
}
