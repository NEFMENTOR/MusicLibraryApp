namespace MusicLibrary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoadAlbum = new Button();
            gridView = new DataGridView();
            SearchBox = new TextBox();
            SearchButton = new Button();
            AlbumThumb = new PictureBox();
            AddAlbumBox = new GroupBox();
            AddButton = new Button();
            DescriptionPrompt = new TextBox();
            URLPrompt = new TextBox();
            YearPrompt = new TextBox();
            ArtistPrompt = new TextBox();
            NamePrompt = new TextBox();
            DescriptionInput = new Label();
            imageURLInput = new Label();
            YearInput = new Label();
            ArtistInput = new Label();
            AlbumNameInput = new Label();
            EditButton = new Button();
            DeleteButton = new Button();
            TracksGridView = new DataGridView();
            TracksLabel = new Label();
            LyricsBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlbumThumb).BeginInit();
            AddAlbumBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TracksGridView).BeginInit();
            SuspendLayout();
            // 
            // LoadAlbum
            // 
            LoadAlbum.Location = new Point(12, 169);
            LoadAlbum.Name = "LoadAlbum";
            LoadAlbum.Size = new Size(95, 23);
            LoadAlbum.TabIndex = 0;
            LoadAlbum.Text = "Load albums";
            LoadAlbum.UseVisualStyleBackColor = true;
            LoadAlbum.Click += LoadAlbum_Click;
            // 
            // gridView
            // 
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Location = new Point(12, 12);
            gridView.Name = "gridView";
            gridView.Size = new Size(684, 150);
            gridView.TabIndex = 1;
            gridView.CellClick += gridView_CellClick;
            // 
            // SearchBox
            // 
            SearchBox.BorderStyle = BorderStyle.FixedSingle;
            SearchBox.Location = new Point(113, 169);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(190, 23);
            SearchBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(309, 169);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(103, 24);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Search Album";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // AlbumThumb
            // 
            AlbumThumb.Location = new Point(418, 419);
            AlbumThumb.Name = "AlbumThumb";
            AlbumThumb.Size = new Size(278, 184);
            AlbumThumb.SizeMode = PictureBoxSizeMode.Zoom;
            AlbumThumb.TabIndex = 4;
            AlbumThumb.TabStop = false;
            // 
            // AddAlbumBox
            // 
            AddAlbumBox.Controls.Add(AddButton);
            AddAlbumBox.Controls.Add(DescriptionPrompt);
            AddAlbumBox.Controls.Add(URLPrompt);
            AddAlbumBox.Controls.Add(YearPrompt);
            AddAlbumBox.Controls.Add(ArtistPrompt);
            AddAlbumBox.Controls.Add(NamePrompt);
            AddAlbumBox.Controls.Add(DescriptionInput);
            AddAlbumBox.Controls.Add(imageURLInput);
            AddAlbumBox.Controls.Add(YearInput);
            AddAlbumBox.Controls.Add(ArtistInput);
            AddAlbumBox.Controls.Add(AlbumNameInput);
            AddAlbumBox.Location = new Point(418, 198);
            AddAlbumBox.Name = "AddAlbumBox";
            AddAlbumBox.Size = new Size(278, 215);
            AddAlbumBox.TabIndex = 5;
            AddAlbumBox.TabStop = false;
            AddAlbumBox.Text = "Add Album";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(6, 177);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 10;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DescriptionPrompt
            // 
            DescriptionPrompt.Location = new Point(90, 137);
            DescriptionPrompt.Name = "DescriptionPrompt";
            DescriptionPrompt.Size = new Size(182, 23);
            DescriptionPrompt.TabIndex = 9;
            // 
            // URLPrompt
            // 
            URLPrompt.Location = new Point(90, 108);
            URLPrompt.Name = "URLPrompt";
            URLPrompt.Size = new Size(182, 23);
            URLPrompt.TabIndex = 8;
            // 
            // YearPrompt
            // 
            YearPrompt.Location = new Point(90, 79);
            YearPrompt.Name = "YearPrompt";
            YearPrompt.Size = new Size(182, 23);
            YearPrompt.TabIndex = 7;
            // 
            // ArtistPrompt
            // 
            ArtistPrompt.Location = new Point(90, 50);
            ArtistPrompt.Name = "ArtistPrompt";
            ArtistPrompt.Size = new Size(182, 23);
            ArtistPrompt.TabIndex = 6;
            // 
            // NamePrompt
            // 
            NamePrompt.Location = new Point(90, 21);
            NamePrompt.Name = "NamePrompt";
            NamePrompt.Size = new Size(182, 23);
            NamePrompt.TabIndex = 5;
            // 
            // DescriptionInput
            // 
            DescriptionInput.AutoSize = true;
            DescriptionInput.Location = new Point(6, 140);
            DescriptionInput.Name = "DescriptionInput";
            DescriptionInput.Size = new Size(67, 15);
            DescriptionInput.TabIndex = 4;
            DescriptionInput.Text = "Description";
            // 
            // imageURLInput
            // 
            imageURLInput.AutoSize = true;
            imageURLInput.Location = new Point(6, 111);
            imageURLInput.Name = "imageURLInput";
            imageURLInput.Size = new Size(64, 15);
            imageURLInput.TabIndex = 3;
            imageURLInput.Text = "Image URL";
            // 
            // YearInput
            // 
            YearInput.AutoSize = true;
            YearInput.Location = new Point(6, 82);
            YearInput.Name = "YearInput";
            YearInput.Size = new Size(29, 15);
            YearInput.TabIndex = 2;
            YearInput.Text = "Year";
            // 
            // ArtistInput
            // 
            ArtistInput.AutoSize = true;
            ArtistInput.Location = new Point(6, 53);
            ArtistInput.Name = "ArtistInput";
            ArtistInput.Size = new Size(35, 15);
            ArtistInput.TabIndex = 1;
            ArtistInput.Text = "Artist";
            // 
            // AlbumNameInput
            // 
            AlbumNameInput.AutoSize = true;
            AlbumNameInput.Location = new Point(6, 24);
            AlbumNameInput.Name = "AlbumNameInput";
            AlbumNameInput.Size = new Size(78, 15);
            AlbumNameInput.TabIndex = 0;
            AlbumNameInput.Text = "Album Name";
            // 
            // EditButton
            // 
            EditButton.Location = new Point(502, 170);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 23);
            EditButton.TabIndex = 6;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(602, 170);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 23);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // TracksGridView
            // 
            TracksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TracksGridView.Location = new Point(12, 222);
            TracksGridView.Name = "TracksGridView";
            TracksGridView.ReadOnly = true;
            TracksGridView.Size = new Size(400, 150);
            TracksGridView.TabIndex = 8;
            TracksGridView.CellContentClick += TracksGridView_CellContentClick;
            // 
            // TracksLabel
            // 
            TracksLabel.AutoSize = true;
            TracksLabel.Location = new Point(12, 204);
            TracksLabel.Name = "TracksLabel";
            TracksLabel.Size = new Size(39, 15);
            TracksLabel.TabIndex = 9;
            TracksLabel.Text = "Tracks";
            // 
            // LyricsBox
            // 
            LyricsBox.Location = new Point(12, 378);
            LyricsBox.Name = "LyricsBox";
            LyricsBox.ReadOnly = true;
            LyricsBox.Size = new Size(194, 225);
            LyricsBox.TabIndex = 10;
            LyricsBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 615);
            Controls.Add(LyricsBox);
            Controls.Add(TracksLabel);
            Controls.Add(TracksGridView);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddAlbumBox);
            Controls.Add(AlbumThumb);
            Controls.Add(SearchButton);
            Controls.Add(SearchBox);
            Controls.Add(gridView);
            Controls.Add(LoadAlbum);
            Name = "Form1";
            Text = "Music Library";
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlbumThumb).EndInit();
            AddAlbumBox.ResumeLayout(false);
            AddAlbumBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TracksGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoadAlbum;
        private DataGridView gridView;
        private TextBox SearchBox;
        private Button SearchButton;
        private PictureBox AlbumThumb;
        private GroupBox AddAlbumBox;
        private Label DescriptionInput;
        private Label imageURLInput;
        private Label YearInput;
        private Label ArtistInput;
        private Label AlbumNameInput;
        private TextBox DescriptionPrompt;
        private TextBox URLPrompt;
        private TextBox YearPrompt;
        private TextBox ArtistPrompt;
        private TextBox NamePrompt;
        private Button AddButton;
        private Button EditButton;
        private Button DeleteButton;
        private DataGridView TracksGridView;
        private Label TracksLabel;
        private RichTextBox LyricsBox;
    }
}
