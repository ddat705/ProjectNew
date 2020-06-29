namespace FinalProject
{
    partial class FormReport
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
            this.ReportXuatHD = new FinalProject.ReportXuatHD();
            this.BILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BILLTableAdapter = new FinalProject.ReportXuatHDTableAdapters.BILLTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportXuatHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BILLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BILLBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.ReportXuatHD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(77, 32);
            this.reportViewer1.Name = "reportViewer1";
            //this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(658, 284);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportXuatHD
            // 
            this.ReportXuatHD.DataSetName = "ReportXuatHD";
            this.ReportXuatHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BILLBindingSource
            // 
            this.BILLBindingSource.DataMember = "BILL";
            this.BILLBindingSource.DataSource = this.ReportXuatHD;
            // 
            // BILLTableAdapter
            // 
            this.BILLTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xin cảm ơn quý khách!!!Hẹn gặp lại";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportXuatHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BILLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BILLBindingSource;
        private ReportXuatHD ReportXuatHD;
        private ReportXuatHDTableAdapters.BILLTableAdapter BILLTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}