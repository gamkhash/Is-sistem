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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_The_IP_of_the_electronic_store_DataSet1.List_of_the_betatesters". При необходимости она может быть перемещена или удалена.
            this.list_of_the_betatestersTableAdapter.Fill(this._The_IP_of_the_electronic_store_DataSet1.List_of_the_betatesters);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
