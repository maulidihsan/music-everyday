using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Music_Everyday
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.StyleManager = styleManager;
            lvCari.BackColor = Color.FromArgb(42, 42, 42);
            lvSample.BackColor = Color.FromArgb(42, 42, 42);
            lvRekomendasi.BackColor = Color.FromArgb(42, 42, 42);
            lvPlaylist.BackColor = Color.FromArgb(42, 42, 42);
        }
    }
}
