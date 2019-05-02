using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PDGT.Models
{
    public class SessionModel
    {
        public string SessionTitle { get; set; }
        public string Sets { get; set; }
        public string Reps { get; set; }
        public string WeightInKg { get; set; }
        public bool IsCompleted { get; set; }
    }
        
}
