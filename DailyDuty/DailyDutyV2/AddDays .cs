using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyDutyV2
{
    internal class AddDays
    {
        Sort sort = new Sort();
       
        public (DateTime, string, string) AddDaysIfValuesIsEven((DateTime, string, string) mainList, List<(DateTime, int, string)> list, int index, int count = 0, int dutyEmployersCount = 0)
        {
            (DateTime, int, string) listj = list[index];
            (DateTime, int, string) listj1 = list[index+1];


            mainList.Item1 = mainList.Item1 = listj.Item1.AddDays(1);
            mainList.Item2 = listj.Item3;
            mainList.Item3 = listj1.Item3;
            return mainList;


        }

        public (DateTime, string,string, string) AddDaysIfValuesIsEven((DateTime,string, string, string) mainList, List<(DateTime, int, string)> list, int index, int count = 0, int dutyEmployersCount = 0)
        {
            (DateTime, int, string) listj = list[index];
            (DateTime, int, string) listj1 = list[index + 1];
            (DateTime, int, string) listj2 = list[index + 2];


            mainList.Item1 = mainList.Item1 = listj.Item1.AddDays(1);

            if (listj.Item1.DayOfWeek != DayOfWeek.Saturday && listj.Item1.DayOfWeek != DayOfWeek.Sunday)
            {
               
                mainList.Item2 = listj.Item3;
                mainList.Item3 = listj1.Item3;
                mainList.Item4 = listj2.Item3;
            }
            else
            {
               
                mainList.Item2 = listj.Item3;
                mainList.Item3 = listj1.Item3;
                mainList.Item4 = " ";
            }
            return mainList; ;


        }


        public (DateTime, string, string) AddDaysIfMainListIsSmaler((DateTime, string, string) mainList, List<(DateTime, int, string)> list, int index, DateTime dutyMonth, int count=0, int dutyEmployersCount=0)
        {

            (DateTime, int, string) listj = list[index];
            (DateTime, int, string) listj1 = list[index + 1];
          

            while (mainList.Item1.Day != listj.Item1.Day)
            {
                listj.Item1 = listj.Item1 = listj.Item1.AddDays(-1);
                count++;
            }

            if (mainList.Item1.Day == listj.Item1.Day)
            {
                listj.Item1 = listj.Item1 = listj.Item1.AddDays(1);

            }

            mainList.Item1 = listj.Item1;
            mainList.Item2 = listj.Item3;
            mainList.Item3 = listj1.Item3;
            return mainList;



        }
        public (DateTime, string,string, string) AddDaysIfMainListIsSmaler((DateTime, string, string, string) mainList, List<(DateTime, int, string)> list, int index, DateTime dutyMonth, int count = 0, int dutyEmployersCount = 0)
        {

            (DateTime, int, string) listj = list[index];
            (DateTime, int, string) listj1 = list[index + 1];
            (DateTime, int, string) listj2 = list[index + 2];


            while (mainList.Item1.Day != listj.Item1.Day)
            {
                listj.Item1 = listj.Item1 = listj.Item1.AddDays(-1);
                count++;
            }

            if (mainList.Item1.Day == listj.Item1.Day)
            {
                listj.Item1 = listj.Item1 = listj.Item1.AddDays(1);

            }

            if (listj.Item1.DayOfWeek != DayOfWeek.Saturday && listj.Item1.DayOfWeek != DayOfWeek.Sunday)
            {
                mainList.Item1 = listj.Item1;
                mainList.Item2 = listj.Item3;
                mainList.Item3 = listj1.Item3;
                mainList.Item4 = listj2.Item3;
            }
            else
            {
                mainList.Item1 = listj.Item1;
                mainList.Item2 = listj.Item3;
                mainList.Item3 = listj1.Item3;
                mainList.Item4 = " ";
            }
            return mainList;



        }




        public (DateTime, string, string) AddDaysIfValueOfMainListIslarger((DateTime, string, string) mainList,  List<(DateTime, int, string)> list, int index, DateTime dutyMonth, int count = 0, int dutyEmployersCount = 0)
        {
            (DateTime, int, string) listj = list[index];
            (DateTime, int, string) listj1 = list[index+1];
            int count1 = 0;

            while (mainList.Item1.Day != listj.Item1.Day)
            {
                listj.Item1 = listj.Item1= listj.Item1.AddDays(1);
                count++;
            }
        

            if (mainList.Item1.Day == listj.Item1.Day)
            {
                listj.Item1 = listj.Item1 = listj.Item1.AddDays(1);

            }

            mainList.Item1 = listj.Item1;
            mainList.Item2 = listj.Item3;
            mainList.Item3 = listj1.Item3;
            return mainList;



        }


        public (DateTime, string,string, string) AddDaysIfValueOfMainListIslarger((DateTime, string,string, string) mainList, List<(DateTime, int, string)> list, int index, DateTime dutyMonth, int count = 0, int dutyEmployersCount = 0)
        {
            (DateTime, int, string) listj = list[index];
            (DateTime, int, string) listj1 = list[index + 1];
            (DateTime, int, string) listj2 = list[index + 2];
            int count1 = 0;

            while (mainList.Item1.Day != listj.Item1.Day)
            {
                listj.Item1 = listj.Item1 = listj.Item1.AddDays(1);
                count++;
            }


            if (mainList.Item1.Day == listj.Item1.Day)
            {
                listj.Item1 = listj.Item1 = listj.Item1.AddDays(1);

            }

            if (listj.Item1.DayOfWeek!=DayOfWeek.Saturday && listj.Item1.DayOfWeek !=DayOfWeek.Sunday)
            {
                mainList.Item1 = listj.Item1;
                mainList.Item2 = listj.Item3;
                mainList.Item3 = listj1.Item3;
                mainList.Item4 = listj2.Item3;
            }
            else
            {
                mainList.Item1 = listj.Item1;
                mainList.Item2 = listj.Item3;
                mainList.Item3 = listj1.Item3;
                mainList.Item4 = " ";
            }
            return mainList;



        }




    }
}
