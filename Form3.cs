using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_store
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          .
            this.orders_and_customersTableAdapter.Fill(this._The_IP_of_the_electronic_store_DataSet.Orders_and_customers);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
          .
            this.marceting_materialTableAdapter.Fill(this._The_IP_of_the_electronic_store_DataSet2.Marceting_material);

        }
    }
}
