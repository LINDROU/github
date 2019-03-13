using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Essaie_Menu
{
    public partial class Page_Menu_2 : UserControl
    {
        public Page_Menu_2()
        {
            InitializeComponent();
            check_exist();
            
        }
        WebClient web = new WebClient();
        public static string BO1_folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "LindraTurnOn\\BO1"; // location of the fps unlockers folders
        public static string BO2_folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "LindraTurnOn\\BO2";
        public static string GHOST_folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "LindraTurnOn\\GHOST";

   

        #region Mouse Hover Next Page
        private void Next_Page_MouseHover(object sender, EventArgs e) //design of next page when your mouse is hover, I made it work but it's messy as fuck
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

        int my_hover = 0;
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
            if (my_hover >= 2)
            {
                Next_Page_lbl.ForeColor = Color.FromArgb(34, 42, 53);
                Next_Page.BackColor = Color.White;
                Next_Page_pic.BackColor = Color.White;
            }

        }
        #endregion

        #region Toogle next page
        public int toogle = 1; // this thing works with form1 and it use a simple int to know if he add to show or not (i tryed with a bool, which doesn't work)
        private void Next_Page_lbl_Click(object sender, EventArgs e)
        {
            toogle = 0;
        }

        private void Next_Page_pic_Click(object sender, EventArgs e)
        {
            toogle = 0;
        }

        private void Next_Page_Click(object sender, EventArgs e)
        {
            toogle = 0;
        }


        #endregion

        //Directory.CreateDirectory(menu_folder + "\\MW2");
        //    Directory.CreateDirectory(menu_folder + "\\MW3");
        #region Check if fps unlocker exists
        private void refresh_BO1_Click(object sender, EventArgs e)
        {
            //download 
            string my_version_bo1 = web.DownloadString("https://dl.dropbox.com/s/g26n58fr9z1aybu/MP_Version.txt?dl=0");
            //
            if (!File.Exists(BO1_folder + "\\BO1_MP"+my_version_bo1+".exe")) // if fps unlocker doesn't exist 
            {
                Update_bo1.ForeColor = Color.Red; // change the color of the label to red
                Update_bo1.Text = "Your BO1 Fps Unlocker isn't installed"; // write ... in a label
                Update_bo1.Location = new Point((bo1_pnl.Width + Update_bo1.Text.Length)/4, Update_bo1.Location.Y); // change location of the label (close to be centered but not really ^^)
                // Directory.CreateDirectory(COD4_folder);
            }
            else // if exist
            {
                Update_bo1.ForeColor = Color.Green; // change the color of the label to green
                Update_bo1.Text = "BO1 Fps Unlocker is allready installed"; // write ... in a label
                Update_bo1.Location = new Point((bo1_pnl.Width + Update_bo1.Text.Length)/4, Update_bo1.Location.Y); // change location of the label (close to be centered but not really ^^)
            }

        }

        private void refresh_BO2_Click(object sender, EventArgs e)
        {
            //download version
            string my_version = web.DownloadString("https://dl.dropbox.com/s/jr49dc8d9yfy4mi/MP_Version.txt?dl=0");
            string my_version1 = web.DownloadString("https://dl.dropbox.com/s/xm9s0zndl92ytgg/SP_Version.txt?dl=0");
            string my_version2 = web.DownloadString("https://dl.dropbox.com/s/k2tw2mapj5vi74l/ZM_Version.txt?dl=0");
            //
            if (!File.Exists(BO2_folder + "\\BO2_SP"+my_version1+".exe") || !File.Exists(BO2_folder + "\\BO2_MP"+my_version+".exe") || !File.Exists(BO2_folder + "\\BO2_ZM"+my_version2+".exe"))
            {
                Update_bo2.ForeColor = Color.Red;
                Update_bo2.Text = "Your BO2 Fps Unlocker isn't installed";
                Update_bo2.Location = new Point((bo2_pnl.Width + Update_bo2.Text.Length)/4, Update_bo2.Location.Y);
            }
            else
            {
                Update_bo2.ForeColor = Color.Green;
                Update_bo2.Text = "BO2 Fps Unlocker is allready installed";
                Update_bo2.Location = new Point((bo2_pnl.Width - Update_bo2.Text.Length)/4, Update_bo2.Location.Y);
            }
        }

        private void refresh_GHOST_Click(object sender, EventArgs e)
        {
            //download version 
            string my_version = web.DownloadString("https://dl.dropbox.com/s/eiyndin2rd029cd/MP_Version.txt?dl=0");
            string my_version1 = web.DownloadString("https://dl.dropbox.com/s/ph08li21golarb3/SP_Version.txt?dl=0");
            //
            if (!File.Exists(GHOST_folder + "GHOST_SP"+my_version1+".exe") || !File.Exists(GHOST_folder + "GHOST_MP"+my_version+".exe"))
            {
                Update_Ghost.ForeColor = Color.Red;
                Update_Ghost.Text = "Your Ghost Fps Unlocker isn't installed";
                Update_Ghost.Location = new Point((ghost_pnl.Width + Update_Ghost.Text.Length)/4, Update_Ghost.Location.Y);
            }
            else
            {
                Update_Ghost.ForeColor = Color.Green;
                Update_Ghost.Text = "Ghost Fps Unlocker is allready installed";
                Update_Ghost.Location = new Point((ghost_pnl.Width+ Update_Ghost.Text.Length)/4, Update_Ghost.Location.Y);
           }
        }
        #endregion

        #region Download Fps unlockers
        private void download_bo1_Click(object sender, EventArgs e)
        {
            //download 
            string my_version = web.DownloadString("https://dl.dropbox.com/s/g26n58fr9z1aybu/MP_Version.txt?dl=0");
            //
            if (File.Exists(BO1_folder + "\\BO1_MP" + my_version + ".exe")) // if fps unlocker does exist 
                {
                DialogResult msg = MessageBox.Show("You have allready download BO1 Fps Unlockers \n Do you want to download them again ?", "Error 0x001", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.OK)
                {
                    File.Delete(BO1_folder + "BO1_MP"); // delete old
                    // download new BO1 fps unlocker
                }

            }
            else
            {
                // download BO1 Fps unlocker
            }
        }

        private void download_bo2_Click(object sender, EventArgs e)
        {
            if (File.Exists(BO2_folder + "BO2_SP") && File.Exists(BO2_folder + "BO2_MP") && File.Exists(BO2_folder + "BO2_ZM"))
            {
                DialogResult msg = MessageBox.Show("You have allready download BO2 Fps Unlockers \n Do you want to download them again ?", "Error 0x001", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.OK)
                {
                    File.Delete(BO2_folder + "BO2_SP"); // delete old
                    File.Delete(BO2_folder + "BO2_MP"); // delete old
                    File.Delete(BO2_folder + "BO2_ZM"); // delete old
                    // download BO2 fps unlocker
                }

            }
            else
            {
                // download BO2 Fps unlocker
            }
        }

        private void download_ghost_Click(object sender, EventArgs e)
        {
            if (File.Exists(GHOST_folder + "GHOST_SP") && File.Exists(GHOST_folder + "GHOST_MP"))
            {
                DialogResult msg = MessageBox.Show("You have allready download GHOST Fps Unlockers \n Do you want to download them again ?", "Error 0x001", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.OK)
                {
                    File.Delete(GHOST_folder + "GHOST_SP"); // delete old
                    File.Delete(GHOST_folder + "GHOST_MP"); // delete old
                    // download Ghost fps unlocker
                }

            }
            else
            {
                // download Ghost Fps unlocker
            }
        }
        #endregion

        #region Toogle BO2 Page
        public int bo2_toogle = 0;

        private void bo2_pnl_Click(object sender, EventArgs e)
        {
            bo2_toogle = 1;
        }

        private void bo2_lbl_Click(object sender, EventArgs e)
        {
            bo2_toogle = 1;
        }

        private void bo2_img_Click(object sender, EventArgs e)
        {
            bo2_toogle = 1;
        }
        #endregion

        #region Toogle ghost Page
        public int ghost_toogle = 0;
        private void ghost_lbl_Click(object sender, EventArgs e)
        {
            ghost_toogle = 1;
        }

        private void ghost_img_Click(object sender, EventArgs e)
        {
            ghost_toogle = 1;
        }

        private void ghost_pnl_Click(object sender, EventArgs e)
        {
            ghost_toogle = 1;
        }
        #endregion

        #region Exist + trash
        public void check_exist()
        {
            //download version 
            string my_version_bo1 = web.DownloadString("https://dl.dropbox.com/s/g26n58fr9z1aybu/MP_Version.txt?dl=0");
            string my_version_bo2_mp = web.DownloadString("https://dl.dropbox.com/s/jr49dc8d9yfy4mi/MP_Version.txt?dl=0");
            string my_version_bo2_sp = web.DownloadString("https://dl.dropbox.com/s/xm9s0zndl92ytgg/SP_Version.txt?dl=0");
            string my_version_bo2_zm = web.DownloadString("https://dl.dropbox.com/s/k2tw2mapj5vi74l/ZM_Version.txt?dl=0");
            string my_version_ghost_mp = web.DownloadString("https://dl.dropbox.com/s/eiyndin2rd029cd/MP_Version.txt?dl=0");
            string my_version_ghost_sp = web.DownloadString("https://dl.dropbox.com/s/ph08li21golarb3/SP_Version.txt?dl=0");
            //

            if (File.Exists(BO1_folder + "BO1_MP" + my_version_bo1 + ".exe"))
                trash_bo1.Visible = true;
            if (File.Exists(BO2_folder + "BO2_MP" + my_version_bo2_mp + ".exe") && File.Exists(BO2_folder + "BO2_SP" + my_version_bo2_sp + ".exe") && File.Exists(BO2_folder + "BO2_ZM" + my_version_bo2_zm + ".exe"))
                trash_bo2.Visible = true;
            if (File.Exists(GHOST_folder + "GHOST_MP" + my_version_ghost_mp + ".exe") && File.Exists(GHOST_folder + "GHOST_SP" + my_version_ghost_sp + ".exe"))
                trash_ghost.Visible = true;
        }

        private void trash_bo1_Click(object sender, EventArgs e)
        {
            string my_version_bo1 = web.DownloadString("https://dl.dropbox.com/s/g26n58fr9z1aybu/MP_Version.txt?dl=0");
            File.Delete(BO1_folder + "BO1_MP" + my_version_bo1 + ".exe");
        }

        private void trash_bo2_Click(object sender, EventArgs e)
        {
            string my_version_bo2_mp = web.DownloadString("https://dl.dropbox.com/s/jr49dc8d9yfy4mi/MP_Version.txt?dl=0");
            string my_version_bo2_sp = web.DownloadString("https://dl.dropbox.com/s/xm9s0zndl92ytgg/SP_Version.txt?dl=0");
            string my_version_bo2_zm = web.DownloadString("https://dl.dropbox.com/s/k2tw2mapj5vi74l/ZM_Version.txt?dl=0");
            File.Delete(BO2_folder + "BO2_SP" + my_version_bo2_sp + ".exe");
            File.Delete(BO2_folder + "BO2_MP" + my_version_bo2_mp + ".exe");
            File.Delete(BO2_folder + "BO2_ZM" + my_version_bo2_zm + ".exe");
        }

        private void trash_ghost_Click(object sender, EventArgs e)
        {
            string my_version_ghost_mp = web.DownloadString("https://dl.dropbox.com/s/eiyndin2rd029cd/MP_Version.txt?dl=0");
            string my_version_ghost_sp = web.DownloadString("https://dl.dropbox.com/s/ph08li21golarb3/SP_Version.txt?dl=0");
            File.Delete(GHOST_folder + "GHOST_SP" + my_version_ghost_sp+ ".exe");
            File.Delete(GHOST_folder + "GHOST_MP" + my_version_ghost_mp + ".exe");

        }
        #endregion 
    }
}
