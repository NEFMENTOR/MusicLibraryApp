using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    class AlbumsDAO
    {
        // connection info
        String connString = "datasource=localhost;" +
            "port=3306;" +
            "username=root;" +
            "password=root;" +
            "database=music;";

        // Fetch method | For albums
        public List<Album> getAlbums()
        {
            // Create new empty list
            List<Album> albums = new List<Album>();

            // Create connection
            MySqlConnection connection = new MySqlConnection
                (connString);
            connection.Open();

            // Define query
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM albums",
                connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumTitle = reader.GetString(1),
                        AlbumArtist = reader.GetString(2),
                        AlbumYear = reader.GetInt32(3),
                        AlbumImage = reader.GetString(4),
                        AlbumAbout = reader.GetString(5)
                    };
                    albums.Add(a);
                }
            }
            return albums;
        }
    }
}
