namespace Lab2_2sem
{
    partial class Produkt
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
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktTableAdapter = new Lab2_2sem.DataSet1TableAdapters.ProduktTableAdapter();
            this.codprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codprDataGridViewTextBoxColumn,
            this.nazvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produktBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // codprDataGridViewTextBoxColumn
            // 
            this.codprDataGridViewTextBoxColumn.DataPropertyName = "cod_pr";
            this.codprDataGridViewTextBoxColumn.HeaderText = "cod_pr";
            this.codprDataGridViewTextBoxColumn.Name = "codprDataGridViewTextBoxColumn";
            this.codprDataGridViewTextBoxColumn.ReadOnly = true;
            this.codprDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazvDataGridViewTextBoxColumn
            // 
            this.nazvDataGridViewTextBoxColumn.DataPropertyName = "nazv";
            this.nazvDataGridViewTextBoxColumn.HeaderText = "nazv";
            this.nazvDataGridViewTextBoxColumn.Name = "nazvDataGridViewTextBoxColumn";
            // 
            // Produkt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 361);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Produkt";
            this.Text = "Produkt";
            this.Load += new System.EventHandler(this.Produkt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private DataSet1TableAdapters.ProduktTableAdapter produktTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvDataGridViewTextBoxColumn;
    }
}