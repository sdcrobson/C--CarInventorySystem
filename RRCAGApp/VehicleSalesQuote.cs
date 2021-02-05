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
using RRCAG.Data;
using System.Data.OleDb;

namespace RRCAGApp
{
    /// <summary>
    /// creataes an instance of the VehicleSalesQuote derived from the form class.
    /// </summary>
    public partial class VehicleSalesQuote : Form
    {
        OleDbDataAdapter salesQuoteDataAdapter;
        DataSet salesDataSet;
        //BindingSource _bindingSource;
        /// <summary>
        /// creates a private field of type salesquote.
        /// </summary>
        private SalesQuote salesQuote;
        //private List<Vehicle> vehicle;
        private BindingSource vehicleBind;
        //private BindingList<string>bindingList;
        //private BindingSource bindingSourceInterior;

        //declare a sales tax amount
        private decimal SalesTaxValue = 0.13m;

        /// <summary>
        /// Creating an instance of a VehicleSalesQuote form.
        /// </summary>
        public VehicleSalesQuote()
        {
            InitializeComponent();

            OleDbConnection salesQuoteConnection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ./AMDatabase.mdb");
            salesQuoteConnection.Open();

            OleDbCommand salesQuoteCommand = new OleDbCommand("SELECT * FROM VehicleStock WHERE SoldBy = 0 ", salesQuoteConnection);

            salesDataSet = new DataSet();

            salesQuoteDataAdapter = new OleDbDataAdapter(salesQuoteCommand);

            salesQuoteDataAdapter.Fill(salesDataSet, "VehicleStock");

            //vehicle = DataRetriever.GetVehicles();
            vehicleBind = new BindingSource();
            //bindingList = new BindingList<string>();
            //bindingSourceInterior = new BindingSource();


            vehicleBind.DataSource = salesDataSet.Tables["VehicleStock"];
            this.cboVehicleSelect.DataSource = vehicleBind;
            this.cboVehicleSelect.DisplayMember = "StockNumber";
            this.cboVehicleSelect.ValueMember = "BasePrice";
  
            //wires the click event for Calculate & Reset
            this.btnCalculate.Click += btnCalculate_Click;
            this.btnReset.Click += btnReset_Click;
            this.cboVehicleSelect.SelectedIndexChanged += cboVehicleSelect_SelectedIndexChanged;
            this.closeToolStripMenuItem1.Click += closeToolStripMenuItem1_Click;
            this.mnuVehicleInformation.Click += vehicleInformationToolStripMenuItem_Click;
            this.closeToolStripMenuItem1.Click += this.closeToolStripMenuItem1_Click;
            lblSalesTaxValue.Text = String.Format("Sales Tax ({0:0}%)", SalesTaxValue * 100);

        }
        /// <summary>
        /// Event handling for Calculate click button.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">btnCalculate_Click</param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(cboVehicleSelect, "");
            errorProvider.SetError(txtTradeInAmount, "");

