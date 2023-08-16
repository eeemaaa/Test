using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSarp_Car_Rental_System
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtUserName.Text == "")
            {
                MessageBox.Show("you have to enter UserName");
                TxtUserName.Select();
                return;
            }
            else if (TxtPassword.Text == "")
            {
                MessageBox.Show("you have to enter password");
                TxtPassword.Select();
                return;
            }

            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from Users where UserName like '" + TxtUserName.Text + "' and Password like '" + TxtPassword.Text + "' ", db.cn);
            db.dr = db.cm.ExecuteReader();
            if(db.dr.HasRows)
            {
                FrmMain f = new FrmMain();
                f.Show();
                this.Hide();
            }
            db.cn.Close();
           
        }

        private void BtnCreateNew_Click(object sender, EventArgs e)
        {
            FrmCreateNew f = new FrmCreateNew();
            f.Show();
            this.Hide();
        }
    }
}
