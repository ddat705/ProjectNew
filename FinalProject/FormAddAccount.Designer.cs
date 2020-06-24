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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cbBoxOptionIDName = new System.Windows.Forms.ComboBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(37, 99);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(248, 300);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách nhân viên chưa có tài khoản ở chức vụ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(427, 203);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(427, 268);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Nhân Viên";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(447, 156);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 16);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "lbl";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(349, 322);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(452, 322);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // cbBoxOptionIDName
            // 
            this.cbBoxOptionIDName.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.cbBoxOptionIDName.DisplayMember = "0";
            this.cbBoxOptionIDName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxOptionIDName.FormattingEnabled = true;
            this.cbBoxOptionIDName.Items.AddRange(new object[] {
            "ID",
            "Họ Tên",
            "--Chọn--"});
            this.cbBoxOptionIDName.Location = new System.Drawing.Point(174, 53);
            this.cbBoxOptionIDName.Name = "cbBoxOptionIDName";
            this.cbBoxOptionIDName.Size = new System.Drawing.Size(83, 21);
            this.cbBoxOptionIDName.TabIndex = 39;
            this.cbBoxOptionIDName.SelectedIndexChanged += new System.EventHandler(this.CbBoxOptionIDName_SelectedIndexChanged);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Enabled = false;
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(273, 53);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(151, 26);
            this.txtSearchBox.TabIndex = 37;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(430, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 26);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FormAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.cbBoxOptionIDName);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBoxSelect);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Name = "FormAddAccount";
            this.Text = "FormAddAccount";
            this.Load += new System.EventHandler(this.FormAddAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.ComboBox cbBoxSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbBoxOptionIDName;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnSearch;
    }
}