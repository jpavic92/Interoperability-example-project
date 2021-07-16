namespace ShazamClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.btnShowPlaylist = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbArtists = new System.Windows.Forms.ListBox();
            this.lbTracks = new System.Windows.Forms.ListBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbLoadingCityTemp = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheckTemp = new System.Windows.Forms.Button();
            this.tbStationName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblValidationResult = new System.Windows.Forms.Label();
            this.tbArtistName = new System.Windows.Forms.TextBox();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.cbArtists = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbXsd = new System.Windows.Forms.RadioButton();
            this.rbRng = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveTrack = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbSubtitle = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblBackground = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbSearchResults = new System.Windows.Forms.ListBox();
            this.btnSearchEntity = new System.Windows.Forms.Button();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.lblKeywordError = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingCityTemp)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 513);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pbLoading);
            this.tabPage1.Controls.Add(this.btnShowPlaylist);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.pbImage);
            this.tabPage1.Controls.Add(this.lbArtists);
            this.tabPage1.Controls.Add(this.lbTracks);
            this.tabPage1.Controls.Add(this.tbSearch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(887, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ShazamAPI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(22, 420);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 45);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Select an artist and check top songs playlist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Artists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Songs";
            // 
            // pbLoading
            // 
            this.pbLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLoading.Image = global::ShazamClient.Properties.Resources.loadingGif;
            this.pbLoading.Location = new System.Drawing.Point(326, 157);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(140, 124);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoading.TabIndex = 1;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // btnShowPlaylist
            // 
            this.btnShowPlaylist.Location = new System.Drawing.Point(231, 432);
            this.btnShowPlaylist.Name = "btnShowPlaylist";
            this.btnShowPlaylist.Size = new System.Drawing.Size(122, 33);
            this.btnShowPlaylist.TabIndex = 6;
            this.btnShowPlaylist.Text = "Show playlist";
            this.btnShowPlaylist.UseVisualStyleBackColor = true;
            this.btnShowPlaylist.Click += new System.EventHandler(this.btnShowPlaylist_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(278, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::ShazamClient.Properties.Resources.defualtImage;
            this.pbImage.Location = new System.Drawing.Point(406, 14);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(400, 400);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // lbArtists
            // 
            this.lbArtists.FormattingEnabled = true;
            this.lbArtists.ItemHeight = 16;
            this.lbArtists.Location = new System.Drawing.Point(22, 266);
            this.lbArtists.Name = "lbArtists";
            this.lbArtists.Size = new System.Drawing.Size(331, 148);
            this.lbArtists.TabIndex = 3;
            this.lbArtists.SelectedIndexChanged += new System.EventHandler(this.lbArtists_SelectedIndexChanged);
            // 
            // lbTracks
            // 
            this.lbTracks.FormattingEnabled = true;
            this.lbTracks.ItemHeight = 16;
            this.lbTracks.Location = new System.Drawing.Point(22, 86);
            this.lbTracks.Name = "lbTracks";
            this.lbTracks.Size = new System.Drawing.Size(331, 148);
            this.lbTracks.TabIndex = 2;
            this.lbTracks.SelectedIndexChanged += new System.EventHandler(this.lbTracks_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSearch.Location = new System.Drawing.Point(22, 34);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(250, 22);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search songs or artists:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pbLoadingCityTemp);
            this.tabPage2.Controls.Add(this.lblResult);
            this.tabPage2.Controls.Add(this.btnCheckTemp);
            this.tabPage2.Controls.Add(this.tbStationName);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(887, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "City temp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbLoadingCityTemp
            // 
            this.pbLoadingCityTemp.Image = global::ShazamClient.Properties.Resources.loadingGif;
            this.pbLoadingCityTemp.Location = new System.Drawing.Point(363, 186);
            this.pbLoadingCityTemp.Name = "pbLoadingCityTemp";
            this.pbLoadingCityTemp.Size = new System.Drawing.Size(150, 124);
            this.pbLoadingCityTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoadingCityTemp.TabIndex = 4;
            this.pbLoadingCityTemp.TabStop = false;
            this.pbLoadingCityTemp.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(7, 100);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 3;
            // 
            // btnCheckTemp
            // 
            this.btnCheckTemp.Location = new System.Drawing.Point(210, 61);
            this.btnCheckTemp.Name = "btnCheckTemp";
            this.btnCheckTemp.Size = new System.Drawing.Size(102, 26);
            this.btnCheckTemp.TabIndex = 2;
            this.btnCheckTemp.Text = "Check";
            this.btnCheckTemp.UseVisualStyleBackColor = true;
            this.btnCheckTemp.Click += new System.EventHandler(this.btnCheckTemp_Click);
            // 
            // tbStationName
            // 
            this.tbStationName.Location = new System.Drawing.Point(12, 63);
            this.tbStationName.Name = "tbStationName";
            this.tbStationName.Size = new System.Drawing.Size(192, 22);
            this.tbStationName.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 7);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 61);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Check temperature by writing weather station name and click Check";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblValidationResult);
            this.tabPage3.Controls.Add(this.tbArtistName);
            this.tabPage3.Controls.Add(this.btnAddArtist);
            this.tabPage3.Controls.Add(this.cbArtists);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnSaveTrack);
            this.tabPage3.Controls.Add(this.tbUrl);
            this.tabPage3.Controls.Add(this.tbSubtitle);
            this.tabPage3.Controls.Add(this.tbTitle);
            this.tabPage3.Controls.Add(this.lblBackground);
            this.tabPage3.Controls.Add(this.lblUrl);
            this.tabPage3.Controls.Add(this.lblSubtitle);
            this.tabPage3.Controls.Add(this.lblTitle);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(887, 484);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Save new entity";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblValidationResult
            // 
            this.lblValidationResult.AutoSize = true;
            this.lblValidationResult.Location = new System.Drawing.Point(169, 278);
            this.lblValidationResult.Name = "lblValidationResult";
            this.lblValidationResult.Size = new System.Drawing.Size(0, 17);
            this.lblValidationResult.TabIndex = 18;
            // 
            // tbArtistName
            // 
            this.tbArtistName.Location = new System.Drawing.Point(417, 140);
            this.tbArtistName.Name = "tbArtistName";
            this.tbArtistName.Size = new System.Drawing.Size(178, 22);
            this.tbArtistName.TabIndex = 17;
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(304, 140);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(75, 23);
            this.btnAddArtist.TabIndex = 16;
            this.btnAddArtist.Text = "Add";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // cbArtists
            // 
            this.cbArtists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArtists.FormattingEnabled = true;
            this.cbArtists.Location = new System.Drawing.Point(108, 140);
            this.cbArtists.Name = "cbArtists";
            this.cbArtists.Size = new System.Drawing.Size(179, 24);
            this.cbArtists.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbXsd);
            this.panel1.Controls.Add(this.rbRng);
            this.panel1.Location = new System.Drawing.Point(107, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 32);
            this.panel1.TabIndex = 14;
            // 
            // rbXsd
            // 
            this.rbXsd.AutoSize = true;
            this.rbXsd.Checked = true;
            this.rbXsd.Location = new System.Drawing.Point(3, 4);
            this.rbXsd.Name = "rbXsd";
            this.rbXsd.Size = new System.Drawing.Size(50, 21);
            this.rbXsd.TabIndex = 11;
            this.rbXsd.TabStop = true;
            this.rbXsd.Text = "xsd";
            this.rbXsd.UseVisualStyleBackColor = true;
            // 
            // rbRng
            // 
            this.rbRng.AutoSize = true;
            this.rbRng.Location = new System.Drawing.Point(59, 4);
            this.rbRng.Name = "rbRng";
            this.rbRng.Size = new System.Drawing.Size(50, 21);
            this.rbRng.TabIndex = 12;
            this.rbRng.Text = "rng";
            this.rbRng.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Validation:";
            // 
            // btnSaveTrack
            // 
            this.btnSaveTrack.Location = new System.Drawing.Point(10, 257);
            this.btnSaveTrack.Name = "btnSaveTrack";
            this.btnSaveTrack.Size = new System.Drawing.Size(122, 39);
            this.btnSaveTrack.TabIndex = 10;
            this.btnSaveTrack.Text = "Save track";
            this.btnSaveTrack.UseVisualStyleBackColor = true;
            this.btnSaveTrack.Click += new System.EventHandler(this.btnSaveTrack_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(108, 95);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(179, 22);
            this.tbUrl.TabIndex = 7;
            // 
            // tbSubtitle
            // 
            this.tbSubtitle.Location = new System.Drawing.Point(108, 57);
            this.tbSubtitle.Name = "tbSubtitle";
            this.tbSubtitle.Size = new System.Drawing.Size(179, 22);
            this.tbSubtitle.TabIndex = 6;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(108, 16);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(179, 22);
            this.tbTitle.TabIndex = 5;
            // 
            // lblBackground
            // 
            this.lblBackground.AutoSize = true;
            this.lblBackground.Location = new System.Drawing.Point(11, 140);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(51, 17);
            this.lblBackground.TabIndex = 4;
            this.lblBackground.Text = "Artists:";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(11, 95);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(30, 17);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "Url:";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(11, 57);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(75, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Performer:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(11, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblKeywordError);
            this.tabPage4.Controls.Add(this.lblSearchResults);
            this.tabPage4.Controls.Add(this.lbSearchResults);
            this.tabPage4.Controls.Add(this.btnSearchEntity);
            this.tabPage4.Controls.Add(this.tbKeyword);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(887, 484);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Search";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbSearchResults
            // 
            this.lbSearchResults.FormattingEnabled = true;
            this.lbSearchResults.ItemHeight = 16;
            this.lbSearchResults.Location = new System.Drawing.Point(15, 51);
            this.lbSearchResults.Name = "lbSearchResults";
            this.lbSearchResults.Size = new System.Drawing.Size(325, 132);
            this.lbSearchResults.TabIndex = 3;
            // 
            // btnSearchEntity
            // 
            this.btnSearchEntity.Location = new System.Drawing.Point(365, 16);
            this.btnSearchEntity.Name = "btnSearchEntity";
            this.btnSearchEntity.Size = new System.Drawing.Size(100, 23);
            this.btnSearchEntity.TabIndex = 2;
            this.btnSearchEntity.Text = "Search";
            this.btnSearchEntity.UseVisualStyleBackColor = true;
            this.btnSearchEntity.Click += new System.EventHandler(this.btnSearchEntity_Click);
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(133, 16);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(207, 22);
            this.tbKeyword.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter a keyword:";
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Location = new System.Drawing.Point(15, 200);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(0, 17);
            this.lblSearchResults.TabIndex = 4;
            // 
            // lblKeywordError
            // 
            this.lblKeywordError.AutoSize = true;
            this.lblKeywordError.ForeColor = System.Drawing.Color.Red;
            this.lblKeywordError.Location = new System.Drawing.Point(346, 21);
            this.lblKeywordError.Name = "lblKeywordError";
            this.lblKeywordError.Size = new System.Drawing.Size(13, 17);
            this.lblKeywordError.TabIndex = 5;
            this.lblKeywordError.Text = "*";
            this.lblKeywordError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 518);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RestClient";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingCityTemp)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ListBox lbArtists;
        private System.Windows.Forms.ListBox lbTracks;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowPlaylist;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckTemp;
        private System.Windows.Forms.TextBox tbStationName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pbLoadingCityTemp;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox tbSubtitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblBackground;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveTrack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbXsd;
        private System.Windows.Forms.RadioButton rbRng;
        private System.Windows.Forms.TextBox tbArtistName;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.ComboBox cbArtists;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lbSearchResults;
        private System.Windows.Forms.Button btnSearchEntity;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValidationResult;
        private System.Windows.Forms.Label lblSearchResults;
        private System.Windows.Forms.Label lblKeywordError;
    }
}

