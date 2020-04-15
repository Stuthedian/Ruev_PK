using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;

namespace Lab3
{
    public partial class Form1 : Form
    {
        XElement doc;
        Root root;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             Создание xml'ки!!
             */
            doc = XElement.Load(@"../../Zaselenie.xml");
            root = new Root();
            root.komnatas = new List<Komnata>();
            root.clients = new List<Client>();

            List<Zaselenie> zaselenies = new List<Zaselenie>();
            foreach (var komnata in doc.Elements("комната"))
            {
                zaselenies.Clear();
                foreach (var zaselenie in komnata.Elements("заселение"))
                {
                    zaselenies.Add(new Zaselenie()
                    {
                        cod = Convert.ToInt32(zaselenie.Element("код_кл").Value),
                        cena = Convert.ToDouble(zaselenie.Element("Цена").Value, CultureInfo.InvariantCulture),
                        date_zas = Convert.ToDateTime(zaselenie.Element("дата_заселения").Value),
                        date_osv = Convert.ToDateTime(zaselenie.Element("дата_освобождения").Value)
                    });
                }
                root.komnatas.Add(new Komnata()
                {
                    nomer = Convert.ToInt32(komnata.Attribute("номер").Value),
                    vmestimost = Convert.ToInt32(komnata.Element("вместимость").Value),
                    zaselenies = zaselenies.ToList()
                });
            }

            foreach (var client in doc.Element("клиенты").Elements("клиент"))
            {
                root.clients.Add(new Client()
                {
                    cod = Convert.ToInt32(client.Element("код_кл").Value),
                    fio = client.Element("фио").Value,
                    pol = client.Element("пол").Value[0]
                });
            }

            dataGridView1.DataSource = root.komnatas.Select(n => new { номер = n.nomer, вместимость = n.vmestimost }).ToArray();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            DataGridView1_SelectionChanged(sender, e);

            comboBox1.DataSource = root.komnatas.Select(n => n.nomer).ToArray();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            ComboBox1_SelectedIndexChanged(sender, e);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = root.komnatas.Where(n => n.nomer.ToString() == comboBox1.SelectedItem.ToString())
                .Select(n => new
                {
                    кол_во = n.zaselenies.Count,
                    кол_во_разных = n.zaselenies.Select(cl => cl.cod).Distinct().Count()
                }).ToArray();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = root.komnatas
                .Where(elem => elem.nomer.ToString() == dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                .Single().zaselenies
                .Select(elem => new
                {
                    клиент = root.clients.Where(n => n.cod == elem.cod).Single().fio,
                    Цена = elem.cena,
                    дата_заселения = elem.date_zas,
                    дата_освобождения = elem.date_osv
                }).ToArray();
        }
    }
}
