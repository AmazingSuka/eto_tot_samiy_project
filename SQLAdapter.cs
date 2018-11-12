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
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-9JL7RPV;Initial Catalog=tentShop;Integrated Security=True");
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
                sqlDataReader.Close();
                sqlConnection.Close();
            }
        }

        internal void ComboBox_Fill(SqlCommand sqlCommand, ComboBox comboBox)
        {
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    comboBox.Items.Add(sqlDataReader.GetValue(0));
                }
            }
            catch (Exception)
            {
                ErrorMessage();
                throw;
            }
            finally
            {
                sqlDataReader.Close();
                sqlConnection.Close();
            }
        }

        // Вставка данных в таблицу в БД
        internal void InsertData(ITableAdapter TableAdapter, params string[] value)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = TableAdapter.Insert(sqlConnection);
                for (int i = 0; i < TableAdapter.InsertParams; i++)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(String.Format("@param{0}", i + 1), value[i]));
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
        internal void RemoveData(ITableAdapter TableAdapter, string value)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = TableAdapter.Delete(sqlConnection);
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add(new SqlParameter("@param1", value));
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
 
        // Редактирование данных 
        internal void EditData(ITableAdapter TableAdapter, params string[] value)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = TableAdapter.Edit(sqlConnection);
                for (int i = 0; i < TableAdapter.InsertParams + 1; i++)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(String.Format("@param{0}", i + 1), value[i]));
                }
                sqlCommand.ExecuteNonQuery();
                CongratulationMessage();
            }
            catch (Exception)
            {
                ErrorMessage();
                throw; // убрать перед показом
            }
            finally
            {
                sqlConnection.Close();
            }
            
        }

        /* Заполняет ТекстБоксы на форме редактирования
                                     Комбобокс с выбором ID и Текстбоксы*/
        internal void SelectDataForEdit(ITableAdapter TableAdapter, string id, TextBox[] textBoxes)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = TableAdapter.Select(sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@param1", id));
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.GetValues(textBoxes);
            }
            catch (Exception)
            {
                ErrorMessage();
                throw;
            }
            finally
            {
                sqlDataReader.Close();
                sqlConnection.Close();
            }
        }

        private void ErrorMessage() => MessageBox.Show("При работе с данными произошла ошибка." +
                                                       "\nПоля с (*) должны быть заполнены.", "Ошибка данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        private void CongratulationMessage() => MessageBox.Show("Команда успешно выполена", 
            "Успешное выполнение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
    }
}
