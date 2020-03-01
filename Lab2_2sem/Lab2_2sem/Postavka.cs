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
    public partial class Postavka : Form
    {
        public Postavka()
        {
            InitializeComponent();
        }

        private void Produkt_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Postavshik". При необходимости она может быть перемещена или удалена.
            //this.postavshikTableAdapter.Fill(this.dataSet1.Postavshik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Produkt". При необходимости она может быть перемещена или удалена.
            //this.produktTableAdapter.Fill(this.dataSet1.Produkt);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Postavka". При необходимости она может быть перемещена или удалена.
            //this.postavkaTableAdapter.Fill(this.dataSet1.Postavka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Postavshik". При необходимости она может быть перемещена или удалена.
            dataSet1 = Form1.dataSet;
            postavshikBindingSource.DataSource = dataSet1;
            produktBindingSource.DataSource = dataSet1;
            postavkaBindingSource.DataSource = dataSet1;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Produkt". При необходимости она может быть перемещена или удалена.
            

        }
    }
}
