namespace Music_Everyday
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
            this.components = new System.ComponentModel.Container();
            this.textArtist = new System.Windows.Forms.TextBox();
            this.textJudul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colArtis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJudul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnSeed = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPreference = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.timerToken = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.adLabel = new System.Windows.Forms.Label();
            this.progressBarSong = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbTrack = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblTimeTrack = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblArtis = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textArtist
            // 
            this.textArtist.Location = new System.Drawing.Point(13, 28);
            this.textArtist.Name = "textArtist";
            this.textArtist.Size = new System.Drawing.Size(88, 20);
            this.textArtist.TabIndex = 1;
            // 
            // textJudul
            // 
            this.textJudul.Location = new System.Drawing.Point(119, 28);
            this.textJudul.Name = "textJudul";
            this.textJudul.Size = new System.Drawing.Size(126, 20);
            this.textJudul.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Artis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Judul";
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(251, 26);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(48, 23);
            this.btnCari.TabIndex = 6;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textJudul);
            this.groupBox1.Controls.Add(this.textArtist);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 207);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Cari Lagu";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colArtis,
            this.colJudul,
            this.colAlbum,
            this.colID});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 130);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colArtis
            // 
            this.colArtis.Text = "Artis";
            this.colArtis.Width = 74;
            // 
            // colJudul
            // 
            this.colJudul.Text = "Judul";
            this.colJudul.Width = 102;
            // 
            // colAlbum
            // 
            this.colAlbum.Text = "Album";
            this.colAlbum.Width = 101;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 5;
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(69, 629);
            this.txtHasil.Multiline = true;
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(242, 100);
            this.txtHasil.TabIndex = 7;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(8, 63);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(281, 130);
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Artis";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Judul";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Album";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 0;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(325, 105);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(41, 25);
            this.btnMoveRight.TabIndex = 13;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(6, 19);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(321, 341);
            this.listView3.TabIndex = 15;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Artis";
            this.columnHeader5.Width = 74;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Judul";
            this.columnHeader6.Width = 102;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Album";
            this.columnHeader7.Width = 108;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 629);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 18;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(325, 136);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(41, 25);
            this.btnMoveLeft.TabIndex = 19;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnSeed
            // 
            this.btnSeed.Location = new System.Drawing.Point(205, 34);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(75, 23);
            this.btnSeed.TabIndex = 14;
            this.btnSeed.Text = "Send";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPreference);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Controls.Add(this.btnSeed);
            this.groupBox2.Location = new System.Drawing.Point(369, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 207);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Kirim Sampel Lagu";
            // 
            // btnPreference
            // 
            this.btnPreference.Location = new System.Drawing.Point(205, 10);
            this.btnPreference.Name = "btnPreference";
            this.btnPreference.Size = new System.Drawing.Size(75, 23);
            this.btnPreference.TabIndex = 16;
            this.btnPreference.Text = "Preferences";
            this.btnPreference.UseVisualStyleBackColor = true;
            this.btnPreference.Click += new System.EventHandler(this.btnPreference_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Up To 5 Sample Songs :";
            // 
            // timerToken
            // 
            this.timerToken.Tick += new System.EventHandler(this.timerToken_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 613);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Debug Stuff:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAlbum);
            this.groupBox3.Controls.Add(this.lblArtis);
            this.groupBox3.Controls.Add(this.lblJudul);
            this.groupBox3.Controls.Add(this.lblTimeTrack);
            this.groupBox3.Controls.Add(this.adLabel);
            this.groupBox3.Controls.Add(this.progressBarSong);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.pbTrack);
            this.groupBox3.Controls.Add(this.btnPause);
            this.groupBox3.Controls.Add(this.btnPlay);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Location = new System.Drawing.Point(352, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 366);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Music Player";
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(138, 237);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(38, 13);
            this.adLabel.TabIndex = 12;
            this.adLabel.Text = "IKLAN";
            this.adLabel.Visible = false;
            // 
            // progressBarSong
            // 
            this.progressBarSong.Location = new System.Drawing.Point(46, 288);
            this.progressBarSong.Name = "progressBarSong";
            this.progressBarSong.Size = new System.Drawing.Size(209, 10);
            this.progressBarSong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Album : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Artis    : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Judul  : ";
            // 
            // pbTrack
            // 
            this.pbTrack.Location = new System.Drawing.Point(71, 48);
            this.pbTrack.Name = "pbTrack";
            this.pbTrack.Size = new System.Drawing.Size(160, 160);
            this.pbTrack.TabIndex = 4;
            this.pbTrack.TabStop = false;
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(170, 319);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(61, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(87, 319);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(56, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(17, 17);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(274, 24);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to Spotify PC";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblTimeTrack
            // 
            this.lblTimeTrack.AutoSize = true;
            this.lblTimeTrack.Location = new System.Drawing.Point(206, 301);
            this.lblTimeTrack.Name = "lblTimeTrack";
            this.lblTimeTrack.Size = new System.Drawing.Size(10, 13);
            this.lblTimeTrack.TabIndex = 13;
            this.lblTimeTrack.Text = "-";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(84, 217);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(10, 13);
            this.lblJudul.TabIndex = 14;
            this.lblJudul.Text = "-";
            // 
            // lblArtis
            // 
            this.lblArtis.AutoSize = true;
            this.lblArtis.Location = new System.Drawing.Point(84, 239);
            this.lblArtis.Name = "lblArtis";
            this.lblArtis.Size = new System.Drawing.Size(10, 13);
            this.lblArtis.TabIndex = 15;
            this.lblArtis.Text = "-";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(84, 263);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(10, 13);
            this.lblAlbum.TabIndex = 16;
            this.lblAlbum.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView3);
            this.groupBox4.Location = new System.Drawing.Point(13, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 366);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "3. Dapatkan Lagu Rekomendasimu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 741);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textArtist;
        private System.Windows.Forms.TextBox textJudul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colArtis;
        private System.Windows.Forms.ColumnHeader colJudul;
        private System.Windows.Forms.ColumnHeader colAlbum;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timerToken;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPreference;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ProgressBar progressBarSong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbTrack;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.Label lblTimeTrack;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblArtis;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

