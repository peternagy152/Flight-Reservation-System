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
    public partial class Form1 : Form
    {
        OracleConnection con = new OracleConnection("Data Source = ORCL ; User Id=scott; Password = tiger;");
        int selectedrow;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void butsearch_Click(object sender, EventArgs e)
        {
            string constr1 = "Data Source = ORCL ; User Id=scott; Password = tiger;";
            string qqq = "select count(*) from flight where ffrom = '" + txtfrom.Text + "' and too = '" + txtto.Text + "' and capacity >= '" + txtseats.Text + "'";
            OracleDataAdapter d32 = new OracleDataAdapter(qqq, constr1);
            DataTable ds = new DataTable();
            d32.Fill(ds);
            if (ds.Rows[0][0].ToString() != "0")
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
               string qry = "select * from flight where ffrom =: ffrom and too =:too and capacity >= :seats";
                cmd.Connection = con;
                cmd.CommandText = qry;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("ffrom", txtfrom.Text);
                cmd.Parameters.Add("too", txtto.Text);
                cmd.Parameters.Add("seats", txtseats.Text);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataTable dt = new DataTable();


                da.Fill(dt);
                // int rowindex = dataGridView1.CurrentCell.RowIndex;

                global.seatsnum = txtseats.Text;
                if (radioButton1.Checked)
                {
                    global.classname = radioButton1.Text;
                    dataGridView1.DataSource = dt;
                }
                else if (radioButton2.Checked)
                {
                    global.classname = radioButton2.Text;
                    dataGridView1.DataSource = dt;

                }
                else if (radioButton3.Checked)
                {
                    global.classname = radioButton3.Text;
                    dataGridView1.DataSource = dt;

                }
                else
                    MessageBox.Show("Please select a class");
                con.Close();
            }
            else
            {

                MessageBox.Show("No flights available");
                dataGridView1.DataSource = string.Empty;
                con.Close();

            }
            txtfrom.Clear();
            //txtseats.Clear();
           txtto.Clear();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {

                MessageBox.Show("Please Select A Flight !");
            }
            else
            {
                Form2 f2 = new Form2();
                f2.Show();
               // this.Hide();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedrow];
            textBox1.Text = row.Cells[0].Value.ToString();
            global.flightId = textBox1.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myReservations r = new myReservations();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
          //  this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LogInForm l = new LogInForm();
            l.Show();
            this.Close();
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Crystal_Report c = new Crystal_Report();
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 ff = new Form3();
            ff.Show();
        }
    }
}
public static class global
{
    public static string flightId;
    public static string seatsnum;
    public static int economy = 500;
    public static int bussiness = 700;
    public static int firstclass = 1000;
    public static string classname;
    public static string passuser;
}

