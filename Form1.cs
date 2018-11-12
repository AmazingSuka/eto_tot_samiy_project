﻿using System;
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

        // Заполняет DataGrid окна OrderList                           ------
        private void OrderGrid_FillWithCondition(string whereSqlCondition = "")
        {
            adapter.sqlCommand = new SqlCommand(String.Format("SELECT o.id, o.date, c.firstName, " +
                                                "c.familyName, ct.date, ct.depositPayed, ct.contractTotalPrice, m.name" +
                                                "FROM Orders as o " +
                                                "JOIN Manager as m ON m.id = o.salespersonID " +
                                                "JOIN Client as c ON c.id = o.customerID " +
                                                "JOIN Contract as ct ON o.id = ct.orderID " +
                                                "{0}", whereSqlCondition), adapter.sqlConnection);
            //adapter.DataGrid_Fill(adapter.sqlCommand, orderDataGrid, 8);
        }         

        // Добавляет в базу новый заказ
        private void OrderGrid_Add()
        {
            // adapter.InsertData({ТекстБоксы и Комбобоксы с данными});
        }

        private void OrderGrid_Remove()
        {
            // adapter.RemoveData({Комбобокс с значением});
        }

        // -------------------------------------------------------------------------------------------------------

        private void TentGrid_Fill()
        {
            adapter.sqlCommand = new SqlCommand("SELECT model, tentType, numberOfSeats, color, basePrice FROM boat", adapter.sqlConnection);
            // adapter.DataGrid_Fill(adapter.sqlCommand, modelDataGrid, 5);
        }

        private void TentGrid_Add()
        {
            // adapter.InsertData({Текстбоксы и комбобоксы с данными});
        }

        private void TentGrid_Remove()
        {
            // adapter.RemoveData({Комбобокс с значением});
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Tents = new Tents();
            Tents.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form Contracts = new Contracts();
            Contracts.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Acsessories = new AcsessoriesForm();
            Acsessories.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form Partners = new Partners();
            Partners.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Orders = new Orders();
            Orders.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form AcsessuaresTents = new AcsessuaresTents();
            AcsessuaresTents.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Clients = new Clients();
            Clients.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form Menegers = new Menegers();
            Menegers.Show();
        }

        // ------------------------------------------------------------------------------------------------------

        /* Функции редактирования, отправляют данные в базу
       с текстбоксов и комбобокса, которые так же используются в SelectDataForEdit*/

        //private void EditData(ITableAdapter tableAdapter, string[] value)
        //{
        //    adapter.TableAdapter = tableAdapter;
        //    adapter.EditData(value);
        //}

        //private void InsertData(ITableAdapter tableAdapter, string[] value)
        //{
        //    adapter.TableAdapter = tableAdapter;
        //    adapter.InsertData(value);
        //}

        //private void RemoveData(ITableAdapter tableAdapter, string id)
        //{
        //    adapter.TableAdapter = tableAdapter;
        //    adapter.RemoveData(id);
        //}
    }
}