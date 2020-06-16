using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
//using System.Data.OracleClient;

namespace module5_5Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        private string user = "";
        private string pass = "";
        private string dataSrc = "data source=PRFT-15123;";
        private string database = "database=fabrikam2;";
        private string args = "integrated security=SSPI;";


        protected void Page_Load(object sender, EventArgs e)
        {

            //SqlConnection con = new SqlConnection(dataSrc + database + args);
            //SqlCommand cmd = new SqlCommand("SELECT * FROM school", con);
            //con.Open();
            //SqlDataReader rdr = cmd.ExecuteReader();
            //GridView1.DataSource = rdr;
            //GridView1.DataBind();
            //con.Close();



        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}