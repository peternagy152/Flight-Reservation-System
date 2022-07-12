using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace LoginPage
{
    public partial class LogInForm : Form
    {

        string odb = ("Data source=ORCL;User Id=scott;Password=tiger;");
        OracleConnection conn2;

        public LogInForm()
        {
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            InitializeComponent();
    
            
        }
        private void LogInForm_Load(object sender, EventArgs e)
        {
            conn2 = new OracleConnection(odb);

        }



        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm  r = new RegisterForm();

            this.Hide();
            r.Show();
        }

    
        private void UserName_Click(object sender, EventArgs e)
        {
          
        }

        private void Password_Click_1(object sender, EventArgs e)
        {
      
           //Password.PasswordChar = '*';
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            conn2.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn2;
            if (UserName.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please Enter The missing data.");
                //this.Close();
                this.Show();
            }
            

            else
            {
                string x = UserName.Text;
             int y = int.Parse(Password.Text);
             cmd.CommandText = "select username , password , ssn from passenger where username = '" + x + "' and password = '" + y + "'";
             cmd.CommandType = CommandType.Text;
           
          
                OracleDataReader drr = cmd.ExecuteReader();
                if (drr.Read())
                {
                    global.passuser = drr[2].ToString();
                    MessageBox.Show("Successfull log in");
                    //this.Hide();
                    Form1 f = new Form1();
                    f.Show();
                    



                }
                else if (drr.Read().Equals(false))
                {
                    MessageBox.Show("check your username or password");


                }
                drr.Close();
           }
           
            conn2.Close();
            
        }

        


        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '\0')
            {
                UnseenBox4.BringToFront();
                Password.PasswordChar = '*';
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '*')
            {
                SeenBox5.BringToFront();
                Password.PasswordChar = '\0';
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
