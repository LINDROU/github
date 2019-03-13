namespace Essaie_Menu
{
    partial class Page_Option
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menu_pic = new System.Windows.Forms.PictureBox();
            this.Menu_lbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Open_configs_lbl = new System.Windows.Forms.Label();
            this.Delete_Fps_lbl = new System.Windows.Forms.Label();
            this.Delete_Fps_pic = new System.Windows.Forms.PictureBox();
            this.Open_configs_pic = new System.Windows.Forms.PictureBox();
            this.Auto_Start = new System.Windows.Forms.CheckBox();
            this.FAQ_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Fps_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Open_configs_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FAQ_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.Menu_pic);
            this.panel1.Controls.Add(this.Menu_lbl);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(14, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 2;
            // 
            // Menu_pic
            // 
            this.Menu_pic.Image = global::Essaie_Menu.Properties.Resources.cog_5121;
            this.Menu_pic.Location = new System.Drawing.Point(22, 10);
            this.Menu_pic.Name = "Menu_pic";
            this.Menu_pic.Size = new System.Drawing.Size(31, 29);
            this.Menu_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Menu_pic.TabIndex = 3;
            this.Menu_pic.TabStop = false;
            // 
            // Menu_lbl
            // 
            this.Menu_lbl.AutoSize = true;
            this.Menu_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_lbl.ForeColor = System.Drawing.Color.White;
            this.Menu_lbl.Location = new System.Drawing.Point(81, 15);
            this.Menu_lbl.Name = "Menu_lbl";
            this.Menu_lbl.Size = new System.Drawing.Size(58, 21);
            this.Menu_lbl.TabIndex = 2;
            this.Menu_lbl.Text = "Option";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(169, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(31, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Open_configs_lbl
            // 
            this.Open_configs_lbl.AutoSize = true;
            this.Open_configs_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_configs_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Open_configs_lbl.Location = new System.Drawing.Point(47, 95);
            this.Open_configs_lbl.Name = "Open_configs_lbl";
            this.Open_configs_lbl.Size = new System.Drawing.Size(282, 21);
            this.Open_configs_lbl.TabIndex = 3;
            this.Open_configs_lbl.Text = "Open where all your configs are saved :";
            this.Open_configs_lbl.Click += new System.EventHandler(this.Open_configs_lbl_Click);
            // 
            // Delete_Fps_lbl
            // 
            this.Delete_Fps_lbl.AutoSize = true;
            this.Delete_Fps_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Fps_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Delete_Fps_lbl.Location = new System.Drawing.Point(496, 520);
            this.Delete_Fps_lbl.Name = "Delete_Fps_lbl";
            this.Delete_Fps_lbl.Size = new System.Drawing.Size(203, 21);
            this.Delete_Fps_lbl.TabIndex = 5;
            this.Delete_Fps_lbl.Text = "Delete all the FPS Unlocker :";
            this.Delete_Fps_lbl.Click += new System.EventHandler(this.Delete_Fps_lbl_Click);
            // 
            // Delete_Fps_pic
            // 
            this.Delete_Fps_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Fps_pic.Image = global::Essaie_Menu.Properties.Resources.full_trash_5121;
            this.Delete_Fps_pic.Location = new System.Drawing.Point(715, 503);
            this.Delete_Fps_pic.Name = "Delete_Fps_pic";
            this.Delete_Fps_pic.Size = new System.Drawing.Size(50, 50);
            this.Delete_Fps_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Delete_Fps_pic.TabIndex = 6;
            this.Delete_Fps_pic.TabStop = false;
            this.Delete_Fps_pic.Click += new System.EventHandler(this.Delete_Fps_pic_Click);
            // 
            // Open_configs_pic
            // 
            this.Open_configs_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Open_configs_pic.Image = global::Essaie_Menu.Properties.Resources.folder_7_5121;
            this.Open_configs_pic.Location = new System.Drawing.Point(335, 80);
            this.Open_configs_pic.Name = "Open_configs_pic";
            this.Open_configs_pic.Size = new System.Drawing.Size(50, 50);
            this.Open_configs_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Open_configs_pic.TabIndex = 4;
            this.Open_configs_pic.TabStop = false;
            this.Open_configs_pic.Click += new System.EventHandler(this.Open_configs_pic_Click);
            // 
            // Auto_Start
            // 
            this.Auto_Start.AutoSize = true;
            this.Auto_Start.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Auto_Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Auto_Start.Location = new System.Drawing.Point(51, 229);
            this.Auto_Start.Name = "Auto_Start";
            this.Auto_Start.Size = new System.Drawing.Size(322, 25);
            this.Auto_Start.TabIndex = 7;
            this.Auto_Start.Text = "Auto Start TCUN when windows is starting";
            this.Auto_Start.UseVisualStyleBackColor = true;
            // 
            // FAQ_pic
            // 
            this.FAQ_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FAQ_pic.Image = global::Essaie_Menu.Properties.Resources.globe_2_512;
            this.FAQ_pic.Location = new System.Drawing.Point(222, 152);
            this.FAQ_pic.Name = "FAQ_pic";
            this.FAQ_pic.Size = new System.Drawing.Size(50, 50);
            this.FAQ_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FAQ_pic.TabIndex = 9;
            this.FAQ_pic.TabStop = false;
            this.FAQ_pic.Click += new System.EventHandler(this.FAQ_pic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(47, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "FAQ Page / Error Page :";
            // 
            // Page_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FAQ_pic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Auto_Start);
            this.Controls.Add(this.Delete_Fps_pic);
            this.Controls.Add(this.Delete_Fps_lbl);
            this.Controls.Add(this.Open_configs_pic);
            this.Controls.Add(this.Open_configs_lbl);
            this.Controls.Add(this.panel1);
            this.Name = "Page_Option";
            this.Size = new System.Drawing.Size(800, 585);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Fps_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Open_configs_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FAQ_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Menu_pic;
        private System.Windows.Forms.Label Menu_lbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Open_configs_lbl;
        private System.Windows.Forms.PictureBox Open_configs_pic;
        private System.Windows.Forms.Label Delete_Fps_lbl;
        private System.Windows.Forms.PictureBox Delete_Fps_pic;
        private System.Windows.Forms.CheckBox Auto_Start;
        private System.Windows.Forms.PictureBox FAQ_pic;
        private System.Windows.Forms.Label label1;
    }
}
