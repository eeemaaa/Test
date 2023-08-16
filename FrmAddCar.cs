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
    public partial class FrmAddCar : Form
    {

        FrmCategoryCar f = new FrmCategoryCar();
        public FrmAddCar(FrmCategoryCar f)
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

        private void FrmAddCar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into Cars(CarName,CarColor,CarModel,Carimg) values (@CarName,@CarColor,@CarModel,@Carimg)", db.cn);
            db.cm.Parameters.AddWithValue("@CarName", TxtCarName.Text);
            db.cm.Parameters.AddWithValue("@CarColor", TxtCarColor.Text);
            db.cm.Parameters.AddWithValue("@CarModel", TxtCarModel.Text);
            db.ConvertImageToSave(pic);
            db.cm.Parameters.AddWithValue("@Carimg", db._img);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Car has been saved");
            db.cn.Close();
            TxtCarColor.Clear();
            TxtCarModel.Clear();
            TxtCarName.Clear();
            TxtCarName.Select();
            f.LoadCars();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("update Cars set CarName=@CarName,CarColor=@CarColor,CarModel=@CarModel,Carimg=@Carimg where id = @id", db.cn);
            db.cm.Parameters.AddWithValue("@id",db._id);
            db.cm.Parameters.AddWithValue("@CarName", TxtCarName.Text);
            db.cm.Parameters.AddWithValue("@CarColor", TxtCarColor.Text);
            db.cm.Parameters.AddWithValue("@CarModel", TxtCarModel.Text);
            db.ConvertImageToSave(pic);
            db.cm.Parameters.AddWithValue("@Carimg", db._img);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Car has been Update");
            db.cn.Close();
            TxtCarColor.Clear(); 
            TxtCarModel.Clear();
            TxtCarName.Clear();
            TxtCarName.Select();
            f.LoadCars();
            Dispose();
        }
    }
}
