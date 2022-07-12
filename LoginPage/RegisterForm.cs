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


    public partial class RegisterForm : Form
    {
        string odb = ("Data source=ORCL;User Id=scott;Password=tiger;");
        OracleConnection conn;
       

        public RegisterForm()
        {
            
            InitializeComponent();
           
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
           
            conn = new OracleConnection(odb);
            
          // birthdate.Text  = DateTime.Now.ToString("MM/dd/yyyy");

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            conn.Open();

            //string [] arr = new string[20];
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            string x = username.Text;
            cmd.CommandText = "select username from passenger where username = '" + x +"'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader drr = cmd.ExecuteReader();
            if (drr.Read())
            {
                MessageBox.Show("User Already Exists! Try Logging In");
                this.Dispose();

            }
            else if (drr.Read().Equals(false))
            {
                if (firstname.Text == "" || lastname.Text == "" || useridd.Text == "" || password.Text == "")
                {
                    MessageBox.Show("Please Enter The missing data.");
                    //this.Close();
                    this.Show();
                }
                else if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Please Enter The missing data.");
                    //this.Close();
                    this.Show();
                }
                else
                {

                    int y = 1;
                    int idd = 1;
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = conn;
                   

                
                    cmd2.CommandText = "insert into passenger values(:fn ,:ln ,:ssnn,:gndr,:bd ,:fid ,:username,:pass)";
                    cmd2.CommandType = CommandType.Text;
               
               
                    global.passuser = useridd.Text;
                    cmd2.Parameters.Add("fn ", firstname.Text);
                    cmd2.Parameters.Add("ln", lastname.Text);
                    cmd2.Parameters.Add("ssnn", useridd.Text);
                    if (radioButton1.Checked)
                    {
                        cmd2.Parameters.Add("gndr", radioButton1.Text);
                       

                    }
                    else if (radioButton2.Checked)
                    {
                        cmd2.Parameters.Add("gndr", radioButton2.Text);
                    }

                    try
                    {
                        cmd2.Parameters.Add("bd", Convert.ToDateTime(birthdate.Text));

                        cmd2.Parameters.Add("fid", y);
                        cmd2.Parameters.Add("username", username.Text);
                        cmd2.Parameters.Add("pass", password.Text);

                        if (pss2.Text != password.Text)
                        {
                            MessageBox.Show("Incorrect Password!");

                        }
                        else
                        {
                            int rV = cmd2.ExecuteNonQuery();
                            if (rV != -1)
                            {
                                MessageBox.Show("Registeration Successfull!");
                                this.Dispose();
                                Form1 f = new Form1();
                                f.Show();
                                this.Hide();

                            }
                        }





                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please enter the date in the format of (MM / dd / yyyy)");
                    }


                    drr.Close();

                }
            }


            conn.Close();

        }

        

       

        

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        
        

        private void SeenBox5_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '\0')
            {
                UnseenBox4.BringToFront();
                password.PasswordChar = '*';
            }
        }

        private void UnseenBox4_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '*')
            {
                SeenBox5.BringToFront();
                password.PasswordChar = '\0';
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pss2.PasswordChar == '\0')
            {
                pictureBox3.BringToFront();
                pss2.PasswordChar = '*';
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pss2.PasswordChar == '*')
            {
                pictureBox2.BringToFront();
                pss2.PasswordChar = '\0';
            }
        }

        private void birthdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
        }

        private void firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cc = e.KeyChar;
            if (!char.IsLetter(cc)  && cc != 8)
            {
                e.Handled = true;
            }
        }
    }


}

//public static class Passengerssn
//{
//    public static int passengerid;
//}