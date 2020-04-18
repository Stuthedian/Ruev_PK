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
    public partial class Postavshik : Form
    {
        public Postavshik()
        {
            InitializeComponent();
        }

        private void Produkt_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Postavshik". При необходимости она может быть перемещена или удалена.
            //this.postavshikTableAdapter.Fill(this.dataSet1.Postavshik);
            dataSet1 = Form1.dataSet;
            postavshikBindingSource.DataSource = dataSet1;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Produkt". При необходимости она может быть перемещена или удалена.
            

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataRow temprow = dataSet1.Postavshik.Rows.Find(((DataRowView)postavshikBindingSource.Current)[0]);
                if (dataSet1.Postavka.Select("cod_postsh='" + temprow[0].ToString() + "'").Count() != 0)
                {
                    MessageBox.Show("Удаление не возможно. Данная строка используется в других таблицах.");
                    e.Handled = true;
                    return;
                }
                try
                {
                    temprow.Delete();
                    //brigadaTableAdapter.Update(dataSet1.Brigada);
                    //dataSet1.Brigada.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Form1.edited.Value = true;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.FormattedValue.ToString() == "")
            {
                MessageBox.Show("Названия обязательны!");
                e.Cancel = true;
            }
            if (e.FormattedValue.ToString().Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("Только буковы!");
                e.Cancel = true;
            }
            string nazv = "";
            string gor = "";
            if(e.ColumnIndex == 1)
            {
                nazv = e.FormattedValue.ToString();
                gor = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            if(e.ColumnIndex == 2)
            {
                gor = e.FormattedValue.ToString();
                nazv = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                if(dataGridView1.Rows[i].Cells[1].Value.ToString().ToLower() == nazv.ToLower() &&
                    dataGridView1.Rows[i].Cells[2].Value.ToString().ToLower() == gor.ToLower() && i != e.RowIndex)
                {
                    MessageBox.Show("В одном городе не может быть поставщика с одинаковым названием!");
                    e.Cancel = true;
                    break;
                }
            }
            Form1.edited.Value = true;
        }
    }
}
