using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essaie_Menu
{
    public partial class Page_Login : UserControl
    {
        public Page_Login()
        {
            InitializeComponent();
            username.Clear();
            pasword.Clear();
            visible_pic.Visible = false;
            Active_pw();
        }



        private void pasword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && username.Text.Length !=0 && pasword.Text.Length !=0)
            {
                ok_lbl_Click(sender, e);
            }
         else if (e.KeyChar == 13 && (username.Text.Length ==0 || pasword.Text.Length == 0))
            {
                MessageBox.Show("Password is empty");
            }
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && username.Text.Length != 0 && pasword.Text.Length != 0)
            {
                ok_lbl_Click(sender, e);
            }
            else if (e.KeyChar == 13 && (username.Text.Length == 0 || pasword.Text.Length == 0))
            {
                MessageBox.Show("Username is empty");
            }

        }

        private void ok_lbl_Click(object sender, EventArgs e)
        {
            if (username.Text =="" && pasword.Text == "")
            this.SendToBack();
        }

        private void ok_pnl_Click(object sender, EventArgs e)
        {
            if (username.Text == "" && pasword.Text == "")
                this.SendToBack();
        }

        #region visible PW
        public void Active_pw()
        {
            pasword.UseSystemPasswordChar = true;
            visible_pic.Visible = false;
            invisible_pic.Visible = true;
        }

        private void invisible_pic_Click(object sender, EventArgs e)
        { 
            pasword.UseSystemPasswordChar = false;
            visible_pic.Visible = true;
            invisible_pic.Visible = false;
            
        }

        private void visible_pic_Click(object sender, EventArgs e)
        {
            pasword.UseSystemPasswordChar = true;
            visible_pic.Visible = false;
            invisible_pic.Visible = true;  
        }
        #endregion

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
      
        private void Next_Page_lbl_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void Next_Page_pic_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void Next_Page_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }


        #endregion


    }
}
