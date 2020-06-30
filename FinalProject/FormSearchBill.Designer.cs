namespace FinalProject
{
    partial class FormSearchBill
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
            this.TimkiemHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchBill = new FinalProject.SearchBill();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.TimkiemHDTableAdapter = new FinalProject.SearchBillTableAdapters.TimkiemHDTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TimkiemHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimkiemHDBindingSource
            // 
            this.TimkiemHDBindingSource.DataMember = "TimkiemHD";
            this.TimkiemHDBindingSource.DataSource = this.SearchBill;
            // 
            // SearchBill
            // 
            this.SearchBill.DataSetName = "SearchBill";
            this.SearchBill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TimkiemHDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.ReportSearchBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 112);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(784, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(471, 67);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Tìm";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.Btnsearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(349, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // TimkiemHDTableAdapter
            // 
            this.TimkiemHDTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã hóa đơn cần tìm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(211, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "TÌM KIẾM THÔNG TIN HÓA ĐƠN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FinalProject.Properties.Resources._8;
            this.pictureBox2.Location = new System.Drawing.Point(46, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 93);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(646, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 93);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormSearchBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 466);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormSearchBill";
            this.Text = "FormSearchBill";
            ((System.ComponentModel.ISupportInitialize)(this.TimkiemHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TimkiemHDBindingSource;
        private SearchBill SearchBill;
        private SearchBillTableAdapters.TimkiemHDTableAdapter TimkiemHDTableAdapter;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}