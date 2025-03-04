namespace MusicLibrary
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();

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
    }
}
