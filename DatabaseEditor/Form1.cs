using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DatabaseEditor
{
    public partial class Form1 : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        //добавление строки подключения, настройки которой есть в фале App.config
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseEditor.Properties.Settings.CustomersConnectionString"].ConnectionString;
        string sql = "SELECT * FROM Clients";
        List<Client> clients = new List<Client>();
        DataGridViewRow ourid;

        public Form1()
        {
            InitializeComponent();

            clientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            clientsDataGridView.AllowUserToAddRows = false;            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // создаем объект DataAdapter
                adapter = new SqlDataAdapter(sql, connection);
                // создаем объект DataSet
                ds = new DataSet();
                // заполняем DataSet
                adapter.Fill(ds);
                // отображаем данные 
                clientsDataGridView.DataSource = ds.Tables[0];
                //// делаем недоступным столбец id для изменения
                //clientsDataGridView.Columns["ClientId"].ReadOnly = true;
            }

        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "customersDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.customersDataSet.Clients);

        }

        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ourid = clientsDataGridView.CurrentRow;
        }

        private void SaveForm_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("sp_CreateClient", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@country", SqlDbType.NChar, 10, "Country"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@city", SqlDbType.NChar, 10, "City"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar, 2147483647, "Address"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@phone", SqlDbType.NChar, 10, "Phone"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 50, "Email"));

                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 0, "ClientId");
                parameter.Direction = ParameterDirection.Output;

                adapter.Update(ds);
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Owner = this;
            info.ShowDialog();
        }
    }
}
