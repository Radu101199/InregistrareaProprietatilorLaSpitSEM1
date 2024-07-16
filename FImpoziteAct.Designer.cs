
namespace Proiect10
{
    partial class FImpoziteAct
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
            this.txtNrImpozit = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Proiect10.DataSet2();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipProprietate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impozitAnualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idImpozitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdContinut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewContinutImpozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.impoziteDS = new Proiect10.impoziteDS();
            this.view_ContinutImpozitTableAdapter = new Proiect10.impoziteDSTableAdapters.View_ContinutImpozitTableAdapter();
            this.clientiTableAdapter = new Proiect10.DataSet2TableAdapters.ClientiTableAdapter();
            this.lblOp = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewContinutImpozitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impoziteDS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNrImpozit
            // 
            this.txtNrImpozit.Enabled = false;
            this.txtNrImpozit.Location = new System.Drawing.Point(72, 54);
            this.txtNrImpozit.Name = "txtNrImpozit";
            this.txtNrImpozit.Size = new System.Drawing.Size(121, 20);
            this.txtNrImpozit.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "Clienti";
            this.clientiBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(316, 50);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 4;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(577, 150);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NrImpozit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Anul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Client";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrcDataGridViewTextBoxColumn,
            this.IdTipProprietate,
            this.impozitAnualDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn,
            this.idImpozitDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn,
            this.IdContinut});
            this.dataGridView1.DataSource = this.viewContinutImpozitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            // 
            // IdTipProprietate
            // 
            this.IdTipProprietate.DataPropertyName = "IdTipProprietate";
            this.IdTipProprietate.HeaderText = "IdTipProprietate";
            this.IdTipProprietate.Name = "IdTipProprietate";
            // 
            // impozitAnualDataGridViewTextBoxColumn
            // 
            this.impozitAnualDataGridViewTextBoxColumn.DataPropertyName = "ImpozitAnual";
            this.impozitAnualDataGridViewTextBoxColumn.HeaderText = "ImpozitAnual";
            this.impozitAnualDataGridViewTextBoxColumn.Name = "impozitAnualDataGridViewTextBoxColumn";
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            // 
            // idImpozitDataGridViewTextBoxColumn
            // 
            this.idImpozitDataGridViewTextBoxColumn.DataPropertyName = "IdImpozit";
            this.idImpozitDataGridViewTextBoxColumn.HeaderText = "IdImpozit";
            this.idImpozitDataGridViewTextBoxColumn.Name = "idImpozitDataGridViewTextBoxColumn";
            this.idImpozitDataGridViewTextBoxColumn.Visible = false;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            // 
            // IdContinut
            // 
            this.IdContinut.DataPropertyName = "IdContinut";
            this.IdContinut.HeaderText = "IdContinut";
            this.IdContinut.Name = "IdContinut";
            this.IdContinut.Visible = false;
            // 
            // viewContinutImpozitBindingSource
            // 
            this.viewContinutImpozitBindingSource.DataMember = "View_ContinutImpozit";
            this.viewContinutImpozitBindingSource.DataSource = this.impoziteDS;
            // 
            // impoziteDS
            // 
            this.impoziteDS.DataSetName = "impoziteDS";
            this.impoziteDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_ContinutImpozitTableAdapter
            // 
            this.view_ContinutImpozitTableAdapter.ClearBeforeFill = true;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(589, 34);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(35, 13);
            this.lblOp.TabIndex = 11;
            this.lblOp.Text = "label5";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FImpoziteAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNrImpozit);
            this.Name = "FImpoziteAct";
            this.Text = "FImpoziteAct";
            this.Load += new System.EventHandler(this.FImpoziteAct_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewContinutImpozitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impoziteDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNrImpozit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private impoziteDS impoziteDS;
        private System.Windows.Forms.BindingSource viewContinutImpozitBindingSource;
        private impoziteDSTableAdapters.View_ContinutImpozitTableAdapter view_ContinutImpozitTableAdapter;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private DataSet2TableAdapters.ClientiTableAdapter clientiTableAdapter;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipProprietate;
        private System.Windows.Forms.DataGridViewTextBoxColumn impozitAnualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idImpozitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdContinut;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}