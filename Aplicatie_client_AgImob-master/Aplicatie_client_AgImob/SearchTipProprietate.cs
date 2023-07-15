using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Aplicatie_client_AgImob
{
    public partial class SearchTipProprietate : Form
    {
        //Connection String  
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\AgImob\AgImob\App_Data\Database1.mdf;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public SearchTipProprietate()
        {
            InitializeComponent();
        }
        //frmSearch Load Event  
        private void SearchTipProprietate_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Tipimobil", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //txt_SearchName TextChanged Event  
        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from TipImobil where id_imobil like '" + txt_SearchName.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}