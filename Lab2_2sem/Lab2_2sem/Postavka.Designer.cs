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
            this.dataSet1 = new Lab2_2sem.DataSet1();
            this.postavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavkaTableAdapter = new Lab2_2sem.DataSet1TableAdapters.PostavkaTableAdapter();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktTableAdapter = new Lab2_2sem.DataSet1TableAdapters.ProduktTableAdapter();
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikTableAdapter = new Lab2_2sem.DataSet1TableAdapters.PostavshikTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codpostshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataproizvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.codprDataGridViewTextBoxColumn,
            this.codpostshDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
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
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // produktBindingSource
            // 
            this.produktBindingSource.DataMember = "Produkt";
            this.produktBindingSource.DataSource = this.dataSet1;
            // 
            // produktTableAdapter
            // 
            this.produktTableAdapter.ClearBeforeFill = true;
            // 
            // postavshikBindingSource
            // 
            this.postavshikBindingSource.DataMember = "Postavshik";
            this.postavshikBindingSource.DataSource = this.dataSet1;
            // 
            // postavshikTableAdapter
            // 
            this.postavshikTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cod_pr";
            this.Column1.DataSource = this.produktBindingSource;
            this.Column1.DisplayMember = "nazv";
            this.Column1.HeaderText = "produkt";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "cod_pr";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cod_postsh";
            this.Column2.DataSource = this.postavshikBindingSource;
            this.Column2.DisplayMember = "nazv";
            this.Column2.HeaderText = "postavshik";
            this.Column2.Name = "Column2";
            this.Column2.ValueMember = "cod_postsh";
            // 
            // codprDataGridViewTextBoxColumn
            // 
            this.codprDataGridViewTextBoxColumn.DataPropertyName = "cod_pr";
            this.codprDataGridViewTextBoxColumn.HeaderText = "cod_pr";
            this.codprDataGridViewTextBoxColumn.Name = "codprDataGridViewTextBoxColumn";
            this.codprDataGridViewTextBoxColumn.Visible = false;
            // 
            // codpostshDataGridViewTextBoxColumn
            // 
            this.codpostshDataGridViewTextBoxColumn.DataPropertyName = "cod_postsh";
            this.codpostshDataGridViewTextBoxColumn.HeaderText = "cod_postsh";
            this.codpostshDataGridViewTextBoxColumn.Name = "codpostshDataGridViewTextBoxColumn";
            this.codpostshDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "Postavka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkt";
            this.Load += new System.EventHandler(this.Produkt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpostshDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataproizvDataGridViewTextBoxColumn;
    }
}