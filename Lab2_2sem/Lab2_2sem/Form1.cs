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

        private void Form1_Load(object sender, EventArgs e)
        {
            new DataSet1TableAdapters.ProduktTableAdapter().Fill(dataSet.Produkt);
            new DataSet1TableAdapters.PostavshikTableAdapter().Fill(dataSet.Postavshik);
            new DataSet1TableAdapters.PostavkaTableAdapter().Fill(dataSet.Postavka);
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
    }
}
