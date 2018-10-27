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
                throw; //Убрать перед показом
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        // Вставка данных в таблицу в БД
        internal void InsertData(string table, string arguments, params string[] value)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(String.Format("INSERT INTO {0} VALUES ({1})", table, arguments), sqlConnection);
                string[] arg = arguments.Split(',');
                for (int i = 0; i < arg.Length; i++)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(arg[i], value[i]));
                }
                sqlCommand.ExecuteNonQuery();
                CongratulationMessage();
            }
            catch (Exception)
            {
                ErrorMessage();
                throw; // Убрать перед показом
            }
            finally
            {
                sqlConnection.Close();
            }            
        }

        // Удаление данных из таблицы в БД
        internal void RemoveData(string table, string value)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(String.Format("DELETE FROM {0} WHERE ID = @1", table), sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@1", value));
                sqlCommand.ExecuteNonQuery();
                CongratulationMessage();
            }
            catch (Exception)
            {
                ErrorMessage();
                throw;
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
