
namespace JudgeSystem
{
    partial class ApprovedSubmission
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgvApprovedSub = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApprovedSub)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "My Approved Solution";
            // 
            // dgvApprovedSub
            // 
            this.dgvApprovedSub.AllowUserToAddRows = false;
            this.dgvApprovedSub.AllowUserToDeleteRows = false;
            this.dgvApprovedSub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApprovedSub.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvApprovedSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApprovedSub.Location = new System.Drawing.Point(12, 57);
            this.dgvApprovedSub.MultiSelect = false;
            this.dgvApprovedSub.Name = "dgvApprovedSub";
            this.dgvApprovedSub.ReadOnly = true;
            this.dgvApprovedSub.RowHeadersWidth = 51;
            this.dgvApprovedSub.RowTemplate.Height = 24;
            this.dgvApprovedSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApprovedSub.Size = new System.Drawing.Size(880, 410);
            this.dgvApprovedSub.TabIndex = 0;
            this.dgvApprovedSub.TabStop = false;
            // 
            // ApprovedSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 479);
            this.Controls.Add(this.dgvApprovedSub);
            this.Controls.Add(this.label6);
            this.Name = "ApprovedSubmission";
            this.Text = "ApprovedSubmission";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApprovedSubmission_FormClosed);
            this.Load += new System.EventHandler(this.ApprovedSubmission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApprovedSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvApprovedSub;
    }
}