namespace FinalProject
{
    partial class FormLuongToanNV
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
            this.TKLFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TKLToanNV = new FinalProject.TKLToanNV();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TKLFullTableAdapter = new FinalProject.TKLToanNVTableAdapters.TKLFullTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TKLFullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKLToanNV)).BeginInit();
            this.SuspendLayout();
            // 
            // TKLFullBindingSource
            // 
            this.TKLFullBindingSource.DataMember = "TKLFull";
            this.TKLFullBindingSource.DataSource = this.TKLToanNV;
            // 
            // TKLToanNV
            // 
            this.TKLToanNV.DataSetName = "TKLToanNV";
            this.TKLToanNV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TKLFullBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.ReportTKLToanNV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TKLFullTableAdapter
            // 
            this.TKLFullTableAdapter.ClearBeforeFill = true;
            // 
            // FormLuongToanNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormLuongToanNV";
            this.Text = "FormLuongToanNV";
            this.Load += new System.EventHandler(this.FormLuongToanNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TKLFullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKLToanNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TKLFullBindingSource;
        private TKLToanNV TKLToanNV;
        private TKLToanNVTableAdapters.TKLFullTableAdapter TKLFullTableAdapter;
    }
}