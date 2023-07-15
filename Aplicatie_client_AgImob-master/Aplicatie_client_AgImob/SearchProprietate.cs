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
    public partial class SearchProprietate : Form
    {
        //Connection String  
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\AgImob\AgImob\App_Data\Database1.mdf;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public SearchProprietate()
        {
            InitializeComponent();
        }
        //frmSearch Load Event  
        private void SearchTipProprietate_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Imobil", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }
        //txt_SearchName3 TextChanged Event  
        private void txt_SearchName3_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Imobil where id_prop like '" + txt_SearchName3.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }

        private void button_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}