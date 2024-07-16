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
    public partial class Clienti : Form
    {
        public Clienti()
        {
            InitializeComponent();
        }

        private void Clienti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.dataSet2.Clienti);
            // TODO: This line of code loads data into the 'dataSet1.Persoane' table. You can move, or remove it, as needed.
            txtIdClient.Visible = false;
            lblIdClient.Visible = false;
            A1();
        }

        private void A1()
        {
            this.clientiTableAdapter.Fill(this.dataSet2.Clienti);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            A3();
        }

        private void A2()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            lblOp.Text = "Adaugare";
            txtIdClient.ReadOnly = true;

            txtNume.Focus();
            golireCampuri();
        }

        private void A3()
        {
            configureazaButoane(true);
            legareControale(true);
            protectiePanel(true);
            lblOp.Text = "";
        }

        private void A4()
        {
            if (lblOp.Text == "Adaugare")
            {
                if (!validareCampuriObligatorii())
                {
                    return;
                }
                adauga_inregistrare();
                golireCampuri();

                txtNume.Focus();
                refresh_grid(clientiBindingSource.Position);
            }
            else if (lblOp.Text == "Modificare")
            {
                modifica_inregistrarea();
                refresh_grid(clientiBindingSource.Position);
                A3();
            }
            else
            {
                MessageBox.Show("Operatie actualizare neefectuata!");
            }

        }

        private bool A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            //if (lblOp.Text == "") return false;
            //if (txtB.Text == "") return false;
            //if (btnRenuntare.Focused) return false;

            try { p = Convert.ToDecimal(txtB.Text); }
            catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            string nrTelefon = txtB.Text.Trim();
            string idPersoana = txtIdClient.Text.Trim();
            if (string.IsNullOrEmpty(nrTelefon))
            {
                MessageBox.Show("Numarul de telefon nu poate fi gol!");
                txtB.Focus();
                return false;
            }

            cmd.CommandText = "SELECT IdClient,NumeClient FROM clienti WHERE NrTelefon = @NrTelefon";
            cmd.Parameters.AddWithValue("@NrTelefon", nrTelefon);

            con.Open();
            r = cmd.ExecuteReader();

            if (r.Read())
            {
                if (lblOp.Text == "Modificare" && idPersoana.Equals(r["IdClient"].ToString()))
                {
                    con.Close();
                    return true;
                }
                MessageBox.Show("Numarul de telefon exista deja!");
                txtB.Focus();
                con.Close();
                return false;
            }

            con.Close();
            return true;
        }

        private void A7()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            lblOp.Text = "Modificare";
            txtNume.Focus();
        }

        private void A8()
        {
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
        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtNume.DataBindings.Add("Text", clientiBindingSource, "NumeClient");
                txtCNP.DataBindings.Add("Text", clientiBindingSource, "CNP");
                txtLocalitate.DataBindings.Add("Text", clientiBindingSource, "Localitate");
                txtAdresa.DataBindings.Add("Text", clientiBindingSource, "Adresa");
                txtNrTel.DataBindings.Add("Text", clientiBindingSource, "NrTelefon");
                txtIdClient.DataBindings.Add("Text", clientiBindingSource, "IdClient");
            }
            else
            {
                txtNume.DataBindings.Clear();
                txtAdresa.DataBindings.Clear();
                txtNrTel.DataBindings.Clear();
                txtLocalitate.DataBindings.Clear();
                txtCNP.DataBindings.Clear();
                txtIdClient.DataBindings.Clear();
                
            }
        }

        private void protectiePanel(bool v)
        {
            txtNume.ReadOnly = v;
            txtAdresa.ReadOnly = v;
            txtNrTel.ReadOnly = v;
            txtCNP.ReadOnly = v;
            txtLocalitate.ReadOnly = v;
        }

        private void golireCampuri()
        {
            txtNume.Text = "";
            txtAdresa.Text = "";
            txtNrTel.Text = "";
            txtLocalitate.Text = "";
            txtCNP.Text = "";
            txtIdClient.Text = "";

        }

        private bool validareCampuriObligatorii()
        {
            if (txtNume.Text == "")
            {
                MessageBox.Show("Numele este obligatoriu!");
                txtNume.Focus();
                return false;
            }
            if (txtCNP.Text == "")
            {
                MessageBox.Show("CNP este obligatoriu!");
                txtCNP.Focus();
                return false;
            }
            if (txtLocalitate.Text == "")
            {
                MessageBox.Show("Localitatea este obligatorie!");
                txtLocalitate.Focus();
                return false;
            }
            if (txtAdresa.Text == "")
            {
                MessageBox.Show("Adresa este obligatorie!");
                txtAdresa.Focus();
                return false;
            }
            if (txtNrTel.Text == "")
            {
                MessageBox.Show("Numarul de telefon este obligatoriu!");
                txtNrTel.Focus();
                return false;
            }
            return true;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;
            if (!A5(txtNrTel))
            {
                return;
            }
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "NumeClient, CNP, Localitate, Adresa, NrTelefon";
            listaValori = "'" + txtNume.Text + "', '" + txtCNP.Text + "', '" + txtLocalitate.Text + "', '" +  txtAdresa.Text + "', '" + txtNrTel.Text + "'";
            cmd.CommandText = "insert into Clienti (" + listaCampuri + ") values (" + listaValori + ")";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void refresh_grid(int p)
        {
            this.clientiTableAdapter.Fill(this.dataSet2.Clienti);
            clientiBindingSource.Position = p;
        }

        private void modifica_inregistrarea()
        {
            string listaSet;
            if (!A5(txtNrTel))
            {
                return;
            }
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "NumeClient='" + txtNume.Text + "', CNP='" + txtCNP.Text + "', Localitate='" + txtLocalitate.Text + "', Adresa='" + txtAdresa.Text + "', NrTelefon='" + txtNrTel.Text + "'";
            cmd.CommandText = "update clienti set " + listaSet + " where IdClient=" + txtIdClient.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Stergeti inregistrarea curenta?";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No)
            {
                return;
            }
            A8();
        }

    }
}
