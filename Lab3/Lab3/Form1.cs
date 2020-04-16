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
        Root root;
        public Form1()
        {
            InitializeComponent();
            root = new Root();
            root.komnatas = new List<Komnata>();
            root.clients = new List<Client>();
            generate_xml();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_xml("../../Zaselenie.xml");
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView5.DataSource = new int[]{ 1 }.Select(s => new
            {
                кол_во_заселений = root.komnatas
                .Select(k =>
                    k.zaselenies.Where(z => z.cod == root.clients
                    .Where(cl => cl.fio == comboBox3.SelectedItem.ToString()).Single().cod).Count()
                ).Sum(),
                кол_во_заселений_разные_комнаты = root.komnatas
                .Select(k =>
                    k.zaselenies.Where(z => z.cod == root.clients
                    .Where(cl => cl.fio == comboBox3.SelectedItem.ToString()).Single().cod).Count()
                ).Sum(n => n > 1 ? 1 : n)
            }).ToArray();
                
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView4.DataSource = root.komnatas.Where(n => n.nomer.ToString() == comboBox2.SelectedItem.ToString())
                .Select(n => new
                {
                    суммарная_стоимость = n.zaselenies.Sum(c => c.cena),
                    кол_во_женщин = n.zaselenies
                    .Where(z => root.clients.Where(cl => cl.cod == z.cod).Single().pol == 'ж').Count()
                }).ToArray();
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

        private void generate_xml()
        {
            XElement doc;
            Root temp_root = new Root()
            {
                komnatas = new List<Komnata>()
                {
                    new Komnata(){ nomer = 1, vmestimost = 2,
                        zaselenies = new List<Zaselenie>()
                        {
                            new Zaselenie() { cod = 1, cena = 1300,
                                date_zas = Convert.ToDateTime("2018.05.04"),
                                date_osv = Convert.ToDateTime("2018.06.04") }
                        } },
                    new Komnata(){ nomer = 11, vmestimost = 1,
                        zaselenies = new List<Zaselenie>()
                        {
                            new Zaselenie() { cod = 1, cena = 1300,
                                date_zas = Convert.ToDateTime("2018.05.04"),
                                date_osv = Convert.ToDateTime("2018.06.04") },
                            new Zaselenie() { cod = 2, cena = 1300.50,
                                date_zas = Convert.ToDateTime("2018.08.24"),
                                date_osv = Convert.ToDateTime("2018.06.04") }
                        } },
                    new Komnata(){ nomer = 12, vmestimost = 3,
                        zaselenies = new List<Zaselenie>()
                        {
                            new Zaselenie() { cod = 1, cena = 1300,
                                date_zas = Convert.ToDateTime("2018.06.02"),
                                date_osv = Convert.ToDateTime("2018.09.04") },
                            new Zaselenie() { cod = 2, cena = 1360.50,
                                date_zas = Convert.ToDateTime("2018.09.24"),
                                date_osv = Convert.ToDateTime("2018.12.04") },
                            new Zaselenie() { cod = 2, cena = 1380.80,
                                date_zas = Convert.ToDateTime("2018.02.24"),
                                date_osv = Convert.ToDateTime("2018.06.04") }
                        } }
                },
                clients = new List<Client>()
                {
                    new Client(){ cod = 1, fio = "Иванов А.Н.", pol = 'м'},
                    new Client(){ cod = 2, fio = "Иванова Н.А.", pol = 'ж'},
                    new Client(){ cod = 3, fio = "Петров В.А.", pol = 'м'}
                }
            };

            doc = new XElement("Root",
                temp_root.komnatas.Select(k =>
                new XElement("комната", new XAttribute("номер", k.nomer),
                    new XElement("вместимость", k.vmestimost),
                    k.zaselenies.Select(z => new XElement("заселение",
                        new XElement("код_кл", z.cod),
                        new XElement("Цена", z.cena),
                        new XElement("дата_заселения", z.date_zas.ToShortDateString()),
                        new XElement("дата_освобождения", z.date_osv.ToShortDateString()))))),
                new XElement("клиенты",
                    temp_root.clients
                    .Select(cl =>
                new XElement("клиент", new XElement("код_кл", cl.cod), new XElement("фио", cl.fio),
                    new XElement("пол", cl.pol)))
                )
                );
            doc.Save("../../Zaselenie.xml");
        }

        private void load_xml(string file)
        {
            root.komnatas.Clear();
            root.clients.Clear();

            XElement doc = XElement.Load(file);

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
            DataGridView1_SelectionChanged(new object(), EventArgs.Empty);

            comboBox1.DataSource = root.komnatas.Select(n => n.nomer).ToArray();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            ComboBox1_SelectedIndexChanged(new object(), EventArgs.Empty);

            comboBox2.DataSource = root.komnatas.Select(n => n.nomer).ToArray();
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            ComboBox2_SelectedIndexChanged(new object(), EventArgs.Empty);

            comboBox3.DataSource = root.clients.Select(n => n.fio).ToArray();
            comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;
            ComboBox3_SelectedIndexChanged(new object(), EventArgs.Empty);
        }

        private void сгенерироватьНовыйXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generate_xml();
        }

        private void загрузитьСуществующийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Xml файлы (*.xml)|*.xml";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.SelectionChanged -= DataGridView1_SelectionChanged;
                comboBox1.SelectedIndexChanged -= ComboBox1_SelectedIndexChanged;
                comboBox2.SelectedIndexChanged -= ComboBox2_SelectedIndexChanged;
                comboBox3.SelectedIndexChanged -= ComboBox3_SelectedIndexChanged;
            }
        }
    }
}
