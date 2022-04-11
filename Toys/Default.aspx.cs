using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Web.UI.HtmlControls;

namespace Toys
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!Page.IsPostBack)
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = WebConfigurationManager.ConnectionStrings["ToysConnectionString"].ConnectionString;

                    // 2. Create a SqlCommand object
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM Products ORDER BY CategoryId";
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();
                    StringBuilder sb = new StringBuilder();

                    //if (sdr.HasRows)
                    //{
                    //    while (sdr.Read())
                    //    {
                    //        sb.Append("<div class='col-lg-3'>");
                    //        sb.Append("<img src='/Content/Catalog/Images/");
                    //        sb.Append(sdr["ImagePath"].ToString());
                    //        sb.Append("'>");
                    //        sb.Append("</div>");
                    //    }
                    //}
                    //lblToys.Text = sb.ToString();                    
                    int i = 0;
                    if (sdr.HasRows)
                    {
                        HtmlGenericControl divRow = new HtmlGenericControl("div");
                        divRow.Attributes.Add("class", "row");
                       
                        while (sdr.Read())
                        {
                            i++;
                            HtmlGenericControl divCol = new HtmlGenericControl("div");
                            divCol.Attributes.Add("class", "col-lg-3");                            
                            HtmlGenericControl img = new HtmlGenericControl("img");
                            img.Attributes.Add("src", "/Content/Catalog/Images/" + sdr["ImagePath"].ToString());
                            divCol.Controls.Add(img);
                            divRow.Controls.Add(divCol); 
                            if (i % 4 ==0)
                            {
                                phToys.Controls.Add(divRow);
                                divRow = new HtmlGenericControl("div");
                                divRow.Attributes.Add("class", "row");
                                i = 0;
                            }
                        }
                       if (i != 0)
                        {
                            phToys.Controls.Add(divRow);
                        }
                    }
                }
            }
        }

       
    }
}