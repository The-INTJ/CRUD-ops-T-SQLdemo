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
            var students = dbContext.findStudent(fName, lName, major);

            GridView2.DataSource = students.AsEnumerable().ToArray();
            GridView2.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string fName = TextBox1.Text;
            string lName = TextBox2.Text;
            string major = DropDownList1.Text;

            var dbContext = new fabrikam2DbContext();
            dbContext.insertStudent(fName, lName, major);

            DropDownList1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string fName = TextBox1.Text;
            string lName = TextBox2.Text;
            string major = DropDownList1.Text;

            var dbContext = new fabrikam2DbContext();
            dbContext.deleteStudent(fName, lName, major);

            DropDownList1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string fName = TextBox1.Text;
            string lName = TextBox2.Text;
            string major = DropDownList1.Text;

            var dbContext = new fabrikam2DbContext();
            dbContext.updateStudent(fName, lName, major);

            DropDownList1.DataBind();
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}