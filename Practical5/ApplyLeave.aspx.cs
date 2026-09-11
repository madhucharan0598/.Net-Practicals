using System;

namespace Practical5
{
    public partial class ApplyLeave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (Session["LeaveDate"] == null)
            {
                Response.Redirect("Default.aspx");
                return;
            }

            if (!IsPostBack)
            {
                lblWelcome.Text =
                    "Welcome, " +
                    Session["Username"].ToString();

                lblDate.Text =
                    "Selected Leave Date: " +
                    Session["LeaveDate"].ToString();
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string username =
                    Session["Username"].ToString();

                string leaveDate =
                    Session["LeaveDate"].ToString();

                string leaveType =
                    ddlLeaveType.SelectedValue;

                string reason =
                    txtReason.Text;

                lblResult.Text =
                    "Leave Applied Successfully!" +
                    "<br/><br/>" +
                    "Username: " + username +
                    "<br/>" +
                    "Leave Date: " + leaveDate +
                    "<br/>" +
                    "Leave Type: " + leaveType +
                    "<br/>" +
                    "Reason: " + reason;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            Response.Redirect("Login.aspx");
        }
    }
}