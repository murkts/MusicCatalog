namespace MusicCatalog
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.gbAddArtist = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAddArtist = new Guna.UI2.WinForms.Guna2Button();
            this.txtArtistName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbAddTrack = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbTrackArtist = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTrackGenre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTrackDuration = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddTrack = new Guna.UI2.WinForms.Guna2Button();
            this.txtTrackTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbAddAlbum = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddAlbum = new Guna.UI2.WinForms.Guna2Button();
            this.txtAlbumTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbAlbumArtist = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbCreatePlaylist = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddToPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.txtPlaylistTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lstAvailableTracks = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreatePlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gbAddArtist.SuspendLayout();
            this.gbAddTrack.SuspendLayout();
            this.gbAddAlbum.SuspendLayout();
            this.gbCreatePlaylist.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(27, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(396, 32);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(445, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Поиск";
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(27, 72);
            this.lstResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(535, 82);
            this.lstResults.TabIndex = 2;
            // 
            // gbAddArtist
            // 
            this.gbAddArtist.Controls.Add(this.label5);
            this.gbAddArtist.Controls.Add(this.btnAddArtist);
            this.gbAddArtist.Controls.Add(this.txtArtistName);
            this.gbAddArtist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAddArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbAddArtist.Location = new System.Drawing.Point(27, 175);
            this.gbAddArtist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAddArtist.Name = "gbAddArtist";
            this.gbAddArtist.Size = new System.Drawing.Size(206, 190);
            this.gbAddArtist.TabIndex = 3;
            this.gbAddArtist.Text = "Добавление исполнителя";
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddArtist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddArtist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddArtist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddArtist.FillColor = System.Drawing.Color.AntiqueWhite;
            this.btnAddArtist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddArtist.ForeColor = System.Drawing.Color.Black;
            this.btnAddArtist.Location = new System.Drawing.Point(43, 136);
            this.btnAddArtist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(116, 38);
            this.btnAddArtist.TabIndex = 4;
            this.btnAddArtist.Text = "Добавить исполнителя";
            // 
            // txtArtistName
            // 
            this.txtArtistName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArtistName.DefaultText = "";
            this.txtArtistName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtArtistName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtArtistName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArtistName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArtistName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArtistName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtArtistName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArtistName.Location = new System.Drawing.Point(14, 86);
            this.txtArtistName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.PasswordChar = '\0';
            this.txtArtistName.PlaceholderText = "";
            this.txtArtistName.SelectedText = "";
            this.txtArtistName.Size = new System.Drawing.Size(178, 32);
            this.txtArtistName.TabIndex = 4;
            // 
            // gbAddTrack
            // 
            this.gbAddTrack.Controls.Add(this.label4);
            this.gbAddTrack.Controls.Add(this.label3);
            this.gbAddTrack.Controls.Add(this.label2);
            this.gbAddTrack.Controls.Add(this.label1);
            this.gbAddTrack.Controls.Add(this.cmbTrackArtist);
            this.gbAddTrack.Controls.Add(this.txtTrackGenre);
            this.gbAddTrack.Controls.Add(this.txtTrackDuration);
            this.gbAddTrack.Controls.Add(this.btnAddTrack);
            this.gbAddTrack.Controls.Add(this.txtTrackTitle);
            this.gbAddTrack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAddTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbAddTrack.Location = new System.Drawing.Point(249, 175);
            this.gbAddTrack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAddTrack.Name = "gbAddTrack";
            this.gbAddTrack.Size = new System.Drawing.Size(313, 328);
            this.gbAddTrack.TabIndex = 5;
            this.gbAddTrack.Text = "Добавить трек";
            // 
            // cmbTrackArtist
            // 
            this.cmbTrackArtist.BackColor = System.Drawing.Color.Transparent;
            this.cmbTrackArtist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTrackArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrackArtist.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTrackArtist.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTrackArtist.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTrackArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTrackArtist.ItemHeight = 30;
            this.cmbTrackArtist.Location = new System.Drawing.Point(122, 216);
            this.cmbTrackArtist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTrackArtist.Name = "cmbTrackArtist";
            this.cmbTrackArtist.Size = new System.Drawing.Size(179, 36);
            this.cmbTrackArtist.TabIndex = 7;
            // 
            // txtTrackGenre
            // 
            this.txtTrackGenre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrackGenre.DefaultText = "";
            this.txtTrackGenre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrackGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTrackGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrackGenre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrackGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrackGenre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrackGenre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrackGenre.Location = new System.Drawing.Point(122, 158);
            this.txtTrackGenre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTrackGenre.Name = "txtTrackGenre";
            this.txtTrackGenre.PasswordChar = '\0';
            this.txtTrackGenre.PlaceholderText = "";
            this.txtTrackGenre.SelectedText = "";
            this.txtTrackGenre.Size = new System.Drawing.Size(178, 32);
            this.txtTrackGenre.TabIndex = 6;
            // 
            // txtTrackDuration
            // 
            this.txtTrackDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrackDuration.DefaultText = "";
            this.txtTrackDuration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrackDuration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTrackDuration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrackDuration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrackDuration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrackDuration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrackDuration.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrackDuration.Location = new System.Drawing.Point(122, 102);
            this.txtTrackDuration.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTrackDuration.Name = "txtTrackDuration";
            this.txtTrackDuration.PasswordChar = '\0';
            this.txtTrackDuration.PlaceholderText = "";
            this.txtTrackDuration.SelectedText = "";
            this.txtTrackDuration.Size = new System.Drawing.Size(178, 32);
            this.txtTrackDuration.TabIndex = 5;
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTrack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTrack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTrack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTrack.FillColor = System.Drawing.Color.AntiqueWhite;
            this.btnAddTrack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTrack.ForeColor = System.Drawing.Color.Black;
            this.btnAddTrack.Location = new System.Drawing.Point(104, 277);
            this.btnAddTrack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(116, 38);
            this.btnAddTrack.TabIndex = 4;
            this.btnAddTrack.Text = "Добавить трек";
            // 
            // txtTrackTitle
            // 
            this.txtTrackTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrackTitle.DefaultText = "";
            this.txtTrackTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrackTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTrackTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrackTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrackTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrackTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrackTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrackTitle.Location = new System.Drawing.Point(122, 44);
            this.txtTrackTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTrackTitle.Name = "txtTrackTitle";
            this.txtTrackTitle.PasswordChar = '\0';
            this.txtTrackTitle.PlaceholderText = "";
            this.txtTrackTitle.SelectedText = "";
            this.txtTrackTitle.Size = new System.Drawing.Size(178, 32);
            this.txtTrackTitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Длительность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Исполнитель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Имя исполнителя";
            // 
            // gbAddAlbum
            // 
            this.gbAddAlbum.Controls.Add(this.label7);
            this.gbAddAlbum.Controls.Add(this.cmbAlbumArtist);
            this.gbAddAlbum.Controls.Add(this.label6);
            this.gbAddAlbum.Controls.Add(this.btnAddAlbum);
            this.gbAddAlbum.Controls.Add(this.txtAlbumTitle);
            this.gbAddAlbum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAddAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbAddAlbum.Location = new System.Drawing.Point(27, 401);
            this.gbAddAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.gbAddAlbum.Name = "gbAddAlbum";
            this.gbAddAlbum.Size = new System.Drawing.Size(206, 273);
            this.gbAddAlbum.TabIndex = 13;
            this.gbAddAlbum.Text = "Добавление альбома";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Название альбома";
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAlbum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAlbum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAlbum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAlbum.FillColor = System.Drawing.Color.AntiqueWhite;
            this.btnAddAlbum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddAlbum.ForeColor = System.Drawing.Color.Black;
            this.btnAddAlbum.Location = new System.Drawing.Point(43, 219);
            this.btnAddAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(116, 38);
            this.btnAddAlbum.TabIndex = 4;
            this.btnAddAlbum.Text = "Добавить исполнителя";
            // 
            // txtAlbumTitle
            // 
            this.txtAlbumTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlbumTitle.DefaultText = "";
            this.txtAlbumTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAlbumTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAlbumTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlbumTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlbumTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlbumTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAlbumTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlbumTitle.Location = new System.Drawing.Point(14, 86);
            this.txtAlbumTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAlbumTitle.Name = "txtAlbumTitle";
            this.txtAlbumTitle.PasswordChar = '\0';
            this.txtAlbumTitle.PlaceholderText = "";
            this.txtAlbumTitle.SelectedText = "";
            this.txtAlbumTitle.Size = new System.Drawing.Size(178, 32);
            this.txtAlbumTitle.TabIndex = 4;
            // 
            // cmbAlbumArtist
            // 
            this.cmbAlbumArtist.BackColor = System.Drawing.Color.Transparent;
            this.cmbAlbumArtist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAlbumArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlbumArtist.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAlbumArtist.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAlbumArtist.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAlbumArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAlbumArtist.ItemHeight = 30;
            this.cmbAlbumArtist.Location = new System.Drawing.Point(14, 168);
            this.cmbAlbumArtist.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAlbumArtist.Name = "cmbAlbumArtist";
            this.cmbAlbumArtist.Size = new System.Drawing.Size(179, 36);
            this.cmbAlbumArtist.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Имя исполнителя";
            // 
            // gbCreatePlaylist
            // 
            this.gbCreatePlaylist.Controls.Add(this.btnCreatePlaylist);
            this.gbCreatePlaylist.Controls.Add(this.label9);
            this.gbCreatePlaylist.Controls.Add(this.lstAvailableTracks);
            this.gbCreatePlaylist.Controls.Add(this.label8);
            this.gbCreatePlaylist.Controls.Add(this.btnAddToPlaylist);
            this.gbCreatePlaylist.Controls.Add(this.txtPlaylistTitle);
            this.gbCreatePlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbCreatePlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbCreatePlaylist.Location = new System.Drawing.Point(249, 516);
            this.gbCreatePlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.gbCreatePlaylist.Name = "gbCreatePlaylist";
            this.gbCreatePlaylist.Size = new System.Drawing.Size(313, 260);
            this.gbCreatePlaylist.TabIndex = 13;
            this.gbCreatePlaylist.Text = "Добавление плейлиста";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Название";
            // 
            // btnAddToPlaylist
            // 
            this.btnAddToPlaylist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToPlaylist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToPlaylist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToPlaylist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToPlaylist.FillColor = System.Drawing.Color.AntiqueWhite;
            this.btnAddToPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddToPlaylist.ForeColor = System.Drawing.Color.Black;
            this.btnAddToPlaylist.Location = new System.Drawing.Point(31, 209);
            this.btnAddToPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToPlaylist.Name = "btnAddToPlaylist";
            this.btnAddToPlaylist.Size = new System.Drawing.Size(116, 38);
            this.btnAddToPlaylist.TabIndex = 4;
            this.btnAddToPlaylist.Text = "Добавить в плейлист";
            // 
            // txtPlaylistTitle
            // 
            this.txtPlaylistTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlaylistTitle.DefaultText = "";
            this.txtPlaylistTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlaylistTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlaylistTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlaylistTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlaylistTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlaylistTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPlaylistTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlaylistTitle.Location = new System.Drawing.Point(122, 43);
            this.txtPlaylistTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPlaylistTitle.Name = "txtPlaylistTitle";
            this.txtPlaylistTitle.PasswordChar = '\0';
            this.txtPlaylistTitle.PlaceholderText = "";
            this.txtPlaylistTitle.SelectedText = "";
            this.txtPlaylistTitle.Size = new System.Drawing.Size(178, 32);
            this.txtPlaylistTitle.TabIndex = 4;
            // 
            // lstAvailableTracks
            // 
            this.lstAvailableTracks.FormattingEnabled = true;
            this.lstAvailableTracks.ItemHeight = 15;
            this.lstAvailableTracks.Location = new System.Drawing.Point(31, 122);
            this.lstAvailableTracks.Name = "lstAvailableTracks";
            this.lstAvailableTracks.Size = new System.Drawing.Size(269, 64);
            this.lstAvailableTracks.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Добавленные треки";
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreatePlaylist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreatePlaylist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreatePlaylist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreatePlaylist.FillColor = System.Drawing.Color.AntiqueWhite;
            this.btnCreatePlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreatePlaylist.ForeColor = System.Drawing.Color.Black;
            this.btnCreatePlaylist.Location = new System.Drawing.Point(184, 209);
            this.btnCreatePlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(116, 38);
            this.btnCreatePlaylist.TabIndex = 15;
            this.btnCreatePlaylist.Text = "Создать плейлист";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(70, 725);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(116, 32);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Выход";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MusicCatalog.Properties.Resources.digital_art_illustration_lofi_hd_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(592, 787);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.gbCreatePlaylist);
            this.Controls.Add(this.gbAddAlbum);
            this.Controls.Add(this.gbAddTrack);
            this.Controls.Add(this.gbAddArtist);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "LoFi";
            this.gbAddArtist.ResumeLayout(false);
            this.gbAddArtist.PerformLayout();
            this.gbAddTrack.ResumeLayout(false);
            this.gbAddTrack.PerformLayout();
            this.gbAddAlbum.ResumeLayout(false);
            this.gbAddAlbum.PerformLayout();
            this.gbCreatePlaylist.ResumeLayout(false);
            this.gbCreatePlaylist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.ListBox lstResults;
        private Guna.UI2.WinForms.Guna2GroupBox gbAddArtist;
        private Guna.UI2.WinForms.Guna2Button btnAddArtist;
        private Guna.UI2.WinForms.Guna2TextBox txtArtistName;
        private Guna.UI2.WinForms.Guna2GroupBox gbAddTrack;
        private Guna.UI2.WinForms.Guna2Button btnAddTrack;
        private Guna.UI2.WinForms.Guna2TextBox txtTrackTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTrackArtist;
        private Guna.UI2.WinForms.Guna2TextBox txtTrackGenre;
        private Guna.UI2.WinForms.Guna2TextBox txtTrackDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GroupBox gbAddAlbum;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAlbumArtist;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnAddAlbum;
        private Guna.UI2.WinForms.Guna2TextBox txtAlbumTitle;
        private Guna.UI2.WinForms.Guna2GroupBox gbCreatePlaylist;
        private System.Windows.Forms.ListBox lstAvailableTracks;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnAddToPlaylist;
        private Guna.UI2.WinForms.Guna2TextBox txtPlaylistTitle;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnCreatePlaylist;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

