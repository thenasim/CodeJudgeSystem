
namespace JudgeSystem
{
    partial class CodeError
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
            this.rtxtYourOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtYourOutput
            // 
            this.rtxtYourOutput.Location = new System.Drawing.Point(12, 36);
            this.rtxtYourOutput.Name = "rtxtYourOutput";
            this.rtxtYourOutput.ReadOnly = true;
            this.rtxtYourOutput.Size = new System.Drawing.Size(524, 490);
            this.rtxtYourOutput.TabIndex = 1;
            this.rtxtYourOutput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Output";
            // 
            // CodeError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtYourOutput);
            this.Name = "CodeError";
            this.Text = "CodeResult";
            this.Load += new System.EventHandler(this.CodeError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtxtYourOutput;
        private System.Windows.Forms.Label label2;
    }
}