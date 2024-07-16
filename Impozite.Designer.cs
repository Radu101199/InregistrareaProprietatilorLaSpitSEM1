
namespace Proiect10
{
    partial class Impozite
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
            this.IdImpozit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.impoziteDS = new Proiect10.impoziteDS();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.viewContinutImpozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImpozitNou = new System.Windows.Forms.Button();
            this.btnModificareImpozit = new System.Windows.Forms.Button();
            this.btnStergeImpozit = new System.Windows.Forms.Button();
            this.txtImpozit = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSpPoza = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.view_TotalTableAdapter = new Proiect10.impoziteDSTableAdapters.View_TotalTableAdapter();
            this.view_ContinutImpozitTableAdapter = new Proiect10.impoziteDSTableAdapters.View_ContinutImpozitTableAdapter();
            this.idImpozitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipProprietate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impozitAnualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdContinut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impoziteDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewContinutImpozitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdImpozit,
            this.nrcDataGridViewTextBoxColumn,
            this.anulDataGridViewTextBoxColumn,
            this.numeClientDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewTotalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdImpozit
            // 
            this.IdImpozit.DataPropertyName = "IdImpozit";
            this.IdImpozit.HeaderText = "IdImpozit";
            this.IdImpozit.Name = "IdImpozit";
            this.IdImpozit.Visible = false;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            // 
            // anulDataGridViewTextBoxColumn
            // 
            this.anulDataGridViewTextBoxColumn.DataPropertyName = "Anul";
            this.anulDataGridViewTextBoxColumn.HeaderText = "Anul";
            this.anulDataGridViewTextBoxColumn.Name = "anulDataGridViewTextBoxColumn";
            // 
            // numeClientDataGridViewTextBoxColumn
            // 
            this.numeClientDataGridViewTextBoxColumn.DataPropertyName = "NumeClient";
            this.numeClientDataGridViewTextBoxColumn.HeaderText = "NumeClient";
            this.numeClientDataGridViewTextBoxColumn.Name = "numeClientDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // viewTotalBindingSource
            // 
            this.viewTotalBindingSource.DataMember = "View_Total";
            this.viewTotalBindingSource.DataSource = this.impoziteDS;
            // 
            // impoziteDS
            // 
            this.impoziteDS.DataSetName = "impoziteDS";
            this.impoziteDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idImpozitDataGridViewTextBoxColumn,
            this.nrcDataGridViewTextBoxColumn1,
            this.IdTipProprietate,
            this.impozitAnualDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn,
            this.IdContinut});
            this.dataGridView2.DataSource = this.viewContinutImpozitBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 246);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(544, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // viewContinutImpozitBindingSource
            // 
            this.viewContinutImpozitBindingSource.DataMember = "View_ContinutImpozit";
            this.viewContinutImpozitBindingSource.DataSource = this.impoziteDS;
            // 
            // btnImpozitNou
            // 
            this.btnImpozitNou.Location = new System.Drawing.Point(616, 86);
            this.btnImpozitNou.Name = "btnImpozitNou";
            this.btnImpozitNou.Size = new System.Drawing.Size(75, 43);
            this.btnImpozitNou.TabIndex = 2;
            this.btnImpozitNou.Text = "Adauga Impozit";
            this.btnImpozitNou.UseVisualStyleBackColor = true;
            this.btnImpozitNou.Click += new System.EventHandler(this.btnImpozitNou_Click);
            // 
            // btnModificareImpozit
            // 
            this.btnModificareImpozit.Location = new System.Drawing.Point(616, 145);
            this.btnModificareImpozit.Name = "btnModificareImpozit";
            this.btnModificareImpozit.Size = new System.Drawing.Size(75, 35);
            this.btnModificareImpozit.TabIndex = 3;
            this.btnModificareImpozit.Text = "Modifica Impozit";
            this.btnModificareImpozit.UseVisualStyleBackColor = true;
            this.btnModificareImpozit.Click += new System.EventHandler(this.btnModificareImpozit_Click);
            // 
            // btnStergeImpozit
            // 
            this.btnStergeImpozit.Location = new System.Drawing.Point(616, 195);
            this.btnStergeImpozit.Name = "btnStergeImpozit";
            this.btnStergeImpozit.Size = new System.Drawing.Size(75, 35);
            this.btnStergeImpozit.TabIndex = 4;
            this.btnStergeImpozit.Text = "Sterge Impozit";
            this.btnStergeImpozit.UseVisualStyleBackColor = true;
            this.btnStergeImpozit.Click += new System.EventHandler(this.btnStergeImpozit_Click);
            // 
            // txtImpozit
            // 
            this.txtImpozit.Location = new System.Drawing.Point(602, 47);
            this.txtImpozit.Name = "txtImpozit";
            this.txtImpozit.Size = new System.Drawing.Size(100, 20);
            this.txtImpozit.TabIndex = 5;
            this.txtImpozit.TextChanged += new System.EventHandler(this.txtImpozit_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(562, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.LocationChanged += new System.EventHandler(this.pictureBox1_LocationChanged);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtSpPoza
            // 
            this.txtSpPoza.Location = new System.Drawing.Point(602, 274);
            this.txtSpPoza.Name = "txtSpPoza";
            this.txtSpPoza.Size = new System.Drawing.Size(100, 20);
            this.txtSpPoza.TabIndex = 7;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(616, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // view_TotalTableAdapter
            // 
            this.view_TotalTableAdapter.ClearBeforeFill = true;
            // 
            // view_ContinutImpozitTableAdapter
            // 
            this.view_ContinutImpozitTableAdapter.ClearBeforeFill = true;
            // 
            // idImpozitDataGridViewTextBoxColumn
            // 
            this.idImpozitDataGridViewTextBoxColumn.DataPropertyName = "IdImpozit";
            this.idImpozitDataGridViewTextBoxColumn.HeaderText = "IdImpozit";
            this.idImpozitDataGridViewTextBoxColumn.Name = "idImpozitDataGridViewTextBoxColumn";
            this.idImpozitDataGridViewTextBoxColumn.Visible = false;
            // 
            // nrcDataGridViewTextBoxColumn1
            // 
            this.nrcDataGridViewTextBoxColumn1.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn1.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn1.Name = "nrcDataGridViewTextBoxColumn1";
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
            // Impozite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSpPoza);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtImpozit);
            this.Controls.Add(this.btnStergeImpozit);
            this.Controls.Add(this.btnModificareImpozit);
            this.Controls.Add(this.btnImpozitNou);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Impozite";
            this.Text = "Impozite";
            this.Load += new System.EventHandler(this.Impozite_Load);
            this.Enter += new System.EventHandler(this.Impozite_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impoziteDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewContinutImpozitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private impoziteDS impoziteDS;
        private impoziteDSTableAdapters.View_TotalTableAdapter view_TotalTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnImpozitNou;
        private System.Windows.Forms.Button btnModificareImpozit;
        private System.Windows.Forms.Button btnStergeImpozit;
        private System.Windows.Forms.TextBox txtImpozit;
        private System.Windows.Forms.BindingSource viewTotalBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSpPoza;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdImpozit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireTipProprietateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewContinutImpozitBindingSource;
        private impoziteDSTableAdapters.View_ContinutImpozitTableAdapter view_ContinutImpozitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idImpozitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipProprietate;
        private System.Windows.Forms.DataGridViewTextBoxColumn impozitAnualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdContinut;
    }
}