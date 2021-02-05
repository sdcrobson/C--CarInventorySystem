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
using System.Collections;

namespace RRCAGApp
{
    /// <summary>
    ///  creataes an instance of the CarWasForm derived from the form class.
    /// </summary>
    public partial class CarWashForm : Form
    {
        private CarWashInvoice carWash;
        /// <summary>
        /// 
        /// </summary>
        private BindingList<Package> package;
        private BindingList<Fragrance> fragrance; 
        List<string> descriptionInterior = new List<string>();
        List<string> descriptionExterior = new List<string>();
        private BindingList<string> bindingListInterior;
        private BindingSource bindingSourceInterior;
        private BindingList<string> bindingListExterior;
        private BindingSource bindingSourceExterior;

        BindingSource bindingSource = new BindingSource();
        

        /// <summary>
        /// Creates an Instance of the CarWashForm
        /// </summary>
        public CarWashForm()
        {
            InitializeComponent();


            package = new BindingList<Package>();
            fragrance = new BindingList<Fragrance>();
            bindingListInterior = new BindingList<string>();
            bindingSourceInterior = new BindingSource();
            bindingSourceInterior.DataSource = bindingListInterior;
            lstInterior.DataSource = bindingSourceInterior;
            bindingSourceExterior = new BindingSource();
            bindingSourceExterior.DataSource = bindingListExterior;
            lstExterior.DataSource = bindingSourceExterior;
            

            package.Add(new Package("Standard", 7.50m));
            package.Add(new Package("Deluxe", 15.00m));
            package.Add(new Package("Executive", 35.00m));
            package.Add(new Package("Luxury", 55.00m));

            fragrance.Add(new Fragrance("Hawaiian Mist", 2.75m));
            fragrance.Add(new Fragrance("Baby Powder", 1.50m));
            fragrance.Add(new Fragrance("Pine", 0.00m));
            fragrance.Add(new Fragrance("Country Floral", 2.25m));
            fragrance.Add(new Fragrance("Pina Coloda", .75m));
            fragrance.Add(new Fragrance("Vanilla", 2.00m));

            descriptionInterior.Add("Fragrance");
            descriptionInterior.Add("Shampoo Carpets");
            descriptionInterior.Add("Shampoo Upholstry");
            descriptionInterior.Add("Interior Protection Coat");

            descriptionExterior.Add("Hand Wash");
            descriptionExterior.Add("Hand Wax");
            descriptionExterior.Add("Wheel Polish");
            descriptionExterior.Add("Detail Engine Compartment");

            this.mnugenerateInvoice.Click += new System.EventHandler(this.mnugenerateInvoice_Click);
            this.mnuFileExit.Click += new System.EventHandler(mnuFileExit_Click);

           
        }

        /// <summary>
        /// Handles the Load event for the CarWashFormn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarWashForm_Load(object sender, EventArgs e)
        {
            bindControls();
            cboPackage.SelectedIndex = -1;
            cboFragrance.SelectedIndex = 2;
            mnugenerateInvoice.Enabled = false;
            FormCreation();
            Formatting();
            this.cboPackage.SelectedIndexChanged += new System.EventHandler(this.cboPackage_SelectedIndexChanged);
            this.cboFragrance.SelectedIndexChanged += new System.EventHandler(this.cboFragrance_SelectedIndexChanged);

        }
        /// <summary>
        /// Binds the combo box for the Package and Fragrence to the required data.
        /// </summary>
        private void bindControls()
        {
            BindingSource packageBind = new BindingSource();
            packageBind.DataSource = package;
            this.cboPackage.DataSource = packageBind;
            this.cboPackage.DisplayMember = "PackageName";
            this.cboPackage.ValueMember = "packageAmount";


            BindingSource fragranceBind = new BindingSource();
            fragranceBind.DataSource = fragrance;
            this.cboFragrance.DataSource = fragranceBind;
            this.cboFragrance.DisplayMember = "FragranceName";
            this.cboFragrance.ValueMember = "fragranceAmount";
        }
        /// <summary>
        /// Handles the index changed event for the combo box for Package.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboPackage_SelectedIndexChanged(object sender, EventArgs e)
        {

            FormCreation();
            Formatting();
            mnugenerateInvoice.Enabled = true;

        }
        /// <summary>
        /// FormatCreation method that handles the updating of the form.
        /// </summary>
        private void FormCreation()
        {
            
            bindingSourceInterior.Clear();
            bindingSourceExterior.Clear();
            

            carWash = new CarWashInvoice(.05m, .05m);

            if(cboPackage.SelectedIndex != -1)
            {
                for (int i = 0; i <= cboPackage.SelectedIndex; i++)
                {
                    bindingSourceInterior.Add(descriptionInterior[i]);
                    bindingSourceExterior.Add(descriptionExterior[i]);

                }
                bindingSourceInterior[0] = " Fragrance - " + cboFragrance.Text;
                carWash.PackageCost = (decimal)cboPackage.SelectedValue;
                carWash.FragranceCost = (decimal)cboFragrance.SelectedValue;
                Formatting();
            }  
        }
        /// <summary>
        /// Handles the index changed event for the combo box for Fragrance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboFragrance_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormCreation();
            Formatting();
            mnugenerateInvoice.Enabled = true;
        }
        /// <summary>
        /// Formatting method for the carWash client.
        /// </summary>
        private void Formatting()
        {
            lblstotal.Text = String.Format("{0:C}", carWash.SubTotal);
            lblpst2.Text = String.Format("{0:N}", carWash.ProvincialSalesTaxCharged);
            lblgst1.Text = String.Format("{0:N}", carWash.GoodsAndServicesTaxCharged);
            lbloutput.Text = String.Format("{0:C}", carWash.Total);
        }
        /// <summary>
        /// Handles the click event for generating the invoice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnugenerateInvoice_Click(object sender, EventArgs e)
        {
            new CarWashInvoiceForm(carWash).ShowDialog();
        }
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
