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
    public partial class Proprietar : Form
    {
       Aplicatie_client_AgImob.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        public static string CNP;
        public Proprietar()
        {
            InitializeComponent();
        

            label8.Text = "Va rugam introduceti datele pentru proprietar:";
        }


        private void button_mergimaideparte_dateproprietar_Click(object sender, EventArgs e)
        {
            TipProprietate f3 = new TipProprietate(); 
            f3.Show(); 
            this.Close();
        }

        private void button_adauga_dateptoprietar_Click(object sender, EventArgs e)
        {
            string cnp = textBox_cnp.Text;
            string nume = textBox_nume.Text;
            string prenume = textBox_prenume.Text;
            string adresa = textBox_adresa.Text;
            string telefon = textBox_telefon.Text;
            string email = textBox_email.Text;
            try
            {
                service.AdaugareDateProprietar(cnp, nume, prenume, adresa, telefon, email);
                MessageBox.Show("Datele d-voastra au fost adaugate cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!" + ex.Message);
            }
            CNP = cnp;
            textBox_cnp.Clear();
            textBox_nume.Clear();
            textBox_prenume.Clear();
            textBox_adresa.Clear();
            textBox_telefon.Clear();
            textBox_email.Clear();
        }

        private void button_modifica_dateproprietar_Click(object sender, EventArgs e)
        {
          
                string cnp = textBox_cnp.Text;
                string nume = textBox_nume.Text;
                string prenume = textBox_prenume.Text;
                string adresa = textBox_adresa.Text;
                string telefon = textBox_telefon.Text;
                string email = textBox_email.Text;
                try
                {
                    service.ModificareDatePropr(cnp, nume, prenume, adresa, telefon, email);
                    MessageBox.Show("Datele d-voastra au fost modificate!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!" + ex.Message);
                }
               
                textBox_cnp.Clear();
                textBox_nume.Clear();
                textBox_prenume.Clear();
                textBox_adresa.Clear();
                textBox_telefon.Clear();
                textBox_email.Clear();
            }

        private void button_sterge_dateproprietar_Click(object sender, EventArgs e)
        {
            string cnp = textBox_cnp.Text;
            try
            {
                service.StergereDateProprietar(cnp);
                MessageBox.Show("Datele d-voastra au fost sterse! O zi buna!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!" + ex.Message);
            }
            textBox_cnp.Clear();
        }

        private void search_proprietar_Click(object sender, EventArgs e)
        {
           SearchProprietar f5 = new SearchProprietar(); 
           f5.Show(); 
           this.Close();
        }
    }
    }


