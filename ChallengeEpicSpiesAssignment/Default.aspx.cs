using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                endPreviousCalendar.SelectedDate = DateTime.Now.Date;
                startNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                endNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
                currentDateTimeLabel.Text = "The current Date and Time is: " + DateTime.Now.ToString();
            }
        }

        protected void assignSpyButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            double budget = 0;
            TimeSpan daysFromPreviousToNew = startNewCalendar.SelectedDate.Subtract(endPreviousCalendar.SelectedDate);
            TimeSpan daysFromStartToEnd = endNewCalendar.SelectedDate.Subtract(startNewCalendar.SelectedDate);

            if (daysFromStartToEnd.Days > 21)
            {
                budget = (daysFromStartToEnd.Days * 500) + 1000;
            }
            else
                budget = (daysFromStartToEnd.Days * 500);

            if(daysFromPreviousToNew.Days < 14)
            {
                resultLabel.Text = "Error: Must allow at least two weeks between previous assignment and new assignment.";
                startNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
            }
            else
                resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}", spyNameTextBox.Text, assignmentNameTextBox.Text, budget);

        }
    }
}