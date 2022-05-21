using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Creater : Form
    {
        User user;
       
        public Creater()
        {
            InitializeComponent();
           
        }
        
        public  void createUser(string name, string password)
        {
            DataTable temp = new DataTable();
            AesCrypto aesCrypto = new AesCrypto();
            DataService dataService = new DataService();
            RSACrypto rsa = new RSACrypto();

            user = new User(name, password);
            temp = dataService.getUserFromExcel(aesCrypto.encrypt(user.getUsername(), user.getUserPassword()), aesCrypto.encrypt(user.getUserPassword(), user.getUserPassword()));
            if (temp.Rows.Count == 0)
            {
                MessageBox.Show("Hello new user");


            }
            else
            {
                
                user.setPassword(aesCrypto.decrypt(temp.Rows[0].ItemArray[3].ToString(), user.getUserPassword()));
                user.created(temp.Rows[0].ItemArray[5].ToString(), temp.Rows[0].ItemArray[2].ToString(), temp.Rows[0].ItemArray[4].ToString());
                SetPassword.Text = temp.Rows[0].ItemArray[3].ToString();
                SetUrl.Text=rsa.Decrypt(user.getUrl(), user.getPassword());
                setComment.Text = rsa.Decrypt(user.getComment(), user.getPassword());
                setName.Text = user.getName();
              
            }
            
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Creater_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RSACrypto rsa = new RSACrypto();
            AesCrypto aesCrypto = new AesCrypto();
            DataTable temp=DataService.getDataFromExcelByName(setName.Text);
            if (temp.Rows.Count != 0) { 
                SetPassword.Text = temp.Rows[0].ItemArray[3].ToString(); 
            setComment.Text = temp.Rows[0].ItemArray[5].ToString();
            SetUrl.Text = temp.Rows[0].ItemArray[4].ToString();
                if(temp.Rows[0].ItemArray[1].ToString()== aesCrypto.encrypt(user.getUserPassword(), user.getUserPassword())) user.setPassword(aesCrypto.decrypt(SetPassword.Text, user.getUserPassword()));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AesCrypto aesCrypto = new AesCrypto();
            RSACrypto rsa = new RSACrypto();
            DataService.putCreatedDataToExcel(aesCrypto.encrypt(user.getUsername(), user.getUserPassword()), aesCrypto.encrypt(user.getUserPassword(), user.getUserPassword()), setName.Text, aesCrypto.encrypt(SetPassword.Text, user.getUserPassword()), rsa.Encrypt(SetUrl.Text, SetPassword.Text), rsa.Encrypt(setComment.Text, SetPassword.Text));
            setName.Text = null;
            SetPassword.Text = null;
            SetUrl.Text = null;
            setComment.Text = null;
            MessageBox.Show("Išsaugota");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetPassword.Text = user.getPassword();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RSACrypto rsa = new RSACrypto();
            SetUrl.Text = rsa.Decrypt(SetUrl.Text, SetPassword.Text);
            setComment.Text = rsa.Decrypt(setComment.Text, SetPassword.Text);

 
        }

        private void SetPassword_Click(object sender, EventArgs e)
        {
            SetPassword.Text = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
     
            AesCrypto aesCrypto = new AesCrypto();
 
                string msg = DataService.deleteDataFromExcel(aesCrypto.encrypt(SetPassword.Text, user.getUserPassword()));
            
    
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AesCrypto aesCrypto = new AesCrypto();
            DataService.changePasswordFromExcel(aesCrypto.encrypt(SetPassword.Text, user.getUserPassword()), aesCrypto.encrypt(user.getUserPassword(), user.getUserPassword()),setName.Text);
        }
    }
}
