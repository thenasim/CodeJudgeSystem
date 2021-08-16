
namespace JudgeSystem
{
    partial class JudgeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtProblemBody = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtProblemTitle = new System.Windows.Forms.RichTextBox();
            this.rtxtTestInput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtxtTestOutput = new System.Windows.Forms.RichTextBox();
            this.rtxtInput = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddMoreIO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginId
            // 
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginId.Location = new System.Drawing.Point(6, 18);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(276, 32);
            this.lblLoginId.TabIndex = 3;
            this.lblLoginId.Text = "Create New Problem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // rtxtProblemBody
            // 
            this.rtxtProblemBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtProblemBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtProblemBody.Location = new System.Drawing.Point(12, 247);
            this.rtxtProblemBody.Name = "rtxtProblemBody";
            this.rtxtProblemBody.Size = new System.Drawing.Size(651, 472);
            this.rtxtProblemBody.TabIndex = 2;
            this.rtxtProblemBody.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Body";
            // 
            // rtxtProblemTitle
            // 
            this.rtxtProblemTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtProblemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtProblemTitle.Location = new System.Drawing.Point(12, 95);
            this.rtxtProblemTitle.Name = "rtxtProblemTitle";
            this.rtxtProblemTitle.Size = new System.Drawing.Size(651, 96);
            this.rtxtProblemTitle.TabIndex = 1;
            this.rtxtProblemTitle.Text = "";
            // 
            // rtxtTestInput
            // 
            this.rtxtTestInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTestInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTestInput.Location = new System.Drawing.Point(695, 95);
            this.rtxtTestInput.Name = "rtxtTestInput";
            this.rtxtTestInput.Size = new System.Drawing.Size(651, 96);
            this.rtxtTestInput.TabIndex = 3;
            this.rtxtTestInput.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(691, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Test Input (optional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(691, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Test Output";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(695, 673);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(307, 46);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtxtTestOutput
            // 
            this.rtxtTestOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTestOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTestOutput.Location = new System.Drawing.Point(695, 247);
            this.rtxtTestOutput.Name = "rtxtTestOutput";
            this.rtxtTestOutput.Size = new System.Drawing.Size(651, 96);
            this.rtxtTestOutput.TabIndex = 4;
            this.rtxtTestOutput.Text = "";
            // 
            // rtxtInput
            // 
            this.rtxtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtInput.Location = new System.Drawing.Point(695, 399);
            this.rtxtInput.Name = "rtxtInput";
            this.rtxtInput.Size = new System.Drawing.Size(651, 96);
            this.rtxtInput.TabIndex = 5;
            this.rtxtInput.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(691, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Input (optional)";
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtOutput.Location = new System.Drawing.Point(695, 551);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.Size = new System.Drawing.Size(651, 96);
            this.rtxtOutput.TabIndex = 6;
            this.rtxtOutput.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(691, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Output";
            // 
            // btnAddMoreIO
            // 
            this.btnAddMoreIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMoreIO.Location = new System.Drawing.Point(1008, 673);
            this.btnAddMoreIO.Name = "btnAddMoreIO";
            this.btnAddMoreIO.Size = new System.Drawing.Size(338, 46);
            this.btnAddMoreIO.TabIndex = 8;
            this.btnAddMoreIO.Text = "AddMoreIO";
            this.btnAddMoreIO.UseVisualStyleBackColor = true;
            this.btnAddMoreIO.Click += new System.EventHandler(this.btnAddMoreIO_Click);
            // 
            // JudgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 731);
            this.Controls.Add(this.btnAddMoreIO);
            this.Controls.Add(this.rtxtOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxtInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxtTestOutput);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxtTestInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtProblemTitle);
            this.Controls.Add(this.rtxtProblemBody);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoginId);
            this.Name = "JudgeForm";
            this.Text = "JudgeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JudgeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtProblemBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtProblemTitle;
        private System.Windows.Forms.RichTextBox rtxtTestInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtxtTestOutput;
        private System.Windows.Forms.RichTextBox rtxtInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddMoreIO;
    }
}