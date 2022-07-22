using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyDutyV2
{
    internal class InputCheck
    {
        public bool GraphMonthDateChecker(DateTime dateTime) 
        {
            DateTime datetimeNow = DateTime.Now;

            if (dateTime.Month>= datetimeNow.Month)
            {
                return true;
            }


            else
            {
                return false;
            }
        
        
        }

        public bool LastDutyDateChecker(DateTime dateTime)
        {
            DateTime datetimeNow = DateTime.Now;

            if (dateTime.Date < datetimeNow)
            {
           

                return true;
            }


            else
            {
                return false;
            }


        }

        public bool VacationDatecheck(DateTime dateTime)
        {
            DateTime datetimeNow = DateTime.Now;

            if (dateTime.Date > datetimeNow.AddDays(-24))
            {
             

                return true;
            }


            else
            {
                return false;
            }


        }

        public bool NameFieldChecker(string  name)
        {
            

            if (name.Length>1)
            {


                return true;
            }


            else
            {
                return false;
            }


        }







    }
}
