using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MELibrary;
using SpotifyAPI.Local;

namespace Music_Everyday
{
    public partial class Form1 : Form
    {
        int counter = 3600;
        private readonly SpotifyLocalAPI _spotify;
        private SpotifyAPI.Local.Models.Track _currentTrack;
        private string _currentUrlTrack;
        DBHelper db = new DBHelper();
        public Form1()
        {
            InitializeComponent();
            _spotify = new SpotifyLocalAPI();
            _spotify.OnTrackTimeChange += _spotify_OnTrackTimeChange;
            updateDB();
            
        }


        private void btnCari_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (!(string.IsNullOrWhiteSpace(textArtist.Text) && string.IsNullOrWhiteSpace(textJudul.Text)))
            {
                string artis = (string.IsNullOrWhiteSpace(textArtist.Text) ? "*" : textArtist.Text);
                string judul = (string.IsNullOrWhiteSpace(textJudul.Text) ? "*" : textJudul.Text);
                List<Lagu> hasilPencarian = SongFinder.GetSong(artis, judul);
                if (hasilPencarian == null)
                {
                    MessageBox.Show("Gagal Mencari Data", "Gagal", MessageBoxButtons.OK);
                }
                else
                {
                    foreach (var item in hasilPencarian)
                    {
                        ListViewItem lagu = new ListViewItem(item.Artis);
                        lagu.SubItems.Add(item.Judul);
                        lagu.SubItems.Add(item.Album);
                        lagu.SubItems.Add(item.TrackID);
                        listView1.Items.Add(lagu);
                    }
                }
            }
            else MessageBox.Show("Harap mengisi nama artis atau judul lagu", "Peringatan", MessageBoxButtons.OK);
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            while (listView1.SelectedItems.Count > 0 && listView2.Items.Count < 5)
            {
                ListViewItem temp = listView1.SelectedItems[0];
                listView1.Items.Remove(temp);
                listView2.Items.Add(temp);
                temp = null;
            }
            listView2.SelectedItems.Clear();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            while (listView2.SelectedItems.Count > 0)
            {
                ListViewItem temp = listView2.SelectedItems[0];
                listView2.Items.Remove(temp);
                listView1.Items.Insert(0, temp);
            }
            listView1.SelectedItems.Clear();
        }

