using System;

namespace Practical5
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSelectDate_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate == DateTime.MinValue)
            {
                lblSelectedDate.Text = "Please select a date.";
            }
            else
            {
                string selectedDate =
                    Calendar1.SelectedDate.ToString("dd/MM/yyyy");

                Session["LeaveDate"] = selectedDate;

                lblSelectedDate.Text =
                    "Selected Date: " + selectedDate;
            }
        }

        protected void btnApplyLeave_Click(object sender, EventArgs e)
        {
            if (Session["LeaveDate"] == null)
            {
                lblSelectedDate.Text =
                    "Please select a date first.";

                return;
            }

            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Redirect("ApplyLeave.aspx");
            }
        }
    }
}