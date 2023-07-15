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
    public partial class TipProprietate : Form
    {
        Aplicatie_client_AgImob.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();

        Random rand = new Random();
       
        

        public TipProprietate()

        {
            InitializeComponent();

            label5.Text = "Va rugam introduceti tipul imobilului.";

            textBox1_id_tip.Text = rand.Next(1000).ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_mergimaideparte_tipimobil_Click(object sender, EventArgs e)
        {
            Proprietate f4 = new Proprietate(); f4.Show(); this.Close();
        }

        private void button_adauga_tipimobil_Click(object sender, EventArgs e)
        {
         
            int Id_imobil = int.Parse(textBox1_id_tip.Text);
            string tipulimob = textBox_tip.Text;
            string descrieretip = textBox3_descriere.Text;

            try
            {
                service.AdaugareTipImobil(Id_imobil, tipulimob, descrieretip);
                MessageBox.Show("Datele d-voastra au fost introduse cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!" + ex.Message);
            }
            
            textBox1_id_tip.Clear();
            textBox_tip.Clear();
            textBox3_descriere.Clear();

        }

        private void button_modifica_tipimobil_Click(object sender, EventArgs e)
        {
            int Id_imobil = int.Parse(textBox1_id_tip.Text);
            string tipulimob = textBox2_tip_propr.Text;
            string descrieretip = textBox3_descriere.Text;

            try
            {
                service.ModificareTipImobil(Id_imobil, tipulimob, descrieretip);
                MessageBox.Show("Datele d-voastra au fost modificate!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!" + ex.Message);
            }

            textBox1_id_tip.Clear();
            textBox2_tip_propr.Clear();
            textBox3_descriere.Clear();

        }

        private void button_sterge_tipimobil_Click(object sender, EventArgs e)
        {
            int Id_imobil = int.Parse(textBox1_id_tip.Text);
            try
            {
                service.StergereTipImobil(Id_imobil);
                MessageBox.Show("Datele introduse au fost sterse! Va dorim o zi buna!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!" + ex.Message);
            }
            textBox1_id_tip.Clear();

        }

        private void button_gotosearch_Click(object sender, EventArgs e)
        {
           SearchTipProprietate f5 = new SearchTipProprietate(); f5.Show(); this.Close();
        }

      
    }
    }

           
    
