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
            dataGridView1.Columns.Add(" ", " ");
            dataGridView1.Columns.Add(" ", " ");
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

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string dd = "";
            double? v;
            IEnumerable<double?> vs;
            for (int i = 0; i < Form1.postavshiks.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Form1.postavshiks[i].gorod;
                dataGridView1.Rows[i].Cells[1].Value = Form1.postavshiks[i].name;
                for (int j = 0; j < Form1.produkts.Count(); j++)
                {
                    dd = "";
                    v = Form1.produkts[j].objem_post(Form1.postavshiks[i].cod);
                    dd += v.HasValue ? "Всего=" + v.Value : "";
                    dd += "\n";

                    v = Form1.produkts[j].objem_post(Form1.postavshiks[i].cod, 
                        dateTimePicker1.Value, dateTimePicker2.Value);
                    dd += v.HasValue ? "За период=" + v.Value : "";
                    dd += "\n";

                    v = Form1.produkts[j].max_post(Form1.postavshiks[i].cod,
                        dateTimePicker1.Value, dateTimePicker2.Value);
                    dd += v.HasValue ? "Максимум=" + v.Value : "";

                    dataGridView1.Rows[i].Cells[j + 2].Value = dd;   
                }

                dd = "";
                vs = Form1.produkts.Select(p => p.objem_post(Form1.postavshiks[i].cod));
                dd += vs.Any(elem => elem.HasValue) ? "Всего=" + vs.Sum().Value : "";
                dd += "\n";

                vs = Form1.produkts.Select(p => p.objem_post(Form1.postavshiks[i].cod,
                        dateTimePicker1.Value, dateTimePicker2.Value));
                dd += vs.Any(elem => elem.HasValue) ? "За период=" + vs.Sum().Value : "";
                dd += "\n";

                vs = Form1.produkts.Select(p => p.max_post(Form1.postavshiks[i].cod,
                        dateTimePicker1.Value, dateTimePicker2.Value));
                dd += vs.Any(elem => elem.HasValue) ? "Максимум=" + vs.Sum().Value : "";
                dd += "\n";

                dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1].Value = dd;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
