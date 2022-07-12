namespace Hotel_Costomers_listBook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label costumer_NameLabel;
            System.Windows.Forms.Label mobile_NumberLabel;
            System.Windows.Forms.Label room_NoLabel;
            System.Windows.Forms.Label citizenship_NoLabel;
            System.Windows.Forms.Label due_PaymentLabel;
            System.Windows.Forms.Label checkout_TimeLabel;
            System.Windows.Forms.Label entry_TimeLabel;
            System.Windows.Forms.Label sNLabel;
            this.dataSet = new Hotel_Costomers_listBook.DataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Hotel_Costomers_listBook.DataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Hotel_Costomers_listBook.DataSetTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumer_NameTextBox = new System.Windows.Forms.TextBox();
            this.mobile_NumberTextBox = new System.Windows.Forms.TextBox();
            this.room_NoTextBox = new System.Windows.Forms.TextBox();
            this.citizenship_NoTextBox = new System.Windows.Forms.TextBox();
            this.due_PaymentTextBox = new System.Windows.Forms.TextBox();
            this.checkout_TimeTextBox = new System.Windows.Forms.TextBox();
            this.entry_TimeTextBox = new System.Windows.Forms.TextBox();
            this.sNNumericUpDown = new System.Windows.Forms.NumericUpDown();
            costumer_NameLabel = new System.Windows.Forms.Label();
            mobile_NumberLabel = new System.Windows.Forms.Label();
            room_NoLabel = new System.Windows.Forms.Label();
            citizenship_NoLabel = new System.Windows.Forms.Label();
            due_PaymentLabel = new System.Windows.Forms.Label();
            checkout_TimeLabel = new System.Windows.Forms.Label();
            entry_TimeLabel = new System.Windows.Forms.Label();
            sNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sNNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Hotel_Costomers_listBook.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(1069, 27);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(12, 458);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowHeadersWidth = 51;
            this.tableDataGridView.RowTemplate.Height = 24;
            this.tableDataGridView.Size = new System.Drawing.Size(1052, 250);
            this.tableDataGridView.TabIndex = 1;
            this.tableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SN";
            this.dataGridViewTextBoxColumn1.HeaderText = "SN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Costumer_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Costumer_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Mobile_Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mobile_Number";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Room_No";
            this.dataGridViewTextBoxColumn4.HeaderText = "Room_No";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Citizenship_No";
            this.dataGridViewTextBoxColumn5.HeaderText = "Citizenship_No";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Entry_Time";
            this.dataGridViewTextBoxColumn6.HeaderText = "Entry_Time";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Checkout_Time";
            this.dataGridViewTextBoxColumn7.HeaderText = "Checkout_Time";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Due_Payment";
            this.dataGridViewTextBoxColumn8.HeaderText = "Due_Payment";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // costumer_NameLabel
            // 
            costumer_NameLabel.AutoSize = true;
            costumer_NameLabel.BackColor = System.Drawing.Color.AliceBlue;
            costumer_NameLabel.Location = new System.Drawing.Point(24, 75);
            costumer_NameLabel.Name = "costumer_NameLabel";
            costumer_NameLabel.Size = new System.Drawing.Size(107, 16);
            costumer_NameLabel.TabIndex = 4;
            costumer_NameLabel.Text = "Costumer Name:";
            // 
            // costumer_NameTextBox
            // 
            this.costumer_NameTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.costumer_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Costumer_Name", true));
            this.costumer_NameTextBox.Location = new System.Drawing.Point(137, 72);
            this.costumer_NameTextBox.Name = "costumer_NameTextBox";
            this.costumer_NameTextBox.Size = new System.Drawing.Size(156, 22);
            this.costumer_NameTextBox.TabIndex = 5;
            // 
            // mobile_NumberLabel
            // 
            mobile_NumberLabel.AutoSize = true;
            mobile_NumberLabel.BackColor = System.Drawing.Color.AliceBlue;
            mobile_NumberLabel.Location = new System.Drawing.Point(24, 103);
            mobile_NumberLabel.Name = "mobile_NumberLabel";
            mobile_NumberLabel.Size = new System.Drawing.Size(102, 16);
            mobile_NumberLabel.TabIndex = 6;
            mobile_NumberLabel.Text = "Mobile Number:";
            // 
            // mobile_NumberTextBox
            // 
            this.mobile_NumberTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.mobile_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Mobile_Number", true));
            this.mobile_NumberTextBox.Location = new System.Drawing.Point(137, 100);
            this.mobile_NumberTextBox.Name = "mobile_NumberTextBox";
            this.mobile_NumberTextBox.Size = new System.Drawing.Size(156, 22);
            this.mobile_NumberTextBox.TabIndex = 7;
            // 
            // room_NoLabel
            // 
            room_NoLabel.AutoSize = true;
            room_NoLabel.BackColor = System.Drawing.Color.AliceBlue;
            room_NoLabel.Location = new System.Drawing.Point(24, 131);
            room_NoLabel.Name = "room_NoLabel";
            room_NoLabel.Size = new System.Drawing.Size(68, 16);
            room_NoLabel.TabIndex = 8;
            room_NoLabel.Text = "Room No:";
            // 
            // room_NoTextBox
            // 
            this.room_NoTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.room_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Room_No", true));
            this.room_NoTextBox.Location = new System.Drawing.Point(137, 128);
            this.room_NoTextBox.Name = "room_NoTextBox";
            this.room_NoTextBox.Size = new System.Drawing.Size(156, 22);
            this.room_NoTextBox.TabIndex = 9;
            // 
            // citizenship_NoLabel
            // 
            citizenship_NoLabel.AutoSize = true;
            citizenship_NoLabel.BackColor = System.Drawing.Color.AliceBlue;
            citizenship_NoLabel.Location = new System.Drawing.Point(24, 159);
            citizenship_NoLabel.Name = "citizenship_NoLabel";
            citizenship_NoLabel.Size = new System.Drawing.Size(95, 16);
            citizenship_NoLabel.TabIndex = 10;
            citizenship_NoLabel.Text = "Citizenship No:";
            // 
            // citizenship_NoTextBox
            // 
            this.citizenship_NoTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.citizenship_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Citizenship_No", true));
            this.citizenship_NoTextBox.Location = new System.Drawing.Point(137, 156);
            this.citizenship_NoTextBox.Name = "citizenship_NoTextBox";
            this.citizenship_NoTextBox.Size = new System.Drawing.Size(156, 22);
            this.citizenship_NoTextBox.TabIndex = 11;
            // 
            // due_PaymentLabel
            // 
            due_PaymentLabel.AutoSize = true;
            due_PaymentLabel.BackColor = System.Drawing.Color.AliceBlue;
            due_PaymentLabel.Location = new System.Drawing.Point(24, 243);
            due_PaymentLabel.Name = "due_PaymentLabel";
            due_PaymentLabel.Size = new System.Drawing.Size(91, 16);
            due_PaymentLabel.TabIndex = 16;
            due_PaymentLabel.Text = "Due Payment:";
            // 
            // due_PaymentTextBox
            // 
            this.due_PaymentTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.due_PaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Due_Payment", true));
            this.due_PaymentTextBox.Location = new System.Drawing.Point(137, 240);
            this.due_PaymentTextBox.Name = "due_PaymentTextBox";
            this.due_PaymentTextBox.Size = new System.Drawing.Size(156, 22);
            this.due_PaymentTextBox.TabIndex = 17;
            // 
            // checkout_TimeLabel
            // 
            checkout_TimeLabel.AutoSize = true;
            checkout_TimeLabel.BackColor = System.Drawing.Color.AliceBlue;
            checkout_TimeLabel.Location = new System.Drawing.Point(24, 215);
            checkout_TimeLabel.Name = "checkout_TimeLabel";
            checkout_TimeLabel.Size = new System.Drawing.Size(100, 16);
            checkout_TimeLabel.TabIndex = 14;
            checkout_TimeLabel.Text = "Checkout Time:";
            // 
            // checkout_TimeTextBox
            // 
            this.checkout_TimeTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.checkout_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Checkout_Time", true));
            this.checkout_TimeTextBox.Location = new System.Drawing.Point(137, 212);
            this.checkout_TimeTextBox.Name = "checkout_TimeTextBox";
            this.checkout_TimeTextBox.Size = new System.Drawing.Size(156, 22);
            this.checkout_TimeTextBox.TabIndex = 15;
            // 
            // entry_TimeLabel
            // 
            entry_TimeLabel.AutoSize = true;
            entry_TimeLabel.BackColor = System.Drawing.Color.AliceBlue;
            entry_TimeLabel.Location = new System.Drawing.Point(24, 187);
            entry_TimeLabel.Name = "entry_TimeLabel";
            entry_TimeLabel.Size = new System.Drawing.Size(74, 16);
            entry_TimeLabel.TabIndex = 12;
            entry_TimeLabel.Text = "Entry Time:";
            // 
            // entry_TimeTextBox
            // 
            this.entry_TimeTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.entry_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Entry_Time", true));
            this.entry_TimeTextBox.Location = new System.Drawing.Point(137, 184);
            this.entry_TimeTextBox.Name = "entry_TimeTextBox";
            this.entry_TimeTextBox.Size = new System.Drawing.Size(156, 22);
            this.entry_TimeTextBox.TabIndex = 13;
            // 
            // sNLabel
            // 
            sNLabel.AutoSize = true;
            sNLabel.BackColor = System.Drawing.Color.AliceBlue;
            sNLabel.Location = new System.Drawing.Point(24, 44);
            sNLabel.Name = "sNLabel";
            sNLabel.Size = new System.Drawing.Size(29, 16);
            sNLabel.TabIndex = 2;
            sNLabel.Text = "SN:";
            // 
            // sNNumericUpDown
            // 
            this.sNNumericUpDown.BackColor = System.Drawing.Color.AliceBlue;
            this.sNNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource, "SN", true));
            this.sNNumericUpDown.Location = new System.Drawing.Point(137, 44);
            this.sNNumericUpDown.Name = "sNNumericUpDown";
            this.sNNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.sNNumericUpDown.TabIndex = 3;
            this.sNNumericUpDown.ValueChanged += new System.EventHandler(this.sNNumericUpDown_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Hotel_Costomers_listBook.Properties.Resources.gurung_Cottagr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1069, 716);
            this.Controls.Add(sNLabel);
            this.Controls.Add(this.sNNumericUpDown);
            this.Controls.Add(costumer_NameLabel);
            this.Controls.Add(this.costumer_NameTextBox);
            this.Controls.Add(mobile_NumberLabel);
            this.Controls.Add(this.mobile_NumberTextBox);
            this.Controls.Add(room_NoLabel);
            this.Controls.Add(this.room_NoTextBox);
            this.Controls.Add(citizenship_NoLabel);
            this.Controls.Add(this.citizenship_NoTextBox);
            this.Controls.Add(entry_TimeLabel);
            this.Controls.Add(this.entry_TimeTextBox);
            this.Controls.Add(checkout_TimeLabel);
            this.Controls.Add(this.checkout_TimeTextBox);
            this.Controls.Add(due_PaymentLabel);
            this.Controls.Add(this.due_PaymentTextBox);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.tableBindingNavigator);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sNNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox costumer_NameTextBox;
        private System.Windows.Forms.TextBox mobile_NumberTextBox;
        private System.Windows.Forms.TextBox room_NoTextBox;
        private System.Windows.Forms.TextBox citizenship_NoTextBox;
        private System.Windows.Forms.TextBox due_PaymentTextBox;
        private System.Windows.Forms.TextBox checkout_TimeTextBox;
        private System.Windows.Forms.TextBox entry_TimeTextBox;
        private System.Windows.Forms.NumericUpDown sNNumericUpDown;
    }
}

