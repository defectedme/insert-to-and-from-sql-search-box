namespace insert_to_and_from_sql
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label requiredDateLabel;
            System.Windows.Forms.Label shippedDateLabel;
            System.Windows.Forms.Label shipViaLabel;
            System.Windows.Forms.Label freightLabel;
            System.Windows.Forms.Label shipNameLabel;
            System.Windows.Forms.Label shipAddressLabel;
            System.Windows.Forms.Label shipCityLabel;
            System.Windows.Forms.Label shipRegionLabel;
            System.Windows.Forms.Label shipPostalCodeLabel;
            System.Windows.Forms.Label shipCountryLabel;
            this.northwindDataSet = new insert_to_and_from_sql.NorthwindDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new insert_to_and_from_sql.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new insert_to_and_from_sql.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ordersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.requiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shippedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipViaTextBox = new System.Windows.Forms.TextBox();
            this.freightTextBox = new System.Windows.Forms.TextBox();
            this.shipNameTextBox = new System.Windows.Forms.TextBox();
            this.shipAddressTextBox = new System.Windows.Forms.TextBox();
            this.shipCityTextBox = new System.Windows.Forms.TextBox();
            this.shipRegionTextBox = new System.Windows.Forms.TextBox();
            this.shipPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.shipCountryTextBox = new System.Windows.Forms.TextBox();
            orderIDLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            shippedDateLabel = new System.Windows.Forms.Label();
            shipViaLabel = new System.Windows.Forms.Label();
            freightLabel = new System.Windows.Forms.Label();
            shipNameLabel = new System.Windows.Forms.Label();
            shipAddressLabel = new System.Windows.Forms.Label();
            shipCityLabel = new System.Windows.Forms.Label();
            shipRegionLabel = new System.Windows.Forms.Label();
            shipPostalCodeLabel = new System.Windows.Forms.Label();
            shipCountryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
            this.ordersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.northwindDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = insert_to_and_from_sql.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersBindingNavigator
            // 
            this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordersBindingNavigator.BindingSource = this.ordersBindingSource;
            this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ordersBindingNavigatorSaveItem});
            this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordersBindingNavigator.Name = "ordersBindingNavigator";
            this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordersBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.ordersBindingNavigator.TabIndex = 0;
            this.ordersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // ordersBindingNavigatorSaveItem
            // 
            this.ordersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorSaveItem.Image")));
            this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
            this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.ordersBindingNavigatorSaveItem.Text = "Save Data";
            this.ordersBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordersBindingNavigatorSaveItem_Click);
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(170, 53);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(50, 13);
            orderIDLabel.TabIndex = 1;
            orderIDLabel.Text = "Order ID:";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(267, 50);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.orderIDTextBox.TabIndex = 2;
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(170, 79);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 3;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(267, 76);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerIDTextBox.TabIndex = 4;
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(170, 105);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 5;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(267, 102);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.employeeIDTextBox.TabIndex = 6;
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(170, 132);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 7;
            orderDateLabel.Text = "Order Date:";
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(267, 128);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDateDateTimePicker.TabIndex = 8;
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(170, 158);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(79, 13);
            requiredDateLabel.TabIndex = 9;
            requiredDateLabel.Text = "Required Date:";
            // 
            // requiredDateDateTimePicker
            // 
            this.requiredDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "RequiredDate", true));
            this.requiredDateDateTimePicker.Location = new System.Drawing.Point(267, 154);
            this.requiredDateDateTimePicker.Name = "requiredDateDateTimePicker";
            this.requiredDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.requiredDateDateTimePicker.TabIndex = 10;
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Location = new System.Drawing.Point(170, 184);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(75, 13);
            shippedDateLabel.TabIndex = 11;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // shippedDateDateTimePicker
            // 
            this.shippedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "ShippedDate", true));
            this.shippedDateDateTimePicker.Location = new System.Drawing.Point(267, 180);
            this.shippedDateDateTimePicker.Name = "shippedDateDateTimePicker";
            this.shippedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.shippedDateDateTimePicker.TabIndex = 12;
            // 
            // shipViaLabel
            // 
            shipViaLabel.AutoSize = true;
            shipViaLabel.Location = new System.Drawing.Point(170, 209);
            shipViaLabel.Name = "shipViaLabel";
            shipViaLabel.Size = new System.Drawing.Size(49, 13);
            shipViaLabel.TabIndex = 13;
            shipViaLabel.Text = "Ship Via:";
            // 
            // shipViaTextBox
            // 
            this.shipViaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipVia", true));
            this.shipViaTextBox.Location = new System.Drawing.Point(267, 206);
            this.shipViaTextBox.Name = "shipViaTextBox";
            this.shipViaTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipViaTextBox.TabIndex = 14;
            // 
            // freightLabel
            // 
            freightLabel.AutoSize = true;
            freightLabel.Location = new System.Drawing.Point(170, 235);
            freightLabel.Name = "freightLabel";
            freightLabel.Size = new System.Drawing.Size(42, 13);
            freightLabel.TabIndex = 15;
            freightLabel.Text = "Freight:";
            // 
            // freightTextBox
            // 
            this.freightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Freight", true));
            this.freightTextBox.Location = new System.Drawing.Point(267, 232);
            this.freightTextBox.Name = "freightTextBox";
            this.freightTextBox.Size = new System.Drawing.Size(200, 20);
            this.freightTextBox.TabIndex = 16;
            // 
            // shipNameLabel
            // 
            shipNameLabel.AutoSize = true;
            shipNameLabel.Location = new System.Drawing.Point(170, 261);
            shipNameLabel.Name = "shipNameLabel";
            shipNameLabel.Size = new System.Drawing.Size(62, 13);
            shipNameLabel.TabIndex = 17;
            shipNameLabel.Text = "Ship Name:";
            // 
            // shipNameTextBox
            // 
            this.shipNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipName", true));
            this.shipNameTextBox.Location = new System.Drawing.Point(267, 258);
            this.shipNameTextBox.Name = "shipNameTextBox";
            this.shipNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipNameTextBox.TabIndex = 18;
            // 
            // shipAddressLabel
            // 
            shipAddressLabel.AutoSize = true;
            shipAddressLabel.Location = new System.Drawing.Point(170, 287);
            shipAddressLabel.Name = "shipAddressLabel";
            shipAddressLabel.Size = new System.Drawing.Size(72, 13);
            shipAddressLabel.TabIndex = 19;
            shipAddressLabel.Text = "Ship Address:";
            // 
            // shipAddressTextBox
            // 
            this.shipAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipAddress", true));
            this.shipAddressTextBox.Location = new System.Drawing.Point(267, 284);
            this.shipAddressTextBox.Name = "shipAddressTextBox";
            this.shipAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipAddressTextBox.TabIndex = 20;
            // 
            // shipCityLabel
            // 
            shipCityLabel.AutoSize = true;
            shipCityLabel.Location = new System.Drawing.Point(170, 313);
            shipCityLabel.Name = "shipCityLabel";
            shipCityLabel.Size = new System.Drawing.Size(51, 13);
            shipCityLabel.TabIndex = 21;
            shipCityLabel.Text = "Ship City:";
            // 
            // shipCityTextBox
            // 
            this.shipCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipCity", true));
            this.shipCityTextBox.Location = new System.Drawing.Point(267, 310);
            this.shipCityTextBox.Name = "shipCityTextBox";
            this.shipCityTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipCityTextBox.TabIndex = 22;
            // 
            // shipRegionLabel
            // 
            shipRegionLabel.AutoSize = true;
            shipRegionLabel.Location = new System.Drawing.Point(170, 339);
            shipRegionLabel.Name = "shipRegionLabel";
            shipRegionLabel.Size = new System.Drawing.Size(68, 13);
            shipRegionLabel.TabIndex = 23;
            shipRegionLabel.Text = "Ship Region:";
            // 
            // shipRegionTextBox
            // 
            this.shipRegionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipRegion", true));
            this.shipRegionTextBox.Location = new System.Drawing.Point(267, 336);
            this.shipRegionTextBox.Name = "shipRegionTextBox";
            this.shipRegionTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipRegionTextBox.TabIndex = 24;
            // 
            // shipPostalCodeLabel
            // 
            shipPostalCodeLabel.AutoSize = true;
            shipPostalCodeLabel.Location = new System.Drawing.Point(170, 365);
            shipPostalCodeLabel.Name = "shipPostalCodeLabel";
            shipPostalCodeLabel.Size = new System.Drawing.Size(91, 13);
            shipPostalCodeLabel.TabIndex = 25;
            shipPostalCodeLabel.Text = "Ship Postal Code:";
            // 
            // shipPostalCodeTextBox
            // 
            this.shipPostalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipPostalCode", true));
            this.shipPostalCodeTextBox.Location = new System.Drawing.Point(267, 362);
            this.shipPostalCodeTextBox.Name = "shipPostalCodeTextBox";
            this.shipPostalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipPostalCodeTextBox.TabIndex = 26;
            // 
            // shipCountryLabel
            // 
            shipCountryLabel.AutoSize = true;
            shipCountryLabel.Location = new System.Drawing.Point(170, 391);
            shipCountryLabel.Name = "shipCountryLabel";
            shipCountryLabel.Size = new System.Drawing.Size(70, 13);
            shipCountryLabel.TabIndex = 27;
            shipCountryLabel.Text = "Ship Country:";
            // 
            // shipCountryTextBox
            // 
            this.shipCountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipCountry", true));
            this.shipCountryTextBox.Location = new System.Drawing.Point(267, 388);
            this.shipCountryTextBox.Name = "shipCountryTextBox";
            this.shipCountryTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipCountryTextBox.TabIndex = 28;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateDateTimePicker);
            this.Controls.Add(requiredDateLabel);
            this.Controls.Add(this.requiredDateDateTimePicker);
            this.Controls.Add(shippedDateLabel);
            this.Controls.Add(this.shippedDateDateTimePicker);
            this.Controls.Add(shipViaLabel);
            this.Controls.Add(this.shipViaTextBox);
            this.Controls.Add(freightLabel);
            this.Controls.Add(this.freightTextBox);
            this.Controls.Add(shipNameLabel);
            this.Controls.Add(this.shipNameTextBox);
            this.Controls.Add(shipAddressLabel);
            this.Controls.Add(this.shipAddressTextBox);
            this.Controls.Add(shipCityLabel);
            this.Controls.Add(this.shipCityTextBox);
            this.Controls.Add(shipRegionLabel);
            this.Controls.Add(this.shipRegionTextBox);
            this.Controls.Add(shipPostalCodeLabel);
            this.Controls.Add(this.shipPostalCodeTextBox);
            this.Controls.Add(shipCountryLabel);
            this.Controls.Add(this.shipCountryTextBox);
            this.Controls.Add(this.ordersBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
            this.ordersBindingNavigator.ResumeLayout(false);
            this.ordersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ordersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker requiredDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker shippedDateDateTimePicker;
        private System.Windows.Forms.TextBox shipViaTextBox;
        private System.Windows.Forms.TextBox freightTextBox;
        private System.Windows.Forms.TextBox shipNameTextBox;
        private System.Windows.Forms.TextBox shipAddressTextBox;
        private System.Windows.Forms.TextBox shipCityTextBox;
        private System.Windows.Forms.TextBox shipRegionTextBox;
        private System.Windows.Forms.TextBox shipPostalCodeTextBox;
        private System.Windows.Forms.TextBox shipCountryTextBox;
    }
}