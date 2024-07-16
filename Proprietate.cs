using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect10
{
    public partial class Proprietate : Form
    {
        const int DenumireTipProprietate = 0;
        const int ImpozitAnual = 1;
        public Proprietate()
        {
            InitializeComponent();
        }



        private void Proprietate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proprietateDS.TipProprietate' table. You can move, or remove it, as needed.
            this.tipProprietateTableAdapter.Fill(this.proprietateDS.TipProprietate);
            config(true);
            refresh();
        }

        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            dataGridView1.Columns[DenumireTipProprietate].ReadOnly = v;
            dataGridView1.Columns[ImpozitAnual].ReadOnly = v;

            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
            btnStergere.Visible = false;
        }

        private void refresh()
        {
            this.tipProprietateTableAdapter.Fill(this.proprietateDS.TipProprietate);
        }

        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in this.proprietateDS.TipProprietate)
            {
                if (r.RowState == DataRowState.Deleted) continue;

                if (r["DenumireTipProprietate"] == DBNull.Value)
                {
                    MessageBox.Show("Denumirea nu poate fi goala!");
                    raspuns = false;
                    return raspuns;
                }

                if (r["ImpozitAnual"] == DBNull.Value)
                {
                    MessageBox.Show("Impozitul Anual nu poate fi gol!");
                    raspuns = false;
                    return raspuns;
                }
            }
            return raspuns;
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri())
            {
                return;
            }
            try
            {
                tipProprietateTableAdapter.Update(proprietateDS.TipProprietate);
                config(true);
                refresh();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
               
                MessageBox.Show(s);
                
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            //A3
            config(true);
            refresh();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (btnRenuntare.Focused)
            {
                dataGridView1.CancelEdit();
                //A3
                config(true);
                refresh();
                return;
            }
            MessageBox.Show("Format eronat");
        }


        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Stergeti proprietatea?";
            const string titlu = "Stergere";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /*private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Stergeti inregistrarea curenta?";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No)
            {
                return;
            }
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "select IdPersoana from impozite where IdPersoana=" + txtIdClient.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Clientul nu poate fi sters pentru ca exista in tabela impozite!");
                con.Close();
                return;
            }
            con.Close();
            cmd.CommandText = "delete from Clienti where IdClient=" + txtIdClient.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(clientiBindingSource.Position); 
        }*/

    }
}
