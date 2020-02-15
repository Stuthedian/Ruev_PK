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
    public partial class Form1 : Form
    {
        public static List<Produkt> produkts = new List<Produkt>();
        public static List<Postavshik> postavshiks = new List<Postavshik>();
        public static List<Bludo> bludos = new List<Bludo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();
            SqlDataReader red;

            con.ConnectionString = Properties.Settings.Default.con;
            com.Connection = con;
            com.CommandText = "select * from postavshiki";
            con.Open();
            red = com.ExecuteReader();
            while (red.Read())
                postavshiks.Add(new Postavshik()
                { 
                    cod = Convert.ToInt32(red[0].ToString()), 
                    name = red[1].ToString(), 
                    gorod = red[3].ToString()
                });
            red.Close();
            /*
            while (red.Read()) 
                produkts.Add(red[0].ToString());*/

            dataGridView5.DataSource = postavshiks.Select(r => new { r.name, r.gorod }).ToArray();

            com.CommandText = "select * from bluda";
            red = com.ExecuteReader();
            while (red.Read())
                bludos.Add(new Bludo()
                {
                    cod = Convert.ToInt32(red[0].ToString()),
                    name = red[1].ToString(),
                    trud = red[5].ToString() == "" ? null : (int?)Convert.ToInt32(red[5].ToString())
                });
            red.Close();

            dataGridView4.DataSource = bludos.Select(r => new { r.name, r.trud}).ToArray();

            com.CommandText = "select produkt, kol_vo, stoim, produkt.pr from produkt left join nalishie on produkt.pr = nalishie.pr";
            

            red = com.ExecuteReader();
            List<Sostav> sostav = new List<Sostav>();
            List<Postavki> postavki = new List<Postavki>();
            
            while (red.Read())
            {
                SqlCommand com2 = new SqlCommand();
                com2.Connection = con;
                com2.CommandText = "select bl, vec from sostav where sostav.pr = @pr";
                com2.Parameters.Add("@pr", SqlDbType.Int);
                com2.Parameters["@pr"].Value = red[3].ToString();

                SqlDataReader red2 = com2.ExecuteReader();
                while(red2.Read())
                {
                    sostav.Add(new Sostav() { bludo = Convert.ToInt32(red2[0].ToString()),
                                              ves = red2[1].ToString() == "" ? null : (double?)Convert.ToDouble(red2[1].ToString())
                    });
                }
                red2.Close();

                com2.CommandText = "select pc, kol, data, cena from postavki where postavki.pr = @pr";
                com2.Parameters["@pr"].Value = red[3].ToString();
                red2 = com2.ExecuteReader();
                while (red2.Read())
                {
                    postavki.Add(new Postavki()
                    {
                        postavshik = Convert.ToInt32(red2[0].ToString()),
                        date = DateTime.Parse(red2[2].ToString()),
                        objem = red2[1].ToString() == "" ? null : (double?)Convert.ToDouble(red2[1]),
                        stoim = red2[3].ToString() == "" ? null : (double?)Convert.ToDouble(red2[3])
                    });
                }
                red2.Close();

                produkts.Add(new Produkt()
                {
                    name = red[0].ToString(),
                    objem = red[1].ToString() == "" ? null : (double?)Convert.ToDouble(red[1].ToString()),
                    //stoim = Convert.ToDouble(red[2].ToString()),
                    sostav = sostav.ToList(),
                    postavki = postavki.ToList()
                });
                sostav.Clear();
                postavki.Clear();

            }
                
            red.Close();

            dataGridView1.DataSource = produkts.Select(r => new { r.name, r.objem/*, r.stoim*/ }).ToArray();
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count != 0)
            {
                dataGridView2.DataSource = produkts[dataGridView1.SelectedRows[0].Index].sostav.Join(bludos, s => s.bludo, b => b.cod,
                    (s, b) => new { b.name, s.ves }).ToArray();
                dataGridView3.DataSource = produkts[dataGridView1.SelectedRows[0].Index].postavki.Join(postavshiks, p => p.postavshik, pst => pst.cod,
                    (p, pst) => new { pst.name, pst.gorod, p.objem, p.stoim }).ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}
