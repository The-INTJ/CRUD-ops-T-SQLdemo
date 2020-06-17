using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace module5_5Web
{
    public partial class ManageStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string fName = TextBox1.Text;
            string lName = TextBox2.Text;
            string major = DropDownList1.Text;

            var dbContext = new fabrikam2DbContext();
            var student = dbContext.findStudent(fName, lName, major);


            GridView2.DataSource = student;
            GridView2.DataBind();


            //string fName = TextBox1.Text;
            //string lName = TextBox2.Text;
            //string major = DropDownList1.Text;

            //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);
            //SqlCommand cmd = new SqlCommand("SELECT * FROM student WHERE firstName=@fName AND " +
            //                                "lastName = @lName AND " +
            //                                "major = @major", con);
            //cmd.Parameters.AddWithValue("@fName", fName);
            //cmd.Parameters.AddWithValue("@lName", lName);
            //cmd.Parameters.AddWithValue("@major", major);
            //con.Open();
            //GridView2.DataSource = cmd.ExecuteReader();
            //GridView2.DataBind();
            //con.Close();

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SELECT * FROM student WHERE firstName=@fName AND " +
                                            "lastName = @lName AND " +
                                            "major = @major", con);
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@major", major);
            con.Open();
            GridView3.DataSource = cmd.ExecuteReader();
            GridView3.DataBind();
            con.Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string fName = TextBox1.Text;
            string lName = TextBox2.Text;
            string major = DropDownList1.Text;

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("INSERT INTO student(firstName, lastName, major) VALUES (@fName, @lName, @major)", con);
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@major", major);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DropDownList1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string fName = TextBox1.Text;
            string lName = TextBox2.Text;
            string major = DropDownList1.Text;

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("DELETE FROM student " +
                                            "WHERE firstName=@fName AND " +
                                            "lastName = @lName AND " +
                                            "major = @major", con);
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@major", major);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DropDownList1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string fName = TextBox1.Text;
            string lName = TextBox2.Text;
            string major = DropDownList1.Text;

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("UPDATE student " +
                                            "SET major = @major " +
                                            "WHERE firstName=@fName AND " +
                                            "lastName = @lName", con);
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@major", major);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DropDownList1.DataBind();
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}