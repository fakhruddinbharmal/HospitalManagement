namespace Hospital
{
    partial class MLCReportForm
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
            this.PatientMLCReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // PatientMLCReportViewer
            // 
            this.PatientMLCReportViewer.ActiveViewIndex = -1;
            this.PatientMLCReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatientMLCReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PatientMLCReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientMLCReportViewer.Location = new System.Drawing.Point(0, 0);
            this.PatientMLCReportViewer.Name = "PatientMLCReportViewer";
            this.PatientMLCReportViewer.Size = new System.Drawing.Size(952, 513);
            this.PatientMLCReportViewer.TabIndex = 0;
            // 
            // MLCReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 513);
            this.Controls.Add(this.PatientMLCReportViewer);
            this.Name = "MLCReportForm";
            this.Text = "MLCReportForm";
            this.Load += new System.EventHandler(this.MLCReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer PatientMLCReportViewer;
    }
}