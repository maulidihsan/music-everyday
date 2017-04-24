using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace MELibrary
{
    class Token
    {
        private static string access_token;
        private static string credentials = "{CLIENT ID : CLIENT SECRET}"; //input your API client credentials;
        public static string GetAccessToken()
        {
            string return_value = string.Empty;
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials)));
                NameValueCollection type = new NameValueCollection
                {
                    {"grant_type", "client_credentials"}
                };
                string url = "https://accounts.spotify.com/api/token";
                byte[] data = client.UploadValues(url, "POST", type);
                string response = Encoding.UTF8.GetString(data);
                JObject obj = JObject.Parse(response);
                access_token = (string)obj["access_token"];
                return_value = access_token;
            }
            catch (WebException e)
            {
                string error = e.ToString();
            }

            return return_value;
        }
    }
}
