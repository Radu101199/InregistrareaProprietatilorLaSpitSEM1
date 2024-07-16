using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect10
{
    public partial class Impozite : Form
    {
        public Impozite()
        {
            InitializeComponent();
        }

        private void Impozite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'impoziteDS.View_ContinutImpozit' table. You can move, or remove it, as needed.
            this.view_ContinutImpozitTableAdapter.Fill(this.impoziteDS.View_ContinutImpozit);
            // TODO: This line of code loads data into the 'impoziteDS.View_ContinutImpozit' table. You can move, or remove it, as needed.
            this.view_ContinutImpozitTableAdapter.Fill(this.impoziteDS.View_ContinutImpozit);
            // TODO: This line of code loads data into the 'impoziteDS.View_ContinutImpozit' table. You can move, or remove it, as needed.
            this.view_ContinutImpozitTableAdapter.Fill(this.impoziteDS.View_ContinutImpozit);
            // TODO: This line of code loads data into the 'impoziteDS.View_Total' table. You can move, or remove it, as needed.
            this.view_TotalTableAdapter.Fill(this.impoziteDS.View_Total);
            txtSpPoza.DataBindings.Add("Text", viewContinutImpozitBindingSource, "SpImagine");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }
        void refreshGrid()
        {
            this.view_ContinutImpozitTableAdapter.Fill(this.impoziteDS.View_ContinutImpozit);
            // TODO: This line of code loads data into the 'impoziteDS.View_Total' table. You can move, or remove it, as needed.
            this.view_TotalTableAdapter.Fill(this.impoziteDS.View_Total);
            
        }



        void filtreazaImpozite(string filtru)
        {
            try
            {
                this.viewContinutImpozitBindingSource.Filter = "IdImpozit = " + filtru;
            }
            catch { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filtreazaImpozite(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtImpozit.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

        private void txtImpozit_TextChanged(object sender, EventArgs e)
        {
            filtreazaImpozite(txtImpozit.Text);
        }

        private void btnStergeImpozit_Click(object sender, EventArgs e)
        {
            const string mesaj = "Sigur doriti sa stergeti impozitul?";
            const string titlu = "Stergere impozit";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No)
            {
                return;
            }
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = view_TotalTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            cmd.CommandText = "DELETE FROM ImpoziteContinut WHERE IdImpozit = " + txtImpozit.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM Impozite WHERE IdImpozit = " + txtImpozit.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            refreshGrid();
        }

        private void btnImpozitNou_Click(object sender, EventArgs e)
        {
            FImpoziteAct frm = new FImpoziteAct("Adaugare", txtImpozit.Text);
            
            frm.completeazaOp("Adaugare impozit");
            frm.generez_nr_impozit();
            frm.incarcaClienti();
            frm.ShowDialog();
            refreshGrid();
        }

        private void btnModificareImpozit_Click(object sender, EventArgs e)
        {
            //object nrInventar = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value;

            FImpoziteAct frm = new FImpoziteAct("Actualizare", txtImpozit.Text);
            
            frm.completeazaOp("Modificare impozit");
            frm.setNrImpozit();
            frm.setCNP();
            frm.calculeazaTotal();
            frm.ShowDialog();
            refreshGrid();
        }

        private void Impozite_Enter(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LocationChanged(object sender, EventArgs e)
        {
             
        }

        private void viewContinutImpozitBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.ImageLocation = txtSpPoza.Text;
        }

    

    }
}
