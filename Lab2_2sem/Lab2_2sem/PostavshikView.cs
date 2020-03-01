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
    public partial class PostavshikView : Form
    {
        DataSet1 dataSet;
        DataView mainview, selectedview;
        //SaveView parent;
        bool is_error_handling;
        private void IspolnitelView_Load(object sender, EventArgs e)
        {
            textBox1.Visible = is_error_handling;
            MainGridView.RowHeadersVisible = is_error_handling;
            mainview = new DataView(dataSet.Postavshik);
            selectedview = new DataView(dataSet.Postavshik);

            mainview.RowStateFilter = DataViewRowState.Added | DataViewRowState.ModifiedCurrent | DataViewRowState.Deleted;
            selectedview.RowStateFilter = DataViewRowState.ModifiedOriginal;
            //if (mainview.Count == 0)
            //{
            //    MessageBox.Show("Нет измененных данных");
            //    Close();
            //    return;
            //}
            MainGridView.DataSource = mainview;
            SelectedGridView.DataSource = selectedview;

            //MainGridView.Columns["nazv"].HeaderText = "Исполнитель";
            MainGridView.Columns["cod_postsh"].Visible = false;
            panel1.Visible = false;
            this.MainGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGridView_CellEnter);
            if (MainGridView.Rows.Count != 0)
                MainGridView.CurrentCell = MainGridView.Rows[0].Cells["nazv"];        
            else
                button1.Enabled = false;
            MainGridView.Columns.Add("Статус", "Статус");
            MainGridView.AutoResizeColumns();
            MainGridView_DataBindingComplete(new object(), new DataGridViewBindingCompleteEventArgs(ListChangedType.Reset));
        }

        private void MainGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            mainview.Sort = "cod_postsh";
            int cod = (int)MainGridView.CurrentRow.Cells["cod_postsh"].Value;
            DataRow r = mainview[mainview.Find(cod)].Row;
            if(is_error_handling)
                textBox1.Text = r.RowError;
            if (r.RowState == DataRowState.Modified)
            {
                selectedview.RowFilter = "cod_postsh=" + cod;
                SelectedGridView.Columns["cod_postsh"].Visible = false;
                //SelectedGridView.Columns["nazv"].HeaderText = "Исполнитель";
                panel1.Visible = true;
            }
            else panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod = (int)MainGridView.CurrentRow.Cells["cod_postsh"].Value;
            DataRow r = mainview[mainview.Find(cod)].Row;
            if (r.RowState == DataRowState.Added && dataSet.Postavka.Select("cod_postsh=" + cod).Count() != 0)
            {
                MessageBox.Show("Есть записи с данным исполнителем");
                return;
            }
            r.ClearErrors();
            r.RejectChanges();
            if (MainGridView.RowCount == 0)
                button1.Enabled = false;
        }

        private void MainGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            mainview.Sort = "cod_postsh";
            for (int i = 0; i < MainGridView.Rows.Count; i++)
            {
                int cod = (int)MainGridView.Rows[i].Cells["cod_postsh"].Value;
                DataRow r = mainview[mainview.Find(cod)].Row;
                switch (r.RowState)
                {
                    case DataRowState.Added:
                        MainGridView.Rows[i].Cells["Статус"].Value = "Добавлен";
                        break;
                    case DataRowState.Deleted:
                        MainGridView.Rows[i].Cells["Статус"].Value = "Удален";
                        break;
                    default:
                        MainGridView.Rows[i].Cells["Статус"].Value = "Изменен";
                        break;
                }
            }
            MainGridView.Columns["Статус"].DisplayIndex = 0;
            this.MainGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.MainGridView_DataBindingComplete);
        }

        private void IspolnitelView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (is_error_handling)
            //    parent.null_child(ViewType.Ispolnitel);
        }

        //public IspolnitelView(SaveView p, DataSet ds, bool e)
        public PostavshikView(DataSet1 ds, bool e)
        {
            InitializeComponent();
            dataSet = ds;
            is_error_handling = e;
            //parent = p;
        }
    }
}
