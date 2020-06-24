namespace FinalProject
{
    partial class FormMenuManager
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
            this.dgvThongtin = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMaMonAn = new System.Windows.Forms.TextBox();
            this.txtBoxTenMonAn = new System.Windows.Forms.TextBox();
            this.txtBoxGia = new System.Windows.Forms.TextBox();
            this.cbBoxLoai = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.cbBoxOptionSearch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongtin
            // 
            this.dgvThongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtin.Location = new System.Drawing.Point(22, 77);
            this.dgvThongtin.Name = "dgvThongtin";
            this.dgvThongtin.Size = new System.Drawing.Size(330, 361);
            this.dgvThongtin.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(22, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(107, 35);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(195, 36);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(617, 126);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(397, 381);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(500, 381);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Enabled = false;
            this.txtSearchBox.Location = new System.Drawing.Point(386, 128);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(214, 20);
            this.txtSearchBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Món Ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Món Ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giá";
            // 
            // txtBoxMaMonAn
            // 
            this.txtBoxMaMonAn.Location = new System.Drawing.Point(500, 177);
            this.txtBoxMaMonAn.Name = "txtBoxMaMonAn";
            this.txtBoxMaMonAn.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMaMonAn.TabIndex = 13;
            // 
            // txtBoxTenMonAn
            // 
            this.txtBoxTenMonAn.Location = new System.Drawing.Point(500, 228);
            this.txtBoxTenMonAn.Name = "txtBoxTenMonAn";
            this.txtBoxTenMonAn.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTenMonAn.TabIndex = 14;
            // 
            // txtBoxGia
            // 
            this.txtBoxGia.Location = new System.Drawing.Point(500, 326);
            this.txtBoxGia.Name = "txtBoxGia";
            this.txtBoxGia.Size = new System.Drawing.Size(100, 20);
            this.txtBoxGia.TabIndex = 15;
            // 
            // cbBoxLoai
            // 
            this.cbBoxLoai.FormattingEnabled = true;
            this.cbBoxLoai.Location = new System.Drawing.Point(500, 276);
            this.cbBoxLoai.Name = "cbBoxLoai";
            this.cbBoxLoai.Size = new System.Drawing.Size(100, 21);
            this.cbBoxLoai.TabIndex = 16;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(283, 36);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(69, 23);
            this.btnReload.TabIndex = 17;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // cbBoxOptionSearch
            // 
            this.cbBoxOptionSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.cbBoxOptionSearch.DisplayMember = "0";
            this.cbBoxOptionSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxOptionSearch.FormattingEnabled = true;
            this.cbBoxOptionSearch.Items.AddRange(new object[] {
            "ID",
            "Tên"});
            this.cbBoxOptionSearch.Location = new System.Drawing.Point(386, 80);
            this.cbBoxOptionSearch.Name = "cbBoxOptionSearch";
            this.cbBoxOptionSearch.Size = new System.Drawing.Size(100, 21);
            this.cbBoxOptionSearch.TabIndex = 18;
            this.cbBoxOptionSearch.SelectedIndexChanged += new System.EventHandler(this.cbBoxOptionSearch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tìm kiếm theo:";
            // 
            // FormMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBoxOptionSearch);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.cbBoxLoai);
            this.Controls.Add(this.txtBoxGia);
            this.Controls.Add(this.txtBoxTenMonAn);
            this.Controls.Add(this.txtBoxMaMonAn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvThongtin);
            this.Name = "FormMenuManager";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenuManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongtin;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMaMonAn;
        private System.Windows.Forms.TextBox txtBoxTenMonAn;
        private System.Windows.Forms.TextBox txtBoxGia;
        private System.Windows.Forms.ComboBox cbBoxLoai;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cbBoxOptionSearch;
        private System.Windows.Forms.Label label5;
    }
}