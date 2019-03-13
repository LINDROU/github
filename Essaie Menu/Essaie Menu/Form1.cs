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

namespace Essaie_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Side_panel default_size = 220;600 minnimize = 80;600
        int panel;
        #region Moove the form 
        private bool isDown;

        private void Top_bar_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void Top_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown == true)
                this.Location = new Point((MousePosition.X - this.Width / 2), (MousePosition.Y));
        }

        private void Top_bar_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        #endregion

        #region Menu activation
        private void Menu_panel_MouseClick(object sender, MouseEventArgs e)
        {
            myMenu();
        }

        private void Menu_lbl_Click(object sender, EventArgs e)
        {
            myMenu();
        }

        private void Menu_pic_Click(object sender, EventArgs e)
        {
            myMenu();
        }
        public void myMenu()
        {
            Menu_panel.BackColor = Color.White;
            Menu_lbl.ForeColor = Color.FromArgb(34, 42, 53);
            Menu_pic.BackColor = Color.FromArgb(34, 42, 53);
            myDDLoff();
            myOptionoff();
            page_Menu1.BringToFront();
            panel = 1;
        }
        public void myMenuoff()
        {
            Menu_panel.BackColor = Color.FromArgb(34, 42, 53);
            Menu_lbl.ForeColor = Color.White;
            Menu_pic.BackColor = Color.FromArgb(34, 42, 53);

        }
        #endregion

        #region Download Activation 
        private void DDL_panel_Click(object sender, EventArgs e)
        {
            myDDL();
        }

        private void DDL_lbl_Click(object sender, EventArgs e)
        {
            myDDL();
        }

        private void DDL_pic_Click(object sender, EventArgs e)
        {
            myDDL();

        }
        public void myDDL()
        {
            myMenuoff();
            myOptionoff();
            DDL_panel.BackColor = Color.White;
            DDL_lbl.ForeColor = Color.FromArgb(34, 42, 53);
            DDL_pic.BackColor = Color.FromArgb(34, 42, 53);
            page_Download1.BringToFront();
            page_Download1.Width = page_Menu1.Width;
            page_Download1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
            panel = 2;
           
        }
        public void myDDLoff()
        {
            DDL_panel.BackColor = Color.FromArgb(34, 42, 53);
            DDL_lbl.ForeColor = Color.White;
            DDL_pic.BackColor = Color.FromArgb(34, 42, 53);
        }
        #endregion

        #region CLose Form
        private void CloseFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Minimize Form
        private void minimize_pic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Option Activation
        private void Option_panel_Click(object sender, EventArgs e)
        {
            myOption();
        }

        private void Option_lbl_Click(object sender, EventArgs e)
        {
            myOption();
        }

        private void Option_pic_Click(object sender, EventArgs e)
        {
            myOption();
        }

        public void myOption()
        {
            myMenuoff();
            myDDLoff();
            Option_panel.BackColor = Color.White;
            Option_lbl.ForeColor = Color.FromArgb(34, 42, 53);
            Option_pic.BackColor = Color.FromArgb(34, 42, 53);
            page_Option1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
            panel = 3;
            page_Option1.BringToFront();
        }
        public void myOptionoff()
        {
            Option_panel.BackColor = Color.FromArgb(34, 42, 53);
            Option_lbl.ForeColor = Color.White;
            Option_pic.BackColor = Color.FromArgb(34, 42, 53);
        }
        #endregion

        #region Side Panel Change SIZE
        bool mini = true;
        private void Change_Side_Panel_Click(object sender, EventArgs e)
        {
            mini = !mini;
            if (mini == true)
            {
                Side_panel.Width = 220;
                Menu_panel.Width = 214;
                DDL_panel.Width = 214;
                Option_panel.Width = 214;
                wd_title.Text = "The Cheat U Need";
                this.Width = 1000;
                login_pnl.Location = new Point(846, 3);
                minimize_pic.Location = new Point(951, 3);
                CloseFrm.Location = new Point(977, 3);
            }

            else
            {
                Side_panel.Width = 80;
                Menu_panel.Width = 74;
                DDL_panel.Width = 74;
                Option_panel.Width = 74;
                wd_title.Text = "TCUN";
                this.Width = 880;
                login_pnl.Location = new Point(726,3);
                minimize_pic.Location = new Point(831, 3);
                CloseFrm.Location = new Point(857, 3);
            }


            if (panel == 1)
            {
                page_Menu1.BringToFront();
                page_Download1.Width = page_Menu1.Width;
                page_Download1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Menu_21.Width = page_Menu1.Width;
                page_Menu_21.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Option1.Width = page_Menu1.Width;
                page_Option1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_MW31.Width = page_Menu1.Width;
                page_MW31.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_MW21.Width = page_Menu1.Width;
                page_MW21.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_BO21.Width = page_Menu1.Width;
                page_BO21.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Ghost1.Width = page_Menu1.Width;
                page_Ghost1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Login1.Width = page_Menu1.Width;
                page_Login1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
            }
            else if (panel == 2)
            {
                page_Download1.BringToFront();
                page_Download1.Width = page_Menu1.Width;
                page_Download1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Menu_21.Width = page_Menu1.Width;
                page_Menu_21.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Option1.Width = page_Menu1.Width;
                page_Option1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_MW31.Width = page_Menu1.Width;
                page_MW31.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_MW21.Width = page_Menu1.Width;
                page_MW21.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_BO21.Width = page_Menu1.Width;
                page_BO21.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Ghost1.Width = page_Menu1.Width;
                page_Ghost1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Login1.Width = page_Menu1.Width;
                page_Login1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
            }
            else if (panel == 3)
            {
                page_Option1.BringToFront();
                page_Download1.Width = page_Menu1.Width;
                page_Download1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Menu_21.Width = page_Menu1.Width;
                page_Menu_21.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Option1.Width = page_Menu1.Width;
                page_Option1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_MW31.Width = page_Menu1.Width;
                page_MW31.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_MW21.Width = page_Menu1.Width;
                page_MW21.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_BO21.Width = page_Menu1.Width;
                page_BO21.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Ghost1.Width = page_Menu1.Width;
                page_Ghost1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Login1.Width = page_Menu1.Width;
                page_Login1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
            }
            else if (panel == 4)
            {
                myMenuoff();
                myDDLoff();
                myOptionoff();
                page_Login1.BringToFront();
                page_Download1.Width = page_Menu1.Width;
                page_Download1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Menu_21.Width = page_Menu1.Width;
                page_Menu_21.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Option1.Width = page_Menu1.Width;
                page_Option1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_MW31.Width = page_Menu1.Width;
                page_MW31.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_MW21.Width = page_Menu1.Width;
                page_MW21.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_BO21.Width = page_Menu1.Width;
                page_BO21.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Ghost1.Width = page_Menu1.Width;
                page_Ghost1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
                page_Login1.Width = page_Menu1.Width;
                page_Login1.Location = new Point(page_Menu1.Location.X, page_Menu1.Location.Y);
            }
        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            page_Menu1.BringToFront();
            myMenu();
            my_Exist();

        }

        #region Change Page 1,2 in the MENU PAGE
        private void Next_Page_Timer_Tick(object sender, EventArgs e)
        {
            if (page_Menu1.toogle == 1)
            {
                page_Menu_21.BringToFront();
                page_Menu1.toogle = 0;
            }
            if (page_Menu_21.toogle == 0)
            {
                page_Menu1.BringToFront();
                page_Menu_21.toogle = 1;
            }
            if (page_Menu1.mw3_toogle == 1)
            {
                page_MW31.BringToFront();
                page_Menu1.mw3_toogle = 0;
            }
            if (page_MW31.mw3_toogle == 0)
            {
                page_Menu1.BringToFront();
                page_MW31.mw3_toogle = 1;
            }
            if (page_Menu1.mw2_toogle == 1)
            {
                page_MW21.BringToFront();
                page_Menu1.mw2_toogle = 0;
            }
            if (page_MW21.mw2_toogle == 0)
            {
                page_Menu1.BringToFront();
                page_MW21.mw2_toogle = 1;
            }
            if (page_Menu_21.bo2_toogle == 1)
            {
                page_BO21.BringToFront();
                page_Menu_21.bo2_toogle = 0;
            }
            if (page_BO21.bo2_toogle == 0)
            {
                page_Menu_21.BringToFront();
                page_BO21.bo2_toogle = 1;
            }
            if (page_Menu_21.ghost_toogle == 1)
            {
                page_Ghost1.BringToFront();
                page_Menu_21.ghost_toogle = 0;
            }
            if (page_Ghost1.ghost_toogle == 0)
            {
                page_Menu_21.BringToFront();
                page_Ghost1.ghost_toogle = 1;
            }
        }
        #endregion

        public static string menu_folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\"+ "LindraTurnOn";
        public static string config_folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "TCUN";
        public void my_Exist()
        {
            if (!Directory.Exists(menu_folder))
                Directory.CreateDirectory(menu_folder);
            if (!Directory.Exists(menu_folder + "\\COD4"))
                Directory.CreateDirectory(menu_folder + "\\COD4");
            if (!Directory.Exists(menu_folder + "\\MW2"))
                Directory.CreateDirectory(menu_folder + "\\MW2");
            if (!Directory.Exists(menu_folder + "\\MW3"))
                Directory.CreateDirectory(menu_folder + "\\MW3");
            if (!Directory.Exists(menu_folder + "\\BO1"))
                Directory.CreateDirectory(menu_folder + "\\BO1");
            if (!Directory.Exists(menu_folder + "\\BO2"))
                Directory.CreateDirectory(menu_folder + "\\BO2");
            if (!Directory.Exists(menu_folder + "\\GHOST"))
                Directory.CreateDirectory(menu_folder + "\\GHOST");
            
            if (!Directory.Exists(config_folder))
                Directory.CreateDirectory(config_folder);
            if (!Directory.Exists(config_folder + "\\COD4"))
                Directory.CreateDirectory(config_folder + "\\COD4");
            if (!Directory.Exists(config_folder + "\\MW2"))
                Directory.CreateDirectory(config_folder + "\\MW2");
            if (!Directory.Exists(config_folder + "\\MW3"))
                Directory.CreateDirectory(config_folder + "\\MW3");
            if (!Directory.Exists(config_folder + "\\BO1"))
                Directory.CreateDirectory(config_folder + "\\BO1");
            if (!Directory.Exists(config_folder + "\\BO2"))
                Directory.CreateDirectory(config_folder + "\\BO2");
            if (!Directory.Exists(config_folder + "\\GHOST"))
                Directory.CreateDirectory(config_folder + "\\GHOST");
            
        }

        private void Check_Update_version_Click(object sender, EventArgs e)
        {
            HasConnection();
            check_for_UPDT();
        }

        #region check update button
        public bool HasConnection()
        {
            try
            {
                System.Net.IPHostEntry i_try = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
        WebClient web = new WebClient();
        public void check_for_UPDT()
        {

            if (HasConnection() == true)
            {
                #region COD4
                if (File.Exists(menu_folder + "\\COD4\\Version"))
                {
                    // download string which contain the version of the lastest release
                    string my_version = web.DownloadString("https://dl.dropbox.com/s/ia4rogzzv73emn2/MP_Version.txt?dl=0");

                    string[] fileEntries = Directory.GetFiles(menu_folder + "\\COD4\\");
                    foreach (string fileName in fileEntries)
                    {
                        string WithoutEXT_Tfile = Path.GetFileNameWithoutExtension(fileName); //search.filename The name of the file

                        if (fileName.Contains("MP")) // if search.filename contains 'Mp'
                        {
                            // download version online
                            if (WithoutEXT_Tfile != "COD4_MP" + my_version) // needed to be updated
                            {
                                DialogResult msg = MessageBox.Show("A new version of COD4 Fps Unlocker is available\n Do you want to downlad the lastest version ?", "Error 0x002", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                if (msg == DialogResult.OK)
                                {

                                    File.Delete(fileName); // delete the old fps unlocker
                                    Update_text.ForeColor = Color.Green; // set the label to green
                                    Update_text.Text = "An Update available"; // an update is available
                                    string my_ddl = web.DownloadString("https://dl.dropbox.com/s/x3eas6u5jv6ronl/MP_Download.txt?dl=0"); // download the download link
                                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(ddl_ddl); // Download it
                                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ddl_ddl2); // check the progress of the download 
                                    web.DownloadFileAsync(new Uri(my_ddl), menu_folder + "\\COD4\\COD4_MP" + my_version + ".exe"); // moove the fps unlocker to the correct folder + have to rename it and add .exe at the end
                                    MessageBox.Show("Download of : COD4 Multi-Player Fps Unlocker v" + my_version + " by LINDRA\n Is finished", "Donwload is finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                        }
                      }
                   }
                #endregion

                #region MW2
                if (File.Exists(menu_folder + "\\MW2\\Version"))
                {
                    // download string which contain the version of the lastest release
                    string my_version = web.DownloadString("https://dl.dropbox.com/s/up9pyknbxdwvjgn/MP_Version.txt?dl=0");
                    string my_version1 = web.DownloadString("https://dl.dropbox.com/s/2cb23jimex9i1ou/SP_Version.txt?dl=0");
                   

                    string[] fileEntries = Directory.GetFiles(menu_folder + "\\MW2\\");
                    foreach (string fileName in fileEntries)
                    {
                        string WithoutEXT_Tfile = Path.GetFileNameWithoutExtension(fileName); //search.filename The name of the file

                        if (fileName.Contains("MP")) // if search.filename contains 'Mp'
                        {
                            // download version online
                            if (WithoutEXT_Tfile != "MW2_MP" + my_version) // needed to be updated
                            {
                                DialogResult msg = MessageBox.Show("A new version of MW2 Fps Unlocker is available\n Do you want to downlad the lastest version ?", "Error 0x002", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                if (msg == DialogResult.OK)
                                {

                                    File.Delete(fileName); // delete the old fps unlocker
                                    Update_text.ForeColor = Color.Green; // set the label to green
                                    Update_text.Text = "An Update available"; // an update is available
                                    string my_ddl = web.DownloadString("https://dl.dropbox.com/s/sddpad26as1nru8/MP_Download.txt?dl=0"); // download the download link
                                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(ddl_ddl); // Download it
                                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ddl_ddl2); // check the progress of the download 
                                    web.DownloadFileAsync(new Uri(my_ddl), menu_folder + "\\MW2\\MW2_MP" + my_version + ".exe"); // moove the fps unlocker to the correct folder + have to rename it and add .exe at the end
                                    MessageBox.Show("Download of : MW2 Multi-Player Fps Unlocker v" + my_version + " by LINDRA\n Is finished", "Donwload is finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                        }
                        if (fileName.Contains("SP")) // if search.filename contains 'Mp'
                        {
                            // download version online
                            if (WithoutEXT_Tfile != "MW2_SP" + my_version1) // needed to be updated
                            {
                                DialogResult msg = MessageBox.Show("A new version of MW2 Fps Unlocker is available\n Do you want to downlad the lastest version ?", "Error 0x002", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                if (msg == DialogResult.OK)
                                {

                                    File.Delete(fileName); // delete the old fps unlocker
                                    Update_text.ForeColor = Color.Green; // set the label to green
                                    Update_text.Text = "An Update available"; // an update is available
                                    string my_ddl = web.DownloadString("https://dl.dropbox.com/s/wv0gseoljpfgvku/SP_Download.txt?dl=0"); // download the download link
                                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(ddl_ddl); // Download it
                                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ddl_ddl2); // check the progress of the download 
                                    web.DownloadFileAsync(new Uri(my_ddl), menu_folder + "\\MW2\\MW2_SP" + my_version1 + ".exe"); // moove the fps unlocker to the correct folder + have to rename it and add .exe at the end
                                    MessageBox.Show("Download of : MW2 Single Player Fps Unlocker v" + my_version1 + " by LINDRA\n Is finished", "Donwload is finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                #endregion

                #region MW3
                if (Directory.Exists(menu_folder + "\\MW3"))
                {
                    // download string which contain the version of the lastest release
                    string my_version = web.DownloadString("https://dl.dropbox.com/s/a6pqzbp1nrs08af/MP_Version.txt?dl=0");
                    string my_version1 = web.DownloadString("https://dl.dropbox.com/s/r2502hb70ddicqg/SP_Version.txt?dl=0");
                    string my_version2 = web.DownloadString("https://dl.dropbox.com/s/sxuy00n7t23jmn6/TK_Version.txt?dl=0");

                    string[] fileEntries = Directory.GetFiles(menu_folder + "\\MW3\\");
                    foreach (string fileName in fileEntries)
                    {
                        string WithoutEXT_Tfile = Path.GetFileNameWithoutExtension(fileName); //search.filename The name of the file

                        if (fileName.Contains("MP")) // if search.filename contains 'Mp'
                        {
                            // download version online
                            if (WithoutEXT_Tfile != "MW3_MP" + my_version) // needed to be updated
                            {
                                DialogResult msg = MessageBox.Show("A new version of MW3 Fps Unlocker is available\n Do you want to downlad the lastest version ?", "Error 0x002", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                if (msg == DialogResult.OK)
                                {

                                    File.Delete(fileName); // delete the old fps unlocker
                                    Update_text.ForeColor = Color.Green; // set the label to green
                                    Update_text.Text = "An Update available"; // an update is available
                                    string my_ddl = web.DownloadString("https://dl.dropbox.com/s/p8ngrn9r4s1eh2k/MP_Download.txt?dl=0"); // download the download link
                                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(ddl_ddl); // Download it
                                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ddl_ddl2); // check the progress of the download 
                                    web.DownloadFileAsync(new Uri(my_ddl), menu_folder + "\\MW3\\MW3_MP" + my_version + ".exe"); // moove the fps unlocker to the correct folder + have to rename it and add .exe at the end
                                    MessageBox.Show("Download of : MW3 Multi-Player Fps Unlocker v"+ my_version + " by LINDRA\n Is finished","Donwload is finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        if (fileName.Contains("SP")) // if search.filename contains 'Mp'
                        {
                            // download version online
                            if (WithoutEXT_Tfile != "MW3_SP" + my_version1) // needed to be updated
                            {
                                DialogResult msg = MessageBox.Show("A new version of MW3 Fps Unlocker is available\n Do you want to downlad the lastest version ?", "Error 0x002", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                if (msg == DialogResult.OK)
                                {

                                    File.Delete(fileName); // delete the old fps unlocker
                                    Update_text.ForeColor = Color.Green; // set the label to green
                                    Update_text.Text = "An Update available"; // an update is available
                                    string my_ddl = web.DownloadString("https://dl.dropbox.com/s/vbvoc1swp20ry4d/SP_Download.txt?dl=0"); // download the download link
                                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(ddl_ddl); // Download it
                                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ddl_ddl2); // check the progress of the download 
                                    web.DownloadFileAsync(new Uri(my_ddl), menu_folder + "\\MW3\\MW3_SP" + my_version1 + ".exe"); // moove the fps unlocker to the correct folder + have to rename it and add .exe at the end
                                    MessageBox.Show("Download of : MW3 Single Player Fps Unlocker v" + my_version1 + " by LINDRA\n Is finished", "Donwload is finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        if (fileName.Contains("TK")) // if search.filename contains 'Mp'
                        {
                            // download version online
                            if (WithoutEXT_Tfile != "MW3_TK" + my_version2) // needed to be updated
                            {
                                DialogResult msg = MessageBox.Show("A new version of MW3 Fps Unlocker is available\n Do you want to downlad the lastest version ?", "Error 0x002", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                if (msg == DialogResult.OK)
                                {

                                    File.Delete(fileName); // delete the old fps unlocker
                                    Update_text.ForeColor = Color.Green; // set the label to green
                                    Update_text.Text = "An Update available"; // an update is available
                                    string my_ddl = web.DownloadString("https://dl.dropbox.com/s/m0dnu30c1ccyncn/TK_Download.txt?dl=0"); // download the download link
                                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(ddl_ddl); // Download it
                                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ddl_ddl2); // check the progress of the download 
                                    web.DownloadFileAsync(new Uri(my_ddl), menu_folder + "\\MW3\\MW3_TK" + my_version2 + ".exe"); // moove the fps unlocker to the correct folder + have to rename it and add .exe at the end
                                    MessageBox.Show("Download of : MW3 TeknoGod Fps Unlocker v" + my_version2 + " by LINDRA\n Is finished", "Donwload is finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }

                }
                #endregion

                #region BO1
                if (File.Exists(menu_folder + "\\BO1\\Version"))
                {
                    // download string which contain the version of the lastest release
                    string my_version = web.DownloadString("https://dl.dropbox.com/s/g26n58fr9z1aybu/MP_Version.txt?dl=0");

                    string[] fileEntries = Directory.GetFiles(menu_folder + "\\BO1\\");
                    foreach (string fileName in fileEntries)
                    {
                        string WithoutEXT_Tfile = Path.GetFileNameWithoutExtension(fileName); //search.filename The name of the file

                        if (fileName.Contains("MP")) // if search.filename contains 'Mp'
                        {
                            // download version online
                            if (WithoutEXT_Tfile != "BO1_MP" + my_version) // needed to be updated
                            {
                                DialogResult msg = MessageBox.Show("A new version of BO1 Fps Unlocker is available\n Do you want to downlad the lastest version ?", "Error 0x002", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                if (msg == DialogResult.OK)
                                {

                                    File.Delete(fileName); // delete the old fps unlocker
                                    Update_text.ForeColor = Color.Green; // set the label to green
                                    Update_text.Text = "An Update available"; // an update is available
                                    string my_ddl = web.DownloadString("https://dl.dropbox.com/s/3ijw75onc8xuduv/MP_Download.txt?dl=0"); // download the download link
                                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(ddl_ddl); // Download it
                                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ddl_ddl2); // check the progress of the download 
                                    web.DownloadFileAsync(new Uri(my_ddl), menu_folder + "\\BO1\\BO1_MP" + my_version + ".exe"); // moove the fps unlocker to the correct folder + have to rename it and add .exe at the end
                                    MessageBox.Show("Download of : BO1 Multi-Player Fps Unlocker v" + my_version + " by LINDRA\n Is finished", "Donwload is finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                        }
                    }
                }
                #endregion

                #region BO2
                if (Directory.Exists(menu_folder + "\\BO2"))
                {
                    // download string which contain the version of the lastest release
                    string my_version = web.DownloadString("https://dl.dropbox.com/s/jr49dc8d9yfy4mi/MP_Version.txt?dl=0");
                    string my_version1 = web.DownloadString("https://dl.dropbox.com/s/xm9s0zndl92ytgg/SP_Version.txt?dl=0");
                    string my_version2 = web.DownloadString("https://dl.dropbox.com/s/k2tw2mapj5vi74l/ZM_Version.txt?dl=0");

                    string[] fileEntries = Directory.GetFiles(menu_folder + "\\BO2\\");
                    foreach (string fileName in fileEntries)
                    {
                        string WithoutEXT_Tfile = Path.GetFileNameWithoutExtension(fileName); //search.filename The name of the file

                        if (fileName.Contains("MP")) // if search.filename contains 'Mp'
                        {
                            // download version online
                            if (WithoutEXT_Tfile != "BO2_MP" + my_version) // needed to be updated
                            {
                                DialogResult msg = MessageBox.Show("A new version of BO2 Fps Unlocker is available\n Do you want to downlad the lastest version ?", "Error 0x002", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                if (msg == DialogResult.OK)
                                {

                                    File.Delete(fileName); // delete the old fps unlocker
                                    Update_text.ForeColor = Color.Green; // set the label to green
                                    Update_text.Text = "An Update available"; // an update is available
                                    string my_ddl = web.DownloadString("https://dl.dropbox.com/s/3vrpdesqfawmhwq/MP_Download.txt?dl=0"); // download the download link
                                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(ddl_ddl); // Download it
                                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ddl_ddl2); // check the progress of the download 
                                    web.DownloadFileAsync(new Uri(my_ddl), menu_folder + "\\BO2\\BO2_MP" + my_version + ".exe"); // moove the fps unlocker to the correct folder + have to rename it and add .exe at the end
                                    MessageBox.Show("Download of : BO2 Multi-Player Fps Unlocker v" + my_version + " by LINDRA\n Is finished", "Donwload is finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        if (fileName.Contains("SP")) // if search.filename contains 'Mp'
                        {
                            // download version online
                            if (WithoutEXT_Tfile != "BO2_SP" + my_version1) // needed to be updated
                            {
                                DialogResult msg = MessageBox.Show("A new version of BO2 Fps Unlocker is available\n Do you want to downlad the lastest version ?", "Error 0x002", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                if (msg == DialogResult.OK)
                                {

                                    File.Delete(fileName); // delete the old fps unlocker
                                    Update_text.ForeColor = Color.Green; // set the label to green
                                    Update_text.Text = "An Update available"; // an update is available
                                    string my_ddl = web.DownloadString("https://dl.dropbox.com/s/i1nwim0eyit4t4x/SP_Download.txt?dl=0"); // download the download link
                                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(ddl_ddl); // Download it
                                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ddl_ddl2); // check the progress of the download 
                                    web.DownloadFileAsync(new Uri(my_ddl), menu_folder + "\\BO2\\BO2_SP" + my_version1 + ".exe"); // moove the fps unlocker to the correct folder + have to rename it and add .exe at the end
                                    MessageBox.Show("Download of : BO2 Single Player Fps Unlocker v" + my_version1 + " by LINDRA\n Is finished", "Donwload is finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        if (fileName.Contains("ZM")) // if search.filename contains 'Mp'
                        {
                            // download version online
                            if (WithoutEXT_Tfile != "BO2_ZM" + my_version2) // needed to be updated
                            {
                                DialogResult msg = MessageBox.Show("A new version of BO2 Fps Unlocker is available\n Do you want to downlad the lastest version ?", "Error 0x002", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                if (msg == DialogResult.OK)
                                {

                                    File.Delete(fileName); // delete the old fps unlocker
                                    Update_text.ForeColor = Color.Green; // set the label to green
                                    Update_text.Text = "An Update available"; // an update is available
                                    string my_ddl = web.DownloadString("https://dl.dropbox.com/s/6e1xx2kca9lbhsg/ZM_Download.txt?dl=0"); // download the download link
                                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(ddl_ddl); // Download it
                                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ddl_ddl2); // check the progress of the download 
                                    web.DownloadFileAsync(new Uri(my_ddl), menu_folder + "\\BO2\\BO2_ZM" + my_version2 + ".exe"); // moove the fps unlocker to the correct folder + have to rename it and add .exe at the end
                                    MessageBox.Show("Download of : BO2 Zombie Fps Unlocker v" + my_version2 + " by LINDRA\n Is finished", "Donwload is finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }

                }
                #endregion

                #region GHOST
                if (File.Exists(menu_folder + "\\GHOST\\Version"))
                {
                    // download string which contain the version of the lastest release
                    string my_version = web.DownloadString("https://dl.dropbox.com/s/eiyndin2rd029cd/MP_Version.txt?dl=0");
                    string my_version1 = web.DownloadString("https://dl.dropbox.com/s/ph08li21golarb3/SP_Version.txt?dl=0");


                    string[] fileEntries = Directory.GetFiles(menu_folder + "\\GHOST\\");
                    foreach (string fileName in fileEntries)
                    {
                        string WithoutEXT_Tfile = Path.GetFileNameWithoutExtension(fileName); //search.filename The name of the file

                        if (fileName.Contains("MP")) // if search.filename contains 'Mp'
                        {
                            // download version online
                            if (WithoutEXT_Tfile != "GHOST_MP" + my_version) // needed to be updated
                            {
                                DialogResult msg = MessageBox.Show("A new version of GHOST Fps Unlocker is available\n Do you want to downlad the lastest version ?", "Error 0x002", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                if (msg == DialogResult.OK)
                                {

                                    File.Delete(fileName); // delete the old fps unlocker
                                    Update_text.ForeColor = Color.Green; // set the label to green
                                    Update_text.Text = "An Update available"; // an update is available
                                    string my_ddl = web.DownloadString("https://dl.dropbox.com/s/jqwzb43nrc0hn2l/MP_Download.txt?dl=0"); // download the download link
                                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(ddl_ddl); // Download it
                                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ddl_ddl2); // check the progress of the download 
                                    web.DownloadFileAsync(new Uri(my_ddl), menu_folder + "\\GHOST\\GHOST_MP" + my_version + ".exe"); // moove the fps unlocker to the correct folder + have to rename it and add .exe at the end
                                    MessageBox.Show("Download of : GHOST Multi-Player Fps Unlocker v" + my_version + " by LINDRA\n Is finished", "Donwload is finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                        }
                        if (fileName.Contains("SP")) // if search.filename contains 'Mp'
                        {
                            // download version online
                            if (WithoutEXT_Tfile != "GHOST_SP" + my_version1) // needed to be updated
                            {
                                DialogResult msg = MessageBox.Show("A new version of GHOST Fps Unlocker is available\n Do you want to downlad the lastest version ?", "Error 0x002", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                if (msg == DialogResult.OK)
                                {

                                    File.Delete(fileName); // delete the old fps unlocker
                                    Update_text.ForeColor = Color.Green; // set the label to green
                                    Update_text.Text = "An Update available"; // an update is available
                                    string my_ddl = web.DownloadString("https://dl.dropbox.com/s/3vmsu01bn1bxe2e/SP_Download.txt?dl=0"); // download the download link
                                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(ddl_ddl); // Download it
                                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ddl_ddl2); // check the progress of the download 
                                    web.DownloadFileAsync(new Uri(my_ddl), menu_folder + "\\GHOST\\GHOST_SP" + my_version1 + ".exe"); // moove the fps unlocker to the correct folder + have to rename it and add .exe at the end
                                    MessageBox.Show("Download of : GHOST Single Player Fps Unlocker v" + my_version1 + " by LINDRA\n Is finished", "Donwload is finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                #endregion
            }
            else
            { // error message if you don't have internet
                MessageBox.Show("Make sure you are connected to internet before you try to update the tool", "Error 0x003", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
     

        private void ddl_ddl(object sender, AsyncCompletedEventArgs e) //not really usefull xD
        {
         
        }
        private void ddl_ddl2(object sender, DownloadProgressChangedEventArgs o) // this could be usefull for a download bar
        {
            
        }
        #endregion

        #region login part
        private void login_pic_Click(object sender, EventArgs e)
        {
            page_Login1.BringToFront();
            panel = 4;
            myMenuoff();
            myDDLoff();
            myOptionoff();
        }

        private void login_lbl_Click(object sender, EventArgs e)
        {
            page_Login1.BringToFront();
            panel = 4;
            myMenuoff();
            myDDLoff();
            myOptionoff();
        }

        private void login_pnl_Click(object sender, EventArgs e)
        {
            page_Login1.BringToFront();
            panel = 4;
            myMenuoff();
            myDDLoff();
            myOptionoff();
        }
        #endregion
    }

}

