using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseEditor
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }

        private void Info_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "customersDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.customersDataSet.Clients);
            this.clientsBindingSource.Position = (this.Owner as Form1).clientsBindingSource.Position;
        }
    }
}
