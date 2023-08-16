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
    public partial class FrmCategoryCar : Form
    {

        public FrmCategoryCar()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dispose();
        }

      public  void LoadCars()
        {
            int i = 0;
            Dgv.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from Cars ", db.cn);
            db.dr = db.cm.ExecuteReader();
            while(db.dr.Read())
            {
                i++;
                Dgv.Rows.Add(db.dr[0],i,db.dr[1],db.dr[2],db.dr[3],db.dr[4]);
            }
            LblCount.Text = "Total customers " + " (" + i.ToString() + ")";
            db.cn.Close();
        }
        private void FrmCategoryCar_Load(object sender, EventArgs e)
        {
            LoadCars();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddCar f = new FrmAddCar(this);

            f.ShowDialog(); 
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string COlName = Dgv.Columns[e.ColumnIndex].Name;
            if(COlName == "ColEdit")
            {
                FrmAddCar f = new FrmAddCar(this);
                db._id = (int)Dgv.CurrentRow.Cells[0].Value;
                f.TxtCarName.Text = Dgv.CurrentRow.Cells[2].Value.ToString();
                f.TxtCarColor.Text = Dgv.CurrentRow.Cells[3].Value.ToString();
                f.TxtCarModel.Text = Dgv.CurrentRow.Cells[4].Value.ToString();
                db.ShowImageinPictureBox(f.pic, Dgv, 5);
                f.BtnUpdate.Enabled = true;
                f.BtnCreate.Enabled = false;
                f.ShowDialog();
            }
            else if(COlName == "ColDelete")
            {
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("delete from Cars where id like '" + Dgv.CurrentRow.Cells[0].Value + "'", db.cn);
                db.cm.ExecuteNonQuery();
                MessageBox.Show("Car has been deleted");
                db.cn.Close();
                LoadCars();
            }
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
