
namespace CSarp_Car_Rental_System
{
    partial class FrmCreateNew
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCreateNew = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnCreateNew);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 506);
            this.panel1.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(42, 421);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(611, 62);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = " Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCreateNew
            // 
            this.BtnCreateNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateNew.ForeColor = System.Drawing.Color.White;
            this.BtnCreateNew.Location = new System.Drawing.Point(41, 328);
            this.BtnCreateNew.Name = "BtnCreateNew";
            this.BtnCreateNew.Size = new System.Drawing.Size(612, 62);
            this.BtnCreateNew.TabIndex = 6;
            this.BtnCreateNew.Text = "Create New User";
            this.BtnCreateNew.UseVisualStyleBackColor = true;
            this.BtnCreateNew.Click += new System.EventHandler(this.BtnCreateNew_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(41, 266);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(611, 22);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(41, 188);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(611, 22);
            this.TxtUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New User";
            // 
            // FrmCreateNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(714, 526);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreateNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreateNew";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCreateNew;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}