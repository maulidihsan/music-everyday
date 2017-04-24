using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Everyday
{
    public partial class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            InitializeComponent();
            savedPreference();

        }

        private void savedPreference()
        {
            if(UserPreferences.Accousticness.HasValue)
            {
                tbAccoust.Enabled = true;
                checkBoxAccoust.Checked = true;
                tbAccoust.Value = (int)UserPreferences.Accousticness;
            }

            if(UserPreferences.Danceablity.HasValue)
            {
                tbDance.Enabled = true;
                checkBoxDance.Checked = true;
                tbDance.Value = (int)UserPreferences.Danceablity;
            }

            if(UserPreferences.Energy.HasValue)
            {
                tbEnergy.Enabled = true;
                checkBoxEnergy.Checked = true;
                tbEnergy.Value = (int)UserPreferences.Energy;
            }

            if(UserPreferences.Instrumentality.HasValue)
            {
                tbInstrument.Enabled = true;
                checkBoxInstrument.Checked = true;
                tbInstrument.Value = (int)UserPreferences.Instrumentality;
            }

            if(UserPreferences.Popularity.HasValue)
            {
                tbPopularity.Enabled = true;
                checkBoxPop.Checked = true;
                tbPopularity.Value = (int)UserPreferences.Popularity;
            }
        }

        public static string Query { get; set; }
        private void checkBoxAccoust_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAccoust.Checked)
            {
                tbAccoust.Enabled = true;
                label3.Enabled = true;
            }

            else
            {
                tbAccoust.Enabled = false;
                label3.Enabled = false;
                UserPreferences.Accousticness = null;
            }

        }

        private void checkBoxDance_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDance.Checked)
            {
                tbDance.Enabled = true;
                label4.Enabled = true;
            }

            else
            {
                tbDance.Enabled = false;
                label4.Enabled = false;
                UserPreferences.Danceablity = null;
            }

        }

        private void checkBoxEnergy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnergy.Checked)
            {
                tbEnergy.Enabled = true;
                label5.Enabled = true;
            }

            else
            {
                tbEnergy.Enabled = false;
                label5.Enabled = false;
                UserPreferences.Danceablity = null;
            }

        }

        private void checkBoxInstrument_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInstrument.Checked)
            {
                tbInstrument.Enabled = true;
                label6.Enabled = true;
            }

            else
            {
                tbInstrument.Enabled = false;
                label6.Enabled = false;
                UserPreferences.Instrumentality = null;
            }

        }

        private void checkBoxPop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPop.Checked)
            {
                tbPopularity.Enabled = true;
                label7.Enabled = true;
            }

            else
            {
                tbPopularity.Enabled = false;
                label7.Enabled = false;
                UserPreferences.Popularity = null;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Query = "";
            if (checkBoxAccoust.Checked)
            {
                UserPreferences.Accousticness = tbAccoust.Value;
                Query += "&target_accousticness=" + ((float)UserPreferences.Accousticness / 10).ToString();
            }

            if (checkBoxDance.Checked)
            {
                UserPreferences.Danceablity = tbDance.Value;
                Query += "&target_danceability=" + ((float)UserPreferences.Danceablity / 10).ToString();
            }

            if (checkBoxEnergy.Checked)
            {
                UserPreferences.Energy = tbEnergy.Value;
                Query += "&target_energy=" + ((float)UserPreferences.Energy / 10).ToString();
            }

            if (checkBoxInstrument.Checked)
            {
                UserPreferences.Instrumentality = tbInstrument.Value;
                Query += "&target_instrumentalness=" + ((float)UserPreferences.Instrumentality / 10).ToString();
            }

            if (checkBoxPop.Checked)
            {
                UserPreferences.Popularity = tbPopularity.Value;
                Query += "&target_popularity=" + (UserPreferences.Popularity * 10).ToString();
            }

            Close();
        }

    }
}
