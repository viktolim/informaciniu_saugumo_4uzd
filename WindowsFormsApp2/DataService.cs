using DocumentFormat.OpenXml.Spreadsheet;
using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp2
{

    class DataService
    {
        protected static string filePath = Directory.GetCurrentDirectory() + "/file.txt";
        protected static string usersFilePath = Directory.GetCurrentDirectory() + "/users.xls";
            protected static string createdFilePath = Directory.GetCurrentDirectory() + "/created.xls";

        public void createTextFile()
        {
            StreamWriter sw = File.CreateText(filePath);
        }
        public string getTextFromFile()
        {
            return File.ReadAllText(filePath);
        }
        public void setTextTofile(string text)
        {
            File.WriteAllText(filePath, text, Encoding.UTF8);
        }
        public  void addTextTOfile(string text)
        {
            File.AppendAllText(filePath, text, Encoding.UTF8);
        }
        public static DataTable getDataFromExcelByName(string name)
        {
            string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + usersFilePath + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;\'";
            OleDbConnection connection = new OleDbConnection(con);                      //prisijungiama prie excel kuris buvo nurodytas kuriant klasės konstruktoriu
            OleDbCommand command = new OleDbCommand("select * from [Sheet1$] WHERE Pavadinimas='" + name + "'", connection); //priskiriama ką turės padaryti
            connection.Open();
            OleDbDataAdapter sda = new OleDbDataAdapter();
            sda.SelectCommand = command;                                                //Nuskaitomi visi duomenys kurie yra įvesti excel puslapyje Sheeet1
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connection.Close();//duomenys įrašomi į lentelę                                                
            return dt;                                                                 //grąžinami įrašyta lentelė kuri yra nuskaityta nuo excel

        }
        public DataTable getUserFromExcel(string username,string password)
        {
            string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + usersFilePath + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;\'";
            OleDbConnection connection = new OleDbConnection(con);                      //prisijungiama prie excel kuris buvo nurodytas kuriant klasės konstruktoriu
            OleDbCommand command = new OleDbCommand("select * from [Sheet1$] WHERE Slapyvardis='" + username + "' AND Slaptazodisuser = '" + password + "'", connection); //priskiriama ką turės padaryti
            connection.Open();
            OleDbDataAdapter sda = new OleDbDataAdapter();
            sda.SelectCommand = command;                                                //Nuskaitomi visi duomenys kurie yra įvesti excel puslapyje Sheeet1
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connection.Close();//duomenys įrašomi į lentelę                                                
            return dt;                                                                 //grąžinami įrašyta lentelė kuri yra nuskaityta nuo excel

        }
        public static void putCreatedDataToExcel(string username,string usernamePassword, string name, string password, string Url, string comment)
        {
            string coni = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + usersFilePath + ";Extended Properties=\'Excel 8.0;HDR=Yes;IMEX=2'";
            OleDbConnection con;
            OleDbCommand command = new OleDbCommand(); //priskiriama ką turės padaryti
            con = new OleDbConnection(coni);
            con.Open();
            command.Connection = con;
            string query = "INSERT INTO [Sheet1$](Slapyvardis,Slaptazodisuser,Pavadinimas,Slaptazodis,URL,Komentaras) VALUES('" + username + "','" + usernamePassword + "','" + name + "','" + password + "','" + Url + "','" + comment + "')";
            //prisijungiama prie excel kuris buvo nurodytas kuriant klasės konstruktoriu
            command.CommandText = query;
            command.ExecuteNonQuery();
            con.Close();
        }
        public static void putUserDataToExcel(string name, string password)
        {
            string coni = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + usersFilePath + ";Extended Properties=\'Excel 8.0;HDR=Yes;IMEX=2'";
            OleDbConnection con;
            OleDbCommand command = new OleDbCommand(); //priskiriama ką turės padaryti
            con = new OleDbConnection(coni);
            con.Open();
            command.Connection = con;
            string query = "INSERT INTO [Sheet1$](Slapyvardis,Slaptazodis) VALUES('" + name + "','" + password + "')";
            //prisijungiama prie excel kuris buvo nurodytas kuriant klasės konstruktoriu
            command.CommandText = query;
            command.ExecuteNonQuery();
            con.Close();
        }
        public static void changePasswordFromExcel(string newpassword,string password, string name)
        {
            try
            {
                string coni = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + usersFilePath + ";Extended Properties=\'Excel 8.0;HDR=Yes;IMEX=2'";
                OleDbConnection con;
                OleDbCommand command = new OleDbCommand(); //priskiriama ką turės padaryti
                con = new OleDbConnection(coni);
                con.Open();
                command.Connection = con;
                string query = "UPDATE [Sheet1$] SET Slaptazodis='" + newpassword + "' WHERE Pavadinimas='" + name + "' AND Slaptazodisuser='" + password + "'";
                //prisijungiama prie excel kuris buvo nurodytas kuriant klasės konstruktoriu
                command.CommandText = query;
                command.ExecuteNonQuery();
                con.Close(); }
            catch (Exception e)

            { 

            }
        }
        public static string deleteDataFromExcel(string password)
        {
            try
            {
                
                string coni = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + usersFilePath + ";Extended Properties=\'Excel 8.0;HDR=Yes;IMEX=2'";
                OleDbConnection con;
                OleDbCommand command = new OleDbCommand(); //priskiriama ką turės padaryti
                con = new OleDbConnection(coni);
                con.Open();
                command.Connection = con;
                string query = "UPDATE [Sheet1$] SET Pavadinimas='',Slaptazodis='',URL='',Komentaras='',Slapyvardis='',Slaptazodisuser='' WHERE Slaptazodis='" + password + "'";
                //prisijungiama prie excel kuris buvo nurodytas kuriant klasės konstruktoriu
                command.CommandText = query;
                command.ExecuteNonQuery();
                con.Close();
                return null;
            }
            catch(Exception e)
            {
                return "Negalite panaikinti, nes ne jūsų sukurtas";
            }

        }
    }
}
