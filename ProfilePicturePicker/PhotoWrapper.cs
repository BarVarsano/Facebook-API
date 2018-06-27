using System;
using System.Drawing;
using System.Drawing.Imaging;
using FacebookWrapper.ObjectModel;

namespace ProfilePicturePicker
{
    public class PhotoWrapper
    {
        private readonly DateTime r_defaultDate = new DateTime(1900, 1, 1);
        private Photo m_Photo;
        private Image m_ResizedImage;
        private bool m_IsSelected;

        public PhotoWrapper(Photo i_Photo, int i_Size)
        {
            m_IsSelected = false;
            m_Photo = i_Photo;
            m_ResizedImage = resizeImage(i_Size, i_Size, m_Photo.ImageNormal);
        }

        public bool IsSelected
        {
            get
            {
                return m_IsSelected;
            }

            set
            {
                m_IsSelected = value;
            }
        }

        public Image ResizedImage
        {
            get
            {
                return m_ResizedImage;
            }
        }

        public Image GetNormalImage()
        {
            return m_Photo.ImageNormal;
        }
        
        public DateTime CreatedTime()
        {
            return m_Photo.CreatedTime.HasValue ? m_Photo.CreatedTime.Value : r_defaultDate;
        }

        public int CommentsCount
        {
            get
            {
                return m_Photo.Comments.Count;
            }
        }

        public int LikesCount
        {
            get
            {
                return m_Photo.LikedBy.Count;
            }
        }

        private Image resizeImage(int newWidth, int newHeight, Image imgToResize)
        {
            Image imgPhoto = new Bitmap(imgToResize);
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            if (sourceWidth < sourceHeight)
            {
                int buff = newWidth;

                newWidth = newHeight;
                newHeight = buff;
            }

            int sourceX = 0, sourceY = 0, destX = 0, destY = 0;
            float nPercent = 0, nPercentW = 0, nPercentH = 0;
            nPercentW = (float)newWidth / (float)sourceWidth;
            nPercentH = (float)newHeight / (float)sourceHeight;
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((newWidth - (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((newHeight - (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap bmPhoto = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Black);
            grPhoto.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            grPhoto.DrawImage(imgPhoto, new Rectangle(destX, destY, destWidth, destHeight), new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight), GraphicsUnit.Pixel);
            grPhoto.Dispose();
            return bmPhoto;
        }
    }
}
