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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Produkt> produkts = new List<Produkt>();
            List<Postavshik> postavshiks = new List<Postavshik>();
            List<Bludo> bludos = new List<Bludo>();

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
                    trud = Convert.ToInt32(red[5].ToString())
                });
            red.Close();

            dataGridView4.DataSource = bludos.Select(r => new { r.name, r.trud}).ToArray();

            com.CommandText = "select produkt, kol_vo, stoim, produkt.pr from produkt left join nalishie on produkt.pr = nalishie.pr";
            SqlCommand com2 = new SqlCommand();
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = Properties.Settings.Default.con;
            con2.Open();
            com2.Connection = con2;
            com2.CommandText = "select bl, vec from sostav where sostav.pr = @pr";
            com2.Parameters.Add("@pr", SqlDbType.Int);
            red = com.ExecuteReader();
            List<Sostav> sostav = new List<Sostav>();
            SqlDataReader red2;

            while (red.Read())
            {
                com2.Parameters["@pr"].Value = red[3].ToString();
                red2 = com2.ExecuteReader();
                while(red2.Read())
                {
                    sostav.Add(new Sostav() { bludo = Convert.ToInt32(red2[0].ToString()), ves = Convert.ToInt32(red2[1].ToString()) });
                }
                produkts.Add(new Produkt()
                {
                    name = red[0].ToString(),
                    objem = Convert.ToDouble(red[1].ToString()),
                    stoim = Convert.ToDouble(red[2].ToString()),
                    sostav = sostav.ToList()
                });
            }
                
            red.Close();
        }
    }
}
