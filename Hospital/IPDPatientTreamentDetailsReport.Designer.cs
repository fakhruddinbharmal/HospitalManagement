namespace Hospital
{
    partial class IPDPatientTreamentDetailsReport
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
            this.IPDPatientTreatmentSheet = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // IPDPatientTreatmentSheet
            // 
            this.IPDPatientTreatmentSheet.ActiveViewIndex = -1;
            this.IPDPatientTreatmentSheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPDPatientTreatmentSheet.Cursor = System.Windows.Forms.Cursors.Default;
            this.IPDPatientTreatmentSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IPDPatientTreatmentSheet.Location = new System.Drawing.Point(0, 0);
            this.IPDPatientTreatmentSheet.Name = "IPDPatientTreatmentSheet";
            this.IPDPatientTreatmentSheet.Size = new System.Drawing.Size(891, 637);
            this.IPDPatientTreatmentSheet.TabIndex = 0;
            this.IPDPatientTreatmentSheet.Load += new System.EventHandler(this.IPDPatientTreatmentSheet_Load);
            // 
            // IPDPatientTreamentDetailsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 637);
            this.Controls.Add(this.IPDPatientTreatmentSheet);
            this.Name = "IPDPatientTreamentDetailsReport";
            this.Text = "IPDPatientTreamentDetailsReport";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer IPDPatientTreatmentSheet;
    }
}