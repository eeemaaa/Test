
namespace CSarp_Car_Rental_System
{
    partial class FrmAddCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCarModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCarColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCarName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 107);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(459, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create Car";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnUpdate);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.BtnCreate);
            this.panel2.Controls.Add(this.pic);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TxtCarModel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TxtCarColor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TxtCarName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 482);
            this.panel2.TabIndex = 4;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnUpdate.FlatAppearance.BorderSize = 5;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(258, 411);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(177, 47);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 5;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(181, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 47);
            this.button3.TabIndex = 9;
            this.button3.Text = "Load Image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCreate.FlatAppearance.BorderSize = 5;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.ForeColor = System.Drawing.Color.White;
            this.BtnCreate.Location = new System.Drawing.Point(22, 411);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(177, 47);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "Create New Car";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(321, 267);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(141, 120);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 7;
            this.pic.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Image";
            // 
            // TxtCarModel
            // 
            this.TxtCarModel.Location = new System.Drawing.Point(20, 183);
            this.TxtCarModel.Name = "TxtCarModel";
            this.TxtCarModel.Size = new System.Drawing.Size(440, 26);
            this.TxtCarModel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Car Model";
            // 
            // TxtCarColor
            // 
            this.TxtCarColor.Location = new System.Drawing.Point(21, 117);
            this.TxtCarColor.Name = "TxtCarColor";
            this.TxtCarColor.Size = new System.Drawing.Size(440, 26);
            this.TxtCarColor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Car Color";
            // 
            // TxtCarName
            // 
            this.TxtCarName.Location = new System.Drawing.Point(22, 55);
            this.TxtCarName.Name = "TxtCarName";
            this.TxtCarName.Size = new System.Drawing.Size(440, 26);
            this.TxtCarName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Car Name";
            // 
            // FrmAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(536, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddCar";
            this.Load += new System.EventHandler(this.FrmAddCar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button BtnUpdate;
        public System.Windows.Forms.PictureBox pic;
        public System.Windows.Forms.TextBox TxtCarModel;
        public System.Windows.Forms.TextBox TxtCarColor;
        public System.Windows.Forms.TextBox TxtCarName;
        public System.Windows.Forms.Button BtnCreate;
        public System.Windows.Forms.Button button3;
    }
}