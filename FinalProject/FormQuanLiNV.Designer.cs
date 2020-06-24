namespace FinalProject
{
    partial class FormQuanLiNV
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
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.dgvThongTinNV = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbBoxOptionSearch = new System.Windows.Forms.ComboBox();
            this.txtBoxHoTen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtBoxCMND = new System.Windows.Forms.TextBox();
            this.txtBoxLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBoxChucVu = new System.Windows.Forms.ComboBox();
            this.dtpNamsinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Enabled = false;
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(637, 40);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(151, 26);
            this.txtSearchBox.TabIndex = 4;
            // 
            // dgvThongTinNV
            // 
            this.dgvThongTinNV.AllowUserToOrderColumns = true;
            this.dgvThongTinNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNV.Location = new System.Drawing.Point(3, 12);
            this.dgvThongTinNV.Name = "dgvThongTinNV";
            this.dgvThongTinNV.Size = new System.Drawing.Size(495, 301);
            this.dgvThongTinNV.TabIndex = 5;
            this.dgvThongTinNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvThongTinNV_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(794, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 26);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tìm kiếm theo:";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(390, 336);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(91, 37);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(264, 336);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 37);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(132, 336);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 37);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 336);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 37);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // cbBoxOptionSearch
            // 
            this.cbBoxOptionSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.cbBoxOptionSearch.DisplayMember = "0";
            this.cbBoxOptionSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxOptionSearch.FormattingEnabled = true;
            this.cbBoxOptionSearch.Items.AddRange(new object[] {
            "ID",
            "Họ Tên",
            "ThuNgan"});
            this.cbBoxOptionSearch.Location = new System.Drawing.Point(525, 40);
            this.cbBoxOptionSearch.Name = "cbBoxOptionSearch";
            this.cbBoxOptionSearch.Size = new System.Drawing.Size(100, 21);
            this.cbBoxOptionSearch.TabIndex = 19;
            this.cbBoxOptionSearch.SelectedIndexChanged += new System.EventHandler(this.CbBoxOptionSearch_SelectedIndexChanged);
            // 
            // txtBoxHoTen
            // 
            this.txtBoxHoTen.Location = new System.Drawing.Point(670, 118);
            this.txtBoxHoTen.Name = "txtBoxHoTen";
            this.txtBoxHoTen.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHoTen.TabIndex = 27;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(670, 89);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Năm sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "ID";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(670, 311);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(567, 311);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // txtBoxCMND
            // 
            this.txtBoxCMND.Location = new System.Drawing.Point(670, 148);
            this.txtBoxCMND.Name = "txtBoxCMND";
            this.txtBoxCMND.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCMND.TabIndex = 29;
            // 
            // txtBoxLuong
            // 
            this.txtBoxLuong.Location = new System.Drawing.Point(670, 219);
            this.txtBoxLuong.Name = "txtBoxLuong";
            this.txtBoxLuong.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLuong.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Lương";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Chức vụ";
            // 
            // cbBoxChucVu
            // 
            this.cbBoxChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxChucVu.FormattingEnabled = true;
            this.cbBoxChucVu.Items.AddRange(new object[] {
            "Quan Li",
            "Phuc Vu",
            "Bao Ve",
            "Thu Ngan"});
            this.cbBoxChucVu.Location = new System.Drawing.Point(670, 259);
            this.cbBoxChucVu.Name = "cbBoxChucVu";
            this.cbBoxChucVu.Size = new System.Drawing.Size(100, 21);
            this.cbBoxChucVu.TabIndex = 34;
            // 
            // dtpNamsinh
            // 
            this.dtpNamsinh.CustomFormat = "yyyy-MM-dd";
            this.dtpNamsinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamsinh.Location = new System.Drawing.Point(670, 186);
            this.dtpNamsinh.Name = "dtpNamsinh";
            this.dtpNamsinh.Size = new System.Drawing.Size(100, 20);
            this.dtpNamsinh.TabIndex = 35;

            // 
            // FormQuanLiNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.dtpNamsinh);
            this.Controls.Add(this.cbBoxChucVu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxLuong);
            this.Controls.Add(this.txtBoxCMND);
            this.Controls.Add(this.txtBoxHoTen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cbBoxOptionSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.dgvThongTinNV);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "FormQuanLiNV";
            this.Text = "FormQuanLiNV";
            this.Load += new System.EventHandler(this.FormQuanLiNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.DataGridView dgvThongTinNV;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbBoxOptionSearch;
        private System.Windows.Forms.TextBox txtBoxHoTen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtBoxCMND;
        private System.Windows.Forms.TextBox txtBoxLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBoxChucVu;
        private System.Windows.Forms.DateTimePicker dtpNamsinh;
    }
}