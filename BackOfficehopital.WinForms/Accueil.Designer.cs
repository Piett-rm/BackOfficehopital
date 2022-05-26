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
            this.btn_stock = new System.Windows.Forms.Button();
            this.lb_debug = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_stock
            // 
            this.btn_stock.Location = new System.Drawing.Point(319, 160);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(133, 25);
            this.btn_stock.TabIndex = 0;
            this.btn_stock.Text = "stock";
            this.btn_stock.UseMnemonic = false;
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // lb_debug
            // 
            this.lb_debug.Location = new System.Drawing.Point(293, 223);
            this.lb_debug.Name = "lb_debug";
            this.lb_debug.Size = new System.Drawing.Size(284, 112);
            this.lb_debug.TabIndex = 1;
            this.lb_debug.Text = "label1";
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(549, 162);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(75, 23);
            this.debug.TabIndex = 2;
            this.debug.Text = "debug";
            this.debug.UseVisualStyleBackColor = true;
            this.debug.Click += new System.EventHandler(this.debug_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.lb_debug);
            this.Controls.Add(this.btn_stock);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button debug;

        private System.Windows.Forms.Label lb_debug;

        private System.Windows.Forms.Button btn_stock;

        #endregion
    }
}