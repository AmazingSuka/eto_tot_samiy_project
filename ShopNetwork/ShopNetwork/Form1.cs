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

namespace ShopNetwork
{
    public partial class Form1 : Form
    {
        private SqlAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            adapter = new SqlAdapter();
            // OrderGrid_FillWithCondition();
            // ModelGrid_Fill();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Заполняет DataGrid окна OrderList | Запрос доделаю
        private void OrderGrid_FillWithCondition(string whereSqlCondition = "")
        {
            adapter.sqlCommand = new SqlCommand(String.Format("SELECT {*} FROM {ORDER_TABLE} as o " +
                                                "JOIN {SALESPERSON_TABLE} as s ON s.id = o.salespersonID " +
                                                "JOIN {CUSTOMER_TABLE} as c ON c.id = o.customerID" +
                                                "JOIN {BOAT_TABLE} as b ON b.id = o.boatID " +
                                                "{0}", whereSqlCondition), adapter.sqlConnection);
            //adapter.DataGrid_Fill(adapter.sqlCommand, orderDataGrid, 4);
        }

        // Добавляет в базу новый заказ
        private void OrderGrid_Add()
        {
            adapter.TableAdapter = new Order();
            // adapter.InsertData({ТекстБоксы и Комбобоксы с данными});
        }

        private void OrderGrid_Remove()
        {
            adapter.TableAdapter = new Order();
            // adapter.RemoveData({Комбобокс с значением});
        }

        private void TentGrid_Fill()
        {
            adapter.sqlCommand = new SqlCommand("SELECT model, tentType, numberOfSeats, color, basePrice FROM boat", adapter.sqlConnection);
            // adapter.DataGrid_Fill(adapter.sqlCommand, modelDataGrid, 5);
        }

        private void TentGrid_Add()
        {
            adapter.TableAdapter = new Tent();
            // adapter.InsertData({Текстбоксы и комбобоксы с данными});
        }

        private void TentGrid_Remove()
        {
            adapter.TableAdapter = new Tent();
            // adapter.RemoveData({Комбобокс с значением});
        }
        
    }
}
