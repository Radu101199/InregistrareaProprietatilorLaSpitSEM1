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
    public partial class Form1 : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();

        }

        private void A1(bool v)
        {
            menuStrip1.Visible = !v;
            lblTitlu.Visible = !v;
            lblAutor.Visible = !v;
            lblUtilizator.Visible = v;
            lblParola.Visible = v;
            txtUtilizator.Visible = v;
            txtParola.Visible = v;
            if (v) btnStart.Text = "Start";
            else btnStart.Text = "Log Out";
        }

        private bool LogareOk()
        {
            if (string.IsNullOrEmpty(txtUtilizator.Text))
            {
                MessageBox.Show("Introduceti un nume de utilizator!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUtilizator.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtParola.Text))
            {
                MessageBox.Show("Introduceti o parola!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParola.Focus();
                return false;
            }
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT Nume,Parola FROM Utilizatori WHERE Nume=@Utilizator AND Parola=@Parola", conn);
                cmd.Parameters.AddWithValue("Utilizator", txtUtilizator.Text);
                cmd.Parameters.AddWithValue("Parola", txtParola.Text);
                OleDbDataReader dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Utilizator si parola sunt corecte!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Utilizator sau parola sunt gresite!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                if (LogareOk())
                {
                    A1(false);
                }
            }
            else
            {
                A1(true);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\raduc\source\repos\Proiect10\Database3.accdb";
            A1(true);
            this.Text = "Imprumuturi";
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clienti f = new Clienti();
            f.ShowDialog();
        }

        private void proprietateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proprietate f = new Proprietate();
            f.ShowDialog();
        }

        private void impoziteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Impozite f = new Impozite();
            f.ShowDialog();
        }
    }
}
