using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Essaie_Menu
{
    public partial class Page_Option : UserControl
    {
        public Page_Option()
        {
            InitializeComponent();
        }

        public string my_config = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TCUN"); // where config located

        #region  Configs location
        private void Open_configs_pic_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(my_config)) // if config exist then it can open the config folder if not it will not open anything
                Process.Start(my_config);
            else
                MessageBox.Show("You havent saved any config, try to save one before opening this folder again !","Configs foler is EMPTY !",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Open_configs_lbl_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(my_config)) // if config exist then it can open the config folder if not it will not open anything
                Process.Start(my_config);
            else
                MessageBox.Show("You havent saved any config, try to save one before opening this folder again !", "Configs foler is EMPTY !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Delete FPS unlocker
        public static string menu_folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "LindraTurnOn"; //Menu folder location
        private void Delete_Fps_lbl_Click(object sender, EventArgs e)
        {
          DialogResult dr =  MessageBox.Show("All your Fps Unlocker will be deleted but you will keep your configs !", "DELETE all fps unlocker", MessageBoxButtons.OKCancel,MessageBoxIcon.Information); //get the Dialog result and check if ok or cancel
            if (dr == DialogResult.OK)
            {
                if (Directory.Exists(menu_folder)) // if ok delete everything if cancel do nothing
                    Directory.Delete(menu_folder, true);
            }     
                      
        }

        private void Delete_Fps_pic_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("All your Fps Unlocker will be deleted but you will keep your configs !", "DELETE all fps unlocker", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                if (Directory.Exists(menu_folder))
                    Directory.Delete(menu_folder, true);
            }
        }
        #endregion

        private void FAQ_pic_Click(object sender, EventArgs e)
        {
            Process.Start(""); // add FAQ Page
        }
    }
}
