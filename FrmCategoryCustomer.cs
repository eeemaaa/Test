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
    public partial class FrmCategoryCustomer : Form
    {
        public FrmCategoryCustomer()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void LoadCustomers()
        {
            int i = 0;
            Dgv.Rows.Clear();

            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from Customers", db.cn);
            db.dr = db.cm.ExecuteReader();
            while(db.dr.Read())
            {
                i++;
                Dgv.Rows.Add(db.dr[0], i, db.dr[1],db.dr[2],db.dr[3],db.dr[4],db.dr[5]);
            }
            LblCount.Text ="Total customers " + " (" + i.ToString() + ")";
            db.cn.Close();

        }
        private void FrmCategoryCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddCustomer f = new FrmAddCustomer(this);
            f.ShowDialog();
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = Dgv.Columns[e.ColumnIndex].Name;
            if(ColName == "ColEdit")
            {
                db._id = (int)Dgv.CurrentRow.Cells[0].Value;
                FrmAddCustomer f = new FrmAddCustomer(this);
                f.TxtName.Text = Dgv.CurrentRow.Cells[2].Value.ToString();
                f.Txtid.Text = Dgv.CurrentRow.Cells[3].Value.ToString();
                f.Txtphone.Text = Dgv.CurrentRow.Cells[4].Value.ToString();
                f.Txtaddress.Text = Dgv.CurrentRow.Cells[5].Value.ToString();
                db.ShowImageinPictureBox(f.pic, Dgv, 6);
                f.BtnCreate.Enabled = false;
                f.BtnUpdate.Enabled = true;
                f.ShowDialog();

            }else if(ColName == "ColDelete")
            {
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("Delete from Customers where id=@id", db.cn);
                db.cm.Parameters.AddWithValue("@id", Dgv.CurrentRow.Cells[0].Value);
                db.cm.ExecuteNonQuery();
                MessageBox.Show("Customer has been Delete");
                db.cn.Close();
                LoadCustomers();
            }
        }
    }
}
