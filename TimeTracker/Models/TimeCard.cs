﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Models
{
   public class TimeCard
    {
        public int ID { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int MondayHours { get; set; }
        public int TuesdayHours { get; set; }
        public int WedesdayHours { get; set; }
        public int ThursdayHours { get; set; }
        public int FridayHours { get; set; }
        public int SaturdayHours { get; set; }
        public int SundayHours { get; set; }
    }
}
