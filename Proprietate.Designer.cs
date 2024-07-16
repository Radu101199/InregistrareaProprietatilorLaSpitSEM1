
using System;

namespace Proiect10
{
    partial class Proprietate
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
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.denumireTipProprietateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impozitAnualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipProprietateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proprietateDS = new Proiect10.proprietateDS();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tipProprietateTableAdapter = new Proiect10.proprietateDSTableAdapters.TipProprietateTableAdapter();
            this.btnStergere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipProprietateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietateDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(106, 37);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(75, 23);
            this.btnActualizare.TabIndex = 0;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(211, 37);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(68, 23);
            this.btnSalvare.TabIndex = 1;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(311, 37);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 2;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireTipProprietateDataGridViewTextBoxColumn,
            this.impozitAnualDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tipProprietateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(126, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(249, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // denumireTipProprietateDataGridViewTextBoxColumn
            // 
            this.denumireTipProprietateDataGridViewTextBoxColumn.DataPropertyName = "DenumireTipProprietate";
            this.denumireTipProprietateDataGridViewTextBoxColumn.HeaderText = "DenumireTipProprietate";
            this.denumireTipProprietateDataGridViewTextBoxColumn.Name = "denumireTipProprietateDataGridViewTextBoxColumn";
            // 
            // impozitAnualDataGridViewTextBoxColumn
            // 
            this.impozitAnualDataGridViewTextBoxColumn.DataPropertyName = "ImpozitAnual";
            this.impozitAnualDataGridViewTextBoxColumn.HeaderText = "ImpozitAnual";
            this.impozitAnualDataGridViewTextBoxColumn.Name = "impozitAnualDataGridViewTextBoxColumn";
            // 
            // tipProprietateBindingSource
            // 
            this.tipProprietateBindingSource.DataMember = "TipProprietate";
            this.tipProprietateBindingSource.DataSource = this.proprietateDS;
            // 
            // proprietateDS
            // 
            this.proprietateDS.DataSetName = "proprietateDS";
            this.proprietateDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tipProprietateTableAdapter
            // 
            this.tipProprietateTableAdapter.ClearBeforeFill = true;
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(421, 37);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 4;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            // 
            // Proprietate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Name = "Proprietate";
            this.Text = "Proprietate";
            this.Load += new System.EventHandler(this.Proprietate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipProprietateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietateDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private proprietateDS proprietateDS;
        private System.Windows.Forms.BindingSource tipProprietateBindingSource;
        private proprietateDSTableAdapters.TipProprietateTableAdapter tipProprietateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireTipProprietateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impozitAnualDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnStergere;
    }
}