
namespace JudgeSystem
{
    partial class SupervisorForm
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
            this.dgvSubmittedDetails = new System.Windows.Forms.DataGridView();
            this.lblLoginId = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmittedDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubmittedDetails
            // 
            this.dgvSubmittedDetails.AllowUserToAddRows = false;
            this.dgvSubmittedDetails.AllowUserToDeleteRows = false;
            this.dgvSubmittedDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubmittedDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSubmittedDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubmittedDetails.Location = new System.Drawing.Point(12, 75);
            this.dgvSubmittedDetails.MultiSelect = false;
            this.dgvSubmittedDetails.Name = "dgvSubmittedDetails";
            this.dgvSubmittedDetails.ReadOnly = true;
            this.dgvSubmittedDetails.RowHeadersWidth = 51;
            this.dgvSubmittedDetails.RowTemplate.Height = 24;
            this.dgvSubmittedDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubmittedDetails.Size = new System.Drawing.Size(1266, 439);
            this.dgvSubmittedDetails.TabIndex = 0;
            this.dgvSubmittedDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubmittedDetails_CellClick);
            // 
            // lblLoginId
            // 
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginId.Location = new System.Drawing.Point(12, 22);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(270, 32);
            this.lblLoginId.TabIndex = 18;
            this.lblLoginId.Text = "Submitted Solutions";
            // 
            // btnVerify
            // 
            this.btnVerify.Enabled = false;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(461, 574);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(368, 46);
            this.btnVerify.TabIndex = 19;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // SupervisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 698);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lblLoginId);
            this.Controls.Add(this.dgvSubmittedDetails);
            this.Name = "SupervisorForm";
            this.Text = "SupervisorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SupervisorForm_FormClosed);
            this.Load += new System.EventHandler(this.SupervisorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmittedDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubmittedDetails;
        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.Button btnVerify;
    }
}