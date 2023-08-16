
namespace CSarp_Car_Rental_System
{
    partial class FrmRent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboCustomers = new System.Windows.Forms.ComboBox();
            this.ComboCar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Rent Car";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Name";
            // 
            // ComboCustomers
            // 
            this.ComboCustomers.FormattingEnabled = true;
            this.ComboCustomers.Location = new System.Drawing.Point(35, 126);
            this.ComboCustomers.Name = "ComboCustomers";
            this.ComboCustomers.Size = new System.Drawing.Size(516, 28);
            this.ComboCustomers.TabIndex = 2;
            // 
            // ComboCar
            // 
            this.ComboCar.FormattingEnabled = true;
            this.ComboCar.Location = new System.Drawing.Point(35, 194);
            this.ComboCar.Name = "ComboCar";
            this.ComboCar.Size = new System.Drawing.Size(516, 28);
            this.ComboCar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Car Name";
            // 
            // BtnRent
            // 
            this.BtnRent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRent.BackColor = System.Drawing.Color.Maroon;
            this.BtnRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRent.ForeColor = System.Drawing.Color.White;
            this.BtnRent.Location = new System.Drawing.Point(35, 245);
            this.BtnRent.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRent.Name = "BtnRent";
            this.BtnRent.Size = new System.Drawing.Size(516, 51);
            this.BtnRent.TabIndex = 5;
            this.BtnRent.Text = "New Car";
            this.BtnRent.UseVisualStyleBackColor = false;
            this.BtnRent.Click += new System.EventHandler(this.BtnRent_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(552, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 322);
            this.Controls.Add(this.BtnRent);
            this.Controls.Add(this.ComboCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboCustomers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRent";
            this.Load += new System.EventHandler(this.FrmRent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboCustomers;
        private System.Windows.Forms.ComboBox ComboCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnRent;
    }
}