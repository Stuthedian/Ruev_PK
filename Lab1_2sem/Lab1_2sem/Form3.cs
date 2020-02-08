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
            
            foreach (Produkt p in Form1.produkts)
            {
                dataGridView1.Columns.Add(p.name, p.name);
            }
            dataGridView1.Columns.Add("", "Итого");
            
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
            int colvo_produktov = Form1.produkts.Count;
            double?[,] itog_po_produktam = new double?[colvo_produktov + 1, 3];
            

            for (int i = 0; i < Form1.postavshiks.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Form1.postavshiks[i].gorod;
                dataGridView1.Rows[i].Cells[1].Value = Form1.postavshiks[i].name;
                for (int j = 0; j < colvo_produktov; j++)
                {
                    dd = "";
                    v = Form1.produkts[j].objem_post(Form1.postavshiks[i].cod);
                    if(!itog_po_produktam[j, 0].HasValue)
                        itog_po_produktam[j, 0] = v;
                    else if(v.HasValue)
                        itog_po_produktam[j, 0] += v;
                    dd += v.HasValue ? "Всего=" + v.Value : "";
                    dd += "\n";

                    v = Form1.produkts[j].objem_post(Form1.postavshiks[i].cod, 
                        dateTimePicker1.Value, dateTimePicker2.Value);
                    if (!itog_po_produktam[j, 1].HasValue)
                        itog_po_produktam[j, 1] = v;
                    else if (v.HasValue)
                        itog_po_produktam[j, 1] += v;
                    dd += v.HasValue ? "За период=" + v.Value : "";
                    dd += "\n";

                    v = Form1.produkts[j].max_post(Form1.postavshiks[i].cod,
                        dateTimePicker1.Value, dateTimePicker2.Value);
                    if (!itog_po_produktam[j, 2].HasValue)
                        itog_po_produktam[j, 2] = v;
                    else if (v.HasValue)
                        itog_po_produktam[j, 2] = v > itog_po_produktam[j, 2] ? v : itog_po_produktam[j, 2];
                    
                    dd += v.HasValue ? "Максимум=" + v.Value : "";

                    dataGridView1.Rows[i].Cells[j + 2].Value = dd;   
                }

                dd = "";
                vs = Form1.produkts.Select(p => p.objem_post(Form1.postavshiks[i].cod));
                v = vs.Any(elem => elem.HasValue) ? vs.Sum() : null;
                if (!itog_po_produktam[colvo_produktov, 0].HasValue)
                    itog_po_produktam[colvo_produktov, 0] = v;
                else if (v.HasValue)
                    itog_po_produktam[colvo_produktov, 0] += v;
                dd += v.HasValue ? "Всего=" + v.Value : "";
                dd += "\n";

                vs = Form1.produkts.Select(p => p.objem_post(Form1.postavshiks[i].cod,
                        dateTimePicker1.Value, dateTimePicker2.Value));
                v = vs.Any(elem => elem.HasValue) ? vs.Sum() : null;
                if (!itog_po_produktam[colvo_produktov, 1].HasValue)
                    itog_po_produktam[colvo_produktov, 1] = v;
                else if (v.HasValue)
                    itog_po_produktam[colvo_produktov, 1] += v;
                dd += v.HasValue ? "За период=" + v.Value : "";
                dd += "\n";

                vs = Form1.produkts.Select(p => p.max_post(Form1.postavshiks[i].cod,
                        dateTimePicker1.Value, dateTimePicker2.Value));
                v = vs.Any(elem => elem.HasValue) ? vs.Max() : null;
                if (!itog_po_produktam[colvo_produktov, 2].HasValue)
                    itog_po_produktam[colvo_produktov, 2] = v;
                else if (v.HasValue)
                    itog_po_produktam[colvo_produktov, 2] = 
                        v > itog_po_produktam[colvo_produktov, 2] ? v : itog_po_produktam[colvo_produktov, 2];
                dd += v.HasValue ? "Максимум=" + v.Value : "";
                dd += "\n";

                dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1].Value = dd;
            }

            for (int i = 0; i < colvo_produktov + 1; i++)
            {
                dd = "";
                dd += itog_po_produktam[i, 0].HasValue ? "Всего=" + itog_po_produktam[i, 0].Value : "";
                dd += "\n";                             

                dd += itog_po_produktam[i, 1].HasValue ? "За период=" + itog_po_produktam[i, 1].Value : "";
                dd += "\n";
                                
                dd += itog_po_produktam[i, 2].HasValue ? "Максимум=" + itog_po_produktam[i, 2].Value : "";

                dataGridView1.Rows[Form1.postavshiks.Count].Cells[i + 2].Value = dd;
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
