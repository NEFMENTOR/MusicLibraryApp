using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
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
                    //JObject album = new JObject();

                    //for(int i = 0; i < reader.FieldCount; i++)
                    //{
                    //    album.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    //}
                    //albums.Add(album);

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

        public List<JObject> getTracks(int albumID)
        {
            List<JObject> tracks = new List<JObject>();

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();

            String query = "SELECT tracks.TRACK_TITLE, albums.ALBUM_TITLE, tracks.VIDEO_URL, tracks.Lyrics\r\nFROM tracks\r\nINNER JOIN albums ON tracks.albums_ID=albums.ID\r\nWHERE albums.ID = @albumID";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@albumID", albumID);
            cmd.Connection = connection;
            

            using (MySqlDataReader r = cmd.ExecuteReader())
            {
                while (r.Read())
                {
                    JObject track = new JObject();

                    for(int i = 0; i < r.FieldCount; i++)
                    {
                        track.Add(r.GetName(i).ToString(), r.GetValue(i).ToString());
                    }
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

        public int addTrack(JObject track)
        {
            String title = track.GetValue("t").ToString();
            int number = Int32.Parse(track.GetValue("n").ToString());
            String url = track.GetValue("u").ToString();
            String lyrics = track.GetValue("l").ToString();
            int id = Int32.Parse(track.GetValue("id").ToString());

            String query = "INSERT INTO tracks (TRACK_TITLE, NUMBER, VIDEO_URL, Lyrics, albums_id) VALUES (@title, @number, @url, @lyrics, @albums_id)";

            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@number", number);
            cmd.Parameters.AddWithValue("@url", url);
            cmd.Parameters.AddWithValue("@lyrics", lyrics);
            cmd.Parameters.AddWithValue("@albums_id", id);
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
