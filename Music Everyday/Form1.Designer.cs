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
            this.label7 = new System.Windows.Forms.Label();
            this.tbPopularity = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tbInstrument = new System.Windows.Forms.TrackBar();
            this.tbEnergy = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDance = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAccoust = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxPop = new System.Windows.Forms.CheckBox();
            this.checkBoxInstrument = new System.Windows.Forms.CheckBox();
            this.checkBoxEnergy = new System.Windows.Forms.CheckBox();
            this.checkBoxDance = new System.Windows.Forms.CheckBox();
            this.checkBoxAccoust = new System.Windows.Forms.CheckBox();
            this.btnSeed = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timerToken = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPopularity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstrument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAccoust)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Text = "Cari Lagu";
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
            this.txtHasil.Location = new System.Drawing.Point(26, 558);
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
            this.listView3.Location = new System.Drawing.Point(18, 239);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(293, 250);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Popularity";
            // 
            // tbPopularity
            // 
            this.tbPopularity.Location = new System.Drawing.Point(100, 150);
            this.tbPopularity.Name = "tbPopularity";
            this.tbPopularity.Size = new System.Drawing.Size(151, 45);
            this.tbPopularity.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Instrumentalness";
            // 
            // tbInstrument
            // 
            this.tbInstrument.Location = new System.Drawing.Point(100, 118);
            this.tbInstrument.Name = "tbInstrument";
            this.tbInstrument.Size = new System.Drawing.Size(151, 45);
            this.tbInstrument.TabIndex = 6;
            // 
            // tbEnergy
            // 
            this.tbEnergy.Location = new System.Drawing.Point(100, 83);
            this.tbEnergy.Name = "tbEnergy";
            this.tbEnergy.Size = new System.Drawing.Size(151, 45);
            this.tbEnergy.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Energy";
            // 
            // tbDance
            // 
            this.tbDance.Location = new System.Drawing.Point(100, 52);
            this.tbDance.Name = "tbDance";
            this.tbDance.Size = new System.Drawing.Size(151, 45);
            this.tbDance.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Danceability";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Accousticness";
            // 
            // tbAccoust
            // 
            this.tbAccoust.Location = new System.Drawing.Point(100, 19);
            this.tbAccoust.Name = "tbAccoust";
            this.tbAccoust.Size = new System.Drawing.Size(151, 45);
            this.tbAccoust.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 573);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxPop);
            this.groupBox3.Controls.Add(this.checkBoxInstrument);
            this.groupBox3.Controls.Add(this.checkBoxEnergy);
            this.groupBox3.Controls.Add(this.checkBoxDance);
            this.groupBox3.Controls.Add(this.checkBoxAccoust);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbPopularity);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbInstrument);
            this.groupBox3.Controls.Add(this.tbEnergy);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbDance);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbAccoust);
            this.groupBox3.Location = new System.Drawing.Point(374, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 250);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Setting";
            // 
            // checkBoxPop
            // 
            this.checkBoxPop.AutoSize = true;
            this.checkBoxPop.Location = new System.Drawing.Point(257, 150);
            this.checkBoxPop.Name = "checkBoxPop";
            this.checkBoxPop.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPop.TabIndex = 17;
            this.checkBoxPop.UseVisualStyleBackColor = true;
            // 
            // checkBoxInstrument
            // 
            this.checkBoxInstrument.AutoSize = true;
            this.checkBoxInstrument.Location = new System.Drawing.Point(257, 118);
            this.checkBoxInstrument.Name = "checkBoxInstrument";
            this.checkBoxInstrument.Size = new System.Drawing.Size(15, 14);
            this.checkBoxInstrument.TabIndex = 16;
            this.checkBoxInstrument.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnergy
            // 
            this.checkBoxEnergy.AutoSize = true;
            this.checkBoxEnergy.Location = new System.Drawing.Point(257, 83);
            this.checkBoxEnergy.Name = "checkBoxEnergy";
            this.checkBoxEnergy.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEnergy.TabIndex = 15;
            this.checkBoxEnergy.UseVisualStyleBackColor = true;
            // 
            // checkBoxDance
            // 
            this.checkBoxDance.AutoSize = true;
            this.checkBoxDance.Location = new System.Drawing.Point(257, 51);
            this.checkBoxDance.Name = "checkBoxDance";
            this.checkBoxDance.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDance.TabIndex = 14;
            this.checkBoxDance.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccoust
            // 
            this.checkBoxAccoust.AutoSize = true;
            this.checkBoxAccoust.Location = new System.Drawing.Point(257, 19);
            this.checkBoxAccoust.Name = "checkBoxAccoust";
            this.checkBoxAccoust.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAccoust.TabIndex = 13;
            this.checkBoxAccoust.UseVisualStyleBackColor = true;
            // 
            // btnSeed
            // 
            this.btnSeed.Location = new System.Drawing.Point(205, 34);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(75, 23);
            this.btnSeed.TabIndex = 14;
            this.btnSeed.Text = "Seed";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Controls.Add(this.btnSeed);
            this.groupBox2.Location = new System.Drawing.Point(369, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 207);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seed Data";
            // 
            // timerToken
            // 
            this.timerToken.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 741);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPopularity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInstrument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAccoust)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tbPopularity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tbInstrument;
        private System.Windows.Forms.TrackBar tbEnergy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbDance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbAccoust;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxPop;
        private System.Windows.Forms.CheckBox checkBoxInstrument;
        private System.Windows.Forms.CheckBox checkBoxEnergy;
        private System.Windows.Forms.CheckBox checkBoxDance;
        private System.Windows.Forms.CheckBox checkBoxAccoust;
        private System.Windows.Forms.Timer timerToken;
    }
}

