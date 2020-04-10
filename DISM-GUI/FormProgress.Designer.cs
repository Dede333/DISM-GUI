namespace DISM_GUI
{
    partial class FormProgress
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
            this.LblDismEnCoursExecution = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProgressBarDismEnCours = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LblDismEnCoursExecution
            // 
            this.LblDismEnCoursExecution.AutoSize = true;
            this.LblDismEnCoursExecution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDismEnCoursExecution.Location = new System.Drawing.Point(79, 40);
            this.LblDismEnCoursExecution.Name = "LblDismEnCoursExecution";
            this.LblDismEnCoursExecution.Size = new System.Drawing.Size(435, 24);
            this.LblDismEnCoursExecution.TabIndex = 0;
            this.LblDismEnCoursExecution.Text = "DISM est en cours d\'exécution. Veuillez patienter...";
            // 
            // ProgressBarDismEnCours
            // 
            this.ProgressBarDismEnCours.Location = new System.Drawing.Point(83, 76);
            this.ProgressBarDismEnCours.Name = "ProgressBarDismEnCours";
            this.ProgressBarDismEnCours.Size = new System.Drawing.Size(431, 23);
            this.ProgressBarDismEnCours.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBarDismEnCours.TabIndex = 1;
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 151);
            this.ControlBox = false;
            this.Controls.Add(this.ProgressBarDismEnCours);
            this.Controls.Add(this.LblDismEnCoursExecution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProgress";
            this.Text = "Dism en cours d\'exécution";
            this.Load += new System.EventHandler(this.FormProgress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDismEnCoursExecution;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar ProgressBarDismEnCours;
    }
}