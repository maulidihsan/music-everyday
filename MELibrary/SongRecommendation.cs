using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MELibrary
{
    public class SongRecommendation
    {
        public static  List<Lagu> GetRecommendation(string query)
        {
            List<Lagu> recommendResult = new List<Lagu>();
            List<Lagu> returnvalue = null;
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("Authorization", "Bearer " + Token.GetAccessToken());
                string url = "https://api.spotify.com/v1/recommendations?" + query;
                string data = client.DownloadString(url);
                JObject obj = JObject.Parse(data);
                foreach (var item in obj["tracks"])
                {
                    string artis = (string)item["artists"][0]["name"];
                    string judul = (string)item["name"];
                    string album = (string)item["album"]["name"];
                    string track_id = (string)item["id"];
                    recommendResult.Add(new Lagu
                    {
                        Artis = artis,
                        Judul = judul,
                        Album = album,
                        TrackID = track_id
                    });
                }
                returnvalue = recommendResult;
            }
            catch (Exception e)
            {
                string error = e.ToString();
            }
            return returnvalue;
        }
    }
}
