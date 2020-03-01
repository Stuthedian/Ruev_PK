using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_2sem
{
    public partial class Produkt : Form
    {
        public Produkt()
        {
            InitializeComponent();
        }

        private void Produkt_Load(object sender, EventArgs e)
        {
            dataSet1 = Form1.dataSet;
            produktBindingSource.DataSource = dataSet1;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Produkt". При необходимости она может быть перемещена или удалена.
            //this.produktTableAdapter.Fill(this.dataSet1.Produkt);

        }
    }
}
