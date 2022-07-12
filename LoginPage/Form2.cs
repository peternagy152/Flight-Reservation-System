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
    public partial class Form2 : Form
    {
        OracleConnection con = new OracleConnection("Data Source = ORCL ; User Id=scott; Password = tiger;");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            string qry = "Select ffrom , too from flight where id =: flightid";
            cmd.CommandText = qry;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("flightid", global.flightId);
            OracleDataReader dd = cmd.ExecuteReader();
            if (dd.Read())
            {
                textBox1.Text = dd[0].ToString();
                textBox2.Text = dd[1].ToString();

            }
            textBox3.Text = global.classname;

            dd.Close();

            if (textBox3.Text == "Economy")
            {
                textBox4.Text = global.economy.ToString();
                int x = global.economy * Convert.ToInt32(global.seatsnum);
                textBox5.Text = x.ToString();
            }
            else if (textBox3.Text == "Business")
            {
                textBox4.Text = global.bussiness.ToString();
                int x = global.bussiness * Convert.ToInt32(global.seatsnum);
                textBox5.Text = x.ToString();
            }
            else if (textBox3.Text == "First Class")
            {
                textBox4.Text = global.firstclass.ToString();
                int x = global.firstclass * Convert.ToInt32(global.seatsnum);
                textBox5.Text = x.ToString();
            }


            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            int cap;
            string qrt = "Select capacity from flight where id =: flightid";
            OracleCommand cmd4 = new OracleCommand();
            cmd4.Connection = con;
            cmd4.CommandText = qrt;
            cmd4.CommandType = CommandType.Text;

            cmd4.Parameters.Add("flightid", global.flightId);
            OracleDataAdapter da4 = new OracleDataAdapter(cmd4);

            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            cap = Convert.ToInt32(dt4.Rows[0][0]);

            for (int y = 1; y <= Convert.ToInt32(global.seatsnum);y++)
            {
              // con.Open();
                while (true)
                {
                    Random rand = new Random();
                    x = rand.Next();

                    con.Open();
                    string qry2 = "select count(*) from ticket where id =: x";
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = qry2;
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.Add("x", x);


                    OracleDataAdapter da2 = new OracleDataAdapter(cmd2);

                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    if (dt2.Rows[0][0].ToString() == "0")
                        break;
                }
                con.Close();
                con.Open();
               
                string qry;
                qry = "Insert into ticket values(:id,:seat,:class,:pass,:fid,:res,:price)";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = qry;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("id", x);
                cmd.Parameters.Add("seat", cap);
                cmd.Parameters.Add("class", textBox3.Text);
                cmd.Parameters.Add("pass", global.passuser);
                cmd.Parameters.Add("fid", global.flightId);
                cmd.Parameters.Add("res", "Reserved");
                cmd.Parameters.Add("price", textBox4.Text);
                 cmd.ExecuteNonQuery();
                cap--;
                con.Close();
                con.Open();
                string qrt2;
                qrt2 = "update flight set capacity =: Cap where id =: flight";
                OracleCommand cmd5 = new OracleCommand();
                cmd5.Connection = con;
                cmd5.CommandText = qrt2;
                cmd5.CommandType = CommandType.Text;
                cmd5.Parameters.Add("Cap", cap);
                cmd5.Parameters.Add("flight", global.flightId);
                cmd5.ExecuteNonQuery();
                /* if (r != -1 )
                 {




                 }*/
                
                con.Close();
                
            }
           // con.Close();
            MessageBox.Show("Tickets Purchased Successfully");

            Form4 ff = new Form4();
            ff.Show();
           // this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
