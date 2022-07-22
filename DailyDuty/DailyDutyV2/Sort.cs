using System.Collections.Generic;
using DailyDutyV2;

class Sort
{


 
    public List<(DateTime, string,string)> MainSortWithTwoTurpleStrings( List<(DateTime,int, string)> listX, DateTime dutyMonthX,int dutyEmployersCountX, int employersCountX)
   {
           
        int count = 0;
        int dutyEmployersCount = 2;
        int mainListLastItemIndex = 0;


        
        List<(DateTime, string,string)> mainList2 = new List<(DateTime, string,string)>();
        AddDays addDays = new AddDays();


        for (int i = 0; i < listX.Count - 1; i++)
        {


            for (int j = 0; j< listX.Count - 1; j++)
            {


              
                if (mainList2.Count==0)
                {
                    DutyCheckerV2(ref listX, listX[0], dutyMonthX, mainListLastItemIndex, dutyEmployersCount);
                    mainList2.Add((listX[j].Item1, listX[j].Item3, listX[j +1].Item3));
                   
                    j++;
                    mainListLastItemIndex = j;

                    
                    continue;
                }



                if (mainList2.Last().Item1.Day>= dutyMonthX.Day)
                {
                    return mainList2;
                }


                if (mainList2.Last().Item1>listX[j].Item1)
                {
                    //mainList2.Add(addDays.AddDaysIfValueOfMainListIslarger(mainList2.Last(), listX[j], listX[j - 1], dutyMonthX, count, dutyEmployersCountX));
                    mainList2.Add(addDays.AddDaysIfValueOfMainListIslarger(mainList2.Last(), listX, j, dutyMonthX));
                    
                    j++;
                    mainListLastItemIndex = j;
                    continue;

                }

            
                if (mainList2.Last().Item1 < listX[j].Item1)
                {
                    //mainList2.Add(addDays.AddDaysIfMainListIsSmaler(mainList2.Last(), listX[j], listX[j - 1], dutyMonthX, count, dutyEmployersCountX));
                    mainList2.Add(addDays.AddDaysIfMainListIsSmaler(mainList2.Last(), listX, j, dutyMonthX));
                   
                    j++;
                    mainListLastItemIndex = j + 1;
                    continue;
                }
            
                if (mainList2.Last().Item1 == listX[j].Item1)
                {

                    //mainList2.Add(addDays.AddDaysIfValuesIsEven(mainList2.Last(), listX[j], listX[j - 1]));
                    mainList2.Add(addDays.AddDaysIfValuesIsEven(mainList2.Last(), listX, j));
                    
                    j++;
                    mainListLastItemIndex = j ;
                    continue;
                }


           


            }






            return mainList2;

        }


        return mainList2;


    }

    public List<(DateTime, string,string, string)> MainSortWithTHreeTurpleStrings(List<(DateTime, int, string)> listX, DateTime dutyMonthX, int dutyEmployersCountX, int employersCountX)
    {

        int count = 0;
        int dutyEmployersCount = 2;
        int mainListLastItemIndex = 0;



        List<(DateTime, string, string,string)> mainList2 = new List<(DateTime,string, string, string)>();
        AddDays addDays = new AddDays();


        for (int i = 0; i < listX.Count - 1; i++)
        {


            for (int j = 0; j < listX.Count - 1; j++)
            {



                if (mainList2.Count == 0)
                {
                    DutyCheckerV2(ref listX, listX[0], dutyMonthX, mainListLastItemIndex, dutyEmployersCount);
                    mainList2.Add((listX[j].Item1, listX[j].Item3, listX[j + 1].Item3,listX[j+2].Item3));

                    j++;
                    mainListLastItemIndex = j;

                 
                    continue;
                }



                if (mainList2.Last().Item1.Day >= dutyMonthX.Day)
                {
                    return mainList2;
                }


                if (mainList2.Last().Item1 > listX[j].Item1)
                {
                    //mainList2.Add(addDays.AddDaysIfValueOfMainListIslarger(mainList2.Last(), listX[j], listX[j - 1], dutyMonthX, count, dutyEmployersCountX));
                    mainList2.Add(addDays.AddDaysIfValueOfMainListIslarger(mainList2.Last(), listX, j, dutyMonthX));

                    j++;
                    mainListLastItemIndex = j;
                    continue;

                }


                if (mainList2.Last().Item1 < listX[j].Item1)
                {
                    //mainList2.Add(addDays.AddDaysIfMainListIsSmaler(mainList2.Last(), listX[j], listX[j - 1], dutyMonthX, count, dutyEmployersCountX));
                    mainList2.Add(addDays.AddDaysIfMainListIsSmaler(mainList2.Last(), listX, j, dutyMonthX));

                    j++;
                    mainListLastItemIndex = j + 1;
                    continue;
                }

                if (mainList2.Last().Item1 == listX[j].Item1)
                {

                    //mainList2.Add(addDays.AddDaysIfValuesIsEven(mainList2.Last(), listX[j], listX[j - 1]));
                    mainList2.Add(addDays.AddDaysIfValuesIsEven(mainList2.Last(), listX, j));

                    j++;
                    mainListLastItemIndex = j;
                    continue;
                }





            }






            return mainList2;

        }


        return mainList2;


    }





    public List<(DateTime, int, string)> BubleSort(List<(DateTime, int, string)> list)
    {

        for (int i = list.Count - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {


                if (list[j].Item1 > list[j + 1].Item1)
                {
                    var temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                   

                }
            }
        }
        return list;

    }

    public void DutyCheckerV2(ref List<(DateTime, int, string)> list, (DateTime, int, string) FirsElement, DateTime dutyMonth, int mainlasItemIndex, int dutyEmployersValue) 
    {
        DateTime dateTimeTemp = DateTime.MinValue;
        (DateTime, int, string) lastVacationDate;
        int vacationDaysCount = -1;
        
        int newIndex;

        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i].Item1.Day >= dutyMonth.Day)
            {

                return;
            }

            if (list[i].Item2 >= 1)
            {

                if (list[i].Item2 >= 1 && dateTimeTemp == DateTime.MinValue)
                {
                    dateTimeTemp = list[i].Item1;
                }
                if (list[i].Item1 == dateTimeTemp)
                {
                    vacationDaysCount++;
                }

                newIndex =  (list[i].Item1.Day - FirsElement.Item1.Day) * dutyEmployersValue + vacationDaysCount;

                (DateTime, int, string) temp;
                temp = list[i];
                list[i] = list[newIndex];
                list[newIndex] = temp;
                if (vacationDaysCount >= 1 || list[i+1].Item1 != dateTimeTemp)
                {
                    vacationDaysCount = -1;
                    dateTimeTemp = DateTime.MinValue;
                }

            }
 

        }

     
    
    }


}