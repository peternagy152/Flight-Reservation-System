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
    public partial class Form3 : Form

    {
        OracleDataAdapter adapter;
        DataSet ds11;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string con = "Data Source = ORCL ; User Id=scott; Password = tiger;";
            string qry = "select * from passenger  where ssn = '" + global.passuser + "' ";

            adapter = new OracleDataAdapter(qry, con);
            ds11 = new DataSet();
            adapter.Fill(ds11);
            dataGridView1.DataSource = ds11.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            OracleCommandBuilder build = new OracleCommandBuilder(adapter);
            adapter.Update(ds11.Tables[0]);
            MessageBox.Show("Updating Account Info is Succeeded ");
        }
    }
}
