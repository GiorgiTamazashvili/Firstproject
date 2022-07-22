using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyDutyV2
{
    internal class Employe:Employer
    {
        public int Priorityvalue { get; set; }
        public string EmemployeName { get; set; }
        public DateTime LastDutyDate { get; set; }
        public int DayliDutyDaysCount { get; set; }
        public DateTime VacationDate { get; set; }
        public int VacationDaysCount { get; set; }
    }
}
