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
    public partial class add : UserControl
    {
        public add()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        //int i = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            da.InsertCommand = new OleDbCommand();
            da.InsertCommand.CommandText = "insert into BOOKS1 values( " + textBoxID.Text + " , '"+textBoxNAME.Text+"' ,'"+textBoxAUTHOR.Text+"','" +textBoxPUBLISHER.Text+"','"+textBoxCATEGORY.Text+"',"+textBoxYEAR.Text+","+textBoxEDTION.Text+","+textBoxRDMAC.Text+" )";

            da.InsertCommand.Connection = con;
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("The Book Has Been Saved");
        }

        private void add_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=C:\\Users\\firas\\Desktop\\LMS\\LMS.mdb");

            con.Open();
            da = new OleDbDataAdapter("select * from BOOKS1", con);
            ds = new DataSet();
            da.Fill(ds);
            /*textBoxID.Text = ds.Tables[0].Rows[0][0].ToString();
            textBoxNAME.Text = ds.Tables[0].Rows[0][1].ToString();
            textBoxAUTHOR.Text = ds.Tables[0].Rows[0][2].ToString();
            textBoxPUBLISHER.Text = ds.Tables[0].Rows[0][3].ToString();
            textBoxCATEGORY.Text = ds.Tables[0].Rows[0][4].ToString();
            textBoxYEAR.Text = ds.Tables[0].Rows[0][5].ToString();
            textBoxEDTION.Text = ds.Tables[0].Rows[0][6].ToString();
            textBoxRDMAC.Text = ds.Tables[0].Rows[0][7].ToString();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxNAME.Clear();
            textBoxAUTHOR.Clear();
            textBoxPUBLISHER.Clear();
            textBoxCATEGORY.Clear();
            textBoxYEAR.Clear();
            textBoxEDTION.Clear();
            textBoxRDMAC.Clear();

            

        }
    }
}
