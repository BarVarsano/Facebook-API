﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPlayerLogics
{
    public class SoundCloudSong : URLSong
    {
        public SoundCloudSong(string i_URL) : base(i_URL)
        {
        }

        public override bool IsValidURL(string i_URL)
        {
            return i_URL.Contains("https://soundcloud.com/");
        }

        protected override string parseToAudio(string i_URL)
        {
            return i_URL;
        }

        protected override string parseToVideo(string i_URL)
        {
            return @"https://w.soundcloud.com/player/?url=" + i_URL + @"&amp;auto_play=true&amp;hide_related=false&amp;show_comments=true&amp;show_user=true&amp;show_reposts=false&amp;visual=true";
        }
    }
}
