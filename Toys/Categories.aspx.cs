using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace Toys
{
    public partial class Categories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindCategoryList();
            }

        }
        #region "This method will add a new category"
        protected void btnAddCategory_Click(object sender, EventArgs e)
        {
            //Response.Write("You entered " + txtCategoryName.Text);
            if (Page.IsValid)
            {
                // 1. Create a SqlConnection object
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["ToysConnectionString"].ConnectionString;

                // 2. Create a SqlCommand object
                SqlCommand cmd = new SqlCommand();

                /// TODO:
                /// We need to change the dynamci SQL statement later to avoid sql-inject attacks
                cmd.CommandText = "INSERT INTO Categories VALUES('" + txtCategoryName.Text + "')";
                cmd.Connection = conn;  // link the command object to the connection object

                // 3. Open the connection
                conn.Open();

                // 4. Execute the command
                cmd.ExecuteNonQuery();  // this will insert data into the database

                // 5. Close the connection
                conn.Close();

                lblFeedback.Visible = true;
                lblFeedback.Text = "The category <strong>" + txtCategoryName.Text + "</strong> was added successfully.";

                BindCategoryList();
            }
            
        }
        #endregion

        protected void BindCategoryList()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["ToysConnectionString"].ConnectionString;

            // 2. Create a SqlCommand object
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Categories";
            cmd.Connection = conn;

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            DataTable dt = new DataTable();
            conn.Open();

            sda.Fill(dt);

            gvCategoryList.DataSource = dt;
            gvCategoryList.DataBind();
            conn.Close();
        }
    }
}