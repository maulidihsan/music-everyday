using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace Music_Everyday
{
    public partial class Form1 : Form
    {
        string credentials = "{YOUR API CREDENTIALS}";
        string access_token;
        public Form1()
        {
            InitializeComponent();
        }

        public bool GetAccessToken()
        {
            WebClient client = new WebClient();
            client.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials)));
            NameValueCollection type = new NameValueCollection
            {
              {"grant_type", "client_credentials"}
            };
            string url = "https://accounts.spotify.com/api/token";
            try
            {
                byte[] data = client.UploadValues(url, "POST", type);
                string response = Encoding.UTF8.GetString(data);
                JObject obj = JObject.Parse(response);
                access_token = (string)obj["access_token"];
                return true;
            }
            catch (WebException)
            {

                return false;
            }
        }

        public bool GetSong(string artis, string judul)
        {
            if (artis == "" && judul == "")
            {
                MessageBox.Show("Masukkan artis dan judul", "Error", MessageBoxButtons.OK);
                return false;
            }
            else if (artis == "")
            {
                judul = "*";
            }
            else if (judul == "")
            {
                judul = "*";
            }
                
            WebClient client = new WebClient();
            string url = "https://api.spotify.com/v1/search?q=" + Uri.EscapeDataString("artist:" + artis + " track:" + judul) + "&type=track";
            try
            {
                string data = client.DownloadString(url);
                txtHasil.Text = data;
                JObject obj = JObject.Parse(data);
                foreach( var item in obj["tracks"]["items"])
                {
                    artis = (string)item["artists"][0]["name"];
                    judul = (string)item["name"];
                    string album = (string)item["album"]["name"];
                    string track_id = (string)item["id"];
                    txtHasil.Text = artis + judul + track_id;
                    ListViewItem lagu = new ListViewItem(artis);
                    lagu.SubItems.Add(judul);
                    lagu.SubItems.Add(album);
                    lagu.SubItems.Add(track_id);
                    listView1.Items.Add(lagu);
                }
                
                return true;
            }
            catch (WebException e)
            {
                txtHasil.Text = e.ToString();
                return false;
            }
        }

        public bool GetRecommendation()
        {
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("Authorization", "Bearer " + access_token);
                string url = "https://api.spotify.com/v1/recommendations?";
                foreach(ListViewItem item in listView2.Items)
                {
                    url += "seed_tracks=" + item.SubItems[3].Text + "&";
                }
                url = url.Remove(url.Length-1);
                url += GetSetting();
                string data = client.DownloadString(url);
                JObject obj = JObject.Parse(data);
                foreach (var item in obj["tracks"])
                {
                    string artis = (string)item["artists"][0]["name"];
                    string judul = (string)item["name"];
                    string album = (string)item["album"]["name"];
                    string track_id = (string)item["id"];
                    txtHasil.Text = artis + judul + track_id;
                    ListViewItem lagu = new ListViewItem(artis);
                    lagu.SubItems.Add(judul);
                    lagu.SubItems.Add(album);
                    lagu.SubItems.Add(track_id);
                    listView3.Items.Add(lagu);
                }
                return true;
            }
            catch(Exception e)
            {
                txtHasil.Text = e.ToString();
                return false;
            }
        }

        private void butToken_Click(object sender, EventArgs e)
        {
            if (GetAccessToken())
            {
                MessageBox.Show("Access Token Berhasil Didapatkan", "Berhasil", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Gagal Mendapatkan Access Token", "Gagal", MessageBoxButtons.OK);
            }

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string artis = textArtist.Text;
            string judul = textJudul.Text;
            if (!GetSong(artis, judul))
            {
                MessageBox.Show("Gagal Mencari Data", "Gagal", MessageBoxButtons.OK);
            }
                

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

        private void btnSeed_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            if (!GetAccessToken())
            {
                MessageBox.Show("Gagal Mendapatkan Access Token", "Gagal", MessageBoxButtons.OK);
            }

            if (!GetRecommendation())
            {
                MessageBox.Show("Gagal Mencari Rekomendasi", "Gagal", MessageBoxButtons.OK);
            }
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

        public string GetSetting()
        {
            string set_url = "";
            if (checkBoxAccoust.Checked)
            {
                int accoustic = tbAccoust.Value / 10;
                set_url = set_url + "&target_accousticness=" + accoustic.ToString();
            }

            if (checkBoxDance.Checked)
            {
                int dance = tbDance.Value / 10;
                set_url = set_url + "&target_danceability=" + dance.ToString();
            }

            if (checkBoxEnergy.Checked)
            {
                int energy = tbEnergy.Value / 10;
                set_url = set_url + "&target_energy=" + energy.ToString();
            }

            if (checkBoxInstrument.Checked)
            {
                int instrument = tbInstrument.Value / 10;
                set_url = set_url + "&target_instrumentalness=" + instrument.ToString();
            }

            if (checkBoxPop.Checked)
            {
                int popular = tbPopularity.Value * 10;
                set_url = set_url + "&target_popularity=" + popular.ToString();
            }
            return set_url;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
