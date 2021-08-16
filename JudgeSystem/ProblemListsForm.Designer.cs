
namespace JudgeSystem
{
    partial class ProblemListsForm
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
            this.lblLoginId = new System.Windows.Forms.Label();
            this.dgvProblemLists = new System.Windows.Forms.DataGridView();
            this.btnSolve = new System.Windows.Forms.Button();
            this.txtSearchProblem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblemLists)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginId
            // 
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginId.Location = new System.Drawing.Point(12, 22);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(187, 32);
            this.lblLoginId.TabIndex = 3;
            this.lblLoginId.Text = "Problem Lists";
            // 
            // dgvProblemLists
            // 
            this.dgvProblemLists.AllowUserToAddRows = false;
            this.dgvProblemLists.AllowUserToDeleteRows = false;
            this.dgvProblemLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProblemLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProblemLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProblemLists.Location = new System.Drawing.Point(18, 86);
            this.dgvProblemLists.MultiSelect = false;
            this.dgvProblemLists.Name = "dgvProblemLists";
            this.dgvProblemLists.ReadOnly = true;
            this.dgvProblemLists.RowHeadersWidth = 51;
            this.dgvProblemLists.RowTemplate.Height = 24;
            this.dgvProblemLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProblemLists.Size = new System.Drawing.Size(1209, 428);
            this.dgvProblemLists.TabIndex = 4;
            this.dgvProblemLists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProblemLists_CellClick);
            // 
            // btnSolve
            // 
            this.btnSolve.Enabled = false;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(438, 569);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(368, 46);
            this.btnSolve.TabIndex = 15;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // txtSearchProblem
            // 
            this.txtSearchProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProblem.Location = new System.Drawing.Point(298, 22);
            this.txtSearchProblem.Name = "txtSearchProblem";
            this.txtSearchProblem.Size = new System.Drawing.Size(929, 34);
            this.txtSearchProblem.TabIndex = 16;
            this.txtSearchProblem.TextChanged += new System.EventHandler(this.txtSearchProblem_TextChanged);
            // 
            // ProblemListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 676);
            this.Controls.Add(this.txtSearchProblem);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.dgvProblemLists);
            this.Controls.Add(this.lblLoginId);
            this.Name = "ProblemListsForm";
            this.Text = "ProblemListsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProblemListsForm_FormClosed);
            this.Load += new System.EventHandler(this.ProblemListsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblemLists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.DataGridView dgvProblemLists;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox txtSearchProblem;
    }
}