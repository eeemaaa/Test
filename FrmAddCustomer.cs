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
    public partial class FrmAddCustomer : Form
    {
        FrmCategoryCustomer f = new FrmCategoryCustomer();

        public FrmAddCustomer(FrmCategoryCustomer f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.OpenImage(pic);
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("Insert into Customers (CustomerName,CustomerID,CustomerPhone,CustomerAddress,Customerimg) values (@CustomerName,@CustomerID,@CustomerPhone,@CustomerAddress,@Customerimg)", db.cn);
            db.cm.Parameters.AddWithValue("@CustomerName", TxtName.Text);
            db.cm.Parameters.AddWithValue("@CustomerID", Txtid.Text);
            db.cm.Parameters.AddWithValue("@CustomerPhone", Txtphone.Text);
            db.cm.Parameters.AddWithValue("@CustomerAddress", Txtaddress.Text);
            db.ConvertImageToSave(pic);
            db.cm.Parameters.AddWithValue("@Customerimg", db._img);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Customer has been Saved");
            db.cn.Close();
            f.LoadCustomers();
            Txtaddress.Clear();
            Txtid.Clear();
            TxtName.Clear();
            Txtphone.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("update Customers set CustomerName=@CustomerName,CustomerID=@CustomerID,CustomerPhone=@CustomerPhone,CustomerAddress=@CustomerAddress,Customerimg=@Customerimg where id=@id", db.cn);
            db.cm.Parameters.AddWithValue("@id",db._id);
            db.cm.Parameters.AddWithValue("@CustomerName", TxtName.Text);
            db.cm.Parameters.AddWithValue("@CustomerID", Txtid.Text);
            db.cm.Parameters.AddWithValue("@CustomerPhone", Txtphone.Text);
            db.cm.Parameters.AddWithValue("@CustomerAddress", Txtaddress.Text);
            db.ConvertImageToSave(pic);
            db.cm.Parameters.AddWithValue("@Customerimg", db._img);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Customer has been Update");
            db.cn.Close();
            f.LoadCustomers();
            Dispose();
        }
    }
}
