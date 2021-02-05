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
using System.Data.OleDb;

namespace RRCAGApp
{
    public partial class VehicleDataForm : Form
    {
        OleDbConnection vehicleConnection;
        DataSet vehicleDataSet;
        BindingSource bindingsource;
        OleDbDataAdapter vehicleDataAdapter;
        OleDbCommandBuilder vehicleCommandBuilder;
        OleDbCommand vehicleCommand;
        
        public VehicleDataForm()
        {
            
            InitializeComponent();

            this.Text = "Vehicle Data";

            vehicleConnection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ./AMDatabase.mdb");
            vehicleConnection.Open();

            vehicleCommand = new OleDbCommand("SELECT * FROM VehicleStock", vehicleConnection);
            
            vehicleDataAdapter = new OleDbDataAdapter(vehicleCommand);

            vehicleDataSet = new DataSet();

            vehicleDataAdapter.Fill(vehicleDataSet, "VehicleStock");

            bindingsource = new BindingSource();

            vehicleCommandBuilder = new OleDbCommandBuilder(vehicleDataAdapter);
            


            dgvVehicleData.SelectionChanged += dgvVehicleData_SelectionChange;
            dgvVehicleData.CellValueChanged += dgvVehicleData_CellRowChanged;


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VehicleDataForm_Load(object sender, EventArgs e)
        {
            bindingsource.DataSource = vehicleDataSet.Tables["VehicleStock"];
            dgvVehicleData.DataSource = bindingsource;
            dgvVehicleData.Columns["Id"].Visible = false;
           // mnuFileSave.Enabled = false;
            //mnuEditDelete.Enabled = false;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                vehicleDataAdapter.Update(vehicleDataSet.Tables["VehicleStock"]);
                this.Text = "Vehicle Data";
                mnuFileSave.Enabled = false;
            }
            catch(Exception)
            {
                MessageBox.Show("An error occurred while saving the changes to the vehicle data", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            if (!vehicleDataSet.HasChanges())
            {

                DialogResult result = MessageBox.Show("Do you wish to save the changes", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        vehicleDataAdapter.Update(vehicleDataSet.Tables["VehicleStock"]);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occurred while saving the changes.", "Do you still wish to close this window?", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    }

                }

            }
            
            this.Close();
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to permanently delete stock item ?", "Delete Stock Item",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    dgvVehicleData.Rows.Remove(dgvVehicleData.CurrentRow);

                    

                }
                catch(Exception)
                {
                    MessageBox.Show("An error occured while deleting the selected vehicle", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvVehicleData_SelectionChange(object sender, EventArgs e)
        {
            if(dgvVehicleData.CurrentRow.Selected && !dgvVehicleData.CurrentRow.IsNewRow)
            {
                mnuEditDelete.Enabled = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvVehicleData_CellRowChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = "* Vehicle Data";
            mnuFileSave.Enabled = true;
        }
    }
    
}
