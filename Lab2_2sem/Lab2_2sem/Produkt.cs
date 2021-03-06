﻿using System;
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

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DataRow temprow = dataSet1.Produkt.Rows.Find(((DataRowView)produktBindingSource.Current)[0]);
                if (dataSet1.Postavka.Select("cod_pr='" + temprow[0].ToString() + "'").Count() != 0)
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
            if (e.FormattedValue.ToString() == "" )
            {
                MessageBox.Show("Названия обязательны!");
                e.Cancel = true;
            }
            if (e.FormattedValue.ToString().Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("Только буковы!");
                e.Cancel = true;
            }
            Form1.edited.Value = true;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //e.Control
        }        
    }
}
