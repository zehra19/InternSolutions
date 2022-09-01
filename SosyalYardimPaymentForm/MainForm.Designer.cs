namespace SosyalYardimPaymentForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbTckn = new System.Windows.Forms.TextBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odemeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcknDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeKdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenecekTtrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenecekDtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apiSosyalOdemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apiSosyalOdemeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTckn
            // 
            this.tbTckn.Location = new System.Drawing.Point(140, 12);
            this.tbTckn.Name = "tbTckn";
            this.tbTckn.Size = new System.Drawing.Size(100, 23);
            this.tbTckn.TabIndex = 0;
            this.tbTckn.Text = "73264108947";
            this.tbTckn.TextChanged += new System.EventHandler(this.tbTckn_TextChanged_1);
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(256, 12);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(138, 23);
            this.btnSorgula.TabIndex = 1;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeNoDataGridViewTextBoxColumn,
            this.tcknDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyAdiDataGridViewTextBoxColumn,
            this.odemeKdDataGridViewTextBoxColumn,
            this.odenecekTtrDataGridViewTextBoxColumn,
            this.odenecekDtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.apiSosyalOdemeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(745, 238);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // odemeNoDataGridViewTextBoxColumn
            // 
            this.odemeNoDataGridViewTextBoxColumn.DataPropertyName = "odemeNo";
            this.odemeNoDataGridViewTextBoxColumn.HeaderText = "odemeNo";
            this.odemeNoDataGridViewTextBoxColumn.Name = "odemeNoDataGridViewTextBoxColumn";
            this.odemeNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tcknDataGridViewTextBoxColumn
            // 
            this.tcknDataGridViewTextBoxColumn.DataPropertyName = "tckn";
            this.tcknDataGridViewTextBoxColumn.HeaderText = "tckn";
            this.tcknDataGridViewTextBoxColumn.Name = "tcknDataGridViewTextBoxColumn";
            this.tcknDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "adi";
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            this.adiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyAdiDataGridViewTextBoxColumn
            // 
            this.soyAdiDataGridViewTextBoxColumn.DataPropertyName = "soyAdi";
            this.soyAdiDataGridViewTextBoxColumn.HeaderText = "soyAdi";
            this.soyAdiDataGridViewTextBoxColumn.Name = "soyAdiDataGridViewTextBoxColumn";
            this.soyAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odemeKdDataGridViewTextBoxColumn
            // 
            this.odemeKdDataGridViewTextBoxColumn.DataPropertyName = "odemeKd";
            this.odemeKdDataGridViewTextBoxColumn.HeaderText = "odemeKd";
            this.odemeKdDataGridViewTextBoxColumn.Name = "odemeKdDataGridViewTextBoxColumn";
            this.odemeKdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odenecekTtrDataGridViewTextBoxColumn
            // 
            this.odenecekTtrDataGridViewTextBoxColumn.DataPropertyName = "odenecekTtr";
            this.odenecekTtrDataGridViewTextBoxColumn.HeaderText = "odenecekTtr";
            this.odenecekTtrDataGridViewTextBoxColumn.Name = "odenecekTtrDataGridViewTextBoxColumn";
            this.odenecekTtrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odenecekDtDataGridViewTextBoxColumn
            // 
            this.odenecekDtDataGridViewTextBoxColumn.DataPropertyName = "odenecekDt";
            this.odenecekDtDataGridViewTextBoxColumn.HeaderText = "odenecekDt";
            this.odenecekDtDataGridViewTextBoxColumn.Name = "odenecekDtDataGridViewTextBoxColumn";
            this.odenecekDtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apiSosyalOdemeBindingSource
            // 
            this.apiSosyalOdemeBindingSource.DataSource = typeof(SosyalYardimPaymentForm.DTO.ApiSosyalOdeme);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.tbTckn);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apiSosyalOdemeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbTckn;
        private Button btnSorgula;
        private DataGridView dataGridView1;
        private EventHandler tbTckn_TextChanged;
        private DataGridViewTextBoxColumn odemeNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tcknDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn odemeKdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn odenecekTtrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn odenecekDtDataGridViewTextBoxColumn;
        private BindingSource apiSosyalOdemeBindingSource;
    }
}