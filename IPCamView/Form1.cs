using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCamView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axVLCPlugin21.playlist.add("http://mm2.pcslab.com/mm/7h800.mp4");
            axVLCPlugin21.playlist.play();
        }

        private void axVLCPlugin21_Enter(object sender, EventArgs e)
        {

        }

        private void axVLCPlugin22_Enter(object sender, EventArgs e)
        {

        }
    }
}
