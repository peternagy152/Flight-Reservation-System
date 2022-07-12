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
    public partial class myReservations : Form
    {
        string orcl = "Data source=orcl;user Id=scott;password=tiger;";
        OracleConnection conn;
        public myReservations()
        {
            InitializeComponent();
        }
        public string n;
        public int counter = 1;
        private void myReservations_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(orcl);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select FLIGHT.too from FLIGHT inner join ticket on ticket.pass_ssn=:ssn and ticket.f_id = flight.id";
            cmd.Parameters.Add("ssn", Int32.Parse(global.passuser));
            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                n = dr[0].ToString();
                cmb_flightTo.Items.Add(dr[0]);

            }
            while (dr.Read()) //ad el flight id el f passenger
            {

                if (n == dr[0].ToString())
                {
                    counter++;
                    continue;
                }

                else if (n != dr[0].ToString())
                {
                    if (cmb_flightTo.Items.Contains(dr[0].ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        cmb_flightTo.Items.Add(dr[0]);
                        counter = 1;
                        n = dr[0].ToString();
                    }
                }
            }
            dr.Close();
            conn.Close();
        }

        private void cmb_flightTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id,fromm,capacity,airport,takeoff,landingtime from flight where TOO=:too  ";
            cmd.Parameters.Add("too", cmb_flightTo.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_airport.Text = dr[3].ToString();
                txt_capacity.Text = dr[2].ToString();
                txt_from.Text = dr[1].ToString();
                txt_id.Text = dr[0].ToString();
                txt_landing.Text = dr[5].ToString();
                txt_takeOFf.Text = dr[4].ToString();
            }

            dr.Close();
            conn.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (cmb_flightTo.Items.Count < 1)
            {
                MessageBox.Show("you have no reserved flights.");
            }
            else if (cmb_flightTo.SelectedIndex != -1)
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update ticket set ticket.reserved= 'available' , ticket.pass_ssn=NULL where " +
                    "ticket.pass_ssn= :ssn and ticket.F_ID= :id ";
                cmd.Parameters.Add("ssn", Int32.Parse(global.passuser));
                cmd.Parameters.Add("id", Int32.Parse(txt_id.Text.ToString()));
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Deleted successfully");
                    cmb_flightTo.Items.RemoveAt(cmb_flightTo.SelectedIndex);
                    txt_airport.Text = "";
                    txt_capacity.Text = "";
                    txt_from.Text = "";
                    txt_id.Text = "";
                    txt_landing.Text = "";
                    txt_takeOFf.Text = "";
                }
            }
            else
            {
                MessageBox.Show("choose a destination from combo box please.");
            }
            conn.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
