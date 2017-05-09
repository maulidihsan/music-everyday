using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using MELibrary;
using System.Threading.Tasks;

namespace Music_Everyday
{
    class DBHelper
    {
        SQLiteConnection connect = new SQLiteConnection("Data Source=music_everyday.db; Version=3; New=False; Compress=True");
        SQLiteCommand command;

        public void insertPlaylist(Lagu input)
        {
            input = escape(input);
            connect.Open();
            string query = "INSERT INTO playlist (track_id, nama_artis, judul_lagu, judul_album) VALUES(" +
                    "'" + input.TrackID + "'," +
                    "'" + input.Artis + "'," +
                    "'" + input.Judul + "'," +
                    "'" + input.Album + "');";
            command = new SQLiteCommand(query, connect);
            command.ExecuteNonQuery();
            connect.Close();
        }

        public List<Lagu> getPlaylist()
        {
            List<Lagu> playlist = new List<Lagu>();
            Lagu lagu;
            connect.Open();
            string query = "SELECT * FROM playlist;";
            command = new SQLiteCommand(query, connect);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lagu = new Lagu();
                lagu.TrackID = reader.GetString(reader.GetOrdinal("track_id"));
                lagu.Artis = reader.GetString(reader.GetOrdinal("nama_artis"));
                lagu.Judul = reader.GetString(reader.GetOrdinal("judul_lagu"));
                lagu.Album = reader.GetString(reader.GetOrdinal("judul_album"));
                playlist.Add(lagu);
            }
            reader.Close();
            connect.Close();
            return playlist;
        }

        public void deletePlaylist(List<Lagu> input)
        {
            connect.Open();
            foreach (Lagu item in input)
            {
                string query = "DELETE FROM playlist WHERE track_id ='" + item.TrackID + "';";
                command = new SQLiteCommand(query, connect);
                command.ExecuteNonQuery();
            }
            connect.Close();
        }

        public Lagu escape(Lagu input)
        {
            input.Album = input.Album.Replace("'", "''");
            input.Judul = input.Judul.Replace("'", "''");
            input.Artis = input.Artis.Replace("'", "''");
            input.Album = input.Album.Replace("'", "''");
            return input;
        }
    }
}
