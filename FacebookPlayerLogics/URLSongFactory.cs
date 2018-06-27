using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPlayerLogics
{
    public static class URLSongFactory
    {
        public static URLSong CreateURLSong(string i_URL)
        {
            URLSong newSong = null;

            if (i_URL.Contains("youtube"))
            {
                newSong = new YoutubeSong(i_URL);
            }
            else if (i_URL.Contains("soundcloud"))
            {
                newSong = new SoundCloudSong(i_URL);
            }
            else if (i_URL.Contains("vimeo"))
            {
                newSong = new VimeoSong(i_URL);
            }

            return newSong;
        }
    }
}
