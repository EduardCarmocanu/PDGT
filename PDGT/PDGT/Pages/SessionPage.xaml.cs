using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PDGT.ViewModels;
using PDGT.Models;
using System.Collections;
using System.Collections.ObjectModel;
using PDGT.Services;

namespace PDGT.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SessionPage : ContentPage
    {
        SessionViewModel _vm;


        public SessionPage()
        {
            InitializeComponent();

            BindingContext = _vm = new SessionViewModel();

            CarouselViews.ItemsSource = _vm._mockService.Exercises;

            ProjectWeekNo.Text = _vm._mockService.WeekNumber.ToString();

            //Initializing the clock and dates on the page
            Device.StartTimer(TimeSpan.FromSeconds(1), Clock);
        }

         private async void GuideBtn_Clicked(object sender, EventArgs e)
            {
                await Navigation.PushModalAsync(new Viewguide());

            }


            bool Clock()
            {
                //creating the variable "now" as current time
                DateTime now = DateTime.Now;
                timeLabel.Text = now.ToString("T");

                //creating the variable "today" as current day/date
                DateTime today = DateTime.Today;

                //getting current month
                CurrentMonth.Text = today.ToString("MMMM", CultureInfo.InvariantCulture).ToUpper() + ":";

                //creating "currentDayOfWeek" as an int to be used for calculations
                int currentDayOfWeek = (int)today.DayOfWeek; //sunday=0, monday=1, tuesday=2, etc.

                DateTime daySunday = today.AddDays(-currentDayOfWeek +7);

                if ( currentDayOfWeek == 0)
                {
                    daySunday = today.AddDays(-currentDayOfWeek);
                }
                    sunday.Text = daySunday.ToString("dd");
                    
                //getting all dates for current week:
                DateTime dayMonday = daySunday.AddDays(-6);
                monday.Text = dayMonday.ToString("dd");
            
                DateTime dayTuesday = dayMonday.AddDays(1);
                tuesday.Text = dayTuesday.ToString("dd");

                DateTime dayWednesday = dayMonday.AddDays(2);
                wednesday.Text = dayWednesday.ToString("dd");

                DateTime dayThursday = dayMonday.AddDays(3);
                thursday.Text = dayThursday.ToString("dd");

                DateTime dayFriday = dayMonday.AddDays(4);
                friday.Text = dayFriday.ToString("dd");

                DateTime daySaturday = dayMonday.AddDays(5);
                saturday.Text = daySaturday.ToString("dd");

            

                //Highlighting the current day
                if (currentDayOfWeek == 0) {
                    sunday.BackgroundColor = Color.Purple;
                    sunday.TextColor = Color.White;
                }

                if (currentDayOfWeek == 1)
                {
                    monday.BackgroundColor = Color.Purple;
                    monday.TextColor = Color.White;
                }

                if (currentDayOfWeek == 2)
                {
                    tuesday.BackgroundColor = Color.Purple;
                    tuesday.TextColor = Color.White;
                }

                if (currentDayOfWeek == 3)
                {
                    wednesday.BackgroundColor = Color.Purple;
                    wednesday.TextColor = Color.White;
                }

                if (currentDayOfWeek == 4)
                {
                    thursday.BackgroundColor = Color.Purple;
                    thursday.TextColor = Color.White;
                }

                if (currentDayOfWeek == 5)
                {
                    friday.BackgroundColor = Color.Purple;
                    friday.TextColor = Color.White;
                }

                if (currentDayOfWeek == 6)
                {
                    saturday.BackgroundColor = Color.Purple;
                    saturday.TextColor = Color.White;
                }

                if (currentDayOfWeek == 0)
                {
                    sunday.BackgroundColor = Color.Purple;
                    sunday.TextColor = Color.White;
                }

                return true;
            }
        }
}                
       