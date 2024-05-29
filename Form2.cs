using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Electronic_store
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Program.form2 = this;
            Program.form3 = new Form3();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            this.orders_and_customersTableAdapter.Fill(this._The_IP_of_the_electronic_store_DataSet.Orders_and_customers);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form3.Show();
        }
    }
}
