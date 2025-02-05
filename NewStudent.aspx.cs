using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class NewStudent : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        disp_data();

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        Response.Redirect("HomePage.aspx");
    }

    protected void btnAddStudent_Click1(object sender, EventArgs e)
    {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into Student values ('" + txtStudentName.Text + "','" + txtRegistrationNumber.Text + "')";
        cmd.ExecuteNonQuery();
        txtStudentName.Text = "";
        txtRegistrationNumber.Text = "";

        disp_data();
    }

    protected void btnDeleteStudent_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "delete from Student where StudentName= '" + txtStudentName.Text + "'";
        cmd.ExecuteNonQuery();
        txtStudentName.Text = "";
        txtRegistrationNumber.Text = "";

        disp_data();
    }

    public void disp_data()
    {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select StudentName,RegistrationNumber from Student";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        GridViewStudent.DataSource = dt;
        GridViewStudent.DataBind();
    }
}