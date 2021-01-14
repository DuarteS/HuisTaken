using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuisTaken
{
    class HuisTaken
    {
        private string[] people;
        private string[] taskName;
        private DateTime startDay;
        private int WeekNumber;
        private int colLen;
        private int rowLen;

        string[,] TaskCalendar;

        public HuisTaken(string[] people, string[] taskname, DateTime startday)
        {
            this.people = people;
            taskName = taskname;
            startDay = startday;

            colLen = 2 + taskName.Length;
            rowLen = 35;

            var currentCulture = CultureInfo.CurrentCulture;
            WeekNumber = currentCulture.Calendar.GetWeekOfYear(startDay, currentCulture.DateTimeFormat.CalendarWeekRule, currentCulture.DateTimeFormat.FirstDayOfWeek);

            TaskCalendar = new string[rowLen, colLen];
            createCalender();
        }

        private void createCalender()
        {
            TaskCalendar[0, 0] = "Week";
            TaskCalendar[0,1]= "Eindigt op";

            for (int i = 0; i <= taskName.Length-1; i++)
            {
                TaskCalendar[0, i + 2] = taskName[i];
            }

            for (int i = 1; i <= rowLen-1; i++)
            {
                TaskCalendar[i, 0] = WeekNumber.ToString();
                WeekNumber++;
                if (WeekNumber > 53)
                {
                    WeekNumber = 1;
                }
            }

            for (int i = 1; i <= rowLen-1; i++)
            {
                TaskCalendar[i, 1] = startDay.ToString("MM/dd");
                startDay= startDay.AddDays(7);
            }

            fillPeople();
        }

        private void fillPeople()
        {
            int startPerson = 0;

            for (int x = 0; x <= taskName.Length-1; x++)
            {
                for (int i = 1; i <= rowLen - 1; i++)
                {
                    TaskCalendar[i, x+2] = people[startPerson];
                    startPerson++;
                    if (startPerson == people.Length)
                    {
                        startPerson = 0;
                    }
                }
            }

            
        }

        public string[,] GetCalender()
        {
            return TaskCalendar;
        }

    }
}
