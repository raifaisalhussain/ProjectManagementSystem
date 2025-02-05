using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAddProject_Click(object sender, EventArgs e)
    {
        Response.Redirect("Projects.aspx");
    }

    protected void btnAddStudent_Click1(object sender, EventArgs e)
    {

        Response.Redirect("NewStudent.aspx");
    }

    protected void btnAddAdvisor_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewAdvisor.aspx");
    }

    protected void btnManageGroup_Click(object sender, EventArgs e)
    {
        Response.Redirect("ManageGroups.aspx");
    }

    protected void btnCreateReport_Click(object sender, EventArgs e)
    {
        Response.Redirect("Reports.aspx");
    }

    protected void btnManageEvaluation_Click(object sender, EventArgs e)
    {
        Response.Redirect("Evaluation.aspx");
    }

    protected void btnCreateGroup_Click(object sender, EventArgs e)
    {
        Response.Redirect("CreateGroup.aspx");
    }
}