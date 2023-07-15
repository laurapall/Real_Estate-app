using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_client_AgImob
{
    public partial class Finalizare : Form
    {
        public Finalizare()
        {
            InitializeComponent();
            label1.Text = "Cererea dumneavoastra va fi procesata!";
                
        
        }
     
        private void button_iesire_finalizare_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



