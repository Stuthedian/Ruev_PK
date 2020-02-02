using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab1_2sem
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add(" ", " ");
            dataGridView1.Columns.Add(" ", " ");
            string dd;
            int kol_col = 0;
            foreach (Produkt p in Form1.produkts)
            {
                dataGridView1.Columns.Add(p.name, p.name);
                kol_col++;
            }
            dataGridView1.Columns.Add("", "Итого");
            double[] sst = new double[kol_col + 1];
            int[] kol_it = new int[kol_col + 1];
            dataGridView1.Rows.Add(Form1.postavshiks.Count + 1);
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = "Итого";

            int kol, kolnull; double? v; //Данные для ячеек
            //// Заполнение datagridview по строкам
            for (int i = 0; i < Form1.postavshiks.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Form1.postavshiks[i].gorod;
                dataGridView1.Rows[i].Cells[1].Value = Form1.postavshiks[i].name;
                for (int j = 0; j < kol_col; j++)
                {
                    v = Form1.produkts[j].objem_post(Form1.postavshiks[i].cod);
                    dataGridView1.Rows[i].Cells[j + 2].Value = 
                        "test";
                }
                //int kolp = 0; double sp = 0; // Итоги в строке
                //    kolnull = Form1.produkts[i].kolnull(int.Parse(dataGridView1.Columns[j].Name));
                //    kol = Form1.produkts[i].kol(int.Parse(dataGridView1.Columns[j].Name));
                //    // методы: кол-во поставок и объем 
                //    v = Form1.produkts[i].vol(int.Parse(dataGridView1.Columns[j].Name));
                //    if (kol > 0)
                //    {
                //        if (v.HasValue)
                //        {
                //            sst[j] += v.Value; sp += v.Value;
                //        }
                //        kol_it[j] += kol; kolp += kol;
                //        dd = "Поставлено(кг)=" + v.ToString() + "\n количество поставок \n без объема=" + kol.ToString();
                //    }
                //    else
                //        dd = ""; // kol=0
                //    dataGridView1.Rows[i].Cells[j].Value = dd;

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
