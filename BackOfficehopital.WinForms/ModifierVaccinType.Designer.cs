using System.ComponentModel;

namespace BackOfficehopital.WinForms
{
    partial class ModifierVaccinType
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_stock = new System.Windows.Forms.Label();
            this.num_stock = new System.Windows.Forms.NumericUpDown();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.bt_val = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.num_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(137, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // lb_stock
            // 
            this.lb_stock.Location = new System.Drawing.Point(137, 136);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(95, 22);
            this.lb_stock.TabIndex = 1;
            this.lb_stock.Text = "Stock";
            // 
            // num_stock
            // 
            this.num_stock.Location = new System.Drawing.Point(260, 137);
            this.num_stock.Maximum = new decimal(new int[] {1000000000, 0, 0, 0});
            this.num_stock.Name = "num_stock";
            this.num_stock.Size = new System.Drawing.Size(191, 20);
            this.num_stock.TabIndex = 3;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(260, 97);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.ReadOnly = true;
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 4;
            // 
            // bt_val
            // 
            this.bt_val.Location = new System.Drawing.Point(304, 219);
            this.bt_val.Name = "bt_val";
            this.bt_val.Size = new System.Drawing.Size(75, 23);
            this.bt_val.TabIndex = 5;
            this.bt_val.Text = "Valider";
            this.bt_val.UseVisualStyleBackColor = true;
            this.bt_val.Click += new System.EventHandler(this.bt_val_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(635, 398);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(635, 358);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Visible = false;
            // 
            // ModifierVaccinType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_val);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.num_stock);
            this.Controls.Add(this.lb_stock);
            this.Controls.Add(this.label1);
            this.Name = "ModifierVaccinType";
            this.Text = "ModifierVaccinType";
            ((System.ComponentModel.ISupportInitialize) (this.num_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button bt_val;

        private System.Windows.Forms.TextBox txt_nom;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.NumericUpDown num_stock;

        #endregion
    }
}