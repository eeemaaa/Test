
namespace CSarp_Car_Rental_System
{
    partial class FrmCategoryCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.AutoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 712);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LblCount);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.BtnLogin);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 702);
            this.panel2.TabIndex = 1;
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.ForeColor = System.Drawing.Color.Yellow;
            this.LblCount.Location = new System.Drawing.Point(-4, 680);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(27, 20);
            this.LblCount.TabIndex = 1;
            this.LblCount.Text = "00";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(678, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create New Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(1042, 3);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(43, 36);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "X";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Dgv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1104, 625);
            this.panel3.TabIndex = 3;
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutoId,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.ColEdit,
            this.ColDelete});
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dgv.Location = new System.Drawing.Point(0, 0);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(1102, 623);
            this.Dgv.TabIndex = 0;
            this.Dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // AutoId
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(28)))));
            this.AutoId.DefaultCellStyle = dataGridViewCellStyle2;
            this.AutoId.HeaderText = "id";
            this.AutoId.MinimumWidth = 6;
            this.AutoId.Name = "AutoId";
            this.AutoId.ReadOnly = true;
            this.AutoId.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Custmer Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "CustomerID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 128;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "CustomerPhone";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 158;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Customer Address";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Customer img";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // ColEdit
            // 
            this.ColEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColEdit.HeaderText = "Edit";
            this.ColEdit.MinimumWidth = 6;
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            this.ColEdit.Text = "Eidt";
            this.ColEdit.UseColumnTextForButtonValue = true;
            this.ColEdit.Width = 44;
            // 
            // ColDelete
            // 
            this.ColDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDelete.HeaderText = "Delete";
            this.ColDelete.MinimumWidth = 6;
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.ReadOnly = true;
            this.ColDelete.Text = "Delete";
            this.ColDelete.UseColumnTextForButtonValue = true;
            this.ColDelete.Width = 64;
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
            this.label1.Size = new System.Drawing.Size(485, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category Customers";
            // 
            // FrmCategoryCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(10)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1140, 730);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCategoryCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategoryCustomer";
            this.Load += new System.EventHandler(this.FrmCategoryCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
    }
}