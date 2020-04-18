namespace Lab2_2sem
{
    partial class Postavka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produkt = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Lab2_2sem.DataSet1();
            this.postavshik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cod_pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_postsh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataproizvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavkaTableAdapter = new Lab2_2sem.DataSet1TableAdapters.PostavkaTableAdapter();
            this.produktTableAdapter = new Lab2_2sem.DataSet1TableAdapters.ProduktTableAdapter();
            this.postavshikTableAdapter = new Lab2_2sem.DataSet1TableAdapters.PostavshikTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produkt,
            this.postavshik,
            this.cod_pr,
            this.cod_postsh,
            this.data,
            this.objemDataGridViewTextBoxColumn,
            this.stoimDataGridViewTextBoxColumn,
            this.srokDataGridViewTextBoxColumn,
            this.dataproizvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postavkaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(996, 444);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
            // 
            // produkt
            // 
            this.produkt.DataPropertyName = "cod_pr";
            this.produkt.DataSource = this.produktBindingSource;
            this.produkt.DisplayMember = "nazv";
            this.produkt.HeaderText = "produkt";
            this.produkt.MinimumWidth = 6;
            this.produkt.Name = "produkt";
            this.produkt.ValueMember = "cod_pr";
            this.produkt.Width = 125;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataMember = "Produkt";
            this.produktBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavshik
            // 
            this.postavshik.DataPropertyName = "cod_postsh";
            this.postavshik.DataSource = this.postavshikBindingSource;
            this.postavshik.DisplayMember = "nazv";
            this.postavshik.HeaderText = "postavshik";
            this.postavshik.MinimumWidth = 6;
            this.postavshik.Name = "postavshik";
            this.postavshik.ValueMember = "cod_postsh";
            this.postavshik.Width = 125;
            // 
            // postavshikBindingSource
            // 
            this.postavshikBindingSource.DataMember = "Postavshik";
            this.postavshikBindingSource.DataSource = this.dataSet1;
            // 
            // cod_pr
            // 
            this.cod_pr.DataPropertyName = "cod_pr";
            this.cod_pr.HeaderText = "cod_pr";
            this.cod_pr.MinimumWidth = 6;
            this.cod_pr.Name = "cod_pr";
            this.cod_pr.Visible = false;
            this.cod_pr.Width = 125;
            // 
            // cod_postsh
            // 
            this.cod_postsh.DataPropertyName = "cod_postsh";
            this.cod_postsh.HeaderText = "cod_postsh";
            this.cod_postsh.MinimumWidth = 6;
            this.cod_postsh.Name = "cod_postsh";
            this.cod_postsh.Visible = false;
            this.cod_postsh.Width = 125;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "data";
            this.data.MinimumWidth = 6;
            this.data.Name = "data";
            this.data.Width = 125;
            // 
            // objemDataGridViewTextBoxColumn
            // 
            this.objemDataGridViewTextBoxColumn.DataPropertyName = "objem";
            this.objemDataGridViewTextBoxColumn.HeaderText = "objem";
            this.objemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.objemDataGridViewTextBoxColumn.Name = "objemDataGridViewTextBoxColumn";
            this.objemDataGridViewTextBoxColumn.Width = 125;
            // 
            // stoimDataGridViewTextBoxColumn
            // 
            this.stoimDataGridViewTextBoxColumn.DataPropertyName = "stoim";
            this.stoimDataGridViewTextBoxColumn.HeaderText = "stoim";
            this.stoimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stoimDataGridViewTextBoxColumn.Name = "stoimDataGridViewTextBoxColumn";
            this.stoimDataGridViewTextBoxColumn.Width = 125;
            // 
            // srokDataGridViewTextBoxColumn
            // 
            this.srokDataGridViewTextBoxColumn.DataPropertyName = "srok";
            this.srokDataGridViewTextBoxColumn.HeaderText = "srok";
            this.srokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.srokDataGridViewTextBoxColumn.Name = "srokDataGridViewTextBoxColumn";
            this.srokDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataproizvDataGridViewTextBoxColumn
            // 
            this.dataproizvDataGridViewTextBoxColumn.DataPropertyName = "data_proizv";
            this.dataproizvDataGridViewTextBoxColumn.HeaderText = "data_proizv";
            this.dataproizvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataproizvDataGridViewTextBoxColumn.Name = "dataproizvDataGridViewTextBoxColumn";
            this.dataproizvDataGridViewTextBoxColumn.Width = 125;
            // 
            // postavkaBindingSource
            // 
            this.postavkaBindingSource.DataMember = "Postavka";
            this.postavkaBindingSource.DataSource = this.dataSet1;
            // 
            // postavkaTableAdapter
            // 
            this.postavkaTableAdapter.ClearBeforeFill = true;
            // 
            // produktTableAdapter
            // 
            this.produktTableAdapter.ClearBeforeFill = true;
            // 
            // postavshikTableAdapter
            // 
            this.postavshikTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 246);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Postavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 444);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Postavka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkt";
            this.Load += new System.EventHandler(this.Produkt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource postavkaBindingSource;
        private DataSet1TableAdapters.PostavkaTableAdapter postavkaTableAdapter;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private DataSet1TableAdapters.ProduktTableAdapter produktTableAdapter;
        private System.Windows.Forms.BindingSource postavshikBindingSource;
        private DataSet1TableAdapters.PostavshikTableAdapter postavshikTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewComboBoxColumn produkt;
        private System.Windows.Forms.DataGridViewComboBoxColumn postavshik;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_pr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_postsh;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn objemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataproizvDataGridViewTextBoxColumn;
    }
}