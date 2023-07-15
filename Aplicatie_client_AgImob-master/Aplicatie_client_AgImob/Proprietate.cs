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
    public partial class Proprietate : Form
    {
        Aplicatie_client_AgImob.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        
        Random rand = new Random();
        
        public Proprietate()
        {
            InitializeComponent();
           

            label1.Text = "Va rugam introduceti datele imobului:";
            textBox_id.Text = rand.Next(1000).ToString();
            textBox_CNP.Text = Proprietar.CNP;
            

        }

        
        private void button_next_Click(object sender, EventArgs e)
        {
            Finalizare next = new Finalizare();
            next.Show();
            this.Close();

        }

        private void button_adauga_Click(object sender, EventArgs e)
        {
            int Id_prop = int.Parse(textBox_id.Text);
            string cnp = textBox_CNP.Text;
            string tipimob = comboBox2.SelectedItem.ToString();
            string adresaimob = textBox_adresa.Text;
            string camere = comboBox1.SelectedItem.ToString();
            string marimeimob = textBox_marime.Text;
            string pretimob = textBox_pret.Text;
            string dataimob = dateTimePicker1.Text;
           
           
            try
            {
                service.AdaugareImobil(Id_prop, cnp, tipimob, adresaimob, camere, marimeimob, pretimob, dataimob);
                MessageBox.Show("Datele au fost introduse cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!" +ex.Message);
            }
            textBox_id.Clear();
            textBox_CNP.Clear();
            comboBox2.Text = "Alegeti tip imobil";
            textBox_adresa.Clear();
            comboBox1.Text = "Alegeti nr.camere";
            textBox_marime.Clear();
            textBox_pret.Clear();
            dateTimePicker1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id_prop = int.Parse(textBox_id.Text);
            string cnp = textBox_CNP.Text;
            string tipimob = comboBox2.SelectedItem.ToString();
            string adresaimob = textBox_adresa.Text;
            string camere = comboBox1.SelectedItem.ToString();
            string marimeimob = textBox_marime.Text;
            string pretimob = textBox_pret.Text;
            string dataimob = dateTimePicker1.Text;
            

            try
            {
                service.ModificareImobil (Id_prop, cnp, tipimob, adresaimob, camere, marimeimob, pretimob, dataimob);
                MessageBox.Show("Datele au fost modificate cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!" +ex.Message);
            }
            textBox_id.Clear();
            textBox_CNP.Clear();
            comboBox1.Text = "Alegeti tip imobil";
            textBox_adresa.Clear();
            comboBox1.Text = "Alegeti nr.camere";
            textBox_marime.Clear();
            textBox_pret.Clear();
            dateTimePicker1.Value = DateTime.MinValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Id_prop = int.Parse(textBox_id.Text);
            try
            {
                service.StergereImobil(Id_prop);
                MessageBox.Show("Datele introduse au fost sterse! Va dorim o zi buna!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!" + ex.Message);
            }
            textBox_id.Clear();
        }

        private void search_proprietar_Click(object sender, EventArgs e)
        {
            SearchProprietate f6 = new SearchProprietate();
            f6.Show();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            //}

        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            Proprietar back = new Proprietar();
            back.Show();
            this.Close();
        }
    }
}




