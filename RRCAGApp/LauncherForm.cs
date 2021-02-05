using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRCAGApp
{
    /// <summary>
    /// creataes an instance of the LauncherForm derived from the form class.
    /// </summary>
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();

            //wires the click for the HelpAbout to launch About Window.
            this.mnuHelpAbout.Click += mnuHelpAbout_Click;

            //wires the click for mnuFileExit to close the form
            this.mnuFileExit.Click += mnuFileExit_Click;

            //wires the click event for mnuFileOpenSalesQutoe
            this.mnuFileOpenSalesQuote.Click += mnuFileOpenSalesQuote_Click;

            //sets the initial state of the launcher form to maximized.
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Event handling for About menu button click.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">mnuHelpAbout_Click</param>
        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
        /// <summary>
        /// Event handling for Exit menu button click.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">mnuFileExit_Click</param>
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// Event handling for the Menu Strip Item - Sales Quote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            new VehicleSalesQuote().ShowDialog();

        }

        private void carWashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CarWashForm().ShowDialog();
        }

        private void mnuDataVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                VehicleDataForm vehicleData = new VehicleDataForm();
                vehicleData.ShowDialog();
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
