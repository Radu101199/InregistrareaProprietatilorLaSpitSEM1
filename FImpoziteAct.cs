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
    public partial class FImpoziteAct : Form
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection con = new OleDbConnection();
        OleDbDataReader rdr;
        private int idImpozit;
        public BindingSource bs1;
        public BindingSource bs2;

        public FImpoziteAct(string tip, string nrImpozit)
        {
            InitializeComponent();
            con.ConnectionString = this.view_ContinutImpozitTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            if (tip == "Adaugare")
            {
                this.impoziteDS.View_ContinutImpozit.Clear();
            }
            if (tip == "Actualizare")
            {
                this.view_ContinutImpozitTableAdapter.Fill(this.impoziteDS.View_ContinutImpozit);
                filtreazaImpozit(nrImpozit);
                this.comboBox1.Enabled = false;
                txtNrImpozit.Text = nrImpozit;
            }
        }

        private void FImpoziteAct_Load(object sender, EventArgs e)
        {
            
            config(true);
            if (lblOp.Text == "Adaugare impozit")
            {
                txtTotal.Text = "0";

            }
        }

        private void config(bool v)
        {
            txtNrImpozit.ReadOnly = v;
            txtTotal.ReadOnly = v;
            dataGridView1.AllowUserToDeleteRows = !v;
        }

        internal void setCNP()
        {
            cmd.CommandText = "Select CNP FROM Clienti WHERE IdClient = (SELECT IdPersoana FROM Impozite WHERE IdImpozit = " + idImpozit + ")";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                comboBox1.Text = rdr[0].ToString();
                rdr.Close();
                con.Close();
            }
            else
            {
                rdr.Close();
                con.Close();
            }
        }
        internal void setNrImpozit()
        {
            this.idImpozit = Convert.ToInt32(txtNrImpozit.Text);
            /*cmd.CommandText = "SELECT Nrc FROM ImpoziteContinut WHERE IdImpozit = " + idImpozit;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                txtNrImpozit.Text = rdr[0].ToString();
                rdr.Close();
                con.Close();
            }
            else
            {
                rdr.Close();
                con.Close();
            }*/

        }
        internal void incarcaClienti()
        {
            cmd.CommandText = "SELECT CNP From Clienti";
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string CNP = rdr["CNP"].ToString();
                comboBox1.Items.Add(CNP);
            }
            rdr.Close();
            con.Close();
        }

        private bool existaProprietatea(string IdTipProprietate, string impozitAnual)
        {
            cmd.CommandText = "SELECT IdTipProprietate, ImpozitAnual FROM TipProprietate WHERE IdTipProprietate = " + IdTipProprietate;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (!rdr[0].ToString().Equals(IdTipProprietate) || !rdr[1].ToString().Equals(impozitAnual))
                {
                    MessageBox.Show("Impozitul anual in valoare de " + impozitAnual + " nu corespunde cu tipul de proprietate!");
                    rdr.Close();
                    con.Close();
                    return false;
                }

                rdr.Close();
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Nu exista tip de proprietate cu impozitul anual de " + impozitAnual);
                rdr.Close();
                con.Close();
                return false;
            }
        }

       /* private int getIdImpozit(string Nrc)
        {
            cmd.CommandText = "SELECT IdImpozit FROM Impozite WHERE Nrc = " + Nrc;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                int idImpozit = Convert.ToInt32(rdr[0]);
                rdr.Close();
                con.Close();
                return idImpozit;
            }
            else
            {
                rdr.Close();
                con.Close();
                return -1;
            }
        }
        */

        private bool completeazaImpozitul(int idImpozit)
        {
            string listaCampuri;
            foreach (DataRow r in this.impoziteDS.View_ContinutImpozit)
            {
                if (r["Nrc"] == DBNull.Value)
                {
                    MessageBox.Show("Nrc nu poate fi gol!");
                    return false;
                }
                if (r["IdTipProprietate"] == DBNull.Value)
                {
                    MessageBox.Show("Tipul de proprietate nu poate fi gol!");
                    return false;
                }
                if (r["ImpozitAnual"] == DBNull.Value)
                {
                    MessageBox.Show("Impozitul Anual nu poate fi gol!");
                    return false;
                }
                if (r["Valoare"] == DBNull.Value)
                {
                    MessageBox.Show("Valoarea proprietatii nu poate fi goala!");
                    return false;
                }
                if (!existaProprietatea(r["IdTipProprietate"].ToString(), r["ImpozitAnual"].ToString()))
                {
                    return false;
                }
            }
            listaCampuri = "IdImpozit,Nrc,IdTipProprietate,Valoare,ImpozitAnual,SpImagine";

            foreach (DataRow r in this.impoziteDS.View_ContinutImpozit)
            {
                cmd.CommandText = "INSERT INTO" + " ImpoziteContinut (" + listaCampuri + ") VALUES (" + this.idImpozit + "," + r["Nrc"] + "," + r["IdTipProprietate"] + "," + r["Valoare"] + "," + r["ImpozitAnual"] + "," +"\""+ r["SpImagine"] + "\"" + ")";
                con.Open();
                 cmd.ExecuteNonQuery();
                con.Close();
            }

            return true;
        }

        internal void completeazaOp(string op)
        {
            this.lblOp.Text = op;
        }

        void filtreazaImpozit(string filtru)
        {
            try
            {
                this.viewContinutImpozitBindingSource.Filter = "IdImpozit = " + filtru;
            }
            catch { }
        }

        private bool actualizeazaComanda()
        {
            return true;
        }

        private bool actualizeazaContinut()
        {
            foreach (DataRow r in this.impoziteDS.View_ContinutImpozit)
            {
                if (r["Nrc"] == DBNull.Value)
                {
                    MessageBox.Show("Nrc nu poate fi gol!");
                    return false;
                }
                if (r["IdTipProprietate"] == DBNull.Value)
                {
                    MessageBox.Show("Tipul de proprietate nu poate fi gol!");
                    return false;
                }
                if (r["ImpozitAnual"] == DBNull.Value)
                {
                    MessageBox.Show("Impozitul Anual nu poate fi gol!");
                    return false;
                }
                if (r["Valoare"] == DBNull.Value)
                {
                    MessageBox.Show("Valoarea proprietatii nu poate fi goala!");
                    return false;
                }
                if (!existaProprietatea(r["IdTipProprietate"].ToString(), r["ImpozitAnual"].ToString()))
                {
                    return false;
                }
            }
            foreach (DataRow r in this.impoziteDS.View_ContinutImpozit)
            {
                //MODIFICA NR INVENTAR IN ID CARTE
                
                cmd.CommandText = "UPDATE ImpoziteContinut SET Valoare =" + r["Valoare"] +", IdTipProprietate = " + r["IdTipProprietate"] + ", ImpozitAnual = " + r["ImpozitAnual"] + ", SpImagine="+"\""+ r["SpImagine"]+"\""+", Nrc = " + r["Nrc"]+ " " + "WHERE IdContinut = " + r["IdContinut"];

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }

        internal void generez_nr_impozit()
        {
            cmd.CommandText = "SELECT MAX(IdImpozit) FROM Impozite";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                txtNrImpozit.Text = (Convert.ToInt32(rdr[0]) + 1).ToString();
                rdr.Close();
                con.Close();
            }
            else
            {
                rdr.Close();
                con.Close();
            }
        }

        private void adaugaInregistrareImpozit()
        {
            string listaCampuri;
            string listaValori;
            DateTime dataImprumut = dateTimePicker1.Value;
            //generez_nr_impozit();
            cmd.CommandText = "SELECT IdClient FROM Clienti WHERE CNP = '" + comboBox1.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                listaCampuri = "IdImpozit, Anul, IdPersoana";
                listaValori = txtNrImpozit.Text + ", " + dataImprumut.ToString("yyyy") + ", " + rdr[0];
                cmd.CommandText = "INSERT INTO Impozite (" + listaCampuri + ") VALUES (" + listaValori + ")";
                rdr.Close();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Nu exista niciun client cu cnp " + comboBox1.Text);
                rdr.Close();
                con.Close();
                return;
            }
            con.Open();
            cmd.CommandText = "SELECT MAX(IdImpozit) FROM Impozite";
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                idImpozit = Convert.ToInt32(rdr[0]);
                rdr.Close();
                con.Close();
            }
            else
            {
                rdr.Close();
                con.Close();
            }
            var completeaza = completeazaImpozitul(idImpozit);
            if (completeaza)
            {
                MessageBox.Show("Impozitul a fost adaugat cu succes!");
            }
            else
            {
                con.Open();
                cmd.CommandText = "DELETE FROM Impozite WHERE IdImpozit = " + idImpozit;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Impozitul nu a fost adaugat!");
            }
        }

        private bool validareCampuriObligatorii()
        { 
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Alegeti un cnp!");
                return false;
            }
            if (viewContinutImpozitBindingSource.Count == 0)
            {
                MessageBox.Show("Nu ati adaugat continut in impozit!");
                return false;
            }
            return true;
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            if (lblOp.Text == "Adaugare impozit")
            {
                //generez_nr_impozit();
                if (validareCampuriObligatorii())
                {
                    adaugaInregistrareImpozit();
                }
            }
            if (lblOp.Text == "Modificare impozit")
            {
                
                 if (actualizeazaContinut()) { MessageBox.Show("Impozitul a fost actualizat cu succes!"); }
                
            }
        }

        internal void calculeazaTotal()
        {
            if (lblOp.Text == "Modificare impozit")
            {
                int IDImpozit = 0;
                txtTotal.Text = "0";
                foreach (DataRow r in this.impoziteDS.View_ContinutImpozit)
                {
                    object idImpozitValue = r["IdImpozit"];
                    if (idImpozitValue != DBNull.Value)
                    {
                        IDImpozit = Convert.ToInt32(idImpozitValue);
                    }

                    object valoareValue = r["Valoare"];
                    object impozitAnualValue = r["ImpozitAnual"];
                    if (valoareValue != DBNull.Value && impozitAnualValue != DBNull.Value && idImpozit == IDImpozit)
                    {

                        int valoare = Convert.ToInt32(valoareValue);
                        double impozitAnual = Convert.ToDouble(impozitAnualValue);
                        
                        txtTotal.Text = (Convert.ToInt32(txtTotal.Text) + valoare * impozitAnual).ToString();
                    }
                }
            }
            else
            {
                foreach (DataRow r in this.impoziteDS.View_ContinutImpozit)
                {

                    object tipProprietateValue = r["IdTipProprietate"];
                    object valoareValue = r["Valoare"];
                    object impozitAnualValue = r["ImpozitAnual"];
                    if (tipProprietateValue != DBNull.Value && valoareValue != DBNull.Value && impozitAnualValue != DBNull.Value)
                    {

                        int valoare = Convert.ToInt32(valoareValue);
                        double impozitAnual = Convert.ToDouble(impozitAnualValue);
                        txtTotal.Text = (Convert.ToInt32(txtTotal.Text) + valoare * impozitAnual).ToString();
                    }
                }
            }
        }


        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            calculeazaTotal();
        }

        private void FImpoziteAct_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            if (dataGridView1.CurrentCell.ColumnIndex == 5)
            {
                openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string s = openFileDialog1.FileName;
                    dataGridView1.CurrentRow.Cells[5].Value = s;
                    dataGridView1.EndEdit();
                }
            }
        }

    }
}