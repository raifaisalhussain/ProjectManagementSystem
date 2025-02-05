using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

public partial class ManageGroups : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Group();
            Advisor();
            CoAdvisor();
            IndustryAdvisor();
        }
        disp_data();
    }

    public void Group()
    {
        SqlCommand cmd = new SqlCommand("Select sr_Number from Group2", con);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        DropDownListGroup.DataTextField = "sr_Number";
        DropDownListGroup.DataValueField = "sr_Number";
        DropDownListGroup.DataSource = rdr;
        DropDownListGroup.DataBind();
        con.Close();
    }
    
    public void Advisor()
    {
        SqlCommand cmd = new SqlCommand("Select AdvisorName from Advisor", con);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        DropDownListAdvisor.DataTextField = "AdvisorName";
        DropDownListAdvisor.DataValueField = "AdvisorName";
        DropDownListAdvisor.DataSource = rdr;
        DropDownListAdvisor.DataBind();
        con.Close();
    }

    public void CoAdvisor()
    {
        SqlCommand cmd = new SqlCommand("Select CoAdvisorName from CoAdvisor", con);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        DropDownListCoAdvisor.DataTextField = "CoAdvisorName";
        DropDownListCoAdvisor.DataValueField = "CoAdvisorName";
        DropDownListCoAdvisor.DataSource = rdr;
        DropDownListCoAdvisor.DataBind();
        con.Close();
    }

    public void IndustryAdvisor()
    {
        SqlCommand cmd = new SqlCommand("Select IndustryAdvisorName from IndustryAdvisor", con);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        DropDownListIndustryAdvisor.DataTextField = "IndustryAdvisorName";
        DropDownListIndustryAdvisor.DataValueField = "IndustryAdvisorName";
        DropDownListIndustryAdvisor.DataSource = rdr;
        DropDownListIndustryAdvisor.DataBind();
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
        SqlCommand s = new SqlCommand("insert into ManageGroup(GroupNumber,AdvisorName,CoAdvisorName,IndustryAdvisorName,GroupID) values(@a,@b,@c,@d,@e)  ", con);
        s.Parameters.AddWithValue("@a", DropDownListGroup.SelectedItem.Text);
        s.Parameters.AddWithValue("@b", DropDownListAdvisor.SelectedItem.Text);
        s.Parameters.AddWithValue("@c", DropDownListCoAdvisor.SelectedItem.Text);
        s.Parameters.AddWithValue("@d", DropDownListIndustryAdvisor.SelectedItem.Text);
        s.Parameters.AddWithValue("@e", txtGroupID.Text);
        s.ExecuteNonQuery();
        con.Close();
        disp_data();

    }

    public void disp_data()
    {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select GroupID,AdvisorName,CoAdvisorName,IndustryAdvisorName from ManageGroup";
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        GridViewGroup.DataSource = dt;
        GridViewGroup.DataBind();
    }


    protected void btnDeleteGroup_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = con.CreateCommand();
        con.Open();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "delete from ManageGroup where GroupID= '" + txtGroupID.Text + "'";
        cmd.ExecuteNonQuery();

        disp_data();
    }

    protected void btnPdf_Click(object sender, EventArgs e)
    {
        
        Response.ContentType = "application/pdf";
        Response.AddHeader("content-disposition","attachment;filename=Groups.pdf");
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        StringWriter stringWriter = new StringWriter();
        HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);
        printpdf.RenderControl(htmlTextWriter);
        StringReader stringReader = new StringReader(stringWriter.ToString());
        Document Doc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
        HTMLWorker htmlparser = new HTMLWorker(Doc);
        PdfWriter.GetInstance(Doc, Response.OutputStream);
        Doc.Open();
        htmlparser.Parse(stringReader);
        Doc.Close();
        Response.Write(Doc);
        Response.End();

        
        int columnsCount = GridViewGroup.HeaderRow.Cells.Count;
        PdfPTable pdfTable = new PdfPTable(columnsCount);
        
        foreach (TableCell gridViewHeaderCell in GridViewGroup.HeaderRow.Cells)
        {
            Font font = new Font();
            font.Color = new BaseColor(GridViewGroup.HeaderStyle.ForeColor);
            
            PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewHeaderCell.Text, font));
            
            pdfCell.BackgroundColor = new BaseColor(GridViewGroup.HeaderStyle.BackColor);
            
            pdfTable.AddCell(pdfCell);
        }
        
        foreach (GridViewRow gridViewRow in GridViewGroup.Rows)
        {
            if (gridViewRow.RowType == DataControlRowType.DataRow)
            {
                foreach (TableCell gridViewCell in gridViewRow.Cells)
                {
                    Font font = new Font();
                    font.Color = new BaseColor(GridViewGroup.RowStyle.ForeColor);

                    PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewCell.Text, font));

                    pdfCell.BackgroundColor = new BaseColor(GridViewGroup.RowStyle.BackColor);

                    pdfTable.AddCell(pdfCell);
                }
            }
        }
        
        Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

        PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

        pdfDocument.Open();
        pdfDocument.Add(pdfTable);
        pdfDocument.Close();

        Response.ContentType = "application/pdf";
        Response.AppendHeader("content-disposition",
            "attachment;filename=Groups.pdf");
        Response.Write(pdfDocument);
        Response.Flush();
        Response.End();
        

    }
    public override void VerifyRenderingInServerForm(Control control)
    {
    }
}