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
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Lab2_2sem.DataSet1();
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavkaTableAdapter = new Lab2_2sem.DataSet1TableAdapters.PostavkaTableAdapter();
            this.produktTableAdapter = new Lab2_2sem.DataSet1TableAdapters.ProduktTableAdapter();
            this.postavshikTableAdapter = new Lab2_2sem.DataSet1TableAdapters.PostavshikTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.produkt = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.postavshik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cod_pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_postsh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataproizvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
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
            // postavshikBindingSource
            // 
            this.postavshikBindingSource.DataMember = "Postavshik";
            this.postavshikBindingSource.DataSource = this.dataSet1;
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
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // produkt
            // 
            this.produkt.DataPropertyName = "cod_pr";
            this.produkt.DataSource = this.produktBindingSource;
            this.produkt.DisplayMember = "nazv";
            this.produkt.HeaderText = "produkt";
            this.produkt.Name = "produkt";
            this.produkt.ValueMember = "cod_pr";
            // 
            // postavshik
            // 
            this.postavshik.DataPropertyName = "cod_postsh";
            this.postavshik.DataSource = this.postavshikBindingSource;
            this.postavshik.DisplayMember = "nazv";
            this.postavshik.HeaderText = "postavshik";
            this.postavshik.Name = "postavshik";
            this.postavshik.ValueMember = "cod_postsh";
            // 
            // cod_pr
            // 
            this.cod_pr.DataPropertyName = "cod_pr";
            this.cod_pr.HeaderText = "cod_pr";
            this.cod_pr.Name = "cod_pr";
            this.cod_pr.Visible = false;
            // 
            // cod_postsh
            // 
            this.cod_postsh.DataPropertyName = "cod_postsh";
            this.cod_postsh.HeaderText = "cod_postsh";
            this.cod_postsh.Name = "cod_postsh";
            this.cod_postsh.Visible = false;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "data";
            this.data.Name = "data";
            // 
            // objemDataGridViewTextBoxColumn
            // 
            this.objemDataGridViewTextBoxColumn.DataPropertyName = "objem";
            this.objemDataGridViewTextBoxColumn.HeaderText = "objem";
            this.objemDataGridViewTextBoxColumn.Name = "objemDataGridViewTextBoxColumn";
            // 
            // stoimDataGridViewTextBoxColumn
            // 
            this.stoimDataGridViewTextBoxColumn.DataPropertyName = "stoim";
            this.stoimDataGridViewTextBoxColumn.HeaderText = "stoim";
            this.stoimDataGridViewTextBoxColumn.Name = "stoimDataGridViewTextBoxColumn";
            // 
            // srokDataGridViewTextBoxColumn
            // 
            this.srokDataGridViewTextBoxColumn.DataPropertyName = "srok";
            this.srokDataGridViewTextBoxColumn.HeaderText = "srok";
            this.srokDataGridViewTextBoxColumn.Name = "srokDataGridViewTextBoxColumn";
            // 
            // dataproizvDataGridViewTextBoxColumn
            // 
            this.dataproizvDataGridViewTextBoxColumn.DataPropertyName = "data_proizv";
            this.dataproizvDataGridViewTextBoxColumn.HeaderText = "data_proizv";
            this.dataproizvDataGridViewTextBoxColumn.Name = "dataproizvDataGridViewTextBoxColumn";
            // 
            // Postavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 361);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
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