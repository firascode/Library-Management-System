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
    public partial class borr : UserControl
    {
        public borr()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        int i = -1;
        private void borr_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=C:\\Users\\firas\\Desktop\\LMS\\LMS.mdb");

            con.Open();
            da = new OleDbDataAdapter("select * from student ", con);
            ds = new DataSet();
            /*da.Fill(ds);
            textBoxID.Text = ds.Tables[0].Rows[0][0].ToString();
            textBoxSNAME.Text = ds.Tables[0].Rows[0][1].ToString();
            textBoxSID.Text = ds.Tables[0].Rows[0][2].ToString();
            textBoxBD.Text = ds.Tables[0].Rows[0][3].ToString();
            textBoxRD.Text = ds.Tables[0].Rows[0][4].ToString();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.InsertCommand = new OleDbCommand();
            da.InsertCommand.CommandText = "insert into student values(" + textBoxID.Text +
            ",'" + textBoxSNAME.Text + "'," + textBoxSID.Text + ",'" + textBoxBD.Text + "','" + textBoxRD.Text + "')";
            da.InsertCommand.Connection = con;
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("its Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxSNAME.Clear();
            textBoxSID.Clear();
            textBoxBD.Clear();
            textBoxRD.Clear();
        }
    }
}
