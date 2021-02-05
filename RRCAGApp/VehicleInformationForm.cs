using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRCAG.Data;
using Robson.Shawn.Business;

namespace RRCAGApp
{
    /// <summary>
    /// Creates an instance of a VehicleInformationForm.
    /// </summary>
    public partial class VehicleInformationForm : Form
    {

        private BindingSource titleChange;
        /// <summary>
        /// VehicleInformationForm accepting one parameter.
        /// </summary>
        /// <param name="vehicle"></param>
        public VehicleInformationForm(BindingSource vehicleList)
        {
            InitializeComponent();

            titleChange = vehicleList;

            Binding stockId = new Binding("Text", vehicleList, "stocknumber", true);
            lblStockID.DataBindings.Add(stockId);


            Binding manufacturedYear = new Binding("Text", vehicleList, "manufacturedYear", true);
            lblYear.DataBindings.Add(manufacturedYear);

            Binding manufacturer = new Binding("Text", vehicleList, "make", true);
            lblMfg.DataBindings.Add(manufacturer);

            Binding model = new Binding("Text", vehicleList, "model", true);
            lblModel.DataBindings.Add(model);

            Binding mileage = new Binding("Text", vehicleList, "mileage", true);
            mileage.FormatString = "N0";
            lblMileage.DataBindings.Add(mileage);

            lblTransmission.Text = Convert.ToBoolean(((DataRowView)vehicleList.Current).Row["Automatic"]) ? "Automatic" : "Manual";

            Binding colour = new Binding("Text", vehicleList, "colour", true);
            colour.FormatString = "N0";
            lblColour.DataBindings.Add(colour);


            Binding basePrice = new Binding("Text", vehicleList, "basePrice", true);
            basePrice.FormatString = "C";
            lblBasePrice.DataBindings.Add(basePrice);

            titleChange.CurrentChanged += title;
            this.Text = String.Format("{0}", titleChange.Current);

        }

        private void title(object sender, EventArgs e)
        {
            this.Text = String.Format("{0}", titleChange.Current);
        }

        /// <summary>
        /// Handles the close event for the button.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
