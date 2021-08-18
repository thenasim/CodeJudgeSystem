
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
            this.btnAction = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
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
            this.dgvProblemLists.Size = new System.Drawing.Size(1209, 416);
            this.dgvProblemLists.TabIndex = 0;
            this.dgvProblemLists.TabStop = false;
            this.dgvProblemLists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProblemLists_CellClick);
            // 
            // btnAction
            // 
            this.btnAction.Enabled = false;
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(438, 541);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(368, 46);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Solve";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(438, 605);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(368, 46);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Visible = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // ProblemListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 676);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnAction);
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
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnAddNew;
    }
}