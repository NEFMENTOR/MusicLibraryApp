using Newtonsoft.Json.Linq;

namespace MusicLibrary
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        public int AlbumID = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadAlbum_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();


            albumBindingSource.DataSource = albumsDAO.getAlbums();

            gridView.DataSource = albumBindingSource;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            String prompt = SearchBox.Text;


            albumBindingSource.DataSource = albumsDAO.searchTitles(prompt);

            gridView.DataSource = albumBindingSource;



        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            DataGridView dataGrid = (DataGridView)sender;

            int currentRow = dataGrid.CurrentRow.Index;
            //MessageBox.Show(currentRow.ToString());


            String imageURL = dataGrid.Rows[currentRow].Cells[4].Value.ToString();



            AlbumThumb.LoadAsync(imageURL);
            //MessageBox.Show(imageURL);

            AlbumID = (int)dataGrid.Rows[currentRow].Cells[0].Value;
            //MessageBox.Show("CELLCLICKTEST" + AlbumID);

            tracksBindingSource.DataSource = albumsDAO.getTracks(AlbumID);

            TracksGridView.DataSource = tracksBindingSource;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            // captures text prompts
            Album alb = new Album
            {
                AlbumTitle = NamePrompt.Text,
                AlbumArtist = ArtistPrompt.Text,
                AlbumYear = Int32.Parse(YearPrompt.Text),
                AlbumImage = URLPrompt.Text,
                AlbumAbout = DescriptionPrompt.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addAlbum(alb);
            MessageBox.Show($"Added {result} new rows");
        }

        private void TracksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView lyricsDataView = (DataGridView)sender;

            int currentRow = lyricsDataView.CurrentRow.Index;
            //MessageBox.Show("" + currentRow);
            String lyrics = lyricsDataView.Rows[currentRow].Cells[3].Value.ToString();
            //MessageBox.Show(lyrics);
            LyricsBox.Text = lyrics;
        }

        private void AddTrackButton_Click(object sender, EventArgs e)
        {
            JObject track = new JObject();


            //MessageBox.Show("ADDTRACKTEST: "+AlbumID
            if(!AlbumID.Equals(0))
            {
                String title = TrackTitlePrompt.Text;
                int number = Int32.Parse(TrackNumberPrompt.Text);
                String url = TrackUrlPrompt.Text;
                String lyrics = TrackLyricsPrompt.Text;
                MessageBox.Show($"ID:{AlbumID}\nTitle:{title}\nNumber:{number}\nURL:{url}\nLyricsStart:{lyrics}\nLyricsEnd");

                track.Add("t",title);
                track.Add("n",number);
                track.Add("u",url);
                track.Add("l",lyrics);
                track.Add("id", AlbumID);

                AlbumsDAO albumsDAO = new AlbumsDAO();
                int result = albumsDAO.addTrack(track);
                MessageBox.Show($"Added {result} new records");
            }
            else
            {
                MessageBox.Show("Choose album first");
            }
        }
    }
}
