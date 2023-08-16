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
    public partial class FrmRent : Form
    {

        FrmMain f = new FrmMain();
        public FrmRent(FrmMain f)
        {
            InitializeComponent();
            this.f = f;
            LoadCustomers();
            LoadCar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void LoadCustomers()
        {

            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from Customers", db.cn);
            db.dr = db.cm.ExecuteReader();
            while(db.dr.Read())
            {
                ComboCustomers.Items.Add(db.dr[1]);
            }
            db.cn.Close();

        }

        public void LoadCar()
        {
            ComboCar.Items.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from Cars where CatStatus=0", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                ComboCar.Items.Add(db.dr[1]);
            }
            db.cn.Close();

        }
        private void FrmRent_Load(object sender, EventArgs e)
        {

        }

        private void BtnRent_Click(object sender, EventArgs e)
        {
        

            //insert information rent
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into Rents (CustomerID,CarID) values (@CustomerID,@CarID)", db.cn);
            db.cm.Parameters.AddWithValue("@CustomerID", ComboCustomers.Text);
            db.cm.Parameters.AddWithValue("@CarID", ComboCar.Text);
            db.cm.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show("Test");


            //update status car from Available to become rent
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("update Cars set CatStatus=1 where CarName=@CarName", db.cn);
            db.cm.Parameters.AddWithValue("@CarName", ComboCar.Text);
            db.cm.ExecuteNonQuery();
            db.cn.Close();
            f.LoadCarsAvailable();
            f.LoadCarsRent();
            LoadCar();
            ComboCar.Text = "";
            ComboCustomers.Text = "";

        }
    }
}
