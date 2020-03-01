namespace Lab2_2sem
{
    partial class PostavkaView
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
            this.MainGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectedGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGridView
            // 
            this.MainGridView.AllowUserToAddRows = false;
            this.MainGridView.AllowUserToDeleteRows = false;
            this.MainGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGridView.Location = new System.Drawing.Point(12, 12);
            this.MainGridView.Name = "MainGridView";
            this.MainGridView.ReadOnly = true;
            this.MainGridView.RowHeadersVisible = false;
            this.MainGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGridView.Size = new System.Drawing.Size(317, 150);
            this.MainGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SelectedGridView);
            this.panel1.Location = new System.Drawing.Point(3, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 91);
            this.panel1.TabIndex = 1;
            // 
            // SelectedGridView
            // 
            this.SelectedGridView.AllowUserToAddRows = false;
            this.SelectedGridView.AllowUserToDeleteRows = false;
            this.SelectedGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedGridView.Location = new System.Drawing.Point(9, 3);
            this.SelectedGridView.Name = "SelectedGridView";
            this.SelectedGridView.ReadOnly = true;
            this.SelectedGridView.RowHeadersVisible = false;
            this.SelectedGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectedGridView.Size = new System.Drawing.Size(317, 84);
            this.SelectedGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(156, 210);
            this.textBox1.TabIndex = 4;
            // 
            // IspolnitelView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(503, 273);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "IspolnitelView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IspolnitelView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IspolnitelView_FormClosing);
            this.Load += new System.EventHandler(this.IspolnitelView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView SelectedGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}