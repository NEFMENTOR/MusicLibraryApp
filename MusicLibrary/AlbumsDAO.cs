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
            connection.Close();
            return albums;
        }

        public List<Track> getTracks(int albumID)
        {
            List<Track> tracks = new List<Track>();

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();

            String query = "SELECT tracks.ID, tracks.TRACK_TITLE, albums.ALBUM_TITLE,tracks.NUMBER, tracks.VIDEO_URL, tracks.Lyrics\r\nFROM tracks\r\nINNER JOIN albums ON tracks.albums_ID=albums.ID\r\nWHERE albums.ID = @albumID";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@albumID", albumID);
            cmd.Connection = connection;
            

            using (MySqlDataReader r = cmd.ExecuteReader())
            {
                while (r.Read())
                {
                    Track track = new Track
                    {
                        ID = r.GetInt32(0),
                        trackTitle = r.GetString(1),
                        albumTitle = r.GetString(2),
                        number = r.GetInt32(3),
                        videoUrl = r.GetString(4),
                        lyrics = r.GetString(5),
                    };
                    tracks.Add(track);
                }
            }
            connection.Close();
            return tracks;
        }

        public int addAlbum(Album album)
        {

            // Create connection to db
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand();

            String query = "INSERT INTO albums (ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION) VALUES (@TITLE, @ARTIST, @YEAR, @URL, @DESC)";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@TITLE", album.AlbumTitle);
            cmd.Parameters.AddWithValue("@ARTIST", album.AlbumArtist);
            cmd.Parameters.AddWithValue("@YEAR", album.AlbumYear);
            cmd.Parameters.AddWithValue("@URL", album.AlbumImage);
            cmd.Parameters.AddWithValue("@DESC", album.AlbumAbout);
            cmd.Connection = connection;
            int affectedRows = cmd.ExecuteNonQuery();
            connection.Close();
            return affectedRows;
        }

        public void editRecord(Album album)
        {

        }

        public void deleteRecord(Album album)
        {

        }

        public List<Album> searchTitles(String prompt)
        {
            // Create new empty list
            List<Album> albums = new List<Album>();

            // Create connection
            MySqlConnection connection = new MySqlConnection
                (connString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand();
            String searchPrompt = "%" + prompt + "%";
            String query = "SELECT * FROM albums WHERE ALBUM_TITLE LIKE @prompt";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@prompt", searchPrompt);
            cmd.Connection = connection;

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
            connection.Close();

            return albums;
        }

    }
}
