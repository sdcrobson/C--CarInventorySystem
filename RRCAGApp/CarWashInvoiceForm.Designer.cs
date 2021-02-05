namespace RRCAGApp
{
    partial class CarWashInvoiceForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblPackagePrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFragrancePrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalWash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Package Price:";
            // 
            // lblPackagePrice
            // 
            this.lblPackagePrice.AutoSize = true;
            this.lblPackagePrice.Location = new System.Drawing.Point(664, 278);
            this.lblPackagePrice.Name = "lblPackagePrice";
            this.lblPackagePrice.Size = new System.Drawing.Size(107, 17);
            this.lblPackagePrice.TabIndex = 7;
            this.lblPackagePrice.Text = "[Package Price]";
            this.lblPackagePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fragrance Price:";
            // 
            // lblFragrancePrice
            // 
            this.lblFragrancePrice.AutoSize = true;
            this.lblFragrancePrice.Location = new System.Drawing.Point(664, 309);
            this.lblFragrancePrice.Name = "lblFragrancePrice";
            this.lblFragrancePrice.Size = new System.Drawing.Size(117, 17);
            this.lblFragrancePrice.TabIndex = 9;
            this.lblFragrancePrice.Text = "[Fragrance Price]";
            this.lblFragrancePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(664, 340);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(68, 17);
            this.lblSubtotal.TabIndex = 11;
            this.lblSubtotal.Text = "[Subtotal]";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(583, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Taxes:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(664, 371);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(54, 17);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "[Taxes]";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(589, 402);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Total:";
            // 
            // lblTotalWash
            // 
            this.lblTotalWash.AutoSize = true;
            this.lblTotalWash.Location = new System.Drawing.Point(664, 402);
            this.lblTotalWash.Name = "lblTotalWash";
            this.lblTotalWash.Size = new System.Drawing.Size(48, 17);
            this.lblTotalWash.TabIndex = 15;
            this.lblTotalWash.Text = "[Total]";
            this.lblTotalWash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CarWashInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 458);
            this.Controls.Add(this.lblTotalWash);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFragrancePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPackagePrice);
            this.Controls.Add(this.label4);
            this.Name = "CarWashInvoiceForm";
            this.Text = "Car Wash Invoice";
            this.Load += new System.EventHandler(this.CarWashInvoiceForm_Load);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblPackagePrice, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lblFragrancePrice, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblSubtotal, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.lblTax, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.lblTotalWash, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPackagePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFragrancePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalWash;
    }
}