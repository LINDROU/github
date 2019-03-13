namespace Essaie_Menu
{
    partial class Page_Login
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Panel ok_pnl;
            this.login_lbl = new System.Windows.Forms.Label();
            this.login_pic = new System.Windows.Forms.PictureBox();
            this.ok_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.visible_pic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.invisible_pic = new System.Windows.Forms.PictureBox();
            this.pasword = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.Alert_lbl = new System.Windows.Forms.Label();
            this.Next_Page = new System.Windows.Forms.Panel();
            this.Next_Page_lbl = new System.Windows.Forms.Label();
            this.Next_Page_pic = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            ok_pnl = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_pic)).BeginInit();
            ok_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visible_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invisible_pic)).BeginInit();
            this.Next_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Next_Page_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            panel2.Controls.Add(this.login_lbl);
            panel2.Controls.Add(this.login_pic);
            panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            panel2.Location = new System.Drawing.Point(3, 56);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(344, 49);
            panel2.TabIndex = 0;
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.ForeColor = System.Drawing.Color.White;
            this.login_lbl.Location = new System.Drawing.Point(165, 17);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(49, 21);
            this.login_lbl.TabIndex = 4;
            this.login_lbl.Text = "Login";
            // 
            // login_pic
            // 
            this.login_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_pic.Image = global::Essaie_Menu.Properties.Resources.change_user_512;
            this.login_pic.Location = new System.Drawing.Point(125, 10);
            this.login_pic.Name = "login_pic";
            this.login_pic.Size = new System.Drawing.Size(28, 28);
            this.login_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_pic.TabIndex = 3;
            this.login_pic.TabStop = false;
            // 
            // ok_pnl
            // 
            ok_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            ok_pnl.Controls.Add(this.ok_lbl);
            ok_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            ok_pnl.ForeColor = System.Drawing.SystemColors.ControlLight;
            ok_pnl.Location = new System.Drawing.Point(137, 253);
            ok_pnl.Name = "ok_pnl";
            ok_pnl.Size = new System.Drawing.Size(80, 40);
            ok_pnl.TabIndex = 5;
            ok_pnl.Click += new System.EventHandler(this.ok_pnl_Click);
            // 
            // ok_lbl
            // 
            this.ok_lbl.AutoSize = true;
            this.ok_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_lbl.ForeColor = System.Drawing.Color.White;
            this.ok_lbl.Location = new System.Drawing.Point(25, 10);
            this.ok_lbl.Name = "ok_lbl";
            this.ok_lbl.Size = new System.Drawing.Size(31, 21);
            this.ok_lbl.TabIndex = 4;
            this.ok_lbl.Text = "OK";
            this.ok_lbl.Click += new System.EventHandler(this.ok_lbl_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(ok_pnl);
            this.panel1.Controls.Add(this.visible_pic);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.invisible_pic);
            this.panel1.Controls.Add(this.pasword);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(panel2);
            this.panel1.Location = new System.Drawing.Point(215, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 400);
            this.panel1.TabIndex = 0;
            // 
            // visible_pic
            // 
            this.visible_pic.Image = global::Essaie_Menu.Properties.Resources.visible_512;
            this.visible_pic.Location = new System.Drawing.Point(311, 187);
            this.visible_pic.Name = "visible_pic";
            this.visible_pic.Size = new System.Drawing.Size(32, 20);
            this.visible_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.visible_pic.TabIndex = 7;
            this.visible_pic.TabStop = false;
            this.visible_pic.Click += new System.EventHandler(this.visible_pic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(36, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(28, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName : ";
            // 
            // invisible_pic
            // 
            this.invisible_pic.Image = global::Essaie_Menu.Properties.Resources.invisible_512;
            this.invisible_pic.Location = new System.Drawing.Point(311, 187);
            this.invisible_pic.Name = "invisible_pic";
            this.invisible_pic.Size = new System.Drawing.Size(32, 20);
            this.invisible_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.invisible_pic.TabIndex = 3;
            this.invisible_pic.TabStop = false;
            this.invisible_pic.Click += new System.EventHandler(this.invisible_pic_Click);
            // 
            // pasword
            // 
            this.pasword.Location = new System.Drawing.Point(137, 187);
            this.pasword.Name = "pasword";
            this.pasword.Size = new System.Drawing.Size(169, 20);
            this.pasword.TabIndex = 2;
            this.pasword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasword_KeyPress);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(129, 143);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(206, 20);
            this.username.TabIndex = 1;
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            // 
            // Alert_lbl
            // 
            this.Alert_lbl.AutoSize = true;
            this.Alert_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alert_lbl.Location = new System.Drawing.Point(56, 508);
            this.Alert_lbl.Name = "Alert_lbl";
            this.Alert_lbl.Size = new System.Drawing.Size(0, 21);
            this.Alert_lbl.TabIndex = 26;
            // 
            // Next_Page
            // 
            this.Next_Page.Controls.Add(this.Next_Page_lbl);
            this.Next_Page.Controls.Add(this.Next_Page_pic);
            this.Next_Page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_Page.Location = new System.Drawing.Point(16, 474);
            this.Next_Page.Name = "Next_Page";
            this.Next_Page.Size = new System.Drawing.Size(237, 62);
            this.Next_Page.TabIndex = 25;
            this.Next_Page.Click += new System.EventHandler(this.Next_Page_Click);
            this.Next_Page.MouseLeave += new System.EventHandler(this.Next_Page_MouseLeave);
            this.Next_Page.MouseHover += new System.EventHandler(this.Next_Page_MouseHover);
            // 
            // Next_Page_lbl
            // 
            this.Next_Page_lbl.AutoSize = true;
            this.Next_Page_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Page_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Next_Page_lbl.Location = new System.Drawing.Point(105, 22);
            this.Next_Page_lbl.Name = "Next_Page_lbl";
            this.Next_Page_lbl.Size = new System.Drawing.Size(124, 21);
            this.Next_Page_lbl.TabIndex = 8;
            this.Next_Page_lbl.Text = "PREVIOUS PAGE";
            this.Next_Page_lbl.Click += new System.EventHandler(this.Next_Page_lbl_Click);
            this.Next_Page_lbl.MouseLeave += new System.EventHandler(this.Next_Page_lbl_MouseLeave);
            this.Next_Page_lbl.MouseHover += new System.EventHandler(this.Next_Page_lbl_MouseHover);
            // 
            // Next_Page_pic
            // 
            this.Next_Page_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_Page_pic.Image = global::Essaie_Menu.Properties.Resources.arrow_82_512;
            this.Next_Page_pic.Location = new System.Drawing.Point(3, 3);
            this.Next_Page_pic.Name = "Next_Page_pic";
            this.Next_Page_pic.Size = new System.Drawing.Size(93, 56);
            this.Next_Page_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Next_Page_pic.TabIndex = 0;
            this.Next_Page_pic.TabStop = false;
            this.Next_Page_pic.Click += new System.EventHandler(this.Next_Page_pic_Click);
            this.Next_Page_pic.MouseLeave += new System.EventHandler(this.Next_Page_pic_MouseLeave);
            this.Next_Page_pic.MouseHover += new System.EventHandler(this.Next_Page_pic_MouseHover);
            // 
            // Page_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Alert_lbl);
            this.Controls.Add(this.Next_Page);
            this.Controls.Add(this.panel1);
            this.Name = "Page_Login";
            this.Size = new System.Drawing.Size(780, 559);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_pic)).EndInit();
            ok_pnl.ResumeLayout(false);
            ok_pnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visible_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invisible_pic)).EndInit();
            this.Next_Page.ResumeLayout(false);
            this.Next_Page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Next_Page_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox invisible_pic;
        private System.Windows.Forms.TextBox pasword;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.PictureBox login_pic;
        private System.Windows.Forms.PictureBox visible_pic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ok_lbl;
        private System.Windows.Forms.Label Alert_lbl;
        private System.Windows.Forms.Panel Next_Page;
        private System.Windows.Forms.Label Next_Page_lbl;
        private System.Windows.Forms.PictureBox Next_Page_pic;
    }
}
