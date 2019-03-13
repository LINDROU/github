using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Essaie_Menu
{
    public partial class Page_Menu : UserControl
    {
        public Page_Menu()
        {
            InitializeComponent();
        }

        public static string COD4_folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "LindraTurnOn\\COD4"; // fps unlocker location
        public static string MW2_folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "LindraTurnOn\\MW2";
        public static string MW3_folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "LindraTurnOn\\MW3";

        #region Mouse Hover Next Page
        private void Next_Page_MouseHover(object sender, EventArgs e) //design of next_page button when your mouse is hover, I made it work but it's messy as fuck
        {
            Next_Page_lbl.ForeColor = Color.White;
            Next_Page.BackColor = Color.FromArgb(34, 42, 53);
            Next_Page_pic.BackColor = Color.White;
            my_hover = my_hover - 1;
        }

        private void Next_Page_lbl_MouseHover(object sender, EventArgs e)
        {
            Next_Page_lbl.ForeColor = Color.White;
            Next_Page.BackColor = Color.FromArgb(34, 42, 53);
            Next_Page_pic.BackColor = Color.White;
            my_hover = my_hover - 1;
        }

        private void Next_Page_pic_MouseHover(object sender, EventArgs e)
        {
            Next_Page_lbl.ForeColor = Color.White;
            Next_Page.BackColor = Color.FromArgb(34, 42, 53);
            Next_Page_pic.BackColor = Color.White;
            my_hover = my_hover - 1;
        }
        #endregion

        int my_hover=0;
        #region Mouse Leave Next Page
        private void Next_Page_MouseLeave(object sender, EventArgs e) //design of next_page button when your mouse is hover, I made it work but it's messy as fuck
        {
            my_hover = my_hover + 1;
            this_Hover();
        }

        private void Next_Page_lbl_MouseLeave(object sender, EventArgs e)
        {
            my_hover = my_hover + 1;
            this_Hover();
        }
        private void Next_Page_pic_MouseLeave(object sender, EventArgs e)
        {
            my_hover = my_hover + 1;
            this_Hover();
        }

        public void this_Hover()
        {
            if (my_hover >=2)
            {
                Next_Page_lbl.ForeColor = Color.FromArgb(34, 42, 53);
                Next_Page.BackColor = Color.White;
                Next_Page_pic.BackColor = Color.White;
            }

        }
        #endregion

        #region Toogle next page
        public int toogle=0; // this toogle different page in the form1 
        private void Next_Page_lbl_Click(object sender, EventArgs e)
        {
            toogle = 1;
        }

        private void Next_Page_pic_Click(object sender, EventArgs e)
        {
            toogle = 1;
        }

        private void Next_Page_Click(object sender, EventArgs e)
        {
            toogle = 1;
        }
        #endregion

        #region Toogle MW3 Page
        public int mw3_toogle = 0;
        private void Mw3_Panel_Click(object sender, EventArgs e)
        {
            mw3_toogle = 1;
        }

        private void Mw3_Label_Click(object sender, EventArgs e)
        {
            mw3_toogle = 1;
        
        }

        private void Mw3_Pic_Click(object sender, EventArgs e)
        {
            mw3_toogle = 1;

        }
        #endregion

        #region Check if fps unlocker are downloaded
        private void refresh_cod4_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(COD4_folder + "COD4_FpsUnlocker"))
            {
                Update_cod4.ForeColor = Color.Red;
                Update_cod4.Text = "Your COD4 Fps Unlocker isn't installed";
                Update_cod4.Location = new Point((COD4_pnl.Width - Update_cod4.Text.Length)/4, Update_cod4.Location.Y);
               // Directory.CreateDirectory(COD4_folder);
            }
            else
            {
                Update_cod4.ForeColor = Color.Green;
                Update_cod4.Text = "COD4 Fps Unlocker is allready installed";
                Update_cod4.Location = new Point((COD4_pnl.Width - Update_cod4.Text.Length)/4, Update_cod4.Location.Y);

            }
        
        }

        private void refresh_mw2_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(MW2_folder + "MW2_FpsUnlocker"))
            {
                Update_mw2.ForeColor = Color.Red;
                Update_mw2.Text = "Your MW2 Fps Unlocker isn't installed";
                Update_mw2.Location = new Point((Mw2_pnl.Width - Update_mw2.Text.Length)/4, Update_mw2.Location.Y);

            }
            else
            {
                Update_mw2.ForeColor = Color.Green;
                Update_mw2.Text = "MW2 Fps Unlocker is allready installed";
                Update_mw2.Location = new Point((Mw2_pnl.Width - Update_mw2.Text.Length)/4, Update_mw2.Location.Y);
            }
        }

        private void refresh_mw3_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(MW3_folder + "MW3_FpsUnlocker"))
            {
                Update_mw3.ForeColor = Color.Red;
                Update_mw3.Text = "Your MW3 Fps Unlocker aren't installed";
                Update_mw3.Location = new Point((Mw3_Panel.Width - Update_mw3.Text.Length)/4, Update_mw3.Location.Y);
            }
            else
            {
                Update_mw3.ForeColor = Color.Green;
                Update_mw3.Text = "MW3 Fps Unlocker are allready installed";
                Update_mw3.Location = new Point((Mw3_Panel.Width - Update_mw3.Text.Length)/4, Update_mw3.Location.Y);
               
            }
        }
        #endregion

        #region Download Fps Unlocker
        private void download_cod4_Click(object sender, EventArgs e)
        {
            if(File.Exists(COD4_folder + "COD4_MP"))
            {
                DialogResult msg = MessageBox.Show("You have allready download COD4 Fps Unlockers \n Do you want to download them again ?", "Error 0x001", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.OK)
                {
                    File.Delete(COD4_folder + "COD4_MP"); //delete old
                    // download new COD4 fps unlocker
                }
               
            }
            else
            {
                // download COD4 Fps unlocker
            }
        }

        private void download_mw2_Click(object sender, EventArgs e)
        {
            if (File.Exists(MW2_folder + "MW2_SP") && File.Exists(MW2_folder + "MW2_MP"))
            {
                DialogResult msg = MessageBox.Show("You have allready download MW2 Fps Unlockers \n Do you want to download them again ?", "Error 0x001", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.OK)
                {
                    File.Delete(MW2_folder + "MW2_SP"); // delete old
                    File.Delete(MW2_folder + "MW2_MP"); // delete old
                    // download new MW2 fps unlocker
                }

            }
            else
            {
                // download MW2 Fps unlocker
            }
        }

        private void download_mw3_Click(object sender, EventArgs e)
        {
            if (File.Exists(MW3_folder + "MW3_SP") && File.Exists(MW3_folder + "MW3_MP") && File.Exists(MW3_folder + "MW3_TK"))
            {
                DialogResult msg = MessageBox.Show("You have allready download MW3 Fps Unlockers \n Do you want to download them again ?", "Error 0x001", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.OK)
                {
                    File.Delete(MW3_folder + "MW3_SP"); // delete old
                    File.Delete(MW3_folder + "MW3_MP"); // delete old
                    File.Delete(MW3_folder + "MW3_TK"); // delete old
                   // download new MW3 fps unlocker

                }

            }
            else
            {
                // download MW3 Fps unlocker
            }
        }

        #endregion

        #region toogle MW2 Page
        public int mw2_toogle = 0; // this thing works with form1 and it use a simple int to know if he add to show or not (i tryed with a bool, which doesn't work)
        private void Mw2_pnl_Click(object sender, EventArgs e)
        {
            mw2_toogle = 1;
        }

        private void Mw2_Label_Click(object sender, EventArgs e)
        {
            mw2_toogle = 1;
        }

        private void Mw2_pic_Click(object sender, EventArgs e)
        {
            mw2_toogle = 1;
        }
        #endregion
    }
}