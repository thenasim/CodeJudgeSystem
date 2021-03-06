
namespace JudgeSystem
{
    partial class ParticipantForm
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
            this.rtxtYourCode = new System.Windows.Forms.RichTextBox();
            this.rtxtProblemBody = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rtxtTestInput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtTestOutput = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtProblemTitle = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtYourCode
            // 
            this.rtxtYourCode.AcceptsTab = true;
            this.rtxtYourCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtYourCode.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtYourCode.Location = new System.Drawing.Point(663, 45);
            this.rtxtYourCode.Name = "rtxtYourCode";
            this.rtxtYourCode.Size = new System.Drawing.Size(683, 619);
            this.rtxtYourCode.TabIndex = 0;
            this.rtxtYourCode.Text = "public static void Main() {\n    // your code here\n}\n\n// you can create new method" +
    " here";
            // 
            // rtxtProblemBody
            // 
            this.rtxtProblemBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtProblemBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtProblemBody.Location = new System.Drawing.Point(12, 187);
            this.rtxtProblemBody.Name = "rtxtProblemBody";
            this.rtxtProblemBody.ReadOnly = true;
            this.rtxtProblemBody.Size = new System.Drawing.Size(645, 304);
            this.rtxtProblemBody.TabIndex = 1;
            this.rtxtProblemBody.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Code:";
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(1095, 670);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 49);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(1201, 670);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 49);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rtxtTestInput
            // 
            this.rtxtTestInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTestInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTestInput.Location = new System.Drawing.Point(12, 530);
            this.rtxtTestInput.Name = "rtxtTestInput";
            this.rtxtTestInput.ReadOnly = true;
            this.rtxtTestInput.Size = new System.Drawing.Size(645, 76);
            this.rtxtTestInput.TabIndex = 6;
            this.rtxtTestInput.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(8, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Test Input:";
            // 
            // rtxtTestOutput
            // 
            this.rtxtTestOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTestOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTestOutput.Location = new System.Drawing.Point(12, 643);
            this.rtxtTestOutput.Name = "rtxtTestOutput";
            this.rtxtTestOutput.ReadOnly = true;
            this.rtxtTestOutput.Size = new System.Drawing.Size(645, 76);
            this.rtxtTestOutput.TabIndex = 8;
            this.rtxtTestOutput.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(8, 616);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Test Output:";
            // 
            // rtxtProblemTitle
            // 
            this.rtxtProblemTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtProblemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtProblemTitle.Location = new System.Drawing.Point(12, 36);
            this.rtxtProblemTitle.Name = "rtxtProblemTitle";
            this.rtxtProblemTitle.ReadOnly = true;
            this.rtxtProblemTitle.Size = new System.Drawing.Size(645, 96);
            this.rtxtProblemTitle.TabIndex = 11;
            this.rtxtProblemTitle.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(8, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Body";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Title";
            // 
            // ParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 731);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtProblemTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxtTestOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtTestInput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtProblemBody);
            this.Controls.Add(this.rtxtYourCode);
            this.MaximizeBox = false;
            this.Name = "ParticipantForm";
            this.Text = "ParticipantForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParticipantForm_FormClosed);
            this.Load += new System.EventHandler(this.ParticipantForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtYourCode;
        private System.Windows.Forms.RichTextBox rtxtProblemBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox rtxtTestInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtTestOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtProblemTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}