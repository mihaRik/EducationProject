namespace EducationProject
{
    partial class Form1
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(13, 13);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(78, 29);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.Location = new System.Drawing.Point(18, 77);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxEmail.Location = new System.Drawing.Point(100, 74);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(121, 22);
            this.tbxEmail.TabIndex = 2;
            this.tbxEmail.Text = "samir@code.edu.az";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPassword.Location = new System.Drawing.Point(100, 100);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(121, 22);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.Text = "10000hoursrule";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(18, 103);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserType.Location = new System.Drawing.Point(18, 129);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(66, 16);
            this.lblUserType.TabIndex = 5;
            this.lblUserType.Text = "User type";
            // 
            // cbxUserType
            // 
            this.cbxUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Location = new System.Drawing.Point(100, 126);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(121, 24);
            this.cbxUserType.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.Location = new System.Drawing.Point(146, 173);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 26);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(18, 173);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 223);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbxUserType);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 262);
            this.MinimumSize = new System.Drawing.Size(305, 262);
            this.Name = "Form1";
            this.Text = "Welcome to Code Academy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cbxUserType;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReset;
    }
}

