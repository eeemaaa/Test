
namespace CSarp_Car_Rental_System
{
    partial class FrmLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCreateNew = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.TxtUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 529);
            this.panel1.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(52, 434);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(611, 62);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCreateNew
            // 
            this.BtnCreateNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateNew.ForeColor = System.Drawing.Color.White;
            this.BtnCreateNew.Location = new System.Drawing.Point(356, 341);
            this.BtnCreateNew.Name = "BtnCreateNew";
            this.BtnCreateNew.Size = new System.Drawing.Size(307, 62);
            this.BtnCreateNew.TabIndex = 6;
            this.BtnCreateNew.Text = "Create New User";
            this.BtnCreateNew.UseVisualStyleBackColor = true;
            this.BtnCreateNew.Click += new System.EventHandler(this.BtnCreateNew_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(52, 269);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(611, 26);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(52, 341);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(211, 62);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(52, 188);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(611, 26);
            this.TxtUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login System rental car ";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(734, 562);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCreateNew;
    }
}

