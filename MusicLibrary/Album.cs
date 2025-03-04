using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    class Album
    {
        public int ID { get; set; }
        public String AlbumTitle { get; set; }
        public String AlbumArtist { get; set; }
        public int AlbumYear { get; set; }
        public String AlbumImage { get; set; }
        public String AlbumAbout { get; set; }

        // TODO: List<Track> songs
    }
}
