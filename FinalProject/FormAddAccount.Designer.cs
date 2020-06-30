namespace FinalProject
{
    partial class FormAddAccount
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
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.cbBoxSelect = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.cbBoxIDTen = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbChucvu = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.ptbImageNV = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(37, 99);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(456, 268);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTaiKhoan_CellClick);
            // 
            // cbBoxSelect
            // 
            this.cbBoxSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxSelect.FormattingEnabled = true;
            this.cbBoxSelect.Items.AddRange(new object[] {
            "Quản Lí",
            "Thu Ngân",
            "Tất Cả"});
            this.cbBoxSelect.Location = new System.Drawing.Point(37, 53);
            this.cbBoxSelect.Name = "cbBoxSelect";
            this.cbBoxSelect.Size = new System.Drawing.Size(121, 21);
            this.cbBoxSelect.TabIndex = 1;
            this.cbBoxSelect.SelectedIndexChanged += new System.EventHandler(this.CbBoxSelect_SelectedIndexChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(628, 160);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(628, 204);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(532, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(532, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(532, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Nhân Viên";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(650, 122);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 16);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "lbl";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(535, 50);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm Tài Khoản";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(653, 314);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(288, 53);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(149, 20);
            this.txtsearch.TabIndex = 12;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.White;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(452, 51);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(61, 23);
            this.btnsearch.TabIndex = 13;
            this.btnsearch.Text = "Tìm";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.Btnsearch_Click);
            // 
            // cbBoxIDTen
            // 
            this.cbBoxIDTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxIDTen.FormattingEnabled = true;
            this.cbBoxIDTen.Items.AddRange(new object[] {
            "ID",
            "Họ Tên",
            "--Chọn--"});
            this.cbBoxIDTen.Location = new System.Drawing.Point(182, 53);
            this.cbBoxIDTen.Name = "cbBoxIDTen";
            this.cbBoxIDTen.Size = new System.Drawing.Size(84, 21);
            this.cbBoxIDTen.TabIndex = 14;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(550, 314);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(530, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Loại tài khoản:";
            // 
            // cbChucvu
            // 
            this.cbChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucvu.FormattingEnabled = true;
            this.cbChucvu.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cbChucvu.Location = new System.Drawing.Point(628, 251);
            this.cbChucvu.Name = "cbChucvu";
            this.cbChucvu.Size = new System.Drawing.Size(100, 21);
            this.cbChucvu.TabIndex = 17;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(761, 314);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(73, 23);
            this.btnReload.TabIndex = 18;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.BackColor = System.Drawing.Color.White;
            this.btnAddPicture.Location = new System.Drawing.Point(860, 314);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(31, 23);
            this.btnAddPicture.TabIndex = 19;
            this.btnAddPicture.Text = "...";
            this.btnAddPicture.UseVisualStyleBackColor = false;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // ptbImageNV
            // 
            this.ptbImageNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImageNV.Location = new System.Drawing.Point(742, 111);
            this.ptbImageNV.Name = "ptbImageNV";
            this.ptbImageNV.Size = new System.Drawing.Size(149, 184);
            this.ptbImageNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImageNV.TabIndex = 20;
            this.ptbImageNV.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::FinalProject.Properties.Resources._133_1331440_free_vector_graphic_create_an_account_icon_clipart7;
            this.pictureBox1.Location = new System.Drawing.Point(822, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 67);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FormAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.qqqqs;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 426);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptbImageNV);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.cbChucvu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbBoxIDTen);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.cbBoxSelect);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Name = "FormAddAccount";
            this.Text = "FormAddAccount";
            this.Load += new System.EventHandler(this.FormAddAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.ComboBox cbBoxSelect;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox cbBoxIDTen;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbChucvu;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.PictureBox ptbImageNV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}