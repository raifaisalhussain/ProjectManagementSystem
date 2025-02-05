using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Projects : System.Web.UI.Page
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

    public void disp_data()
    {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select ProjectName,ProjectDescription from Project";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        GridViewProject.DataSource = dt;
        GridViewProject.DataBind();
    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");

    }

    protected void btnSaveProject_Click1(object sender, EventArgs e)
    {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into Project values ('" + txtProjectName.Text + "','" + txtProjectDescription.Text + "')";
        cmd.ExecuteNonQuery();
        txtProjectName.Text = "";
        txtProjectDescription.Text = "";

        disp_data();

    }

    protected void btnDeleteProject_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "delete from Project where ProjectName= '" + txtProjectName.Text + "'";
        cmd.ExecuteNonQuery();
        txtProjectName.Text = "";
        txtProjectDescription.Text = "";

        disp_data();
    }

}