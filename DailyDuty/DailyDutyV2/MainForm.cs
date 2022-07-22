using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyDutyV2
{
 
    public partial class MainForm : Form
    {
        
       

        List<(DateTime, int, string)> PrimaryList = new List<(DateTime, int, string)>();

        List<(DateTime, int, string)> allInOneList = new List<(DateTime, int, string)>();
        int priorityvalue;
        Employe employe = new Employe();
        public MainForm()
        {
            InitializeComponent();
            VacationDateTimePicker.Enabled = false;
            VacationDaysCountComboBox.Enabled = false;

            GraphMonthDateTimePicker.Enabled = true;
            CountofEmployeComboBox.Enabled = true;
            DutyEmployeCountComboBox.Enabled = true;
            DutyDaysIntervalComboBOx.Enabled = true;
            priorityvalue = 0;

        }

        
        private void VacationlCheckBox_Click(object sender, EventArgs e)
        {
            if (VacationlCheckBox.Checked)
            {
                VacationDateTimePicker.Enabled = true;
               VacationDaysCountComboBox.Enabled = true;
                priorityvalue = 1;
            }
            else
            {
                VacationDateTimePicker.Enabled = false;
                VacationDaysCountComboBox.Enabled = false;
                priorityvalue = 0;
            }
        }



      

       
       

        private void SaveInformathionButton_Click(object sender, EventArgs e)
        {
            InputCheck inputCheck = new InputCheck();
            GraphMake graphMake = new GraphMake();
            
          


            if (inputCheck.GraphMonthDateChecker(GraphMonthDateTimePicker.Value))
            {
                try
                {
                    employe.DutyGraphMonth = GraphMonthDateTimePicker.Value;
                }
                catch (Exception)
                {

                    throw new Exception("მორიგეობის თვე შეყვანილია არასწორედ!");
                }
            }

            try
            {
                employe.CountOfAllEmployes = CountofEmployeComboBox.SelectedIndex + 1;
            }
            catch (Exception)
            {

                throw new Exception("თანამშრომლების საერთოდ რაოდენობა  შეყვანილია არასწორედ!");
            }
            try
            {
                employe.DutyEmployesCount = DutyEmployeCountComboBox.SelectedIndex + 2;
            }
            catch (Exception)
            {

                throw new Exception("მორიგეების  რაოდენობა  შეყვანილია არასწორედ!");
            }
            try
            {
                employe.DutyInterval = DutyDaysIntervalComboBOx.SelectedIndex + 4;
            }
            catch (Exception)
            {

                throw new Exception("მორიგეობის დღეების რაოდენობა  შეყვანილია არასწორედ!");
            }


            if (inputCheck.NameFieldChecker(EmployeNameTextBox.Text))
            {
                try
                {
                    employe.EmemployeName = EmployeNameTextBox.Text;
                }
                catch (Exception)
                {

                    throw new Exception("სახელი   შეყვანილია არასწორედ!");
                }
            }
            else
            {
                throw new Exception("სახელი   შეყვანილია არასწორედ!");
            }

            if (inputCheck.LastDutyDateChecker(LastDutyDateTimePicker.Value))
            {
                try
                {
                    employe.LastDutyDate = LastDutyDateTimePicker.Value;
                }
                catch (Exception)
                {

                    throw new Exception("ბოლო მორიგეობის თარიღი შეყვანილია არასწორედ!");
                }
            }
            else
            {
                throw new Exception("ბოლო მორიგეობის თარიღი შეყვანილია არასწორედ!");
            }

            if (DailyDutyAddingComboBox.SelectedIndex >= 0)
            {
                try
                {
                    employe.DayliDutyDaysCount = DailyDutyAddingComboBox.SelectedIndex;
                }
                catch (Exception)
                {

                    throw new Exception("ყოველღიური ველი შევსებულია არასწორედ!");
                }
            }
            else
            {
                throw new Exception("ყოველღიური ველი შევსებულია არასწორედ!");
            }



            if (VacationlCheckBox.Checked)
            {
                if (inputCheck.VacationDatecheck(VacationDateTimePicker.Value))
                {
                    try
                    {
                        employe.VacationDate = VacationDateTimePicker.Value;
                    }
                    catch (Exception)
                    {

                        throw new Exception("შვებულების თარიღი შევსებულია არასწორედ!");
                    }
             
                }
                else
                {
                    throw new Exception("შვებულების ჩექბოქსთან დაკავშირებული ხარვეზი! !");
                }
                try
                {
                    employe.Priorityvalue = priorityvalue;
                }
                catch (Exception)
                {

                    throw new Exception("ხარვეზი 'შვებულება' ჩექ ოქსტან დაკავშირებით! !");
                }
                try
                {
                    employe.VacationDaysCount = VacationDaysCountComboBox.SelectedIndex + 1;
                }
                catch (Exception)
                {

                    throw new Exception("შვებულების თარიღი შევსებულია არასწორედ!");
                }

                PrimaryList = graphMake.GraphWithVacation(employe);


            }
            if (VacationlCheckBox.Checked == false)
            {
                try
                {
                    employe.Priorityvalue = priorityvalue;
                }
                catch (Exception)
                {

                    throw new Exception("ხარვეზი 'შვებულება' ჩექ ოქსტან დაკავშირებით! !");
                }

                PrimaryList = graphMake.GraphWithoutVacation(employe);


            }




            foreach (var item in PrimaryList)
            {
                allInOneList.Add(item);
            }




            GraphMonthDateTimePicker.Enabled = false;
            CountofEmployeComboBox.Enabled = false;
            DutyEmployeCountComboBox.Enabled = false;
            DutyDaysIntervalComboBOx.Enabled = false;

        }

        private void GraphmakeButton_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();
           

            // delete this after testing
            DateTime dateTime = new DateTime(2022, 07, 31);
            int tutyEmployersCounttest = 3;

            // delete this after testing
            
            

            List<(DateTime, string,string)> mainListWithTwoTurpleStrings = new List<(DateTime, string,string)>(); 
            List<(DateTime, string, string,string)> mainListWithThreeTurpleStrings = new List<(DateTime, string, string,string)>();

            List<(DateTime, int, string)> bubleSortedList = new List<(DateTime, int, string)>();
            

          

            #region
            //bubleSortedList.Add((new DateTime(2022, 07, 04), 0, "tarasa"));//0
            //bubleSortedList.Add((new DateTime(2022, 07, 05), 0, "kaxa")); //1
            //bubleSortedList.Add((new DateTime(2022, 07, 05), 0, "zura")); //2
            //bubleSortedList.Add((new DateTime(2022, 07, 06), 0, "roma"));//3
            //bubleSortedList.Add((new DateTime(2022, 07, 06), 0, "sigua"));//4
            //bubleSortedList.Add((new DateTime(2022, 07, 06), 1, "giorgi"));//5
            //bubleSortedList.Add((new DateTime(2022, 07, 07), 0, "tarasa"));//6
            //bubleSortedList.Add((new DateTime(2022, 07, 07), 0, "shota"));//7
            //bubleSortedList.Add((new DateTime(2022, 07, 07), 0, "joto"));//8
            //bubleSortedList.Add((new DateTime(2022, 07, 08), 0, "kaxa"));//9
            //bubleSortedList.Add((new DateTime(2022, 07, 08), 0, "zura"));//10
            //bubleSortedList.Add((new DateTime(2022, 07, 09), 0, "roma"));//11
            //bubleSortedList.Add((new DateTime(2022, 07, 09), 0, "sigua"));//12
            //bubleSortedList.Add((new DateTime(2022, 07, 09), 1, "giorgi"));//13
            //bubleSortedList.Add((new DateTime(2022, 07, 10), 0, "tarasa"));//14 ==
            //bubleSortedList.Add((new DateTime(2022, 07, 10), 0, "shota"));//15
            //bubleSortedList.Add((new DateTime(2022, 07, 10), 0, "joto"));//16
            //bubleSortedList.Add((new DateTime(2022, 07, 11), 0, "kaxa"));//17
            //bubleSortedList.Add((new DateTime(2022, 07, 11), 0, "zura"));//18
            //bubleSortedList.Add((new DateTime(2022, 07, 12), 0, "roma"));//19
            //bubleSortedList.Add((new DateTime(2022, 07, 12), 0, "sigua"));//;20
            //bubleSortedList.Add((new DateTime(2022, 07, 12), 1, "giorgi"));//);21
            //bubleSortedList.Add((new  DateTime(2022,07, 13), 0, "tarasa"));//);22
            //bubleSortedList.Add((new DateTime(2022, 07, 13), 0, "shota"));//;23
            //bubleSortedList.Add((new DateTime(2022, 07, 13), 0, "joto"));//24
            //bubleSortedList.Add((new DateTime(2022, 07, 14), 0, "kaxa"));//25
            //bubleSortedList.Add((new DateTime(2022, 07, 14), 0, "zura"));//26
            //bubleSortedList.Add((new DateTime(2022, 07, 15), 0, "roma"));//27
            //bubleSortedList.Add((new DateTime(2022, 07, 15), 0, "sigua"));//28
            //bubleSortedList.Add((new DateTime(2022, 07, 16), 0, "tarasa"));//29====
            //bubleSortedList.Add((new DateTime(2022, 07, 16), 0, "shota"));//30
            ////bubleSortedList.Add((dateTime.AddDays(16), 1, "giorgi"))//;
            //bubleSortedList.Add((new DateTime(2022, 07, 16), 0, "joto"));//31
            //bubleSortedList.Add((new DateTime(2022, 07, 17), 0, "kaxa"));//32
            //bubleSortedList.Add((new DateTime(2022, 07, 17), 0, "zura"));//33
            //bubleSortedList.Add((new DateTime(2022, 07, 18), 0, "roma"));//34
            //bubleSortedList.Add((new DateTime(2022, 07, 18), 0, "sigua"));//35
            //bubleSortedList.Add((new DateTime(2022, 07, 19), 0, "tarasa"));//36
            //bubleSortedList.Add((new DateTime(2022, 07, 19), 0, "shota"));//37
            ////bubleSortedList.Add((dateTime.AddDays(20), "giorgi"));
            //bubleSortedList.Add((new DateTime(2022, 07, 19), 0, "joto"));//38
            //bubleSortedList.Add((new DateTime(2022, 07, 20), 0, "kaxa"));//39
            //bubleSortedList.Add((new DateTime(2022, 07, 20), 0, "zura"));//40
            //bubleSortedList.Add((new DateTime(2022, 07, 21), 0, "roma"));//41
            //bubleSortedList.Add((new DateTime(2022, 07, 21), 0, "sigua"));//42
            //bubleSortedList.Add((new DateTime(2022, 07, 22), 0, "tarasa"));//43
            //bubleSortedList.Add((new DateTime(2022, 07, 22), 0, "shota"));//44====
            ////bubleSortedList.Add((dateTime.AddDays(24), "giorgi"));
            //bubleSortedList.Add((new DateTime(2022, 07, 22), 0, "joto"));//45
            //bubleSortedList.Add((new DateTime(2022, 07, 23), 0, "kaxa"));//46
            //bubleSortedList.Add((new DateTime(2022, 07, 23), 0, "zura"));//47
            //bubleSortedList.Add((new DateTime(2022, 07, 24), 0, "roma"));//48
            //bubleSortedList.Add((new DateTime(2022, 07, 24), 0, "sigua"));//49
            //bubleSortedList.Add((new DateTime(2022, 07, 25), 0, "tarasa"));//50
            //bubleSortedList.Add((new DateTime(2022, 07, 25), 0, "shota"));//51
            //bubleSortedList.Add((new DateTime(2022, 07, 25), 0, "joto"));//52
            //bubleSortedList.Add((new DateTime(2022, 07, 26), 0, "kaxa"));//53
            //bubleSortedList.Add((new DateTime(2022, 07, 26), 0, "zura"));//54
            //bubleSortedList.Add((new DateTime(2022, 07, 27), 0, "roma"));//55
            //bubleSortedList.Add((new DateTime(2022, 07, 27), 0, "sigua"));//56
            //bubleSortedList.Add((new DateTime(2022, 07, 28), 0, "tarasa"));//57
            //bubleSortedList.Add((new DateTime(2022, 07, 28), 0, "shota"));//58
            //bubleSortedList.Add((new DateTime(2022, 07, 28), 0, "joto"));//59

            //bubleSortedList.Add((new DateTime(2022, 07, 28), 1, "giorgi"));//60
            //bubleSortedList.Add((new DateTime(2022, 07, 29), 0, "kaxa"));//61
            //bubleSortedList.Add((new DateTime(2022, 07, 29), 0, "zura"));//62
            //bubleSortedList.Add((new DateTime(2022, 07, 30), 0, "roma"));//63
            //bubleSortedList.Add((new DateTime(2022, 07, 30), 0, "sigua"));//64
            //bubleSortedList.Add((new DateTime(2022, 07, 31), 0, "tarasa"));//65
            //bubleSortedList.Add((new DateTime(2022, 07, 31), 0, "shota"));//66
            //bubleSortedList.Add((new DateTime(2022, 07, 31), 0, "joto"));//67
            //bubleSortedList.Add((new DateTime(2022, 07, 31), 1, "girogi"));//68
            //bubleSortedList.Add((new DateTime(2022, 08, 01), 0, "laxa"));//69
            //bubleSortedList.Add((new DateTime(2022, 08, 01), 0, "zura"));//70
            //bubleSortedList.Add((new DateTime(2022, 08, 02), 0, "rom"));//71
            //bubleSortedList.Add((new DateTime(2022, 08, 02), 0, "sigua"));//72
            //bubleSortedList.Add((new DateTime(2022, 08, 03), 0, "tarasa"));//73
            //bubleSortedList.Add((new DateTime(2022, 08, 03), 0, "shota"));//74
            //bubleSortedList.Add((new DateTime(2022, 08, 03), 0, "joto"));//75

            #endregion



            bubleSortedList = sort.BubleSort(allInOneList); //Main Code

            //bubleSortedList = sort.BubleSort(bubleSortedList); //test code








            if (employe.DutyEmployesCount == 2)
            {
                mainListWithTwoTurpleStrings = sort.MainSortWithTwoTurpleStrings(bubleSortedList, dateTime, employe.DutyEmployesCount, employe.CountOfAllEmployes);

                foreach (var item in mainListWithTwoTurpleStrings)
                {
                    richTextBox1.AppendText(item.Item1.ToString("MM.dd.yyyy"));
                    richTextBox1.AppendText(" ");
                    richTextBox1.AppendText(item.Item2);
                    richTextBox1.AppendText(" ");
                    richTextBox1.AppendText(item.Item3);
                    richTextBox1.AppendText("\n");


                }

            }
            if (employe.DutyEmployesCount == 3)
            {
                mainListWithThreeTurpleStrings = sort.MainSortWithTHreeTurpleStrings(bubleSortedList, dateTime, employe.DutyEmployesCount - 1, employe.CountOfAllEmployes);

                foreach (var item in mainListWithThreeTurpleStrings)
                {
                    richTextBox1.AppendText(item.Item1.ToString("MM.dd.yyyy"));
                    richTextBox1.AppendText(" ");
                    richTextBox1.AppendText(item.Item2);
                    richTextBox1.AppendText(" ");
                    richTextBox1.AppendText(item.Item3);
                    richTextBox1.AppendText(" + დამხმარე: ");
                    richTextBox1.AppendText(item.Item4);
                    richTextBox1.AppendText("\n");

                }


            }


        
            
        }

       
    }

       
}

