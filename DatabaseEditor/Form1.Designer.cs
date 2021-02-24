namespace DatabaseEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSet = new DatabaseEditor.CustomersDataSet();
            this.clientsTableAdapter = new DatabaseEditor.CustomersDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new DatabaseEditor.CustomersDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveForm = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.customersDataSet;
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "CustomersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn4.HeaderText = "City";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn3.HeaderText = "Country";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClientId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ClientId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(12, 39);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(746, 220);
            this.clientsDataGridView.TabIndex = 1;
            this.clientsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsDataGridView_CellContentClick);
            // 
            // SaveForm
            // 
            this.SaveForm.Location = new System.Drawing.Point(12, 279);
            this.SaveForm.Name = "SaveForm";
            this.SaveForm.Size = new System.Drawing.Size(75, 23);
            this.SaveForm.TabIndex = 2;
            this.SaveForm.Text = "Сохранить";
            this.SaveForm.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(683, 279);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(75, 23);
            this.Info.TabIndex = 3;
            this.Info.Text = "Подробнее";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 314);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.SaveForm);
            this.Controls.Add(this.clientsDataGridView);
            this.Name = "Form1";
            this.Text = "CustomersEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public CustomersDataSet customersDataSet;
        public System.Windows.Forms.BindingSource clientsBindingSource;
        private CustomersDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private CustomersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.Button SaveForm;
        private System.Windows.Forms.Button Info;
    }
}

