using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCore.Common.ParserModal.Zing
{
    public class zSong
    {
        string name;
        string artist;
        string mp3Link;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Artist
        {
            get
            {
                return artist;
            }

            set
            {
                artist = value;
            }
        }

        public string Mp3Link
        {
            get
            {
                return mp3Link;
            }

            set
            {
                mp3Link = value;
            }
        }
    }
}