        private void btnSeed_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            string query = string.Empty;
            foreach (ListViewItem item in listView2.Items)
            {
                query += "seed_tracks=" + item.SubItems[3].Text + "&";
            }
            query = query.Remove(query.Length - 1);
            query += PreferencesForm.Query;
            txtHasil.Text = PreferencesForm.Query;
            List<Lagu> laguRecommended = SongRecommendation.GetRecommendation(query);
            if (laguRecommended == null)
            {
                MessageBox.Show("Gagal Mencari Data", "Gagal", MessageBoxButtons.OK);
            }
            else
            {
                foreach (var item in laguRecommended)
                {
                    ListViewItem lagu = new ListViewItem(item.Artis);
                    lagu.SubItems.Add(item.Judul);
                    lagu.SubItems.Add(item.Album);
                    lagu.SubItems.Add(item.TrackID);
                    listView3.Items.Add(lagu);
                }
            }
        }

        private void timerToken_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timerToken.Stop();
                timerToken.Enabled = false;
            }
        }
        
        public void Connect()
        {
            if (!SpotifyLocalAPI.IsSpotifyRunning())
            {
                MessageBox.Show(@"Spotify isn't running!");
                return;
            }
            bool sukses;
            try { sukses = _spotify.Connect();} catch { sukses = false; }
            if (sukses)
            {
                btnConnect.Text = @"Sukses menyambungkan ke Spotify PC";
                btnConnect.Enabled = false;
                _spotify.ListenForEvents = true;
                btnPlay.Enabled = true;
                btnPause.Enabled = true;
                SpotifyAPI.Local.Models.StatusResponse status = _spotify.GetStatus();
                if (status.Track != null)
                    UpdateTrack(status.Track, "");
            }
            else
            {
                DialogResult res = MessageBox.Show(@"Gagal menyambungkan ke Spotify PC. Coba lagi?", @"Spotify", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                    Connect();
            }
        }

        public async void UpdateTrack(SpotifyAPI.Local.Models.Track track, string urlTrack)
        {
            _currentTrack = track;
            _currentUrlTrack = urlTrack;

            adLabel.Visible = track.IsAd() ? true : false;
            progressBarSong.Maximum = track.Length;

            if (track.IsAd())
                return; //Don't process further, maybe null values

            lblJudul.Text = track.TrackResource.Name;

            lblArtis.Text = track.ArtistResource.Name;

            lblAlbum.Text = track.AlbumResource.Name;

            SpotifyAPI.Local.Models.SpotifyUri uri = track.TrackResource.ParseUri();
            pbTrack.Image = await track.GetAlbumArtAsync(SpotifyAPI.Local.Enums.AlbumArtSize.Size160);
        }

        private void btnPreference_Click(object sender, EventArgs e)
        {
            PreferencesForm setting = new PreferencesForm();
            setting.Show();
        }

       
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            string track = "";
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem currentTrack = listView1.SelectedItems[0];
                track = currentTrack.SubItems[3].Text;
                currentTrack.Selected = false;
            }

            else if (listView3.SelectedItems.Count > 0)
            {
                ListViewItem currentTrack = listView3.SelectedItems[0];
                track = currentTrack.SubItems[3].Text;
                currentTrack.Selected = false;
            }

            else if (listView4.SelectedItems.Count > 0)
            {
                ListViewItem currentTrack = listView4.SelectedItems[0];
                track = currentTrack.SubItems[3].Text;
                currentTrack.Selected = false;
            }

            if (_currentUrlTrack != track)
            {
                await _spotify.PlayURL("https://open.spotify.com/track/" + track);
                SpotifyAPI.Local.Models.StatusResponse status = _spotify.GetStatus();
                if (status.Track != null)
                    UpdateTrack(status.Track, track);
            }
            else
            {
                await _spotify.Play();
            }

        }

        
        private async void btnPause_Click(object sender, EventArgs e)
        {
            await _spotify.Pause();
        }

        private void _spotify_OnTrackTimeChange(object sender, TrackTimeChangeEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => _spotify_OnTrackTimeChange(sender, e)));
                return;
            }
            lblTimeTrack.Text = $@"{FormatTime(e.TrackTime)}/{FormatTime(_currentTrack.Length)}";
            if (e.TrackTime < _currentTrack.Length)
                progressBarSong.Value = (int)e.TrackTime;
        }

        private static String FormatTime(double sec)
        {
            TimeSpan span = TimeSpan.FromSeconds(sec);
            String secs = span.Seconds.ToString(), mins = span.Minutes.ToString();
            if (secs.Length < 2)
                secs = "0" + secs;
            return mins + ":" + secs;
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            Lagu input = new Lagu();
            while (listView3.SelectedItems.Count > 0)
            {
                ListViewItem item = listView3.SelectedItems[0];
                input.Artis = item.SubItems[0].Text;
                input.Judul = item.SubItems[1].Text;
                input.Album = item.SubItems[2].Text;
                input.TrackID = item.SubItems[3].Text;
                try
                {
                    db.insertPlaylist(input);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                item.Selected = false;
            }
            updateDB();
        }

        private void updateDB()
        {
            listView4.Items.Clear();
            try
            {
                List<Lagu> playlist = db.getPlaylist();
                foreach (Lagu lagu in playlist)
                {
                    ListViewItem list = new ListViewItem(lagu.Artis);
                    list.SubItems.Add(lagu.Judul);
                    list.SubItems.Add(lagu.Album);
                    list.SubItems.Add(lagu.TrackID);
                    listView4.Items.Add(list);
                }
            }
            catch
            {
                MessageBox.Show("Gagal Mendapatkan Data");
            }
        }
    }
}
