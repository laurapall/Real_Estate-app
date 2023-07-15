using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AgImob
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection myCon = new SqlConnection();

        [WebMethod]
        public void AdaugareDateProprietar(string cnp, string nume, string prenume, string adresa, string telefon, string email)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\AgImob\AgImob\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            //SqlDataAdapter = contine un set de comenzi de date si conexiunea la db si este folosit pentru a interschimba date intre datatset si db
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM DateProprietar ORDER BY cnp", myCon);
            //SqlCommandBuilder poate genera instructiuni CRUD folosind proprietatea SelectCommand
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            //DataSet - manipularea datelor
            DataSet newQueryDatePropr = new DataSet();
            //folosind dataAdapterul si proprietatea Fill, vom face o copie a datelor din db in dataSet
            cursAdapter.Fill(newQueryDatePropr, "DateProprietar");
            //se creaza un rand nou de tipul DateProprietar
            DataRow newRow = newQueryDatePropr.Tables["DateProprietar"].NewRow();
            //populam noul rand creat
            newRow["cnp"] = cnp;
            newRow["nume"] = nume;
            newRow["prenume"] = prenume;
            newRow["adresa"] = adresa;
            newRow["telefon"] = telefon;
            newRow["email"] = email;
            //Facem adaugarea in dataSet 
            newQueryDatePropr.Tables["DateProprietar"].Rows.Add(newRow);
            //facem update cu noul dataSet in db
            cursAdapter.Update(newQueryDatePropr, "DateProprietar");
            myCon.Close();
        }

        [WebMethod]
        public void AdaugareTipImobil(int Id_imobil, string tipulimob, string descrieretip)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\AgImob\AgImob\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM TipImobil ORDER BY Id_imobil", myCon);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            //vom crea un nou dataSet
            DataSet newQueryTipImob = new DataSet();
            //folosind dataAdapterul si proprietatea Fill, vom face o copie a datelor din db in dataSet
            cursAdapter.Fill(newQueryTipImob, "TipImobil");
            //se creaza un rand nou de tipul TipProprietate
            DataRow newRow = newQueryTipImob.Tables["TipImobil"].NewRow();
            //populam noul rand creat
            newRow["Id_imobil"] = Id_imobil;
            newRow["tipulimob"] = tipulimob;
            newRow["descrieretip"] = descrieretip;
            //Facem adaugarea in dataSet 
            newQueryTipImob.Tables["TipImobil"].Rows.Add(newRow);
            //facem update cu noul dataSet in db
            cursAdapter.Update(newQueryTipImob, "TipImobil");
            myCon.Close();
        }


        [WebMethod]
        public void AdaugareImobil(int Id_prop, string cnp, string tipimob, string adresaimob, string camere, string marimeimob, string pretimob, string dataimob)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\AgImob\AgImob\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM Imobil ORDER BY Id_prop", myCon);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);

            //folosim un nou dataset pentru a face adaugarea
            DataSet newQueryImob = new DataSet();
            //facem o copie a datelor din db in dataSet
            cursAdapter.Fill(newQueryImob, "Imobil");
            //se creaza un rand nou de tipul Proprietate
            DataRow newRow = newQueryImob.Tables["Imobil"].NewRow();
            //populam noul rand creat
            newRow["Id_prop"] = Id_prop;
            newRow["cnp"] = cnp;
            newRow["tipimob"] = tipimob;
            newRow["adresaimob"] = adresaimob;
            newRow["camere"] = camere;
            newRow["marimeimob"] = marimeimob;
            newRow["pretimob"] = pretimob;
            newRow["dataimob"] = dataimob;
           

            //Facem adaugarea in dataSet 
            newQueryImob.Tables["Imobil"].Rows.Add(newRow);
            //facem update cu noul dataSet in db
            cursAdapter.Update(newQueryImob, "Imobil");
            myCon.Close();
        }

        [WebMethod]
        public void StergereDateProprietar(string cnp)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\AgImob\AgImob\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM DateProprietar ORDER BY cnp", myCon); //facem querry la db
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            DataSet deleteDatePropr = new DataSet(); //folosim dataSetul pentru manipularea datelor
            cursAdapter.Fill(deleteDatePropr, "DateProprietar"); //in dataSet facem o copie a tabelei
            DataColumn[] pk = new DataColumn[1]; //definim un array de ob DataColumn cu 1 element
            pk[0] = deleteDatePropr.Tables["DateProprietar"].Columns["cnp"]; //pe primul element din array punem coloana cnp care este de tipul DataColumn
            deleteDatePropr.Tables["DateProprietar"].PrimaryKey = pk; //setam pe dataSet ca si cheie primara cnp pe care l-am definit anterior
            //cautam Row-ul corespunzator cnp-ului primit pe metoda
            DataRow caut = null;
            while (caut == null)
            {
                caut = deleteDatePropr.Tables["DateProprietar"].Rows.Find(cnp); //cauta dupa cnp
            }
            caut.Delete(); //sterge Row gasit din dataSet
            cursAdapter.Update(deleteDatePropr, "DateProprietar"); //updateaza tabela din db cu dataSetul
            myCon.Close();
        }




        [WebMethod]
        public void StergereTipImobil(int Id_imobil)
        {

            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\AgImob\AgImob\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM TipImobil ORDER BY Id_imobil", myCon);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            DataSet deleteTipImobil = new DataSet();
            cursAdapter.Fill(deleteTipImobil, "TipImobil"); //in dataSet facem o copie a tabelei
            DataColumn[] pk = new DataColumn[1];//definim un array de ob DataColumn cu 1 element
            pk[0] = deleteTipImobil.Tables["TipImobil"].Columns["Id_imobil"];//pe primul element din array punem coloana id_imobil care este de tipul DataColumn
            deleteTipImobil.Tables["TipImobil"].PrimaryKey = pk;//setam pe dataSet ca si cheie primara id_imobil pe care l-am definit anterior
            ////cautam Row-ul corespunzator id_imobil -ului primit pe metoda
            DataRow caut = null;
            while (caut == null)
            {
                caut = deleteTipImobil.Tables["TipImobil"].Rows.Find(Id_imobil); //cauta dupa Id_imobil
            }
            caut.Delete(); //sterge randul gasit in dataSet
            cursAdapter.Update(deleteTipImobil, "TipImobil");//updateaza tabela din db cu dataSetul
            myCon.Close();
        }

        [WebMethod]
        public void StergereImobil(int Id_prop)
        {

            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\AgImob\AgImob\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM Imobil ORDER BY Id_prop", myCon);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            DataSet deleteImobil = new DataSet();
            cursAdapter.Fill(deleteImobil, "Imobil"); //in dataSet facem o copie a tabelei
            DataColumn[] pk = new DataColumn[1];//definim un array de ob DataColumn cu 1 element
            pk[0] = deleteImobil.Tables["Imobil"].Columns["Id_prop"];  //pe primul element din array punem coloana id_prop care este de tipul DataColumn
            deleteImobil.Tables["Imobil"].PrimaryKey = pk;//setam pe dataSet ca si cheie primara Id_prop pe care l-am definit anterior
            ////cautam Row-ul corespunzator Id_prop-ului primit pe metoda
            DataRow caut = null;
            while (caut == null)
            {
                caut = deleteImobil.Tables["Imobil"].Rows.Find(Id_prop); //cauta dupa Id_prop
            }
            caut.Delete(); //sterge randul gasit in dataSet
            cursAdapter.Update(deleteImobil, "Imobil");//updateaza tabela din db cu dataSetul
            myCon.Close();
        }


        [WebMethod]
        public void ModificareImobil(int Id_prop, string cnp, string tipimob, string adresaimob, string camere, string marimeimob, string pretimob, string dataimob)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\AgImob\AgImob\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM Imobil ORDER BY Id_prop", myCon);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            DataSet updateImobil = new DataSet();
            cursAdapter.Fill(updateImobil, "Imobil"); //in dataSet facem o copie a tabelei
            DataColumn[] pk = new DataColumn[1]; //definim un array de ob DataColumn cu 1 element
            pk[0] = updateImobil.Tables["Imobil"].Columns["Id_prop"]; //pe primul elem din array punem coloana Id_prop
            updateImobil.Tables["Imobil"].PrimaryKey = pk; ////setam pe dataSet ca si cheie primara Id_prop pe care l-am definit anterior//
            ////cautam Row-ul corespunzator primit pe metoda
            DataRow caut = null;
            while (caut == null)
            {
                caut = updateImobil.Tables["Imobil"].Rows.Find(Id_prop); //cautam dupa Id_prop
            }
            //populam randul creat
            caut["Id_prop"] = Id_prop;
            caut["cnp"] = cnp;
            caut["tipimob"] = tipimob;
            caut["adresaimob"] = adresaimob;
            caut["camere"] = camere;
            caut["marimeimob"] = marimeimob;
            caut["pretimob"] = pretimob;
            caut["dataimob"] = dataimob;
            //facem update cu noul dataSet in db
            cursAdapter.Update(updateImobil, "Imobil");
            myCon.Close();
        }

        [WebMethod]
        public void ModificareTipImobil(int Id_imobil, string tipulimob, string descrieretip)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\AgImob\AgImob\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM TipImobil ORDER BY Id_imobil", myCon);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            DataSet updateTipImobil = new DataSet();
            cursAdapter.Fill(updateTipImobil, "TipImobil"); //in dataSet facem o copie a tabelei
            DataColumn[] pk = new DataColumn[1]; //definim un array de ob DataColumn cu 1 element
            pk[0] = updateTipImobil.Tables["TipImobil"].Columns["Id_imobil"]; //pe primul elem din array punem coloana id_imobil
            updateTipImobil.Tables["TipImobil"].PrimaryKey = pk; ////setam pe dataSet ca si cheie primara id_imobil pe care l-am definit anterior//
            ////cautam Row-ul corespunzator primit pe metoda
            DataRow caut = null;
            while (caut == null)
            {
                caut = updateTipImobil.Tables["TipImobil"].Rows.Find(Id_imobil); //cautam dupa id_imobil
            }
            //populam randul creat
            caut["Id_imobil"] = Id_imobil;
            caut["tipulimob"] = tipulimob;
            caut["descrieretip"] = descrieretip;
            //facem update cu noul dataSet in db
            cursAdapter.Update(updateTipImobil, "TipImobil");
            myCon.Close();
        }

        [WebMethod]
        public void ModificareDatePropr(string cnp, string nume, string prenume, string adresa, string telefon, string email)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\AgImob\AgImob\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM DateProprietar ORDER BY cnp", myCon);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            DataSet updateDatePropr = new DataSet();
            cursAdapter.Fill(updateDatePropr, "DateProprietar"); //in dataSet facem o copie a tabelei
            DataColumn[] pk = new DataColumn[1];//definim un array de ob DataColumn cu 1 element
            pk[0] = updateDatePropr.Tables["DateProprietar"].Columns["cnp"];//pe primul elem din array punem coloana cnp
            updateDatePropr.Tables["DateProprietar"].PrimaryKey = pk;////setam pe dataSet ca si cheie primara id pe care l-am definit anterior
            //cautam Row-ul corespunzator primit pe metoda
            DataRow caut = null;
            while (caut == null)
            {
                caut = updateDatePropr.Tables["DateProprietar"].Rows.Find(cnp);//cautam dupa cnp
            }
            //populam randul creat
            caut["nume"] = nume;
            caut["prenume"] = prenume;
            caut["adresa"] = adresa;
            caut["telefon"] = telefon;
            caut["email"] = email;
            //facem update cu noul dataSet in db
            myCon.Close();
        }
    }


}
        

