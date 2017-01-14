using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace a2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        //Declare multidimensional array to hold date and event
        string[,] events = new string[6, 2];


        protected void Page_Load(object sender, EventArgs e)
        {
            //on page load add these dates and events to array "events"

            events[0, 0] = "5/9/2017";
            events[0, 1] = "Steve's Birthday!";
            events[1, 0] = "12/25/2017";
            events[1, 1] = "Christmas!";
            events[2, 0] = "1/20/2017";
            events[2, 1] = "Get Oil Change";
            events[3, 0] = "1/20/2017";
            events[3, 1] = "Karate Lessons";
            events[4, 0] = "1/25/2017";
            events[4, 1] = "Take CompTia test";
            events[5, 0] = "1/27/2017";
            events[5, 1] = "Make Dinner";

        }

        protected void DateChanged(object sender, EventArgs e)
        {
         
            //On date changed display date for every date
            MessageLabel.Text = Calendar1.SelectedDate.ToShortDateString();

            //Create arraylist "myEvents" within DateChanged Scope
            ArrayList myEvents = new ArrayList();

            //Create counter at DateChanged Scope
            int count = 0;

            //Initialize "for loop" at half the length of array to componsate for two dimenions
            for (int i=0; i<(events.Length/2); i++)
            {

                //if events at array position is equal to the date clicked perform action
                if (events[i, 0].Equals(Calendar1.SelectedDate.ToShortDateString()))
                {
                    //increment counter to keep track of arraylist size
                    count++;
                    //add corresponding event for the date clicked to arraylist
                    //using arraylist for multiple events on same date
                    myEvents.Add(events[i, 1]);

                }    
            }
           
            //create for loop with the length of our arraylist to print all collected events for that date
            for (int dd = 0; dd < count; dd++)
            {
                //format events to appear on multiple lines
                MessageLabel.Text += "<br/>" + myEvents[dd];
            }
        }
    }
}