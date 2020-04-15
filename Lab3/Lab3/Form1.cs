﻿using System;
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
            
            doc = XElement.Load(@"../../Zaselenie.xml");
            root = new Root();
            root.komnatas = new List<Komnata>();
            root.clients = new List<Client>();

            Komnata temp_komnata = new Komnata();
            temp_komnata.zaselenies = new List<Zaselenie>();
            Zaselenie temp_zaselenie = new Zaselenie();
            foreach (var komnata in doc.Elements("комната"))
            {
                temp_komnata.nomer = Convert.ToInt32(komnata.Attribute("номер").Value);
                temp_komnata.vmestimost = Convert.ToInt32(komnata.Element("вместимость").Value);
                temp_komnata.zaselenies.Clear();
                foreach (var zaselenie in komnata.Elements("заселение"))
                {
                    temp_zaselenie.cod = Convert.ToInt32(zaselenie.Element("код_кл").Value);
                    temp_zaselenie.cena = Convert.ToDouble(zaselenie.Element("Цена").Value, CultureInfo.InvariantCulture);
                    temp_zaselenie.date_zas = Convert.ToDateTime(zaselenie.Element("дата_заселения").Value);
                    temp_zaselenie.date_osv = Convert.ToDateTime(zaselenie.Element("дата_освобождения").Value);
                }
                temp_komnata.zaselenies.Add(temp_zaselenie);
                root.komnatas.Add(temp_komnata);
            }

            Client temp_client = new Client();
            foreach (var client in doc.Element("клиенты").Elements("клиент"))
            {
                temp_client.cod = Convert.ToInt32(client.Element("код_кл").Value);
                temp_client.fio = client.Element("фио").Value;
                temp_client.pol = client.Element("пол").Value[0];

                root.clients.Add(temp_client);
            }

            //    dataGridView1.DataSource = doc.Elements("комната").Attributes("номер")
            //    .Select(n => new { номер = n.Value, вместимость = n.Parent.Element("вместимость").Value } ).ToArray();
            //dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            //DataGridView1_SelectionChanged(sender, e);
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //dataGridView2.DataSource = doc.Elements("комната")
            //    .Where(elem => elem.Attribute("номер").Value == dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
            //    .Single().Elements("заселение")
            //    .Select(elem => new
            //    {
            //        Цена = elem.Element("Цена").Value,
            //        дата_заселения = elem.Element("дата_заселения").Value,
            //        дата_освобождения = elem.Element("дата_освобождения").Value
            //    }).ToArray();
        }
    }
}
