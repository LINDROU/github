namespace Essaie_Menu
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Top_bar = new System.Windows.Forms.Panel();
            this.wd_title = new System.Windows.Forms.Label();
            this.Next_Page_Timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.Menu_lbl = new System.Windows.Forms.Label();
            this.DDL_panel = new System.Windows.Forms.Panel();
            this.DDL_lbl = new System.Windows.Forms.Label();
            this.Option_panel = new System.Windows.Forms.Panel();
            this.Option_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Update_text = new System.Windows.Forms.Label();
            this.Side_panel = new System.Windows.Forms.Panel();
            this.login_pnl = new System.Windows.Forms.Panel();
            this.login_lbl = new System.Windows.Forms.Label();
            this.login_pic = new System.Windows.Forms.PictureBox();
            this.minimize_pic = new System.Windows.Forms.PictureBox();
            this.CloseFrm = new System.Windows.Forms.PictureBox();
            this.Change_Side_Panel = new System.Windows.Forms.PictureBox();
            this.Check_Update_version = new System.Windows.Forms.PictureBox();
            this.Option_pic = new System.Windows.Forms.PictureBox();
            this.DDL_pic = new System.Windows.Forms.PictureBox();
            this.Menu_pic = new System.Windows.Forms.PictureBox();
            this.page_Login1 = new Essaie_Menu.Page_Login();
            this.page_Ghost1 = new Essaie_Menu.Page_Ghost();
            this.page_BO21 = new Essaie_Menu.Page_BO2();
            this.page_MW21 = new Essaie_Menu.Page_MW2();
            this.page_MW31 = new Essaie_Menu.Page_MW3();
            this.page_Option1 = new Essaie_Menu.Page_Option();
            this.page_Menu_21 = new Essaie_Menu.Page_Menu_2();
            this.page_Download1 = new Essaie_Menu.Page_Download();
            this.page_Menu1 = new Essaie_Menu.Page_Menu();
            this.Top_bar.SuspendLayout();
            this.Menu_panel.SuspendLayout();
            this.DDL_panel.SuspendLayout();
            this.Option_panel.SuspendLayout();
            this.Side_panel.SuspendLayout();
            this.login_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseFrm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Change_Side_Panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_Update_version)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Option_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DDL_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_bar
            // 
            this.Top_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Top_bar.Controls.Add(this.login_pnl);
            this.Top_bar.Controls.Add(this.wd_title);
            this.Top_bar.Controls.Add(this.minimize_pic);
            this.Top_bar.Controls.Add(this.CloseFrm);
            this.Top_bar.Controls.Add(this.Change_Side_Panel);
            this.Top_bar.Location = new System.Drawing.Point(0, 0);
            this.Top_bar.Name = "Top_bar";
            this.Top_bar.Size = new System.Drawing.Size(1000, 40);
            this.Top_bar.TabIndex = 1;
            this.Top_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_bar_MouseDown);
            this.Top_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Top_bar_MouseMove);
            this.Top_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Top_bar_MouseUp);
            // 
            // wd_title
            // 
            this.wd_title.AutoSize = true;
            this.wd_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wd_title.ForeColor = System.Drawing.Color.White;
            this.wd_title.Location = new System.Drawing.Point(46, 9);
            this.wd_title.Name = "wd_title";
            this.wd_title.Size = new System.Drawing.Size(135, 21);
            this.wd_title.TabIndex = 2;
            this.wd_title.Text = "The Cheat U Need";
            this.wd_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Next_Page_Timer
            // 
            this.Next_Page_Timer.Enabled = true;
            this.Next_Page_Timer.Tick += new System.EventHandler(this.Next_Page_Timer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 157);
            this.panel2.TabIndex = 1;
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Menu_panel.Controls.Add(this.Menu_pic);
            this.Menu_panel.Controls.Add(this.Menu_lbl);
            this.Menu_panel.Location = new System.Drawing.Point(3, 220);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(214, 55);
            this.Menu_panel.TabIndex = 2;
            this.Menu_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Menu_panel_MouseClick);
            // 
            // Menu_lbl
            // 
            this.Menu_lbl.AutoSize = true;
            this.Menu_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_lbl.ForeColor = System.Drawing.Color.White;
            this.Menu_lbl.Location = new System.Drawing.Point(94, 18);
            this.Menu_lbl.Name = "Menu_lbl";
            this.Menu_lbl.Size = new System.Drawing.Size(50, 21);
            this.Menu_lbl.TabIndex = 0;
            this.Menu_lbl.Text = "Menu";
            this.Menu_lbl.Click += new System.EventHandler(this.Menu_lbl_Click);
            // 
            // DDL_panel
            // 
            this.DDL_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.DDL_panel.Controls.Add(this.DDL_pic);
            this.DDL_panel.Controls.Add(this.DDL_lbl);
            this.DDL_panel.Location = new System.Drawing.Point(3, 290);
            this.DDL_panel.Name = "DDL_panel";
            this.DDL_panel.Size = new System.Drawing.Size(214, 55);
            this.DDL_panel.TabIndex = 3;
            this.DDL_panel.Click += new System.EventHandler(this.DDL_panel_Click);
            // 
            // DDL_lbl
            // 
            this.DDL_lbl.AutoSize = true;
            this.DDL_lbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DDL_lbl.ForeColor = System.Drawing.Color.White;
            this.DDL_lbl.Location = new System.Drawing.Point(94, 18);
            this.DDL_lbl.Name = "DDL_lbl";
            this.DDL_lbl.Size = new System.Drawing.Size(81, 21);
            this.DDL_lbl.TabIndex = 0;
            this.DDL_lbl.Text = "Download";
            this.DDL_lbl.Click += new System.EventHandler(this.DDL_lbl_Click);
            // 
            // Option_panel
            // 
            this.Option_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Option_panel.Controls.Add(this.Option_pic);
            this.Option_panel.Controls.Add(this.Option_lbl);
            this.Option_panel.Location = new System.Drawing.Point(3, 360);
            this.Option_panel.Name = "Option_panel";
            this.Option_panel.Size = new System.Drawing.Size(214, 55);
            this.Option_panel.TabIndex = 4;
            this.Option_panel.Click += new System.EventHandler(this.Option_panel_Click);
            // 
            // Option_lbl
            // 
            this.Option_lbl.AutoSize = true;
            this.Option_lbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Option_lbl.ForeColor = System.Drawing.Color.White;
            this.Option_lbl.Location = new System.Drawing.Point(93, 18);
            this.Option_lbl.Name = "Option_lbl";
            this.Option_lbl.Size = new System.Drawing.Size(65, 21);
            this.Option_lbl.TabIndex = 0;
            this.Option_lbl.Text = "Options";
            this.Option_lbl.Click += new System.EventHandler(this.Option_lbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check Update";
            // 
            // Update_text
            // 
            this.Update_text.AutoSize = true;
            this.Update_text.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_text.ForeColor = System.Drawing.Color.Red;
            this.Update_text.Location = new System.Drawing.Point(78, 571);
            this.Update_text.Name = "Update_text";
            this.Update_text.Size = new System.Drawing.Size(128, 17);
            this.Update_text.TabIndex = 6;
            this.Update_text.Text = "No Update available";
            // 
            // Side_panel
            // 
            this.Side_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.Side_panel.Controls.Add(this.Update_text);
            this.Side_panel.Controls.Add(this.label1);
            this.Side_panel.Controls.Add(this.Check_Update_version);
            this.Side_panel.Controls.Add(this.Option_panel);
            this.Side_panel.Controls.Add(this.DDL_panel);
            this.Side_panel.Controls.Add(this.Menu_panel);
            this.Side_panel.Controls.Add(this.panel2);
            this.Side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_panel.Location = new System.Drawing.Point(0, 0);
            this.Side_panel.Name = "Side_panel";
            this.Side_panel.Size = new System.Drawing.Size(220, 600);
            this.Side_panel.TabIndex = 0;
            // 
            // login_pnl
            // 
            this.login_pnl.Controls.Add(this.login_lbl);
            this.login_pnl.Controls.Add(this.login_pic);
            this.login_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_pnl.Location = new System.Drawing.Point(846, 3);
            this.login_pnl.Name = "login_pnl";
            this.login_pnl.Size = new System.Drawing.Size(99, 33);
            this.login_pnl.TabIndex = 3;
            this.login_pnl.Click += new System.EventHandler(this.login_pnl_Click);
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.ForeColor = System.Drawing.Color.White;
            this.login_lbl.Location = new System.Drawing.Point(35, 6);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(49, 21);
            this.login_lbl.TabIndex = 2;
            this.login_lbl.Text = "Login";
            this.login_lbl.Click += new System.EventHandler(this.login_lbl_Click);
            // 
            // login_pic
            // 
            this.login_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_pic.Image = global::Essaie_Menu.Properties.Resources.change_user_512;
            this.login_pic.Location = new System.Drawing.Point(4, 4);
            this.login_pic.Name = "login_pic";
            this.login_pic.Size = new System.Drawing.Size(25, 25);
            this.login_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_pic.TabIndex = 0;
            this.login_pic.TabStop = false;
            this.login_pic.Click += new System.EventHandler(this.login_pic_Click);
            // 
            // minimize_pic
            // 
            this.minimize_pic.Image = global::Essaie_Menu.Properties.Resources.minimize_window_5121;
            this.minimize_pic.Location = new System.Drawing.Point(951, 3);
            this.minimize_pic.Name = "minimize_pic";
            this.minimize_pic.Size = new System.Drawing.Size(20, 34);
            this.minimize_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_pic.TabIndex = 2;
            this.minimize_pic.TabStop = false;
            this.minimize_pic.Click += new System.EventHandler(this.minimize_pic_Click);
            // 
            // CloseFrm
            // 
            this.CloseFrm.Image = global::Essaie_Menu.Properties.Resources.delete_2_512__1_1;
            this.CloseFrm.Location = new System.Drawing.Point(977, 3);
            this.CloseFrm.Name = "CloseFrm";
            this.CloseFrm.Size = new System.Drawing.Size(20, 34);
            this.CloseFrm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseFrm.TabIndex = 1;
            this.CloseFrm.TabStop = false;
            this.CloseFrm.Click += new System.EventHandler(this.CloseFrm_Click);
            // 
            // Change_Side_Panel
            // 
            this.Change_Side_Panel.Image = global::Essaie_Menu.Properties.Resources._588a64e0d06f6719692a2d10;
            this.Change_Side_Panel.Location = new System.Drawing.Point(3, 0);
            this.Change_Side_Panel.Name = "Change_Side_Panel";
            this.Change_Side_Panel.Size = new System.Drawing.Size(37, 37);
            this.Change_Side_Panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Change_Side_Panel.TabIndex = 0;
            this.Change_Side_Panel.TabStop = false;
            this.Change_Side_Panel.Click += new System.EventHandler(this.Change_Side_Panel_Click);
            // 
            // Check_Update_version
            // 
            this.Check_Update_version.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check_Update_version.Image = global::Essaie_Menu.Properties.Resources.available_updates_512;
            this.Check_Update_version.Location = new System.Drawing.Point(12, 545);
            this.Check_Update_version.Name = "Check_Update_version";
            this.Check_Update_version.Size = new System.Drawing.Size(50, 43);
            this.Check_Update_version.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Check_Update_version.TabIndex = 5;
            this.Check_Update_version.TabStop = false;
            this.Check_Update_version.Click += new System.EventHandler(this.Check_Update_version_Click);
            // 
            // Option_pic
            // 
            this.Option_pic.Image = global::Essaie_Menu.Properties.Resources.cog_5121;
            this.Option_pic.Location = new System.Drawing.Point(19, 12);
            this.Option_pic.Name = "Option_pic";
            this.Option_pic.Size = new System.Drawing.Size(31, 29);
            this.Option_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Option_pic.TabIndex = 1;
            this.Option_pic.TabStop = false;
            this.Option_pic.Click += new System.EventHandler(this.Option_pic_Click);
            // 
            // DDL_pic
            // 
            this.DDL_pic.Image = global::Essaie_Menu.Properties.Resources.download_2_5124;
            this.DDL_pic.Location = new System.Drawing.Point(19, 12);
            this.DDL_pic.Name = "DDL_pic";
            this.DDL_pic.Size = new System.Drawing.Size(31, 29);
            this.DDL_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DDL_pic.TabIndex = 2;
            this.DDL_pic.TabStop = false;
            this.DDL_pic.Click += new System.EventHandler(this.DDL_pic_Click);
            // 
            // Menu_pic
            // 
            this.Menu_pic.Image = global::Essaie_Menu.Properties.Resources.icon_home_white1;
            this.Menu_pic.Location = new System.Drawing.Point(19, 12);
            this.Menu_pic.Name = "Menu_pic";
            this.Menu_pic.Size = new System.Drawing.Size(31, 29);
            this.Menu_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Menu_pic.TabIndex = 1;
            this.Menu_pic.TabStop = false;
            this.Menu_pic.Click += new System.EventHandler(this.Menu_pic_Click);
            // 
            // page_Login1
            // 
            this.page_Login1.Location = new System.Drawing.Point(220, 41);
            this.page_Login1.Name = "page_Login1";
            this.page_Login1.Size = new System.Drawing.Size(780, 559);
            this.page_Login1.TabIndex = 10;
            // 
            // page_Ghost1
            // 
            this.page_Ghost1.Location = new System.Drawing.Point(220, 41);
            this.page_Ghost1.Name = "page_Ghost1";
            this.page_Ghost1.Size = new System.Drawing.Size(780, 559);
            this.page_Ghost1.TabIndex = 9;
            // 
            // page_BO21
            // 
            this.page_BO21.Location = new System.Drawing.Point(220, 41);
            this.page_BO21.Name = "page_BO21";
            this.page_BO21.Size = new System.Drawing.Size(780, 559);
            this.page_BO21.TabIndex = 8;
            // 
            // page_MW21
            // 
            this.page_MW21.Location = new System.Drawing.Point(220, 41);
            this.page_MW21.Name = "page_MW21";
            this.page_MW21.Size = new System.Drawing.Size(780, 556);
            this.page_MW21.TabIndex = 7;
            // 
            // page_MW31
            // 
            this.page_MW31.Location = new System.Drawing.Point(220, 41);
            this.page_MW31.Name = "page_MW31";
            this.page_MW31.Size = new System.Drawing.Size(780, 559);
            this.page_MW31.TabIndex = 6;
            // 
            // page_Option1
            // 
            this.page_Option1.Location = new System.Drawing.Point(220, 42);
            this.page_Option1.Name = "page_Option1";
            this.page_Option1.Size = new System.Drawing.Size(780, 558);
            this.page_Option1.TabIndex = 5;
            // 
            // page_Menu_21
            // 
            this.page_Menu_21.BackColor = System.Drawing.Color.White;
            this.page_Menu_21.Location = new System.Drawing.Point(221, 41);
            this.page_Menu_21.Name = "page_Menu_21";
            this.page_Menu_21.Size = new System.Drawing.Size(778, 558);
            this.page_Menu_21.TabIndex = 4;
            // 
            // page_Download1
            // 
            this.page_Download1.BackColor = System.Drawing.Color.White;
            this.page_Download1.Location = new System.Drawing.Point(220, 42);
            this.page_Download1.Name = "page_Download1";
            this.page_Download1.Size = new System.Drawing.Size(780, 558);
            this.page_Download1.TabIndex = 3;
            // 
            // page_Menu1
            // 
            this.page_Menu1.BackColor = System.Drawing.Color.White;
            this.page_Menu1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.page_Menu1.Location = new System.Drawing.Point(220, 42);
            this.page_Menu1.Name = "page_Menu1";
            this.page_Menu1.Size = new System.Drawing.Size(780, 558);
            this.page_Menu1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.page_Login1);
            this.Controls.Add(this.page_Ghost1);
            this.Controls.Add(this.page_BO21);
            this.Controls.Add(this.page_MW21);
            this.Controls.Add(this.page_MW31);
            this.Controls.Add(this.page_Option1);
            this.Controls.Add(this.page_Menu_21);
            this.Controls.Add(this.page_Download1);
            this.Controls.Add(this.Top_bar);
            this.Controls.Add(this.page_Menu1);
            this.Controls.Add(this.Side_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "TCUN Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Top_bar.ResumeLayout(false);
            this.Top_bar.PerformLayout();
            this.Menu_panel.ResumeLayout(false);
            this.Menu_panel.PerformLayout();
            this.DDL_panel.ResumeLayout(false);
            this.DDL_panel.PerformLayout();
            this.Option_panel.ResumeLayout(false);
            this.Option_panel.PerformLayout();
            this.Side_panel.ResumeLayout(false);
            this.Side_panel.PerformLayout();
            this.login_pnl.ResumeLayout(false);
            this.login_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseFrm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Change_Side_Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_Update_version)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Option_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DDL_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Top_bar;
        private System.Windows.Forms.Timer Next_Page_Timer;
        private System.Windows.Forms.PictureBox Change_Side_Panel;
        private System.Windows.Forms.PictureBox CloseFrm;
        private Page_Menu page_Menu1;
        private Page_Download page_Download1;
        private Page_Menu_2 page_Menu_21;
        private Page_Option page_Option1;
        private Page_MW3 page_MW31;
        private System.Windows.Forms.PictureBox minimize_pic;
        private Page_MW2 page_MW21;
        private System.Windows.Forms.Label wd_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.PictureBox Menu_pic;
        private System.Windows.Forms.Label Menu_lbl;
        private System.Windows.Forms.Panel DDL_panel;
        private System.Windows.Forms.PictureBox DDL_pic;
        private System.Windows.Forms.Label DDL_lbl;
        private System.Windows.Forms.Panel Option_panel;
        private System.Windows.Forms.PictureBox Option_pic;
        private System.Windows.Forms.Label Option_lbl;
        private System.Windows.Forms.PictureBox Check_Update_version;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Update_text;
        private System.Windows.Forms.Panel Side_panel;
        private Page_BO2 page_BO21;
        private Page_Ghost page_Ghost1;
        private System.Windows.Forms.Panel login_pnl;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.PictureBox login_pic;
        private Page_Login page_Login1;
    }
}

