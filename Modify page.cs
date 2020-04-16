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
    public partial class modi : UserControl
    {
        public modi()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        // int i = -1;
        private void button1_Click(object sender, EventArgs e)
        {


            da.UpdateCommand = new OleDbCommand();
            da.UpdateCommand.CommandText = "update BOOKS1 set bname='" + textBoxNAME.Text + "'where Bid=" + textBoxID.Text;
            da.UpdateCommand.Connection = con;
            da.UpdateCommand.ExecuteNonQuery();
        




            da.DeleteCommand = new OleDbCommand();
            da.DeleteCommand.CommandText = "delete from BOOKS1 where Bid=" +
            textBoxID.Text;
            da.DeleteCommand.Connection = con;
            da.DeleteCommand.ExecuteNonQuery();
           










        }

        private void modi_Load(object sender, EventArgs e)
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
            da.DeleteCommand = new OleDbCommand();
            da.DeleteCommand.CommandText = "delete from BOOKS1 where Bid=" +
            textBoxID.Text;
            da.DeleteCommand.Connection = con;
            da.DeleteCommand.ExecuteNonQuery();
            MessageBox.Show("Its Delete");
        }

        private void button3_Click(object sender, EventArgs e)
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
