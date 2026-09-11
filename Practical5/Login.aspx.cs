using System;

namespace Practical5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Response.Redirect("ApplyLeave.aspx");
            }

            if (!IsPostBack)
            {
                if (Request.Cookies["Username"] != null)
                {
                    txtUsername.Text =
                        Request.Cookies["Username"].Value;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" ||
                txtPassword.Text == "")
            {
                lblMessage.Text =
                    "Please enter username and password.";

                lblMessage.ForeColor =
                    System.Drawing.Color.Red;

                return;
            }

            Session["Username"] =
                txtUsername.Text;

            Session["Password"] =
                txtPassword.Text;

            if (chkRemember.Checked)
            {
                Response.Cookies["Username"].Value =
                    txtUsername.Text;

                Response.Cookies["Username"].Expires =
                    DateTime.Now.AddDays(30);
            }

            Response.Redirect("ApplyLeave.aspx");
        }
    }
}