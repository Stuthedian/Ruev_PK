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
            dateTimePicker1.Visible = false;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].HeaderText.Contains("data"))
            {
                Rectangle rect1;
                rect1 = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                dateTimePicker1.Location = new Point(dataGridView1.Location.X + rect1.Location.X,
                        dataGridView1.Location.Y + rect1.Location.Y);
                dateTimePicker1.Width = rect1.Width;
                if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != DBNull.Value)
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                dateTimePicker1.Visible = true;
            }
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText.Contains("data"))
            {
                dateTimePicker1.Visible = false;
                //((DataRowView)postavkaBindingSource.Current)[dataGridView1.Columns[e.ColumnIndex].HeaderText] = 
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 
                dateTimePicker1.Value.ToShortDateString();
            }
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var current_row = dataGridView1.Rows[e.RowIndex];
            if (current_row.Cells["produkt"].Value == DBNull.Value || current_row.Cells["postavshik"].Value == DBNull.Value
                || current_row.Cells["data"].Value == null)
            {
                e.Cancel = true;
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["produkt"].Value == null || current_row.Cells["produkt"].Value == null)
                    continue;
                if (row.Index != e.RowIndex &&
                    row.Cells["postavshik"].Value.ToString() == current_row.Cells["postavshik"].Value.ToString() &&
                    row.Cells["produkt"].Value.ToString() == current_row.Cells["produkt"].Value.ToString() &&
                    row.Cells["data"].Value.ToString() == current_row.Cells["data"].Value.ToString())
                {
                    MessageBox.Show("В день поставщик может поставлять один и тот же товар только один раз");
                    e.Cancel = true;
                    break;
                }
            }
        }
    }
}
