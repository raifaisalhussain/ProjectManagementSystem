using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Evaluation : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Group();
        }
        disp_data();
    }

    public void Group()
    {
        SqlCommand cmd = new SqlCommand("Select GroupID from ManageGroup", con);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        DropDownListGroup.DataTextField = "GroupID";
        DropDownListGroup.DataValueField = "GroupID";
        DropDownListGroup.DataSource = rdr;
        DropDownListGroup.DataBind();
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



    protected void btnManageGroup_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand s = new SqlCommand("insert into Evaluations(GroupName,TotalMarks,ObtainedMarks,Date) values(@a,@b,@c,@d)  ", con);
        s.Parameters.AddWithValue("@a", DropDownListGroup.SelectedItem.Text);
        s.Parameters.AddWithValue("@b", txtTotalMarks.Text);
        s.Parameters.AddWithValue("@c", txtObtainedMarks.Text);
        s.Parameters.AddWithValue("@d", txtDate.Text);
        s.ExecuteNonQuery();
        con.Close();
        disp_data();

    }
    public void disp_data()
    {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select GroupName,TotalMarks,ObtainedMarks,Date from Evaluations";
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        GridViewEvaluation.DataSource = dt;
        GridViewEvaluation.DataBind();
    }

}