namespace FinalProject
{
    partial class FormTKDoanhThu
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongKeDoanhThu = new FinalProject.ThongKeDoanhThu();
            this.TKDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TKDTTableAdapter = new FinalProject.ThongKeDoanhThuTableAdapters.TKDTTableAdapter();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKDTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TKDTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.ReportThongKeDT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(215, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // ThongKeDoanhThu
            // 
            this.ThongKeDoanhThu.DataSetName = "ThongKeDoanhThu";
            this.ThongKeDoanhThu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TKDTBindingSource
            // 
            this.TKDTBindingSource.DataMember = "TKDT";
            this.TKDTBindingSource.DataSource = this.ThongKeDoanhThu;
            // 
            // TKDTTableAdapter
            // 
            this.TKDTTableAdapter.ClearBeforeFill = true;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(192, 61);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(411, 61);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 2;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(627, 61);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(75, 23);
            this.btnTK.TabIndex = 3;
            this.btnTK.Text = "button1";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.BtnTK_Click);
            // 
            // FormTKDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormTKDoanhThu";
            this.Text = "FormTKDoanhThu";
            this.Load += new System.EventHandler(this.FormTKDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKDTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TKDTBindingSource;
        private ThongKeDoanhThu ThongKeDoanhThu;
        private ThongKeDoanhThuTableAdapters.TKDTTableAdapter TKDTTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnTK;
    }
}