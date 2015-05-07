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
            
            double budget = 50.00;
            resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}", spyNameTextBox.Text, assignmentNameTextBox.Text, budget);
        }
    }
}