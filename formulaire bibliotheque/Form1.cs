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
            MessageBox.Show("operation efectuee");           
        }
        private void btnAnnuler_Click(object sender,EventArgs e)
        {
            comboBoxReference.Text = "";
            textBoxNom.Text = "";
            textBoxPrix.Text = "";
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            delete(comboBoxReference.Text);
        }
        void delete(string reference)
        {
            SqlConnection cnx = new SqlConnection(strConnection);
            string strSql = "delete from livre where reference='"+comboBoxReference.Text+ "';";
            SqlCommand sqlcmd = new SqlCommand(strSql, cnx);
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            btnNouveau.Enabled = false;
            btnModifier.Enabled = false;
            btnsupprimer.Enabled = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;
            cnx.Close();
        }
        private void  btnNouveau_Click(object sender, EventArgs e)
        {

         //   dataGridViewBd.Rows.Add(comboBoxReference.Text, textBoxNom.Text, textBoxPrix.Text);
            SqlConnection cnx = new SqlConnection(strConnection);
            string strSql = "Insert into livre Values('" + comboBoxReference.Text + "', '" + textBoxNom.Text + "','" + textBoxPrix.Text + "')";
            SqlCommand sqlcmd =new SqlCommand(strSql, cnx);
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            btnNouveau.Enabled = false;
            btnModifier.Enabled = false;
            btnsupprimer.Enabled = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;
            cnx.Close();
          
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
         
            SqlConnection cnx = new SqlConnection(strConnection);
            string strSql = "update livre set nom='" + textBoxNom.Text + "',prix='" + textBoxPrix.Text + "' where reference='" + comboBoxReference.Text + "' ";
            SqlCommand sqlcmd = new SqlCommand(strSql, cnx);
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            btnNouveau.Enabled = false;
            btnModifier.Enabled = false;
            btnsupprimer.Enabled = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;
            cnx.Close();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            FillComboRef();
            FILLDGV();

        }
        private void FillComboRef()
        {
           /* comboBoxReference.Items.Clear();
            SqlConnection cnx = new SqlConnection(strConnection);
            cnx.Open();
            SqlCommand cmd = new SqlCommand();
            cmd =cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from reference";
            cmd.ExecuteNonQuery();
            DataTable dt =new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                comboBoxReference.Items.Add(dr["reference"].ToString());
            }
            cnx.Close();*/
        }

        private void lblnom_Click(object sender, EventArgs e)
        {

        }
        

        private void comboBoxReference_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            SqlConnection cnx = new SqlConnection(strConnection);
            string strSql = "select refence from livre";
            SqlCommand sqlcmd = new SqlCommand(strSql, cnx);
            
            dap = new SqlDataAdapter(sqlcmd);
            ds = new DataSet();
            dap.Fill(ds,"reference");
            foreach(DataRow x in ds.Tables[0].Rows)
            {
                comboBoxReference.Items.Add(x[0].ToString());
            }*/
            try
            {
                SqlConnection cnx = new SqlConnection(strConnection);
                string strSql = "SELECT * FROM livre";
                cnx.Open();
                SqlCommand sqlcmd = new SqlCommand(strSql, cnx);
                SqlDataReader reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxReference.Items.Add(reader.GetString("reference"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void FILLDGV()
        {
            try
            {
                SqlConnection cnx = new SqlConnection(strConnection);
                string query = "select * from livre";
                SqlDataAdapter adapter = new SqlDataAdapter(query, cnx);
                cnx.Open();
               // DataSet ds = new DataSet();
               DataTable dt =new DataTable();
                adapter.Fill(dt);
               // adapter.Fill(ds, "livre");
                dataGridViewBd.DataSource = dt;
                cnx.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewBd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridViewBd.Rows.Add(comboBoxReference.SelectedItem, textBoxNom.Text, textBoxPrix.Text);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}