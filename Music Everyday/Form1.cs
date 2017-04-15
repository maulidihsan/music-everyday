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
        string credentials = "dfe0e6a795634db3a099e739de690f48:56addc812a8d40aabf7d318ea3b33f01";
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
            if (artis == "")
            {
                artis = "*";
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
                    url = url + "seed_tracks=" + item.SubItems[3].Text + "&";
                }
                url = url.Remove(url.Length-1);
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

        private void btnPindah_Click(object sender, EventArgs e)
        {
            while (listView1.SelectedItems.Count > 0)
            {
                ListViewItem temp = listView1.SelectedItems[0];
                listView1.Items.Remove(temp);
                listView2.Items.Add(temp);
            }
        }

        private void btnSeed_Click(object sender, EventArgs e)
        {
            if (!GetAccessToken())
            {
                MessageBox.Show("Gagal Mendapatkan Access Token", "Gagal", MessageBoxButtons.OK);
            }

            if (!GetRecommendation())
            {
                MessageBox.Show("Gagal Mencari Rekomendasi", "Gagal", MessageBoxButtons.OK);
            }
        }
    }
}
