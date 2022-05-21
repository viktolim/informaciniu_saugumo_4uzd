using Scrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
               // DataService.putCreatedDataToExcel("vik", "slap", "dlk", "ds");


            //temp=DataService.getDataFromExcel("vik");
            // User user = new User(temp.Rows[0].ItemArray[0].ToString(), temp.Rows[0].ItemArray[1].ToString(), temp.Rows[0].ItemArray[2].ToString(), temp.Rows[0].ItemArray[3].ToString());
            //DataService.deleteDataFromExcel("aha");
            //DataService.putDataToExcel("vik",aesCrypto.encrypt("galva","vik"),"ghb","turi");
            try
            {
               /* DataService.setTextTofile(aesCrypto.encrypt("sveikuciai", "ohbh"));
                MessageBox.Show(aesCrypto.decrypt(DataService.getTextFromFile(), "ohbh"));*/
               

            }
            catch(Exception e)
            {
                MessageBox.Show("noo");
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(setUsername.Text, setPassword.Text);

            Creater nauj = new Creater();
            nauj.createUser(user.getUsername(), user.getUserPassword());
            nauj.Show();
            this.Hide();



        }
    }
}
