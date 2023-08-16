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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            LoadCarsAvailable();
            LoadCarsRent();
            LoadCustomers();
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            this.Width = width;
            this.Height = height;
            Top = 0;
            Left = 0;
            panel1.Width = width -20;
            panel1.Height = height - 20;
        }

        private void BtnCreateCar_Click(object sender, EventArgs e)
        {
            FrmCategoryCar f = new FrmCategoryCar();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategoryCustomer F = new FrmCategoryCustomer();
            F.ShowDialog();
        }

        public void LoadCustomers()
        {
            int i = 0;
            DgvCustomers.Rows.Clear();

            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from Customers", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                i++;
                DgvCustomers.Rows.Add(db.dr[0], i, db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5]);
            }
            LblCustomer.Text = "Total customers " + " (" + i.ToString() + ")";
            db.cn.Close();

        }

        public void LoadCarsAvailable()
        {
            int i = 0;
            DgvAvailable.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from Cars where CatStatus='0'", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                i++;
                DgvAvailable.Rows.Add(db.dr[0], i, db.dr[1], db.dr[2], db.dr[3], db.dr[4]);
            }
            LblCarAvilable.Text = "Total Car Avilable " + " (" + i.ToString() + ")";
            db.cn.Close();


        }

        public void LoadCarsRent()
        {
            int i = 0;
            DgvRent.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from Cars where CatStatus='1'", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                i++;
                DgvRent.Rows.Add(db.dr[0], i, db.dr[1], db.dr[2], db.dr[3], db.dr[4]);
            }
             LblCarRent.Text = "Total Car Rent " + " (" + i.ToString() + ")";
            db.cn.Close();
        }
            private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnRent_Click(object sender, EventArgs e)
        {
            FrmRent f = new FrmRent(this);
            f.ShowDialog();
        }
    }
}
