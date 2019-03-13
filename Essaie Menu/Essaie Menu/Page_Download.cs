using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace Essaie_Menu
{
    public partial class Page_Download : UserControl
    {
        public Page_Download()
        {
            InitializeComponent();
            string config_folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "TCUN";
            config_lbl.Text = "All Your config : " + config_folder;
            download_timer.Start();
           
        }
    
        private void directory_config_Click(object sender, EventArgs e)
        {
            string config_folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "TCUN";
            Process.Start(config_folder);
        }

        private void download_timer_Tick(object sender, EventArgs e)
        {
      
        }
    }
}
