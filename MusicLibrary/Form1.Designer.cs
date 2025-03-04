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
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // LoadAlbum
            // 
            LoadAlbum.Location = new Point(12, 12);
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
            gridView.Location = new Point(113, 12);
            gridView.Name = "gridView";
            gridView.Size = new Size(543, 150);
            gridView.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 450);
            Controls.Add(gridView);
            Controls.Add(LoadAlbum);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button LoadAlbum;
        private DataGridView gridView;
    }
}
