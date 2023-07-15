using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_client_AgImob
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

       
        private void button_dateproprietar_Click(object sender, EventArgs e)
        {
            Proprietar f1 = new Proprietar(); 
            
            f1.Show();
        }

        private void button_tipimobil_Click(object sender, EventArgs e)
        {
            TipProprietate f2 = new TipProprietate(); 
            
            f2.Show();
        }

        private void button_proprietate_Click(object sender, EventArgs e)
        {
            Proprietate f3 = new Proprietate(); 
            
            f3.Show();
        }

        private void button_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
