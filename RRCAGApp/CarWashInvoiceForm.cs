using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Robson.Shawn.Business;

namespace RRCAGApp
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CarWashInvoiceForm : InvoiceForm
    {
        /// <summary>
        /// Creates an instance of the CarWashInvoiceForm.
        /// </summary>
        /// <param name="carWash"></param>
        public CarWashInvoiceForm(CarWashInvoice carWash)
        {
            InitializeComponent();
            this.FormClosed += CarWashInvoiceForm_FormClosed;

            lblTitle.Text = "Car Wash Invoice";

            Binding packageCost = new Binding("Text", carWash, "PackageCost", true);
            packageCost.FormatString = "C";
            lblPackagePrice.DataBindings.Add(packageCost);

            Binding fragranceCost = new Binding("Text", carWash, "FragranceCost", true);
            fragranceCost.FormatString = "N";
            lblFragrancePrice.DataBindings.Add(fragranceCost);

            Binding subtotal = new Binding("Text", carWash, "Subtotal", true);
            subtotal.FormatString = "C";
            lblSubtotal.DataBindings.Add(subtotal);

            Binding tax = new Binding("Text", carWash, "GoodsAndServicesTaxCharged", true);
            tax.FormatString = "N";
            lblTax.DataBindings.Add(tax);

            Binding total = new Binding("Text", carWash, "Total", true);
            total.FormatString = "C";
            lblTotalWash.DataBindings.Add(total);
            
           

        }

        private void CarWashInvoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CarWashInvoiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
