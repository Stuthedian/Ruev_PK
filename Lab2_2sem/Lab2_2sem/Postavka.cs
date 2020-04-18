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
                if(dataGridView1.Columns[e.ColumnIndex].HeaderText.Contains("proizv"))
                {
                    dataGridView1.KeyPress += DataGridView1_KeyPress;
                }
            }
        }

        private void DataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                dataGridView1.KeyPress -= DataGridView1_KeyPress;
                DataGridViewCellEventArgs dataGrid =
                    new DataGridViewCellEventArgs(dataGridView1.CurrentCell.ColumnIndex,
                    dataGridView1.CurrentCell.RowIndex);
                dataGridView1_CellLeave(sender, dataGrid);
                dataGridView1.CurrentCell.Value = DBNull.Value;
            }
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText.Contains("data"))
            {
                if (dateTimePicker1.Visible == false)
                    return;
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
                || current_row.Cells["data"].Value == DBNull.Value)
            {
                e.Cancel = true;
                return;
            }
            if (current_row.Cells[5].Value != DBNull.Value)
            {
                if (Convert.ToInt32(current_row.Cells[5].Value) < 1)
                {
                    MessageBox.Show("Запрет на отрицательный объем!");
                    e.Cancel = true;
                    return;
                }
            }
            if (current_row.Cells[6].Value != DBNull.Value)
            {
                if (Convert.ToInt32(current_row.Cells[6].Value) < 1)
                {
                    MessageBox.Show("Запрет на отрицательный стоимость!");
                    e.Cancel = true;
                    return;
                }
            }
            if (current_row.Cells[7].Value != DBNull.Value)
            {
                if (Convert.ToInt32(current_row.Cells[7].Value) < 1)
                {
                    MessageBox.Show("Запрет на отрицательный срок!");
                    e.Cancel = true;
                    return;
                }
            }
            if (current_row.Cells[8].Value != DBNull.Value)
            {
                if (current_row.Cells[4].Value != DBNull.Value)
                {
                    if (Convert.ToDateTime(current_row.Cells[8].Value) < Convert.ToDateTime(current_row.Cells[4].Value))
                    {
                        MessageBox.Show("Дата поствки не меньше даты производства!");
                        e.Cancel = true;
                        return;
                    }
                }
                    
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
            Form1.edited.Value = true;
        }
    }
}
