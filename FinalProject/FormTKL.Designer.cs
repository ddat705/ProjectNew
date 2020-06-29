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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongKeLuong = new FinalProject.ThongKeLuong();
            this.ThongKeLuongBoPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongKeLuongBoPhanTableAdapter = new FinalProject.ThongKeLuongTableAdapters.ThongKeLuongBoPhanTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeLuongBoPhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ThongKeLuongBoPhanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.TKL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(173, 135);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // ThongKeLuong
            // 
            this.ThongKeLuong.DataSetName = "ThongKeLuong";
            this.ThongKeLuong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ThongKeLuongBoPhanBindingSource
            // 
            this.ThongKeLuongBoPhanBindingSource.DataMember = "ThongKeLuongBoPhan";
            this.ThongKeLuongBoPhanBindingSource.DataSource = this.ThongKeLuong;
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
            this.comboBox1.Location = new System.Drawing.Point(323, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // FormTKL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormTKL";
            this.Text = "FormTKL";
            this.Load += new System.EventHandler(this.FormTKL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeLuongBoPhanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThongKeLuongBoPhanBindingSource;
        private ThongKeLuong ThongKeLuong;
        private ThongKeLuongTableAdapters.ThongKeLuongBoPhanTableAdapter ThongKeLuongBoPhanTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}