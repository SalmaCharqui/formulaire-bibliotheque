using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading.Channels;
using System.Data.SqlTypes;
using System.Security.Cryptography.Xml;

namespace formulaire_bibliotheque
{   

      
    public partial class Form1 : Form
    {
        
        String strConnection= @"Data Source=SALMACHARQUI;Initial Catalog=bibliotheque;Integrated Security=True";
         
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            comboBoxReference.Enabled = true;
        }
        private void btnAnnuler_Click(object sender,EventArgs e)
        {
        
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            delete(comboBoxReference.Text);
        }
        void delete(string reference)
        {
            SqlConnection cnx = new SqlConnection(strConnection);
            string strSql = "delete from livre where refernce='"+comboBoxReference.Text+ "';";
            SqlCommand sqlcmd = new SqlCommand(strSql, cnx);
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            btnNouveau.Enabled = false;
            btnModifier.Enabled = false;
            btnsupprimer.Enabled = false;
            btnModifier.Visible = false;
            btnsupprimer.Visible = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;
            cnx.Close();
        }
        private void  btnNouveau_Click(object sender, EventArgs e)
        {

            SqlConnection cnx = new SqlConnection(strConnection);
            string strSql = "Insert into livre Values('" + comboBoxReference.Text + "', '" + textBoxNom.Text + "','" + textBoxPrix.Text + "')";
            SqlCommand sqlcmd =new SqlCommand(strSql, cnx);
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            btnNouveau.Enabled = false;
            btnModifier.Enabled = false;
            btnsupprimer.Enabled = false;
            btnModifier.Visible = false;
            btnsupprimer.Visible = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;
            cnx.Close();
          
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            update(comboBoxReference.Text, textBoxNom.Text, textBoxPrix.Text);

        }
        void update(string reference,string nom,string prix)
        {
            SqlConnection cnx = new SqlConnection(strConnection);
            string strSql = "update livre set name'" + comboBoxReference.Text + "', '" + textBoxNom.Text + "','" + textBoxPrix.Text + "';";
            SqlCommand sqlcmd = new SqlCommand(strSql, cnx);
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            btnNouveau.Enabled = false;
            btnModifier.Enabled = false;
            btnsupprimer.Enabled = false;
            btnModifier.Visible = false;
            btnsupprimer.Visible = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;
            cnx.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}