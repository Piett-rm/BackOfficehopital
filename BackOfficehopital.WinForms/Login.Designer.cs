using System.ComponentModel;

namespace BackOfficehopital.WinForms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btn_val = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_val
            // 
            this.btn_val.Location = new System.Drawing.Point(347, 271);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(75, 23);
            this.btn_val.TabIndex = 0;
            this.btn_val.Text = "Valider";
            this.btn_val.UseVisualStyleBackColor = true;
            this.btn_val.Click += new System.EventHandler(this.btn_val_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(322, 145);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(128, 20);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "martine39@auger.com";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(322, 198);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(127, 20);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "Epsi.123";
            // 
            // lb_username
            // 
            this.lb_username.Location = new System.Drawing.Point(220, 145);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(72, 15);
            this.lb_username.TabIndex = 3;
            this.lb_username.Text = "username";
            // 
            // lb_password
            // 
            this.lb_password.Location = new System.Drawing.Point(220, 195);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(76, 23);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_val);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;

        private System.Windows.Forms.Button btn_val;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;

        #endregion
    }
}