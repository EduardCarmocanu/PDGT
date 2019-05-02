using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using PDGT.Models;

namespace PDGT.ViewModels
{
    public class SessionViewModel
    {
        public ObservableCollection<SessionModel> Sessions { get; set; }
        public List<DateTime> Calender { get; set; }       

        public SessionViewModel()
        {
            Sessions = new ObservableCollection<SessionModel>
            {
                    new SessionModel
                    {
                        SessionTitle = "Rotator cuff strengthening I",
                        Sets = "3",
                        Reps = "8",
                        WeightInKg = "3-5"
                    },

                    new SessionModel
                    {
                        SessionTitle = "Rotator cuff strengthening II",
                        Sets = "5",
                        Reps = "10",
                        WeightInKg = "3-5"
                    },

                    new SessionModel
                    {
                        SessionTitle = "Rotator cuff strengthening III",
                        Sets = "5",
                        Reps = "10",
                        WeightInKg = "3-5"
                    }
                    
            };
               
            //The Calender
            //Creating current date
            DateTime now = DateTime.Now;

            //Creating current day of week
            int currentDayOfWeek = (int)DateTime.Now.DayOfWeek;

            //Finding Sunday
            DateTime sunday = now.AddDays(-currentDayOfWeek);
            DateTime monday = sunday.AddDays(1);

            if (currentDayOfWeek == 0)
            {
                monday = monday.AddDays(-7);
            }

            var dates = (int)((monday - sunday).TotalDays);

            Calender = Enumerable.Range(0, 7).Select(x => monday.AddDays(x)).ToList();
        }
    }
}
