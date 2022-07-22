using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyDutyV2
{
    internal class GraphMake
    {
        public List<(DateTime,int, string)> GraphWithoutVacation(Employe employe) 
        {
            List<(DateTime,int, string)> graphList = new List<(DateTime,int, string)>();
            
           
           

            while (employe.LastDutyDate<= employe.DutyGraphMonth)
            {

                employe.LastDutyDate = employe.LastDutyDate.AddDays( employe.DutyInterval+employe.DayliDutyDaysCount );
                
                graphList.Add((employe.LastDutyDate,employe.Priorityvalue, employe.EmemployeName));


            }
            return graphList;
        
        }

        public List<(DateTime,int, string)> GraphWithVacation(Employe employe)
        {
            List<(DateTime,int, string)> graphList = new List<(DateTime,int, string)>();
            DateTime vacationDateTemp = employe.VacationDate;

            while (vacationDateTemp.AddDays(-(employe.DutyInterval-1))>employe.LastDutyDate.AddDays(employe.DutyInterval) )
            {

                vacationDateTemp = vacationDateTemp = vacationDateTemp.AddDays((-employe.DutyInterval)+employe.DayliDutyDaysCount);
                graphList.Add((vacationDateTemp,employe.Priorityvalue, employe.EmemployeName));


            }
            vacationDateTemp = employe.VacationDate.AddDays(employe.VacationDaysCount);

            while (vacationDateTemp <= employe.DutyGraphMonth)
            {

                vacationDateTemp = vacationDateTemp.AddDays(employe.DutyInterval);
                graphList.Add((vacationDateTemp,employe.Priorityvalue, employe.EmemployeName));


            }
            return graphList;

        }

      



    }

 
}
