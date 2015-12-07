namespace Hospital
{
    partial class DischargeSummeryReport
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
            this.DischargeSummeryReportForm = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // DischargeSummeryReportForm
            // 
            this.DischargeSummeryReportForm.ActiveViewIndex = -1;
            this.DischargeSummeryReportForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DischargeSummeryReportForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.DischargeSummeryReportForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DischargeSummeryReportForm.Location = new System.Drawing.Point(0, 0);
            this.DischargeSummeryReportForm.Name = "DischargeSummeryReportForm";
            this.DischargeSummeryReportForm.Size = new System.Drawing.Size(906, 528);
            this.DischargeSummeryReportForm.TabIndex = 0;
            this.DischargeSummeryReportForm.Load += new System.EventHandler(this.DischargeSummeryReportForm_Load);
            // 
            // DischargeSummeryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 528);
            this.Controls.Add(this.DischargeSummeryReportForm);
            this.Name = "DischargeSummeryReport";
            this.Text = "DischargeSummeryReport";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer DischargeSummeryReportForm;
    }
}