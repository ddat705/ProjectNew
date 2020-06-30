namespace FinalProject
{
    partial class FormTKL
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ThongKeLuongBoPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongKeLuong = new FinalProject.ThongKeLuong();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongKeLuongBoPhanTableAdapter = new FinalProject.ThongKeLuongTableAdapters.ThongKeLuongBoPhanTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureTableAdapter1 = new FinalProject.SearchBillTableAdapters.PICTURETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeLuongBoPhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // ThongKeLuongBoPhanBindingSource
            // 
            this.ThongKeLuongBoPhanBindingSource.DataMember = "ThongKeLuongBoPhan";
            this.ThongKeLuongBoPhanBindingSource.DataSource = this.ThongKeLuong;
            // 
            // ThongKeLuong
            // 
            this.ThongKeLuong.DataSetName = "ThongKeLuong";
            this.ThongKeLuong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ThongKeLuongBoPhanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.TKL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 111);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 362);
            this.reportViewer1.TabIndex = 0;
            // 
            // ThongKeLuongBoPhanTableAdapter
            // 
            this.ThongKeLuongBoPhanTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Quản Lí",
            "Thu Ngân",
            "Phục Vụ",
            "Bảo Vệ"});
            this.comboBox1.Location = new System.Drawing.Point(408, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(215, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "THỐNG KÊ LƯƠNG THEO CHỨC VỤ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn chức vụ:";
            // 
            // pictureTableAdapter1
            // 
            this.pictureTableAdapter1.ClearBeforeFill = true;
            // 
            // FormTKL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormTKL";
            this.Text = "FormTKL";
            this.Load += new System.EventHandler(this.FormTKL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeLuongBoPhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThongKeLuongBoPhanBindingSource;
        private ThongKeLuong ThongKeLuong;
        private ThongKeLuongTableAdapters.ThongKeLuongBoPhanTableAdapter ThongKeLuongBoPhanTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SearchBillTableAdapters.PICTURETableAdapter pictureTableAdapter1;
    }
}