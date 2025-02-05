using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class CreateGroup : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Student1();
            Student2();
            Student3();
            Student4();
            Project();
        }
    }
    public void Student1()
    {
        SqlCommand cmd = new SqlCommand("Select RegistrationNumber from Student", con);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        DropDownListStudent1.DataTextField = "RegistrationNumber";
        DropDownListStudent1.DataValueField = "RegistrationNumber";
        DropDownListStudent1.DataSource = rdr;
        DropDownListStudent1.DataBind();
        con.Close();
    }

    public void Student2()
    {
        SqlCommand cmd = new SqlCommand("Select RegistrationNumber from Student", con);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        DropDownListStudent2.DataTextField = "RegistrationNumber";
        DropDownListStudent2.DataValueField = "RegistrationNumber";
        DropDownListStudent2.DataSource = rdr;
        DropDownListStudent2.DataBind();
        con.Close();
    }

    public void Student3()
    {
        SqlCommand cmd = new SqlCommand("Select RegistrationNumber from Student", con);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        DropDownListStudent3.DataTextField = "RegistrationNumber";
        DropDownListStudent3.DataValueField = "RegistrationNumber";
        DropDownListStudent3.DataSource = rdr;
        DropDownListStudent3.DataBind();
        con.Close();
    }

    public void Student4()
    {
        SqlCommand cmd = new SqlCommand("Select RegistrationNumber from Student", con);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        DropDownListStudent4.DataTextField = "RegistrationNumber";
        DropDownListStudent4.DataValueField = "RegistrationNumber";
        DropDownListStudent4.DataSource = rdr;
        DropDownListStudent4.DataBind();
        con.Close();
    }

    public void Project()
    {
        SqlCommand cmd = new SqlCommand("Select ProjectName from Project", con);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        DropDownListProject.DataTextField = "ProjectName";
        DropDownListProject.DataValueField = "ProjectName";
        DropDownListProject.DataSource = rdr;
        DropDownListProject.DataBind();
        con.Close();

    }
    protected void btnBackAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }


    protected void btnManageGroup_Click1(object sender, EventArgs e)
    {
        con.Open();
        //   SqlCommand cmd = con.CreateCommand();
        //  cmd.CommandType = CommandType.Text;
        // cmd.CommandText = "insert into Group values ('" + DropDownListStudent1.SelectedItem.Text + "','" + DropDownListStudent2.SelectedItem.Text + "','" + DropDownListStudent3.SelectedItem.Text + "','" + DropDownListStudent4.SelectedItem.Text + "','" + DropDownListProject.SelectedValue + "')";
        SqlCommand s = new SqlCommand("insert into Group2(Student1,Student2,Student3,Student4,Project) values(@a,@b,@c,@d,@e)  ", con);
        s.Parameters.AddWithValue("@a", DropDownListStudent1.SelectedItem.Text);
        s.Parameters.AddWithValue("@b", DropDownListStudent2.SelectedItem.Text);
        s.Parameters.AddWithValue("@c", DropDownListStudent3.SelectedItem.Text);
        s.Parameters.AddWithValue("@d", DropDownListStudent4.SelectedItem.Text);
        s.Parameters.AddWithValue("@e", DropDownListProject.SelectedItem.Text);
        s.ExecuteNonQuery();
        con.Close();
    }


}