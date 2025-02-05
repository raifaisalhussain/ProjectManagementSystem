using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class NewAdvisor : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        disp_data_Advisor();
        disp_data_CoAdvisor();
        disp_data_IndustryAdvisor();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        Response.Redirect("HomePage.aspx");
    }

    protected void btnAddStudent_Click(object sender, EventArgs e)
    {
        


    }
    public void disp_data_Advisor()
    {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select AdvisorName,Designation from Advisor";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        GridViewAdvisor.DataSource = dt;
        GridViewAdvisor.DataBind();
    }
    public void disp_data_CoAdvisor()
    {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select CoAdvisorName,Designation from CoAdvisor";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        GridViewCoAdvisor.DataSource = dt;
        GridViewCoAdvisor.DataBind();
    }
    public void disp_data_IndustryAdvisor()
    {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select IndustryAdvisorName,Designation from IndustryAdvisor";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        GridViewIndustryAdvisor.DataSource = dt;
        GridViewIndustryAdvisor.DataBind();
    }


    protected void btnDeleteAdvisor_Click(object sender, EventArgs e)
    {
        if (DropDownListAdvisor.SelectedValue == "Advisor")
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Advisor where AdvisorName= '" + txtAdvisorName.Text + "'";
            cmd.ExecuteNonQuery();
            txtAdvisorName.Text = "";
            txtDesignation.Text = "";
            DropDownListAdvisor.SelectedValue = "";
            disp_data_Advisor();
            disp_data_CoAdvisor();
            disp_data_IndustryAdvisor();

        }
        else if (DropDownListAdvisor.SelectedValue == "CoAdvisor")
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from CoAdvisor where CoAdvisorName= '" + txtAdvisorName.Text + "'";
            cmd.ExecuteNonQuery();
            txtAdvisorName.Text = "";
            txtDesignation.Text = "";
            DropDownListAdvisor.SelectedValue = "";
            disp_data_Advisor();
            disp_data_CoAdvisor();
            disp_data_IndustryAdvisor();

        }
        else if (DropDownListAdvisor.SelectedValue == "IndustryAdvisor")
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from IndustryAdvisor where IndustryAdvisorName= '" + txtAdvisorName.Text + "'";
            cmd.ExecuteNonQuery();
            txtAdvisorName.Text = "";
            txtDesignation.Text = "";
            DropDownListAdvisor.SelectedValue = "";
            disp_data_Advisor();
            disp_data_CoAdvisor();
            disp_data_IndustryAdvisor();
        }
    }

    protected void btnAddAdvisor_Click(object sender, EventArgs e)
    {
        if (DropDownListAdvisor.SelectedValue == "Advisor")
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Advisor values ('" + txtAdvisorName.Text + "','" + txtDesignation.Text + "')";
            cmd.ExecuteNonQuery();

        }
        else if (DropDownListAdvisor.SelectedValue == "CoAdvisor")
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into CoAdvisor values ('" + txtAdvisorName.Text + "','" + txtDesignation.Text + "')";
            cmd.ExecuteNonQuery();

        }
        else if (DropDownListAdvisor.SelectedValue == "IndustryAdvisor")
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into IndustryAdvisor values ('" + txtAdvisorName.Text + "','" + txtDesignation.Text + "')";
            cmd.ExecuteNonQuery();
        }
        txtAdvisorName.Text = "";
        txtDesignation.Text = "";
        DropDownListAdvisor.SelectedValue = "";
        disp_data_Advisor();
        disp_data_CoAdvisor();
        disp_data_IndustryAdvisor();
    }
}