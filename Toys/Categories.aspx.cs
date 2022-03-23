using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Toys
{
    public partial class Categories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //txtCategoryName.Text = "Please enter a name.";
            }


        }

        protected void btnAddCategory_Click(object sender, EventArgs e)
        {
            //Response.Write("You entered " + txtCategoryName.Text);
            if (Page.IsValid)
            {
                lblFeedback.Text = "You entered " + txtCategoryName.Text;
                lblFeedback.Visible = true;
            }

            //if (txtCategoryName.Text.Trim() == "")
            //{
            //    lblFeedback.Text = "Please enter a name.";
            //}
            //else
            //{
            //    lblFeedback.Text = "You entered " + txtCategoryName.Text;
            //}

            //lblFeedback.Visible = true;
        }
    }
}