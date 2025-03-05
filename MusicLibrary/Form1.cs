namespace MusicLibrary
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

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

            int AlbumID = (int)dataGrid.Rows[currentRow].Cells[0].Value;

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
            String lyrics = lyricsDataView.Rows[currentRow].Cells[5].Value.ToString();
            //MessageBox.Show(lyrics);
            LyricsBox.Text = lyrics;
        }
    }
}