            QuoteCreation();
           
        }
        /// <summary>
        /// Handes the vheicleSelect index change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void cboVehicleSelect_SelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            QuoteChangeReset();
            mnuVehicleInformation.Enabled = true;
            
        }
        
        /// <summary>
        /// Runs the validation checks and sets initials variables for the salesQuote
        /// </summary>
        private void QuoteCreation()
        {
           
            decimal tradeValue = 0;
            Accessories accessoriesChecked = Accessories.None;
            ExteriorFinish exteriorFinishChecked = ExteriorFinish.Standard;

            string errorMessageVehicle = "";
            string errorMessageTradeIn = "";
            
            
            if (cboVehicleSelect.SelectedValue == null)
            {
                errorMessageVehicle = "Vehicle price is a required field";
            }
       
            errorProvider.SetError(cboVehicleSelect, errorMessageVehicle);

            //Trade-In value error checking.

            if (cboVehicleSelect.SelectedItem != null)
            {
                if (string.IsNullOrEmpty(txtTradeInAmount.Text))
                {
                    errorMessageTradeIn = "Trade-In value is a required field";

                }
                else if (!decimal.TryParse(txtTradeInAmount.Text, out tradeValue))
                {
                    errorMessageTradeIn = "Trade-in value cannot contain letters or special characters.";
                }
                else if (tradeValue < 0)
                {
                    errorMessageTradeIn = "Trade-in value cannot be less than 0.";
                }
                
                else if (tradeValue > decimal.Parse(cboVehicleSelect.SelectedValue.ToString()))
                {
                    errorMessageTradeIn = "Trade-in value cannot exceed the vehicle sale price";

                }
                
            }

            errorProvider.SetError(txtTradeInAmount, errorMessageTradeIn);
            
            
            // If statements to add the value checked off to AccessoriesChosen.
            if (chkComputerNavigation.Checked && chkLeatherInterior.Checked && chkStereoSystem.Checked)
            {
                accessoriesChecked = Accessories.All;
            }
            else if (chkStereoSystem.Checked && chkLeatherInterior.Checked)
            {
                accessoriesChecked = Accessories.SteroeAndLeather;
            }
            else if (chkStereoSystem.Checked && chkComputerNavigation.Checked)
            {
                accessoriesChecked = Accessories.StereoAndNavigation;
            }
            else if (chkLeatherInterior.Checked && chkComputerNavigation.Checked)
            {
                accessoriesChecked = Accessories.LeatherAndNavigation;
            }
            else if (chkStereoSystem.Checked)
            {
                accessoriesChecked = Accessories.StereoSystem;
            }
            else if (chkLeatherInterior.Checked)
            {
                accessoriesChecked = Accessories.LeatherInterior;
            }
            else if (chkComputerNavigation.Checked)
            {
                accessoriesChecked = Accessories.ComputerNavigation;
            }
            else
                accessoriesChecked = Accessories.None;

            // If statements that add the a cost associated with the radio button selected.
            if (radStandard.Checked)
            {
                exteriorFinishChecked = ExteriorFinish.Standard;
            }
            else if (radPearlized.Checked)
            {
                exteriorFinishChecked = ExteriorFinish.Pearlized;
            }
            else if (radCustomizedDetailing.Checked)
            {
                exteriorFinishChecked = ExteriorFinish.Custom;
            }
            /// If all checks are validated creates a quote with proper formatting.
            if (errorMessageTradeIn.Equals ("") && errorMessageVehicle.Equals(""))
            {

                salesQuote = new SalesQuote(decimal.Parse(cboVehicleSelect.SelectedValue.ToString()), tradeValue, SalesTaxValue, accessoriesChecked, exteriorFinishChecked);
                Formatting();
                Finance();
            }
        }
        /// <summary>
        /// Event handling for VechicleSalePrice when the value is changed.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">txtVehicleSalePrice_TextChanged</param>
        private void txtVehicleSalePrice_TextChanged(object sender, EventArgs e)
        {
            QuoteChangeReset();
        }
        /// <summary>
        /// Event handling for TradeInAmount when the value is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">txtTradeInAmount_TextChanged</param>
        private void txtTradeInAmount_TextChanged(object sender, EventArgs e)
        {
            QuoteChangeReset();
          
        }

        /// <summary>
        /// Event handling for Reset click button.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">btnReset_Click</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult reset = MessageBox.Show("Do you want to reset the form?", "Reset Form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(reset == DialogResult.Yes)
            {
                QuoteRest();
                lblMonthlyPayment.Text = "";
               
            }

        }
        /// <summary>
        /// Resets the sales quote back to a default state.
        /// </summary>
        private void QuoteRest()
        {
            
            salesQuote = null;
            errorProvider.SetError(txtTradeInAmount, "");
            errorProvider.SetError(cboVehicleSelect, "");

            cboVehicleSelect.SelectedItem = null;
            lblVehicleSalePrice.Text = "";
            txtTradeInAmount.Text = "0";
            lblSalesTax.Text = "";
            lblTradeIn.Text = "";
            lblSubTotal.Text = "";
            lblTotal.Text = "";
            lblAmountDue.Text = "";
            lblOptions.Text = "";
            lblMonthlyPayment.Text = "";
            nudAnnualInterestRate.Value = 5.00m;
            nudNoOfYears.Value = 1;
            chkComputerNavigation.Checked = false;
            chkLeatherInterior.Checked = false;
            chkStereoSystem.Checked = false;
            radStandard.Checked = true;
            mnuVehicleInformation.Enabled = false;


        }
        /// <summary>
        /// Resets the sales Quote to a default blank state if values are changed.
        /// </summary>
        public void QuoteChangeReset()
        {
           
            lblVehicleSalePrice.Text = "";
            lblSalesTax.Text = "";
            lblTradeIn.Text = "";
            lblSubTotal.Text = "";
            lblTotal.Text = "";
            lblAmountDue.Text = "";
            lblOptions.Text = "";
            lblMonthlyPayment.Text = "";
            mnuVehicleInformation.Enabled = false;

        }

        /// <summary>
        /// Creates a formatting method that adds formatting to the salesQuote.
        /// </summary>
        private void Formatting()
        {
            lblVehicleSalePrice.Text = String.Format("{0:C}", salesQuote.VehicleSalePrice);
            lblTradeIn.Text = String.Format("-" + salesQuote.TradeInAmount);
            lblSalesTax.Text = String.Format("{0:N}", salesQuote.SalesTax);
            lblSubTotal.Text = String.Format("{0:C}", salesQuote.SubTotal);
            lblTotal.Text = String.Format("{0:C}", salesQuote.Total);
            lblAmountDue.Text = String.Format("{0:C}", salesQuote.AmountDue);
            lblOptions.Text = String.Format("{0}", salesQuote.AccessoryCost + salesQuote.FinishCost);
        }
        /// <summary>
        /// Sets focus on the VehicleSalePrice text box when a VehicleSalesQuote is shown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VehicleSalesQuote_Show(object sender, EventArgs e)
        {
            this.cboVehicleSelect.Focus();
        }

        /// <summary>
        /// Method that performs the Monthly payment calculation based on the annual Interest Rate and number of years.
        /// </summary>
        private void Finance()
        {
            if(salesQuote!=null)
            {
                lblMonthlyPayment.Text = String.Format("{0:C}", Financial.GetPayment(nudAnnualInterestRate.Value / 100m /12, ((int)nudNoOfYears.Value) * 12, salesQuote.AmountDue));
            }
        }
        
        /// <summary>
        /// Method that updates the accessories when they are checked off.
        /// </summary>
        private void updateOptions()
        {
            if(salesQuote !=null)
            {
                QuoteCreation();
                Finance();
            }

        }
        /// <summary>
        /// Event update that handles the Checkbox and Radio button selections
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">RadioCheckBox_CheckedChange</param>
        private void RadioCheckBox_CheckedChange(Object sender, EventArgs e)
        {
            updateOptions();
        }
        /// <summary>
        /// Handles the intial load event of the VaehicleSalesQuote Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VehicleSalesQuote_Load(object sender, EventArgs e)
        {
            
            cboVehicleSelect.SelectedItem = null;
            mnuVehicleInformation.Enabled = false;


        }
        /// <summary>
        /// Handles the VehicleInformation menue button event.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e"></param>
        private void vehicleInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            VehicleInformationForm vehicleInformationForm = new VehicleInformationForm(vehicleBind);
            vehicleInformationForm.Show();

        }
        /// <summary>
        /// Handles the close event from the close menu strip item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
