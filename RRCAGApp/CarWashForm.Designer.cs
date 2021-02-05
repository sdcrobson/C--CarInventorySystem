namespace RRCAGApp
{
    partial class CarWashForm
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
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnugenerateInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.cboFragrance = new System.Windows.Forms.ComboBox();
            this.gpoSummary = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstExterior = new System.Windows.Forms.ListBox();
            this.lstInterior = new System.Windows.Forms.ListBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblPst = new System.Windows.Forms.Label();
            this.lblGst = new System.Windows.Forms.Label();
            this.lblstotal = new System.Windows.Forms.Label();
            this.lblpst2 = new System.Windows.Forms.Label();
            this.lblgst1 = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.msMainMenu.SuspendLayout();
            this.gpoSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(520, 28);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnugenerateInvoice,
            this.toolStripMenuItem1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnugenerateInvoice
            // 
            this.mnugenerateInvoice.Enabled = false;
            this.mnugenerateInvoice.Name = "mnugenerateInvoice";
            this.mnugenerateInvoice.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.mnugenerateInvoice.Size = new System.Drawing.Size(290, 26);
            this.mnugenerateInvoice.Text = "&Generate Invoice...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(287, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(290, 26);
            this.mnuFileExit.Text = "&Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Package:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fragrance:";
            // 
            // cboPackage
            // 
            this.cboPackage.BackColor = System.Drawing.SystemColors.Menu;
            this.cboPackage.DisplayMember = "GetPackageName";
            this.cboPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.Location = new System.Drawing.Point(35, 80);
            this.cboPackage.Name = "cboPackage";
            this.cboPackage.Size = new System.Drawing.Size(201, 24);
            this.cboPackage.TabIndex = 3;
            // 
            // cboFragrance
            // 
            this.cboFragrance.BackColor = System.Drawing.SystemColors.Menu;
            this.cboFragrance.DisplayMember = "GetFragranceName";
            this.cboFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFragrance.FormattingEnabled = true;
            this.cboFragrance.Location = new System.Drawing.Point(274, 80);
            this.cboFragrance.Name = "cboFragrance";
            this.cboFragrance.Size = new System.Drawing.Size(201, 24);
            this.cboFragrance.TabIndex = 4;
            // 
            // gpoSummary
            // 
            this.gpoSummary.Controls.Add(this.label4);
            this.gpoSummary.Controls.Add(this.label3);
            this.gpoSummary.Controls.Add(this.lstExterior);
            this.gpoSummary.Controls.Add(this.lstInterior);
            this.gpoSummary.Location = new System.Drawing.Point(12, 132);
            this.gpoSummary.Name = "gpoSummary";
            this.gpoSummary.Size = new System.Drawing.Size(489, 215);
            this.gpoSummary.TabIndex = 5;
            this.gpoSummary.TabStop = false;
            this.gpoSummary.Text = "Summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exterior:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interior:";
            // 
            // lstExterior
            // 
            this.lstExterior.FormattingEnabled = true;
            this.lstExterior.ItemHeight = 16;
            this.lstExterior.Location = new System.Drawing.Point(262, 67);
            this.lstExterior.Name = "lstExterior";
            this.lstExterior.Size = new System.Drawing.Size(201, 116);
            this.lstExterior.TabIndex = 1;
            // 
            // lstInterior
            // 
            this.lstInterior.FormattingEnabled = true;
            this.lstInterior.ItemHeight = 16;
            this.lstInterior.Location = new System.Drawing.Point(23, 67);
            this.lstInterior.Name = "lstInterior";
            this.lstInterior.Size = new System.Drawing.Size(201, 116);
            this.lstInterior.TabIndex = 0;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(309, 370);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 17);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblPst
            // 
            this.lblPst.AutoSize = true;
            this.lblPst.Location = new System.Drawing.Point(334, 410);
            this.lblPst.Name = "lblPst";
            this.lblPst.Size = new System.Drawing.Size(39, 17);
            this.lblPst.TabIndex = 7;
            this.lblPst.Text = "PST:";
            // 
            // lblGst
            // 
            this.lblGst.AutoSize = true;
            this.lblGst.Location = new System.Drawing.Point(332, 447);
            this.lblGst.Name = "lblGst";
            this.lblGst.Size = new System.Drawing.Size(41, 17);
            this.lblGst.TabIndex = 8;
            this.lblGst.Text = "GST:";
            // 
            // lblstotal
            // 
            this.lblstotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblstotal.Location = new System.Drawing.Point(396, 366);
            this.lblstotal.Name = "lblstotal";
            this.lblstotal.Size = new System.Drawing.Size(105, 24);
            this.lblstotal.TabIndex = 9;
            this.lblstotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblpst2
            // 
            this.lblpst2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblpst2.Location = new System.Drawing.Point(396, 404);
            this.lblpst2.Name = "lblpst2";
            this.lblpst2.Size = new System.Drawing.Size(105, 24);
            this.lblpst2.TabIndex = 10;
            this.lblpst2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblgst1
            // 
            this.lblgst1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblgst1.Location = new System.Drawing.Point(396, 442);
            this.lblgst1.Name = "lblgst1";
            this.lblgst1.Size = new System.Drawing.Size(105, 24);
            this.lblgst1.TabIndex = 11;
            this.lblgst1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(396, 482);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(105, 24);
            this.lbloutput.TabIndex = 12;
            this.lbloutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(333, 487);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total:";
            // 
            // CarWashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 529);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblgst1);
            this.Controls.Add(this.lblpst2);
            this.Controls.Add(this.lblstotal);
            this.Controls.Add(this.lblGst);
            this.Controls.Add(this.lblPst);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.gpoSummary);
            this.Controls.Add(this.cboFragrance);
            this.Controls.Add(this.cboPackage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.msMainMenu;
            this.MaximizeBox = false;
            this.Name = "CarWashForm";
            this.ShowIcon = false;
            this.Text = "CarWashForm";
            this.Load += new System.EventHandler(this.CarWashForm_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.gpoSummary.ResumeLayout(false);
            this.gpoSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnugenerateInvoice;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.ComboBox cboFragrance;
        private System.Windows.Forms.GroupBox gpoSummary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstExterior;
        private System.Windows.Forms.ListBox lstInterior;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPst;
        private System.Windows.Forms.Label lblGst;
        private System.Windows.Forms.Label lblstotal;
        private System.Windows.Forms.Label lblpst2;
        private System.Windows.Forms.Label lblgst1;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lblTotal;
    }
}