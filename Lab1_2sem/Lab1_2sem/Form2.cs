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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add(" ", " ");
            string dd;
            int kol_col = Form1.produkts.Count;
            foreach (Produkt p in Form1.produkts){
                dataGridView1.Columns.Add(p.name, p.name);
                kol_col++;
            }
            dataGridView1.Columns.Add("", "Итого");
            double[] sst = new double[kol_col + 1];
            int[] kol_it = new int[kol_col + 1];
            dataGridView1.Rows.Add(Form1.bludos.Count + 1);

            int kol, kolnull; double? v; //Данные для ячеек
            // Заполнение datagridview по строкам
            for (int i = 0; i < Form1.bludos.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Form1.bludos[i].name;
                int kolp = 0; double sp = 0; // Итоги в строке
                for (int j = 1; j < kol_col; j++)
                { 
                    kolnull = Form1.produkts[i].kolnull(int.Parse(dataGridView1.Columns[j].Name));
                    kol = Form1.produkts[i].kol(int.Parse(dataGridView1.Columns[j].Name));
                    // методы: кол-во поставок и объем 
                    v =  Form1.produkts[i].vol(int.Parse(dataGridView1.Columns[j].Name)); 
                    if (kol > 0)
                    {
                        if (v.HasValue) 
                        { 
                            sst[j] += v.Value; sp += v.Value; 
                        }                     
                        kol_it[j] += kol; kolp += kol; 
                        dd = "Поставлено(кг)=" + v.ToString() + "\n количество поставок \n без объема=" + kol.ToString();}
                        else 
                            dd = ""; // kol=0
                        dataGridView1.Rows[i].Cells[j].Value = dd;

                }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
