using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNetwork
{
    public partial class Tents : Form
    {
        public Tents()
        {
            InitializeComponent();
        }

        private void AddTents_Click(object sender, EventArgs e)
        {
            Form AddTents = new AddTents();
            AddTents.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
