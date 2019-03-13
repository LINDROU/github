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
using System.Diagnostics;

namespace Essaie_Menu
{
    public partial class Page_Ghost : UserControl
    {
        public Page_Ghost()
        {
            InitializeComponent();
        }

        public string MW3_location = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "LindraTurnOn\\BO2";

        #region Toogle back to menu 
        public int ghost_toogle = 1;
        private void Next_Page_pic_Click(object sender, EventArgs e)
        {
            ghost_toogle = 0;
        }

        private void Next_Page_lbl_Click(object sender, EventArgs e)
        {
            ghost_toogle = 0;
        }

        private void Next_Page_Click(object sender, EventArgs e)
        {
            ghost_toogle = 0;
        }
        #endregion

        #region Mouse Hover Next Page
        private void Next_Page_MouseHover(object sender, EventArgs e)
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
        private void Next_Page_MouseLeave(object sender, EventArgs e)
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

        #region Ghost SP
        private void MW3_SP_lbl_Click(object sender, EventArgs e)
        {
            if (File.Exists(MW3_location + "\\GHOST_SP.exe"))
            {
                Process.Start(MW3_location + "\\GHOST_SP.exe");
            }
            else
                MessageBox.Show("TCUN haven't found your GHOST Single Player fps unlocker\n Try to download it again !", "BO2 Single Player fps unlocker Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MW3_SP_pnl_Click(object sender, EventArgs e)
        {
            if (File.Exists(MW3_location + "\\GHOST_SP.exe"))
            {
                Process.Start(MW3_location + "\\GHOST_SP.exe");
            }
            else
                MessageBox.Show("TCUN haven't found your GHOST Single Player fps unlocker\n Try to download it again !", "BO2 Single Player fps unlocker Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MW3_SP_pic_Click(object sender, EventArgs e)
        {
            if (File.Exists(MW3_location + "\\GHOST_SP.exe"))
            {
                Process.Start(MW3_location + "\\GHOST_SP.exe");
            }
            else
                MessageBox.Show("TCUN haven't found your GHOST Single Player fps unlocker\n Try to download it again !", "BO2 Single Player fps unlocker Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Ghost MP
        private void MW3_MP_pnl_Click(object sender, EventArgs e) // mp fps unlocker check if exist, and etc
        {
            {
                if (File.Exists(MW3_location + "\\GHOST_MP.exe"))
                {
                    Process.Start(MW3_location + "\\GHOST_MP.exe");
                }
                else
                    MessageBox.Show("TCUN haven't found your GHOST Multi-Player fps unlocker\n Try to download it again !", "BO2 Multi-Player fps unlocker Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MW3_MP_lbl_Click(object sender, EventArgs e)
        {
            {
                if (File.Exists(MW3_location + "\\GHOST_MP.exe"))
                {
                    Process.Start(MW3_location + "\\GHOST_MP.exe");
                }
                else
                    MessageBox.Show("TCUN haven't found your GHOST Multi-Player fps unlocker\n Try to download it again !", "BO2 Multi-Player fps unlocker Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MW3_MP_pic_Click(object sender, EventArgs e)
        {
            {
                if (File.Exists(MW3_location + "\\GHOST_MP.exe"))
                {
                    Process.Start(MW3_location + "\\GHOST_MP.exe");
                }
                else
                    MessageBox.Show("TCUN haven't found your GHOST Multi-Player fps unlocker\n Try to download it again !", "BO2 Multi-Player fps unlocker Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion // // mp fps unlocker

  

    }
}
