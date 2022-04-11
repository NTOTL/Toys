using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Toys
{
    public partial class ViewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["productId"] != null)
                {
                    int productId = int.Parse(Request.QueryString["productId"]);
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = WebConfigurationManager.ConnectionStrings["ToysConnectionString"].ConnectionString;
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "SELECT ProductName, Description, UnitPrice, ImagePath, CategoryName FROM Products P INNER JOIN Categories C " +
                            "ON P.CategoryId = C.CategoryId  WHERE P.ProductId = " + productId ;

                        cmd.Connection = conn;
                        conn.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.HasRows)
                        {
                            if (sdr.Read())
                            {
                                lblProductName.Text += sdr["ProductName"].ToString();
                                lblProductDescription.Text += sdr["Description"].ToString();
                                lblUnitPrice.Text += string.Format("{0:c}", sdr["UnitPrice"]);
                                imgProduct.ImageUrl = "/Content/Catalog/Images/" + sdr["ImagePath"].ToString();
                                lblCategoryName.Text += sdr["CategoryName"].ToString();

                            }

                        }
                            
                    }
                }
            }
        }
    }
}