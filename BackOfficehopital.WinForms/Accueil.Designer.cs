using System.ComponentModel;

namespace BackOfficehopital.WinForms
{
    partial class Accueil
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
            this.listVaccinType = new System.Windows.Forms.ListBox();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listVaccinType
            // 
            this.listVaccinType.FormattingEnabled = true;
            this.listVaccinType.Location = new System.Drawing.Point(157, 82);
            this.listVaccinType.Name = "listVaccinType";
            this.listVaccinType.Size = new System.Drawing.Size(505, 95);
            this.listVaccinType.TabIndex = 3;
            // 
            // bt_modifier
            // 
            this.bt_modifier.Location = new System.Drawing.Point(359, 219);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(75, 23);
            this.bt_modifier.TabIndex = 4;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = true;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_modifier);
            this.Controls.Add(this.listVaccinType);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bt_modifier;

        private System.Windows.Forms.ListBox listVaccinType;

        #endregion
    }
}