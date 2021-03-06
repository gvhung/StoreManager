﻿namespace storeManager.UI.Controls
{
    partial class ucOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.lblSaleTax = new System.Windows.Forms.Label();
            this.btnSaleDiscCal = new System.Windows.Forms.Button();
            this.btnSaleTax = new System.Windows.Forms.Button();
            this.txtSalTax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSaleDiscount = new System.Windows.Forms.TextBox();
            this.btnChooseProduct = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbPaymentTerm = new System.Windows.Forms.ComboBox();
            this.lblPaymentTerm = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnChooseSalePerson = new System.Windows.Forms.Button();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtTotalAmt = new System.Windows.Forms.TextBox();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.txtSalesPerson = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBalanceDue = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblSalesPerson = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnRecord = new Telerik.WinControls.UI.RadButton();
            this.gridViewItemLayout = new System.Windows.Forms.DataGridView();
            this.ColQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDecscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItemLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmbLocation);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtBarCode);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1001, 604);
            this.splitContainer1.SplitterDistance = 61;
            this.splitContainer1.TabIndex = 0;
            // 
            // cmbLocation
            // 
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(124, 16);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(170, 21);
            this.cmbLocation.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Location :";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarCode.BackColor = System.Drawing.Color.White;
            this.txtBarCode.Location = new System.Drawing.Point(732, 15);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(263, 20);
            this.txtBarCode.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(653, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "BarCode # :";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.radPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainer2.Panel2.Controls.Add(this.lblStatus);
            this.splitContainer2.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer2.Panel2.Controls.Add(this.btnRecord);
            this.splitContainer2.Panel2.Controls.Add(this.gridViewItemLayout);
            this.splitContainer2.Size = new System.Drawing.Size(1001, 539);
            this.splitContainer2.SplitterDistance = 297;
            this.splitContainer2.TabIndex = 0;
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.radPanel1.Controls.Add(this.lblSaleTax);
            this.radPanel1.Controls.Add(this.btnSaleDiscCal);
            this.radPanel1.Controls.Add(this.btnSaleTax);
            this.radPanel1.Controls.Add(this.txtSalTax);
            this.radPanel1.Controls.Add(this.label12);
            this.radPanel1.Controls.Add(this.label13);
            this.radPanel1.Controls.Add(this.txtSaleDiscount);
            this.radPanel1.Controls.Add(this.btnChooseProduct);
            this.radPanel1.Controls.Add(this.btnDelete);
            this.radPanel1.Controls.Add(this.btnInsert);
            this.radPanel1.Controls.Add(this.btnNew);
            this.radPanel1.Controls.Add(this.cmbPaymentTerm);
            this.radPanel1.Controls.Add(this.lblPaymentTerm);
            this.radPanel1.Controls.Add(this.txtUnitPrice);
            this.radPanel1.Controls.Add(this.label18);
            this.radPanel1.Controls.Add(this.txtQty);
            this.radPanel1.Controls.Add(this.label17);
            this.radPanel1.Controls.Add(this.txtItemName);
            this.radPanel1.Controls.Add(this.label16);
            this.radPanel1.Controls.Add(this.txtItemNo);
            this.radPanel1.Controls.Add(this.label15);
            this.radPanel1.Controls.Add(this.btnAddCustomer);
            this.radPanel1.Controls.Add(this.btnChooseSalePerson);
            this.radPanel1.Controls.Add(this.txtCustomer);
            this.radPanel1.Controls.Add(this.lblCustomer);
            this.radPanel1.Controls.Add(this.txtTotalAmt);
            this.radPanel1.Controls.Add(this.dtpSaleDate);
            this.radPanel1.Controls.Add(this.txtSalesPerson);
            this.radPanel1.Controls.Add(this.txtInvoiceNo);
            this.radPanel1.Controls.Add(this.label2);
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Controls.Add(this.label5);
            this.radPanel1.Controls.Add(this.cmbPaymentMode);
            this.radPanel1.Controls.Add(this.label11);
            this.radPanel1.Controls.Add(this.txtComment);
            this.radPanel1.Controls.Add(this.label6);
            this.radPanel1.Controls.Add(this.txtBalanceDue);
            this.radPanel1.Controls.Add(this.txtSubTotal);
            this.radPanel1.Controls.Add(this.txtAmountPaid);
            this.radPanel1.Controls.Add(this.lblSalesPerson);
            this.radPanel1.Controls.Add(this.label7);
            this.radPanel1.Controls.Add(this.label9);
            this.radPanel1.Controls.Add(this.label8);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1001, 297);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "Breeze";
            // 
            // lblSaleTax
            // 
            this.lblSaleTax.AutoSize = true;
            this.lblSaleTax.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleTax.Location = new System.Drawing.Point(945, 121);
            this.lblSaleTax.Name = "lblSaleTax";
            this.lblSaleTax.Size = new System.Drawing.Size(15, 14);
            this.lblSaleTax.TabIndex = 31;
            this.lblSaleTax.Text = "--";
            // 
            // btnSaleDiscCal
            // 
            this.btnSaleDiscCal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaleDiscCal.BackgroundImage")));
            this.btnSaleDiscCal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaleDiscCal.FlatAppearance.BorderSize = 0;
            this.btnSaleDiscCal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSaleDiscCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleDiscCal.Location = new System.Drawing.Point(916, 91);
            this.btnSaleDiscCal.Name = "btnSaleDiscCal";
            this.btnSaleDiscCal.Size = new System.Drawing.Size(22, 19);
            this.btnSaleDiscCal.TabIndex = 27;
            this.btnSaleDiscCal.UseVisualStyleBackColor = true;
            this.btnSaleDiscCal.Click += new System.EventHandler(this.btnSaleDiscCal_Click);
            // 
            // btnSaleTax
            // 
            this.btnSaleTax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaleTax.BackgroundImage")));
            this.btnSaleTax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaleTax.FlatAppearance.BorderSize = 0;
            this.btnSaleTax.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSaleTax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSaleTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleTax.Location = new System.Drawing.Point(915, 119);
            this.btnSaleTax.Name = "btnSaleTax";
            this.btnSaleTax.Size = new System.Drawing.Size(22, 18);
            this.btnSaleTax.TabIndex = 30;
            this.btnSaleTax.UseVisualStyleBackColor = true;
            this.btnSaleTax.Click += new System.EventHandler(this.btnSaleTax_Click);
            // 
            // txtSalTax
            // 
            this.txtSalTax.BackColor = System.Drawing.Color.White;
            this.txtSalTax.Location = new System.Drawing.Point(836, 118);
            this.txtSalTax.Name = "txtSalTax";
            this.txtSalTax.Size = new System.Drawing.Size(79, 20);
            this.txtSalTax.TabIndex = 29;
            this.txtSalTax.TextChanged += new System.EventHandler(this.txtSalTax_TextChanged);
            this.txtSalTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(797, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 14);
            this.label12.TabIndex = 28;
            this.label12.Text = "Tax :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(769, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 14);
            this.label13.TabIndex = 25;
            this.label13.Text = "Discount :";
            // 
            // txtSaleDiscount
            // 
            this.txtSaleDiscount.BackColor = System.Drawing.Color.White;
            this.txtSaleDiscount.Location = new System.Drawing.Point(836, 90);
            this.txtSaleDiscount.Name = "txtSaleDiscount";
            this.txtSaleDiscount.Size = new System.Drawing.Size(79, 20);
            this.txtSaleDiscount.TabIndex = 26;
            this.txtSaleDiscount.TextChanged += new System.EventHandler(this.txtSalTax_TextChanged);
            this.txtSaleDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // btnChooseProduct
            // 
            this.btnChooseProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChooseProduct.BackgroundImage")));
            this.btnChooseProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseProduct.FlatAppearance.BorderSize = 0;
            this.btnChooseProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnChooseProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnChooseProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseProduct.Location = new System.Drawing.Point(276, 98);
            this.btnChooseProduct.Name = "btnChooseProduct";
            this.btnChooseProduct.Size = new System.Drawing.Size(22, 18);
            this.btnChooseProduct.TabIndex = 9;
            this.btnChooseProduct.UseVisualStyleBackColor = true;
            this.btnChooseProduct.Click += new System.EventHandler(this.btnChooseProduct_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(96, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Remove Item";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Location = new System.Drawing.Point(190, 267);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 42;
            this.btnInsert.Text = "Add To Sale";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(15, 267);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 40;
            this.btnNew.Text = "New Sale";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cmbPaymentTerm
            // 
            this.cmbPaymentTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPaymentTerm.FormattingEnabled = true;
            this.cmbPaymentTerm.Location = new System.Drawing.Point(124, 46);
            this.cmbPaymentTerm.Name = "cmbPaymentTerm";
            this.cmbPaymentTerm.Size = new System.Drawing.Size(170, 21);
            this.cmbPaymentTerm.TabIndex = 6;
            this.cmbPaymentTerm.Visible = false;
            // 
            // lblPaymentTerm
            // 
            this.lblPaymentTerm.AutoSize = true;
            this.lblPaymentTerm.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTerm.Location = new System.Drawing.Point(15, 48);
            this.lblPaymentTerm.Name = "lblPaymentTerm";
            this.lblPaymentTerm.Size = new System.Drawing.Size(102, 14);
            this.lblPaymentTerm.TabIndex = 5;
            this.lblPaymentTerm.Text = "Payment Term :";
            this.lblPaymentTerm.Visible = false;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.White;
            this.txtUnitPrice.Location = new System.Drawing.Point(124, 191);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(170, 20);
            this.txtUnitPrice.TabIndex = 15;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(45, 194);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 14);
            this.label18.TabIndex = 14;
            this.label18.Text = "Unit Price :";
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.White;
            this.txtQty.Location = new System.Drawing.Point(124, 160);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(170, 20);
            this.txtQty.TabIndex = 13;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(49, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 14);
            this.label17.TabIndex = 12;
            this.label17.Text = "Quantity :";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.Location = new System.Drawing.Point(124, 96);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(151, 20);
            this.txtItemName.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 14);
            this.label16.TabIndex = 10;
            this.label16.Text = "Item Number :";
            // 
            // txtItemNo
            // 
            this.txtItemNo.BackColor = System.Drawing.Color.White;
            this.txtItemNo.Location = new System.Drawing.Point(124, 127);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(170, 20);
            this.txtItemNo.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(39, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 14);
            this.label15.TabIndex = 7;
            this.label15.Text = "Item Name :";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.BackgroundImage")));
            this.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Location = new System.Drawing.Point(275, 13);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(22, 18);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnChooseSalePerson
            // 
            this.btnChooseSalePerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChooseSalePerson.BackgroundImage")));
            this.btnChooseSalePerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseSalePerson.FlatAppearance.BorderSize = 0;
            this.btnChooseSalePerson.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnChooseSalePerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnChooseSalePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseSalePerson.Location = new System.Drawing.Point(568, 128);
            this.btnChooseSalePerson.Name = "btnChooseSalePerson";
            this.btnChooseSalePerson.Size = new System.Drawing.Size(22, 18);
            this.btnChooseSalePerson.TabIndex = 18;
            this.btnChooseSalePerson.UseVisualStyleBackColor = true;
            this.btnChooseSalePerson.Visible = false;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.White;
            this.txtCustomer.Location = new System.Drawing.Point(124, 12);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(151, 20);
            this.txtCustomer.TabIndex = 1;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(47, 15);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(70, 14);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer :";
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTotalAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalAmt.Location = new System.Drawing.Point(836, 150);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.ReadOnly = true;
            this.txtTotalAmt.Size = new System.Drawing.Size(149, 13);
            this.txtTotalAmt.TabIndex = 33;
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Location = new System.Drawing.Point(420, 191);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(193, 20);
            this.dtpSaleDate.TabIndex = 22;
            // 
            // txtSalesPerson
            // 
            this.txtSalesPerson.BackColor = System.Drawing.Color.White;
            this.txtSalesPerson.Location = new System.Drawing.Point(419, 127);
            this.txtSalesPerson.Name = "txtSalesPerson";
            this.txtSalesPerson.ReadOnly = true;
            this.txtSalesPerson.Size = new System.Drawing.Size(151, 20);
            this.txtSalesPerson.TabIndex = 17;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInvoiceNo.Location = new System.Drawing.Point(836, 19);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(149, 13);
            this.txtInvoiceNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(774, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order # :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(738, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 14);
            this.label5.TabIndex = 32;
            this.label5.Text = "Total Amount :";
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPaymentMode.FormattingEnabled = true;
            this.cmbPaymentMode.Location = new System.Drawing.Point(836, 202);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(149, 21);
            this.cmbPaymentMode.TabIndex = 37;
            this.cmbPaymentMode.Visible = false;
            this.cmbPaymentMode.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMode_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(344, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 14);
            this.label11.TabIndex = 19;
            this.label11.Text = "Comment :";
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.White;
            this.txtComment.Location = new System.Drawing.Point(420, 160);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(193, 20);
            this.txtComment.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(767, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 14);
            this.label6.TabIndex = 23;
            this.label6.Text = "SubTotal :";
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBalanceDue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBalanceDue.Location = new System.Drawing.Point(836, 236);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.ReadOnly = true;
            this.txtBalanceDue.Size = new System.Drawing.Size(149, 13);
            this.txtBalanceDue.TabIndex = 39;
            this.txtBalanceDue.Visible = false;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTotal.Location = new System.Drawing.Point(836, 62);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(149, 13);
            this.txtSubTotal.TabIndex = 24;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.BackColor = System.Drawing.Color.White;
            this.txtAmountPaid.Location = new System.Drawing.Point(836, 174);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(149, 20);
            this.txtAmountPaid.TabIndex = 35;
            this.txtAmountPaid.Visible = false;
            this.txtAmountPaid.TextChanged += new System.EventHandler(this.txtPaidToday_TextChanged);
            this.txtAmountPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // lblSalesPerson
            // 
            this.lblSalesPerson.AutoSize = true;
            this.lblSalesPerson.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesPerson.Location = new System.Drawing.Point(331, 130);
            this.lblSalesPerson.Name = "lblSalesPerson";
            this.lblSalesPerson.Size = new System.Drawing.Size(84, 14);
            this.lblSalesPerson.TabIndex = 16;
            this.lblSalesPerson.Text = "Sales Person :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(743, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 14);
            this.label7.TabIndex = 34;
            this.label7.Text = "Amount Paid :";
            this.label7.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(749, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 14);
            this.label9.TabIndex = 38;
            this.label9.Text = "Balance Due :";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(734, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 14);
            this.label8.TabIndex = 36;
            this.label8.Text = "Payment Mode :";
            this.label8.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(5, 214);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 14);
            this.lblStatus.TabIndex = 33;
            this.lblStatus.Text = "--";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(885, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeName = "Breeze";
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecord.Location = new System.Drawing.Point(769, 204);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(110, 24);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Record";
            this.btnRecord.ThemeName = "Breeze";
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // gridViewItemLayout
            // 
            this.gridViewItemLayout.AllowUserToAddRows = false;
            this.gridViewItemLayout.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.gridViewItemLayout.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewItemLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewItemLayout.BackgroundColor = System.Drawing.Color.White;
            this.gridViewItemLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewItemLayout.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewItemLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewItemLayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColQty,
            this.ColItmNumber,
            this.ColDecscription,
            this.ColPrice,
            this.ColDiscount,
            this.ColTax,
            this.ColTotal});
            this.gridViewItemLayout.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridViewItemLayout.Location = new System.Drawing.Point(8, 8);
            this.gridViewItemLayout.Name = "gridViewItemLayout";
            this.gridViewItemLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewItemLayout.RowHeadersWidth = 25;
            this.gridViewItemLayout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewItemLayout.Size = new System.Drawing.Size(993, 161);
            this.gridViewItemLayout.TabIndex = 0;
            this.gridViewItemLayout.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewItemLayout_CellValueChanged);
            this.gridViewItemLayout.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridViewItemLayout_RowsAdded);
            this.gridViewItemLayout.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridViewItemLayout_RowsRemoved);
            // 
            // ColQty
            // 
            this.ColQty.HeaderText = "Quantity";
            this.ColQty.Name = "ColQty";
            this.ColQty.Width = 80;
            // 
            // ColItmNumber
            // 
            this.ColItmNumber.HeaderText = "Item Number";
            this.ColItmNumber.Name = "ColItmNumber";
            this.ColItmNumber.ReadOnly = true;
            this.ColItmNumber.Visible = false;
            this.ColItmNumber.Width = 150;
            // 
            // ColDecscription
            // 
            this.ColDecscription.HeaderText = "Description";
            this.ColDecscription.Name = "ColDecscription";
            this.ColDecscription.ReadOnly = true;
            this.ColDecscription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDecscription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColDecscription.Width = 300;
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            this.ColPrice.Width = 120;
            // 
            // ColDiscount
            // 
            this.ColDiscount.HeaderText = "Disc %";
            this.ColDiscount.Name = "ColDiscount";
            this.ColDiscount.ReadOnly = true;
            this.ColDiscount.Width = 120;
            // 
            // ColTax
            // 
            this.ColTax.HeaderText = "Tax";
            this.ColTax.Name = "ColTax";
            this.ColTax.ReadOnly = true;
            this.ColTax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColTax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTax.Width = 110;
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            this.ColTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColTotal.Width = 120;
            // 
            // ucOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucOrder";
            this.Size = new System.Drawing.Size(1001, 604);
            this.Load += new System.EventHandler(this.ucOrder_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItemLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        public System.Windows.Forms.Button btnChooseProduct;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbPaymentTerm;
        private System.Windows.Forms.Label lblPaymentTerm;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Button btnAddCustomer;
        public System.Windows.Forms.Button btnChooseSalePerson;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtTotalAmt;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.TextBox txtSalesPerson;
        public System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBalanceDue;
        private System.Windows.Forms.TextBox txtSubTotal;
        public System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblSalesPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView gridViewItemLayout;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label14;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnRecord;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaleDiscCal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSaleDiscount;
        private System.Windows.Forms.Label lblSaleTax;
        public System.Windows.Forms.Button btnSaleTax;
        private System.Windows.Forms.TextBox txtSalTax;
        private System.Windows.Forms.Label label12;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDecscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.Label lblStatus;
    }
}
