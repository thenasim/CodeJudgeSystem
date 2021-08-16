
namespace JudgeSystem
{
    partial class LoginForm
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
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.lblLoginId = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginHeader = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoginId
            // 
            this.txtLoginId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginId.Location = new System.Drawing.Point(12, 239);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(368, 34);
            this.txtLoginId.TabIndex = 0;
            // 
            // lblLoginId
            // 
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginId.Location = new System.Drawing.Point(8, 212);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(77, 24);
            this.lblLoginId.TabIndex = 1;
            this.lblLoginId.Text = "Login Id";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPassword.Location = new System.Drawing.Point(8, 304);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(92, 24);
            this.lblLoginPassword.TabIndex = 3;
            this.lblLoginPassword.Text = "Password";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.Location = new System.Drawing.Point(12, 331);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(368, 34);
            this.txtLoginPassword.TabIndex = 2;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // lblLoginHeader
            // 
            this.lblLoginHeader.AutoSize = true;
            this.lblLoginHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeader.Location = new System.Drawing.Point(101, 114);
            this.lblLoginHeader.Name = "lblLoginHeader";
            this.lblLoginHeader.Size = new System.Drawing.Size(181, 38);
            this.lblLoginHeader.TabIndex = 4;
            this.lblLoginHeader.Text = "Login Page";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(12, 413);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(368, 46);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 583);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLoginHeader);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.lblLoginId);
            this.Controls.Add(this.txtLoginId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label lblLoginHeader;
        private System.Windows.Forms.Button btnLogin;
    }
}

