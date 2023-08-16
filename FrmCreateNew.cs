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
    public partial class FrmCreateNew : Form
    {
        public FrmCreateNew()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreateNew_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into Users(UserName,Password)values(@UserName,@Password)", db.cn);
            db.cm.Parameters.AddWithValue("@UserName", TxtUserName.Text);
            db.cm.Parameters.AddWithValue("@Password", TxtPassword.Text);
            db.cm.ExecuteNonQuery();
            TxtPassword.Clear();
            TxtUserName.Clear();
            MessageBox.Show("User has been saved");
            db.cn.Close();

            FrmLogin f = new FrmLogin();
            f.Show();
            this.Dispose();

        }
    }
}
