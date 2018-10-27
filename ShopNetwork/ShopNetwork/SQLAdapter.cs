using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShopNetwork
{
    class SqlAdapter
    {
        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;
        public SqlDataReader sqlDataReader;

        public SqlAdapter()
        {
            //sqlConnection = new SqlConnection(ShopNetwork.Properties.Settings.Default.ConnectionString); Строка подключения
        }

        // Добавление информации в DataGrid
        internal void DataGrid_Fill(SqlCommand sqlCommand, DataGridView dataGridView, int columnCount)
        {
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                int i = 0;
                while (sqlDataReader.Read())
                {
                    dataGridView.Rows.Add();
                    for (int j = 0; j < columnCount; j++)
                    {
                        dataGridView.Rows[i].Cells[j].Value = sqlDataReader.GetValue(j);
                    }
                    i++;
                }
            }
            catch(Exception)
            {
                ErrorMessage();
            }
            finally
            {
                sqlConnection.Close();
            }           
        }

        private void ErrorMessage()
        {
            MessageBox.Show("При работе с данными произошла ошибка", "Ошибка данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void CongratulationMessage()
        {
            MessageBox.Show("Команда успешно выполена", "Успешное выполнение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        
    }
}
