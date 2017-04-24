using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MELibrary
{
    public class SongFinder
    {
        public static List<Lagu> GetSong(string Artis, string Judul)
        {

            List<Lagu> searchResult = new List<Lagu>();
            List<Lagu> returnvalue = null;
            WebClient client = new WebClient();
            string url = "https://api.spotify.com/v1/search?q=" + Uri.EscapeDataString("artist:" + Artis + " track:" + Judul) + "&type=track";
            try
            {
                string data = client.DownloadString(url);
                JObject obj = JObject.Parse(data);
                foreach (var item in obj["tracks"]["items"])
                {
                    string artis = (string)item["artists"][0]["name"];
                    string judul = (string)item["name"];
                    string album = (string)item["album"]["name"];
                    string track_id = (string)item["id"];
                    //ListViewItem lagu = new ListViewItem(artis);
                    searchResult.Add(new Lagu
                    {
                        Artis = artis,
                        Judul = judul,
                        Album = album,
                        TrackID = track_id
                    });
                }

                returnvalue = searchResult;
            }
            catch (WebException e)
            {
                string error = e.ToString();
            }

            return returnvalue;
        }
    }
}
