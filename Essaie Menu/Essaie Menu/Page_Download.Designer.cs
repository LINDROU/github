namespace Essaie_Menu
{
    partial class Page_Download
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menu_lbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.config_lbl = new System.Windows.Forms.Label();
            this.directory_config = new System.Windows.Forms.PictureBox();
            this.Menu_pic = new System.Windows.Forms.PictureBox();
            this.download_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directory_config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_pic)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // Menu_lbl
            // 
            this.Menu_lbl.AutoSize = true;
            this.Menu_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_lbl.ForeColor = System.Drawing.Color.White;
            this.Menu_lbl.Location = new System.Drawing.Point(81, 15);
            this.Menu_lbl.Name = "Menu_lbl";
            this.Menu_lbl.Size = new System.Drawing.Size(81, 21);
            this.Menu_lbl.TabIndex = 2;
            this.Menu_lbl.Text = "Download";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(83)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(169, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(31, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // config_lbl
            // 
            this.config_lbl.AutoSize = true;
            this.config_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.config_lbl.Location = new System.Drawing.Point(140, 141);
            this.config_lbl.Name = "config_lbl";
            this.config_lbl.Size = new System.Drawing.Size(442, 25);
            this.config_lbl.TabIndex = 3;
            this.config_lbl.Text = "All Your config : C://User/Lindra/Documents/Config";
            // 
            // directory_config
            // 
            this.directory_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.directory_config.Image = global::Essaie_Menu.Properties.Resources.folder_7_512;
            this.directory_config.Location = new System.Drawing.Point(57, 116);
            this.directory_config.Name = "directory_config";
            this.directory_config.Size = new System.Drawing.Size(66, 66);
            this.directory_config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.directory_config.TabIndex = 2;
            this.directory_config.TabStop = false;
            this.directory_config.Click += new System.EventHandler(this.directory_config_Click);
            // 
            // Menu_pic
            // 
            this.Menu_pic.Image = global::Essaie_Menu.Properties.Resources.download_2_51211;
            this.Menu_pic.Location = new System.Drawing.Point(22, 10);
            this.Menu_pic.Name = "Menu_pic";
            this.Menu_pic.Size = new System.Drawing.Size(31, 29);
            this.Menu_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Menu_pic.TabIndex = 3;
            this.Menu_pic.TabStop = false;
            // 
            // download_timer
            // 
            this.download_timer.Tick += new System.EventHandler(this.download_timer_Tick);
            // 
            // Page_Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.config_lbl);
            this.Controls.Add(this.directory_config);
            this.Controls.Add(this.panel1);
            this.Name = "Page_Download";
            this.Size = new System.Drawing.Size(856, 645);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directory_config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Menu_pic;
        private System.Windows.Forms.Label Menu_lbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox directory_config;
        private System.Windows.Forms.Label config_lbl;
        private System.Windows.Forms.Timer download_timer;
    }
}
