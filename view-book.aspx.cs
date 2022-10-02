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
        Books();

    }

    protected void Books()
    {
        try
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql_query = "select * from  ebook where  status = @status and id = @id  order by id desc";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@status", 1);
            cmd.Parameters.AddWithValue("@id", Request.QueryString["val"].ToString());

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            
            string div = "";
            int id;
            if (dt.Rows.Count > 0 && dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    id = 9;
                    div = "<div class='row p-3 shadow'><div class='col-md-5 '><img  src= '" + dt.Rows[0]["image"].ToString() + "' class='img-fluid' alt='abccc'></div><div class='col-md-5'><h3>" + dt.Rows[0]["title"].ToString() + "</h3> <p>Author: " + dt.Rows[0]["author"].ToString() + "</p> <p>Pubisher: " + dt.Rows[0]["publisher"].ToString() + "</p> <p>Rating : " + dt.Rows[0]["rating"].ToString() + "</p> <p><a href=' "+ dt.Rows[0]["pdf"].ToString() + "'>Download Pdf</a></p> <p>" + dt.Rows[0]["description"].ToString() + "</p></div></div>";
                }


                books.InnerHtml = div;
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

}