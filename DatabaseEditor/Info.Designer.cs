namespace DatabaseEditor
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            System.Windows.Forms.Label clientIdLabel1;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label countryLabel1;
            System.Windows.Forms.Label cityLabel1;
            System.Windows.Forms.Label addressLabel1;
            System.Windows.Forms.Label phoneLabel1;
            System.Windows.Forms.Label emailLabel;
            this.customersDataSet = new DatabaseEditor.CustomersDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new DatabaseEditor.CustomersDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new DatabaseEditor.CustomersDataSetTableAdapters.TableAdapterManager();
            this.clientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clientIdTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.countryTextBox1 = new System.Windows.Forms.TextBox();
            this.cityTextBox1 = new System.Windows.Forms.TextBox();
            this.addressTextBox1 = new System.Windows.Forms.TextBox();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            clientIdLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            countryLabel1 = new System.Windows.Forms.Label();
            cityLabel1 = new System.Windows.Forms.Label();
            addressLabel1 = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).BeginInit();
            this.clientsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "CustomersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.customersDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DatabaseEditor.CustomersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsBindingNavigator
            // 
            this.clientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientsBindingNavigator.BindingSource = this.clientsBindingSource;
            this.clientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clientsBindingNavigatorSaveItem});
            this.clientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientsBindingNavigator.Name = "clientsBindingNavigator";
            this.clientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientsBindingNavigator.Size = new System.Drawing.Size(338, 25);
            this.clientsBindingNavigator.TabIndex = 0;
            this.clientsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
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
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // clientsBindingNavigatorSaveItem
            // 
            this.clientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsBindingNavigatorSaveItem.Image")));
            this.clientsBindingNavigatorSaveItem.Name = "clientsBindingNavigatorSaveItem";
            this.clientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.clientsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.clientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientsBindingNavigatorSaveItem_Click);
            // 
            // clientIdLabel1
            // 
            clientIdLabel1.AutoSize = true;
            clientIdLabel1.Location = new System.Drawing.Point(33, 73);
            clientIdLabel1.Name = "clientIdLabel1";
            clientIdLabel1.Size = new System.Drawing.Size(48, 13);
            clientIdLabel1.TabIndex = 13;
            clientIdLabel1.Text = "Client Id:";
            // 
            // clientIdTextBox1
            // 
            this.clientIdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ClientId", true));
            this.clientIdTextBox1.Location = new System.Drawing.Point(87, 70);
            this.clientIdTextBox1.Name = "clientIdTextBox1";
            this.clientIdTextBox1.Size = new System.Drawing.Size(212, 20);
            this.clientIdTextBox1.TabIndex = 14;
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(33, 99);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 15;
            nameLabel1.Text = "Name:";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(87, 96);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(212, 20);
            this.nameTextBox1.TabIndex = 16;
            // 
            // countryLabel1
            // 
            countryLabel1.AutoSize = true;
            countryLabel1.Location = new System.Drawing.Point(33, 125);
            countryLabel1.Name = "countryLabel1";
            countryLabel1.Size = new System.Drawing.Size(46, 13);
            countryLabel1.TabIndex = 17;
            countryLabel1.Text = "Country:";
            // 
            // countryTextBox1
            // 
            this.countryTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Country", true));
            this.countryTextBox1.Location = new System.Drawing.Point(87, 122);
            this.countryTextBox1.Name = "countryTextBox1";
            this.countryTextBox1.Size = new System.Drawing.Size(212, 20);
            this.countryTextBox1.TabIndex = 18;
            // 
            // cityLabel1
            // 
            cityLabel1.AutoSize = true;
            cityLabel1.Location = new System.Drawing.Point(33, 151);
            cityLabel1.Name = "cityLabel1";
            cityLabel1.Size = new System.Drawing.Size(27, 13);
            cityLabel1.TabIndex = 19;
            cityLabel1.Text = "City:";
            // 
            // cityTextBox1
            // 
            this.cityTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "City", true));
            this.cityTextBox1.Location = new System.Drawing.Point(87, 148);
            this.cityTextBox1.Name = "cityTextBox1";
            this.cityTextBox1.Size = new System.Drawing.Size(212, 20);
            this.cityTextBox1.TabIndex = 20;
            // 
            // addressLabel1
            // 
            addressLabel1.AutoSize = true;
            addressLabel1.Location = new System.Drawing.Point(33, 177);
            addressLabel1.Name = "addressLabel1";
            addressLabel1.Size = new System.Drawing.Size(48, 13);
            addressLabel1.TabIndex = 21;
            addressLabel1.Text = "Address:";
            // 
            // addressTextBox1
            // 
            this.addressTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Address", true));
            this.addressTextBox1.Location = new System.Drawing.Point(87, 174);
            this.addressTextBox1.Name = "addressTextBox1";
            this.addressTextBox1.Size = new System.Drawing.Size(212, 20);
            this.addressTextBox1.TabIndex = 22;
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Location = new System.Drawing.Point(33, 203);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(41, 13);
            phoneLabel1.TabIndex = 23;
            phoneLabel1.Text = "Phone:";
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Phone", true));
            this.phoneTextBox1.Location = new System.Drawing.Point(87, 200);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(212, 20);
            this.phoneTextBox1.TabIndex = 24;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(33, 229);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(87, 226);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(212, 20);
            this.emailTextBox.TabIndex = 26;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 289);
            this.Controls.Add(clientIdLabel1);
            this.Controls.Add(this.clientIdTextBox1);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(countryLabel1);
            this.Controls.Add(this.countryTextBox1);
            this.Controls.Add(cityLabel1);
            this.Controls.Add(this.cityTextBox1);
            this.Controls.Add(addressLabel1);
            this.Controls.Add(this.addressTextBox1);
            this.Controls.Add(phoneLabel1);
            this.Controls.Add(this.phoneTextBox1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.clientsBindingNavigator);
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).EndInit();
            this.clientsBindingNavigator.ResumeLayout(false);
            this.clientsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomersDataSet customersDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private CustomersDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private CustomersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clientsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox clientIdTextBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox countryTextBox1;
        private System.Windows.Forms.TextBox cityTextBox1;
        private System.Windows.Forms.TextBox addressTextBox1;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}