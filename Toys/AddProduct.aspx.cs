using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Toys
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindCategoryDDL();
            }
        }

        private void BindCategoryDDL()
        {
            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["ToysConnectionString"].ConnectionString;

                // 2. Create a SqlCommand object
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Categories ORDER BY CategoryName";
                cmd.Connection = conn;

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;

                DataTable dt = new DataTable();
                conn.Open();

                sda.Fill(dt);

                ddlCategories.DataSource = dt;
                ddlCategories.DataTextField = "CategoryName";
                ddlCategories.DataValueField = "CategoryId";
                ddlCategories.DataBind();
            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string imagePath = "";
                if (fuProductImage.HasFile)
                {
                    imagePath = fuProductImage.FileName;
                    fuProductImage.SaveAs(Server.MapPath(Request.ApplicationPath) + "/Content/Catalog/Images/" + imagePath);

                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = WebConfigurationManager.ConnectionStrings["ToysConnectionString"].ConnectionString;

                        // 2. Create a SqlCommand object
                        SqlCommand cmd = new SqlCommand();
                        ///TODO
                        cmd.CommandText = "INSERT INTO Products VALUES('" + txtProductName.Text.Trim() + "', '" +
                            txtProductDescription.Text.Trim() + "', '" + imagePath + "', " + txtUnitPrice.Text.Trim() +
                            ", " + ddlCategories.SelectedValue + ")";
                        cmd.Connection = conn;
                        conn.Open();

                        cmd.ExecuteNonQuery();

                        Response.Redirect("Default.aspx");
                    }
                }
            }
        }
    }
}