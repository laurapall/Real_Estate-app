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
    public partial class SearchProprietar : Form
    {
        //Connection String  
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\AgImob\AgImob\App_Data\Database1.mdf;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public SearchProprietar()
        {
            InitializeComponent();
        }
        //frmSearch Load Event  
        private void SearchProprietar_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from DateProprietar", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        //txt_SearchName2 TextChanged Event  
        private void txt_SearchName2_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from DateProprietar where cnp like '" + txt_SearchName2.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void button_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}