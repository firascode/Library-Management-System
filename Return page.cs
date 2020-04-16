using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MINI_PROJECT_LMS___FINAL_v
{
    public partial class rtr : UserControl
    {
        public rtr()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        //int i = -1;
        private void rtr_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=C:\\Users\\firas\\Desktop\\LMS\\LMS.mdb");

            con.Open();
            da = new OleDbDataAdapter("select * from student ", con);
            ds = new DataSet();
            da.Fill(ds);
           /* textBoxID.Text = ds.Tables[0].Rows[0][0].ToString();
            textBoxSNAME.Text = ds.Tables[0].Rows[0][1].ToString();
            textBoxSID.Text = ds.Tables[0].Rows[0][2].ToString();
            textBoxBD.Text = ds.Tables[0].Rows[0][3].ToString();
            textBoxRD.Text = ds.Tables[0].Rows[0][4].ToString();*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.UpdateCommand = new OleDbCommand();
            da.UpdateCommand.CommandText = "update student set rdate='" + textBoxRD.Text + "'where Bid=" + textBoxID.Text;
            da.UpdateCommand.Connection = con;
            da.UpdateCommand.ExecuteNonQuery();
            MessageBox.Show("Record Update");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow[] row = ds.Tables[0].Select("Bid=" + srch.Text);
            textBoxID.Text = row[0][0].ToString();
            textBoxSNAME.Text = row[0][1].ToString();
            textBoxSID.Text = row[0][2].ToString();
            textBoxBD.Text = row[0][3].ToString();
            textBoxRD.Text = row[0][4].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxSNAME.Clear();
            textBoxSID.Clear();
            textBoxBD.Clear();
            textBoxRD.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxRD.Clear();
        }
    }
}
