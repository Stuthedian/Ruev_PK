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
    public partial class Form1 : Form
    {
        public static DataSet1 dataSet = new DataSet1();
        public Form1()
        {
            InitializeComponent();
        }

        private void продуктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Produkt().ShowDialog();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Postavshik().ShowDialog();
        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Postavka().ShowDialog();
        }
        DataSet1TableAdapters.ProduktTableAdapter ProduktTableAdapter = new DataSet1TableAdapters.ProduktTableAdapter();
        DataSet1TableAdapters.PostavshikTableAdapter PostavshikTableAdapter= new DataSet1TableAdapters.PostavshikTableAdapter();
        DataSet1TableAdapters.PostavkaTableAdapter PostavkaTableAdapter = new DataSet1TableAdapters.PostavkaTableAdapter();
        private void Form1_Load(object sender, EventArgs e)
        {
            ProduktTableAdapter.Fill(dataSet.Produkt);
            PostavshikTableAdapter.Fill(dataSet.Postavshik);
            PostavkaTableAdapter.Fill(dataSet.Postavka);
            //new DataSet1TableAdapters.ProduktTableAdapter().Fill(dataSet.Produkt);
            //new DataSet1TableAdapters.PostavshikTableAdapter().Fill(dataSet.Postavshik);
            //new DataSet1TableAdapters.PostavkaTableAdapter().Fill(dataSet.Postavka);
            edited.Value = false;
        }

        private void продуктыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ProduktView(dataSet, false).ShowDialog();
        }

        private void поставщикиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new PostavshikView(dataSet, false).ShowDialog();
        }

        private void поставкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new PostavkaView(dataSet, false).ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edited.Value)
            {
                if (DialogResult.Yes == MessageBox.Show("Сохранить изменения в БД?", "Внимание", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        ProduktTableAdapter.Adapter.ContinueUpdateOnError = true;
                        PostavshikTableAdapter.Adapter.ContinueUpdateOnError = true;
                        PostavkaTableAdapter.Adapter.ContinueUpdateOnError = true;
                        ProduktTableAdapter.Update(dataSet.Produkt);
                        PostavshikTableAdapter.Update(dataSet.Postavshik);
                        PostavkaTableAdapter.Update(dataSet.Postavka);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    dataSet.RejectChanges();
                    edited.Value = false;
                }
                if (DialogResult.No == MessageBox.Show("Выйти?", "Выход", MessageBoxButtons.YesNo))
                {
                    e.Cancel = true;
                    edited.Value = false;
                }
            }
        }
        public static class edited
        {
            public static bool Value { get; set; }
        }
    }
}
