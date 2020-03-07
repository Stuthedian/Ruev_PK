namespace Lab2_2sem
{
    partial class Postavshik
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
            this.codpostshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Lab2_2sem.DataSet1();
            this.postavshikTableAdapter = new Lab2_2sem.DataSet1TableAdapters.PostavshikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codpostshDataGridViewTextBoxColumn,
            this.nazvDataGridViewTextBoxColumn,
            this.gorodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postavshikBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // codpostshDataGridViewTextBoxColumn
            // 
            this.codpostshDataGridViewTextBoxColumn.DataPropertyName = "cod_postsh";
            this.codpostshDataGridViewTextBoxColumn.HeaderText = "cod_postsh";
            this.codpostshDataGridViewTextBoxColumn.Name = "codpostshDataGridViewTextBoxColumn";
            this.codpostshDataGridViewTextBoxColumn.ReadOnly = true;
            this.codpostshDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazvDataGridViewTextBoxColumn
            // 
            this.nazvDataGridViewTextBoxColumn.DataPropertyName = "nazv";
            this.nazvDataGridViewTextBoxColumn.HeaderText = "nazv";
            this.nazvDataGridViewTextBoxColumn.Name = "nazvDataGridViewTextBoxColumn";
            // 
            // gorodDataGridViewTextBoxColumn
            // 
            this.gorodDataGridViewTextBoxColumn.DataPropertyName = "gorod";
            this.gorodDataGridViewTextBoxColumn.HeaderText = "gorod";
            this.gorodDataGridViewTextBoxColumn.Name = "gorodDataGridViewTextBoxColumn";
            // 
            // postavshikBindingSource
            // 
            this.postavshikBindingSource.DataMember = "Postavshik";
            this.postavshikBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavshikTableAdapter
            // 
            this.postavshikTableAdapter.ClearBeforeFill = true;
            // 
            // Postavshik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 361);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Postavshik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkt";
            this.Load += new System.EventHandler(this.Produkt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource postavshikBindingSource;
        private DataSet1TableAdapters.PostavshikTableAdapter postavshikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpostshDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorodDataGridViewTextBoxColumn;
    }
}