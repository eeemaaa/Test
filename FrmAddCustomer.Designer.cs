
namespace CSarp_Car_Rental_System
{
    partial class FrmAddCustomer
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txtaddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Txtaddress);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.pic);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Txtphone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Txtid);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TxtName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 91);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 425);
            this.panel2.TabIndex = 6;
            // 
            // Txtaddress
            // 
            this.Txtaddress.Location = new System.Drawing.Point(25, 268);
            this.Txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.Txtaddress.Multiline = true;
            this.Txtaddress.Name = "Txtaddress";
            this.Txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txtaddress.Size = new System.Drawing.Size(329, 136);
            this.Txtaddress.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Customer Address";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 5;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(388, 352);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 50);
            this.button3.TabIndex = 9;
            this.button3.Text = "Load Image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(388, 51);
            this.pic.Margin = new System.Windows.Forms.Padding(4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(218, 204);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 7;
            this.pic.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(384, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Image";
            // 
            // Txtphone
            // 
            this.Txtphone.Location = new System.Drawing.Point(25, 192);
            this.Txtphone.Margin = new System.Windows.Forms.Padding(4);
            this.Txtphone.Name = "Txtphone";
            this.Txtphone.Size = new System.Drawing.Size(329, 26);
            this.Txtphone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer Phone";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(26, 119);
            this.Txtid.Margin = new System.Windows.Forms.Padding(4);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(329, 26);
            this.Txtid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(29, 48);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(329, 26);
            this.TxtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnUpdate.FlatAppearance.BorderSize = 5;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(374, 21);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(239, 66);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCreate.FlatAppearance.BorderSize = 5;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.ForeColor = System.Drawing.Color.White;
            this.BtnCreate.Location = new System.Drawing.Point(25, 21);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(196, 66);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "Create New Car";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 75);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(782, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 50);
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
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create Customer";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BtnCreate);
            this.panel3.Controls.Add(this.BtnUpdate);
            this.panel3.Location = new System.Drawing.Point(9, 524);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 104);
            this.panel3.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(565, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(643, 644);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddCustomer";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox Txtaddress;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button BtnUpdate;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button BtnCreate;
        public System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Txtphone;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button button1;
    }
}