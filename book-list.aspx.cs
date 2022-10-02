using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class pages_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Books("where");
        }
        //    Books("where");
    }

    protected void Books(string where)
    {
        try
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "select * from  ebook "+where+" status = @status   order by id desc";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@status",1);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            string div1 = "<div class='row'>";
            string div2 = "";
            string div = "";
            int id;
            if (dt.Rows.Count > 0 && dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //        string link = "+Response.Redirect("./ view - book.aspx ? val = "+ dt.Rows[i]["id"].ToString() )";
                 id =9;
                    div = "<div class='col-md-3  mb-1'> <a class='nav-link' href='./view-book.aspx?val=" + dt.Rows[i]["id"].ToString() + "'><div class='shadow p-3'><img  src= '" + dt.Rows[i]["image"].ToString() +"' class='img-fluid' alt='abccc'><div class='col-md-7 text-center'>" + dt.Rows[i]["title"].ToString() + "</div></div></a></div>";

                    div2 += div;
                }


                books.InnerHtml = div1+div2+ "</div>";
            }
            else
            {

            }
        }
        catch (Exception ex)
        {
            // Label2.Text = ex.Message;
        }
        finally
        {
            con.Close();
        }
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        if(DropDownList1.SelectedValue.ToString() == "0")
            Books("where");
        else
            Books("where category = " + DropDownList1.SelectedValue.ToString() + " and");

        //   Label1.Text = DropDownList1.SelectedValue.ToString();
    }
}