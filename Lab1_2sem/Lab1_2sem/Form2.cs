﻿using System;
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
            foreach (Produkt p in Form1.produkts)
            {
                dataGridView1.Columns.Add(p.name, p.name);
            }
            dataGridView1.Columns.Add("", "Итого");
            double[] sst = new double[kol_col + 1];
            int[] kol_it = new int[kol_col + 1];
            dataGridView1.Rows.Add(Form1.bludos.Count + 1);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            int kol, kolnull; double? v; //Данные для ячеек
            for (int i = 0; i < Form1.bludos.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Form1.bludos[i].name;
                int kolp = 0; double sp = 0; // Итоги в строке
                for (int j = 1; j < kol_col+1; j++)
                {
                    kolnull = Form1.produkts[j-1].kolnull(Form1.bludos[i].cod);
                    v = Form1.produkts[j - 1].vol(Form1.bludos[i].cod);
                    if (v > 0)
                        kol = Form1.produkts[j - 1].kol(Form1.bludos[i].cod);
                    else
                        kol = 0;
                    if (kol > 0)
                    {
                        if (v.HasValue)
                        {
                            sst[j] += v.Value; sp += v.Value;
                        }
                        kol_it[j]++;
                        kolp += kol;
                        dd = "Вес в блюде=" + v.ToString() + "\n порций=" + kol.ToString();
                    }
                    else
                        dd = "";
                    dataGridView1.Rows[i].Cells[j].Value = dd;
                }
                if (kolp > 0)
                    dd = "Вес в блюдах =" + sp.ToString() + "\n порций=" + kolp.ToString();
                else
                    dd = "";
                dataGridView1.Rows[i].Cells[kol_col+1].Value = dd;
            }
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "Итого";
            for (int j = 1; j < dataGridView1.Columns.Count-1; j++)
            {
                if (kol_it[j] > 0)
                    dd = "Количество блюд=" + kol_it[j].ToString();
                else
                    dd = "";
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[j].Value = dd;
            }
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
