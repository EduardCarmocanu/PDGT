using System;
using System.Collections.Generic;
using System.Text;

namespace PDGT.Models
{
    class WeekState
    {
        public List<Exercise> Exercises { get; set; }
        public bool AvailableWeeklyQuestionnaire { get; set; }
        public bool SessionsFinished { get; set; }
        public int WeekNumber { get; set; }
    }
}
