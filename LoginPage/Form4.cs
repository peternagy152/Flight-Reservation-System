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
    public partial class Form4 : Form
    {
        OracleConnection con;
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string qry2 = "select count(*) from ticket where pass_ssn=:ssn ";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = qry2;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ssn", global.passuser);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows[0][0].ToString() != "0")
            {
                con.Open();
                string qry = "select seat_number,class,f_id,price from ticket where id=:id";
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = con;
                cmd2.CommandText = qry;
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("id", Convert.ToInt32(comboBox1.SelectedItem));
                OracleDataReader dr2 = cmd2.ExecuteReader();
                // int price;
                if (dr2.Read())
                {

                    textBox1.Text = dr2[0].ToString();
                    textBox2.Text = dr2[1].ToString();
                    textBox3.Text = dr2[2].ToString();
                    textBox4.Text = dr2[3].ToString();
                }
                dr2.Close();
                con.Close();
                con.Open();
                tickets.Items.Clear();
                OracleCommand comm = new OracleCommand();
                comm.Connection = con;
                comm.CommandText = "select id from ticket where F_ID = :idd and reserved like 'available' ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.Add("idd", Convert.ToInt32(textBox3.Text));
                OracleDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    tickets.Items.Add(dr[0]);
                }
                dr.Close();
                con.Close();

            }
            else
                MessageBox.Show("No Reserved Tickets");

            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con = new OracleConnection("Data Source = ORCL ; User Id=scott; Password = tiger;");
            con.Open();
            //string qry = "select id from ticket where pass_ssn=:ssn";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "GetTicket";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("passid", global.passuser);
            cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (tickets.SelectedItem != null)
            {
                OracleCommand c = new OracleCommand();
                c.Connection = con;
                c.CommandText = "update ticket set Reserved = 'available' , pass_ssn = NULL where id = :idd";
                c.CommandType = CommandType.Text;
                c.Parameters.Add("idd", Convert.ToInt32(comboBox1.SelectedItem));
                int x = c.ExecuteNonQuery();

                OracleCommand com = new OracleCommand();
                com.Connection = con;
                com.CommandText = "update ticket set Reserved = 'Reserved' , pass_ssn = :ssn where id = :idd";
                com.CommandType = CommandType.Text;
                com.Parameters.Add("ssn", global.passuser);
                com.Parameters.Add("idd", Convert.ToInt32(tickets.SelectedItem));
                int y = com.ExecuteNonQuery();

                MessageBox.Show("Edited");

                this.Close();
            }
            else
                MessageBox.Show("There is no ticket to edit");


            con.Close();
        }

        private void tickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand comm = new OracleCommand();
            comm.Connection = con;
            comm.CommandText = "GetData2";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("id", tickets.SelectedItem.ToString());
            comm.Parameters.Add("seats", OracleDbType.NVarchar2, ParameterDirection.Output);
            comm.Parameters.Add("cls", OracleDbType.Varchar2, ParameterDirection.Output);
            comm.Parameters.Add("price", OracleDbType.Varchar2, ParameterDirection.Output);
            OracleDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                seat.Text = dr[0].ToString();
                cls.Text = dr[1].ToString();
                price.Text = dr[2].ToString();
            }
            dr.Close();
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //con.Open();
            if (comboBox1.Items.Count < 1)
            {
                MessageBox.Show("you have no reserved flights.");
            }
            else if (comboBox1.SelectedIndex != -1)
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "update ticket set ticket.reserved= 'available' , ticket.pass_ssn=NULL where " +
                   "ticket.pass_ssn= :ssn and ticket.F_ID= :fid AND TICKET.ID=:ID ";
                cmd.Parameters.Add("ssn", Int32.Parse(global.passuser));
                cmd.Parameters.Add("fid", Int32.Parse(textBox3.Text.ToString()));
                cmd.Parameters.Add("ID", Int32.Parse(comboBox1.SelectedItem.ToString()));
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Deleted successfully");
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    seat.Text = "";
                    cls.Text = "";
                    price.Text = "";
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("choose an id from combo box please.");
            }
           // con.Close();

        }
    }
}
