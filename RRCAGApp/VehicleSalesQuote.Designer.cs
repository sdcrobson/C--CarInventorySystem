namespace RRCAGApp
{
    partial class VehicleSalesQuote
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTradeInAmount = new System.Windows.Forms.TextBox();
            this.chkStereoSystem = new System.Windows.Forms.CheckBox();
            this.chkLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkComputerNavigation = new System.Windows.Forms.CheckBox();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.grpExeriorFinish = new System.Windows.Forms.GroupBox();
            this.nudNoOfYears = new System.Windows.Forms.NumericUpDown();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.subtotalBox = new System.Windows.Forms.GroupBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblTradeIn = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblVehicleSalePrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.lblSalesTaxValue = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VehicleSummary = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboVehicleSelect = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAccessories.SuspendLayout();
            this.grpExeriorFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).BeginInit();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).BeginInit();
            this.subtotalBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vehicle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Trade-In Amount:";
            // 
            // txtTradeInAmount
            // 
            this.errorProvider.SetIconPadding(this.txtTradeInAmount, 3);
            this.txtTradeInAmount.Location = new System.Drawing.Point(157, 80);
            this.txtTradeInAmount.Name = "txtTradeInAmount";
            this.txtTradeInAmount.Size = new System.Drawing.Size(203, 22);
            this.txtTradeInAmount.TabIndex = 1;
            this.txtTradeInAmount.Text = "0";
            this.txtTradeInAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTradeInAmount.TextChanged += new System.EventHandler(this.txtTradeInAmount_TextChanged);
            // 
            // chkStereoSystem
            // 
            this.chkStereoSystem.AutoSize = true;
            this.chkStereoSystem.Location = new System.Drawing.Point(29, 44);
            this.chkStereoSystem.Name = "chkStereoSystem";
            this.chkStereoSystem.Size = new System.Drawing.Size(122, 21);
            this.chkStereoSystem.TabIndex = 0;
            this.chkStereoSystem.Text = "Stereo System";
            this.chkStereoSystem.UseVisualStyleBackColor = true;
            this.chkStereoSystem.CheckedChanged += new System.EventHandler(this.RadioCheckBox_CheckedChange);
            // 
            // chkLeatherInterior
            // 
            this.chkLeatherInterior.AutoSize = true;
            this.chkLeatherInterior.Location = new System.Drawing.Point(29, 92);
            this.chkLeatherInterior.Name = "chkLeatherInterior";
            this.chkLeatherInterior.Size = new System.Drawing.Size(127, 21);
            this.chkLeatherInterior.TabIndex = 1;
            this.chkLeatherInterior.Text = "Leather Interior";
            this.chkLeatherInterior.UseVisualStyleBackColor = true;
            this.chkLeatherInterior.CheckedChanged += new System.EventHandler(this.RadioCheckBox_CheckedChange);
            // 
            // chkComputerNavigation
            // 
            this.chkComputerNavigation.AutoSize = true;
            this.chkComputerNavigation.Location = new System.Drawing.Point(29, 140);
            this.chkComputerNavigation.Name = "chkComputerNavigation";
            this.chkComputerNavigation.Size = new System.Drawing.Size(162, 21);
            this.chkComputerNavigation.TabIndex = 2;
            this.chkComputerNavigation.Text = "Computer Navigation";
            this.chkComputerNavigation.UseVisualStyleBackColor = true;
            this.chkComputerNavigation.CheckedChanged += new System.EventHandler(this.RadioCheckBox_CheckedChange);
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkStereoSystem);
            this.grpAccessories.Controls.Add(this.chkComputerNavigation);
            this.grpAccessories.Controls.Add(this.chkLeatherInterior);
            this.grpAccessories.Location = new System.Drawing.Point(41, 138);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(332, 209);
            this.grpAccessories.TabIndex = 2;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(25, 43);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(87, 21);
            this.radStandard.TabIndex = 0;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            this.radStandard.CheckedChanged += new System.EventHandler(this.RadioCheckBox_CheckedChange);
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(25, 90);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(88, 21);
            this.radPearlized.TabIndex = 1;
            this.radPearlized.Text = "Pearlized";
            this.radPearlized.UseVisualStyleBackColor = true;
            this.radPearlized.CheckedChanged += new System.EventHandler(this.RadioCheckBox_CheckedChange);
            // 
            // radCustomizedDetailing
            // 
            this.radCustomizedDetailing.AutoSize = true;
            this.radCustomizedDetailing.Location = new System.Drawing.Point(25, 138);
            this.radCustomizedDetailing.Name = "radCustomizedDetailing";
            this.radCustomizedDetailing.Size = new System.Drawing.Size(161, 21);
            this.radCustomizedDetailing.TabIndex = 2;
            this.radCustomizedDetailing.Text = "Customized Detailing";
            this.radCustomizedDetailing.UseVisualStyleBackColor = true;
            this.radCustomizedDetailing.CheckedChanged += new System.EventHandler(this.RadioCheckBox_CheckedChange);
            // 
            // grpExeriorFinish
            // 
            this.grpExeriorFinish.Controls.Add(this.radStandard);
            this.grpExeriorFinish.Controls.Add(this.radCustomizedDetailing);
            this.grpExeriorFinish.Controls.Add(this.radPearlized);
            this.grpExeriorFinish.Location = new System.Drawing.Point(41, 372);
            this.grpExeriorFinish.Name = "grpExeriorFinish";
            this.grpExeriorFinish.Size = new System.Drawing.Size(332, 189);
            this.grpExeriorFinish.TabIndex = 3;
            this.grpExeriorFinish.TabStop = false;
            this.grpExeriorFinish.Text = "Exterior Finish";
            // 
            // nudNoOfYears
            // 
            this.nudNoOfYears.Location = new System.Drawing.Point(52, 79);
            this.nudNoOfYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNoOfYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfYears.Name = "nudNoOfYears";
            this.nudNoOfYears.Size = new System.Drawing.Size(87, 22);
            this.nudNoOfYears.TabIndex = 0;
            this.nudNoOfYears.Tag = "";
            this.nudNoOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfYears.ValueChanged += new System.EventHandler(this.RadioCheckBox_CheckedChange);
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.lblMonthlyPayment);
            this.grpFinance.Controls.Add(this.label5);
            this.grpFinance.Controls.Add(this.nudNoOfYears);
            this.grpFinance.Controls.Add(this.label3);
            this.grpFinance.Controls.Add(this.nudAnnualInterestRate);
            this.grpFinance.Controls.Add(this.label4);
            this.grpFinance.Location = new System.Drawing.Point(415, 402);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(439, 159);
            this.grpFinance.TabIndex = 4;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(301, 80);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(113, 23);
            this.lblMonthlyPayment.TabIndex = 3;
            this.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monthly Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "No. Of Years";
            // 
            // nudAnnualInterestRate
            // 
            this.nudAnnualInterestRate.DecimalPlaces = 2;
            this.nudAnnualInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAnnualInterestRate.Location = new System.Drawing.Point(181, 80);
            this.nudAnnualInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudAnnualInterestRate.Name = "nudAnnualInterestRate";
            this.nudAnnualInterestRate.Size = new System.Drawing.Size(88, 22);
            this.nudAnnualInterestRate.TabIndex = 1;
            this.nudAnnualInterestRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAnnualInterestRate.ValueChanged += new System.EventHandler(this.RadioCheckBox_CheckedChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "Annual\r\nInterest Rate";
            // 
            // btnCalculate
            // 
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculate.Location = new System.Drawing.Point(704, 589);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 38);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate Quote";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(41, 593);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 34);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // subtotalBox
            // 
            this.subtotalBox.Controls.Add(this.lblAmountDue);
            this.subtotalBox.Controls.Add(this.lblTradeIn);
            this.subtotalBox.Controls.Add(this.lblTotal);
            this.subtotalBox.Controls.Add(this.lblSalesTax);
            this.subtotalBox.Controls.Add(this.lblSubTotal);
            this.subtotalBox.Controls.Add(this.lblOptions);
            this.subtotalBox.Controls.Add(this.lblVehicleSalePrice);
            this.subtotalBox.Controls.Add(this.label9);
            this.subtotalBox.Controls.Add(this.label8);
            this.subtotalBox.Controls.Add(this.total);
            this.subtotalBox.Controls.Add(this.lblSalesTaxValue);
            this.subtotalBox.Controls.Add(this.subtotalLabel);
            this.subtotalBox.Controls.Add(this.label6);
            this.subtotalBox.Controls.Add(this.VehicleSummary);
            this.subtotalBox.Location = new System.Drawing.Point(415, 34);
            this.subtotalBox.Name = "subtotalBox";
            this.subtotalBox.Size = new System.Drawing.Size(450, 362);
            this.subtotalBox.TabIndex = 7;
            this.subtotalBox.TabStop = false;
            this.subtotalBox.Text = "Summary";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountDue.Location = new System.Drawing.Point(232, 284);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(182, 24);
            this.lblAmountDue.TabIndex = 38;
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTradeIn
            // 
            this.lblTradeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTradeIn.Location = new System.Drawing.Point(232, 238);
            this.lblTradeIn.Name = "lblTradeIn";
            this.lblTradeIn.Size = new System.Drawing.Size(182, 24);
            this.lblTradeIn.TabIndex = 37;
            this.lblTradeIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(232, 196);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(182, 24);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTax.Location = new System.Drawing.Point(232, 158);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(182, 24);
            this.lblSalesTax.TabIndex = 35;
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Location = new System.Drawing.Point(232, 117);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(182, 24);
            this.lblSubTotal.TabIndex = 34;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOptions
            // 
            this.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptions.Location = new System.Drawing.Point(232, 78);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(182, 24);
            this.lblOptions.TabIndex = 33;
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVehicleSalePrice
            // 
            this.lblVehicleSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalePrice.Location = new System.Drawing.Point(232, 37);
            this.lblVehicleSalePrice.Name = "lblVehicleSalePrice";
            this.lblVehicleSalePrice.Size = new System.Drawing.Size(182, 24);
            this.lblVehicleSalePrice.TabIndex = 32;
            this.lblVehicleSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Amount Due:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Trade-in:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(173, 197);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(44, 17);
            this.total.TabIndex = 26;
            this.total.Text = "Total:";
            // 
            // lblSalesTaxValue
            // 
            this.lblSalesTaxValue.AutoSize = true;
            this.lblSalesTaxValue.Location = new System.Drawing.Point(104, 162);
            this.lblSalesTaxValue.Name = "lblSalesTaxValue";
            this.lblSalesTaxValue.Size = new System.Drawing.Size(116, 17);
            this.lblSalesTaxValue.TabIndex = 24;
            this.lblSalesTaxValue.Text = "Sales Tax (13%):";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(156, 121);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(64, 17);
            this.subtotalLabel.TabIndex = 22;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Options:";
            // 
            // VehicleSummary
            // 
            this.VehicleSummary.AutoSize = true;
            this.VehicleSummary.Location = new System.Drawing.Point(94, 41);
            this.VehicleSummary.Name = "VehicleSummary";
            this.VehicleSummary.Size = new System.Drawing.Size(126, 17);
            this.VehicleSummary.TabIndex = 17;
            this.VehicleSummary.Text = "Vehicle Sale Price:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // cboVehicleSelect
            // 
            this.cboVehicleSelect.BackColor = System.Drawing.SystemColors.Menu;
            this.cboVehicleSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleSelect.FormattingEnabled = true;
            this.errorProvider.SetIconPadding(this.cboVehicleSelect, 3);
            this.cboVehicleSelect.Location = new System.Drawing.Point(157, 38);
            this.cboVehicleSelect.Name = "cboVehicleSelect";
            this.cboVehicleSelect.Size = new System.Drawing.Size(203, 24);
            this.cboVehicleSelect.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.closeToolStripMenuItem1.Text = "&Close";
            
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVehicleInformation});
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.closeToolStripMenuItem.Text = "&View";
            // 
            // mnuVehicleInformation
            // 
            this.mnuVehicleInformation.Name = "mnuVehicleInformation";
            this.mnuVehicleInformation.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.mnuVehicleInformation.Size = new System.Drawing.Size(299, 26);
            this.mnuVehicleInformation.Text = "Vehicle &Information";
            
            // 
            // VehicleSalesQuote
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 648);
            this.Controls.Add(this.cboVehicleSelect);
            this.Controls.Add(this.subtotalBox);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpExeriorFinish);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.txtTradeInAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "VehicleSalesQuote";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Text = "VehicleSalesQuote";
            this.Load += new System.EventHandler(this.VehicleSalesQuote_Load);
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExeriorFinish.ResumeLayout(false);
            this.grpExeriorFinish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).EndInit();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).EndInit();
            this.subtotalBox.ResumeLayout(false);
            this.subtotalBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTradeInAmount;
        private System.Windows.Forms.CheckBox chkStereoSystem;
        private System.Windows.Forms.CheckBox chkLeatherInterior;
        private System.Windows.Forms.CheckBox chkComputerNavigation;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radCustomizedDetailing;
        private System.Windows.Forms.GroupBox grpExeriorFinish;
        private System.Windows.Forms.NumericUpDown nudNoOfYears;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAnnualInterestRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox subtotalBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label VehicleSummary;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label lblSalesTaxValue;
        private System.Windows.Forms.Label lblVehicleSalePrice;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblTradeIn;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cboVehicleSelect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleInformation;
    }
}