using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Software_Engineering_2
{
    public sealed class Event_Logging
    {
        private String Old_Text = "";
        private DateTime time = DateTime.Now;
        private char added_or_removed_letter = ' ';
        private int possition;
        private int id;
        private Reports_builder report_builder;
        public Reports_builder Builder
        {
            set { report_builder = value; }
        }
        private Event_Logging() { }
        private static Event_Logging Instance;
        public static Event_Logging GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Event_Logging();
            }
            return Instance;
        }
        public void snapshot(String Main_Text, DateTime Now_Time)
        {
            Old_Text = Main_Text;
            time = Now_Time;
        }
        public char Difference(String NewText)
        {
            String New_Text = NewText;
            int i = 0;
            bool symbol_add = false;
            if (Old_Text.Length < New_Text.Length)     //symbol added
            {
                Old_Text = Old_Text + " ";            //to compare the old and new text character by character, we will make the lines the same size (add a space character)
                symbol_add = true;
            }
            else if (Old_Text.Length > New_Text.Length)    //symbol is deleted
            {
                New_Text = New_Text + " ";      //to compare the old and new text character by character, we will make the lines the same size
                symbol_add = false;
            }
            while (i < New_Text.Length)     //to find the added character, you need to compare the old and new text character by character
            {
                if ((Old_Text[i] != New_Text[i])&&(symbol_add == true))
                {
                    possition = i;
                    added_or_removed_letter = New_Text[i];
                    break;
                }
                else if ((Old_Text[i] != New_Text[i])&&(symbol_add == false))
                {
                    possition = i;
                    added_or_removed_letter = Old_Text[i];
                    break;
                }
                i++;
            }
            if (symbol_add)
            {
                using (FileStream stream = new FileStream("Event_Logging.txt", FileMode.Append))
                {
                    byte[] arr = System.Text.Encoding.Default.GetBytes("Symbol '" + added_or_removed_letter + "' added in position " + (possition + 1) + " time: " + time.ToString() + "\n");
                    stream.Write(arr, 0, arr.Length);
                }
            }
            else
            {
                using (FileStream stream = new FileStream("Event_Logging.txt", FileMode.Append))
                {
                    byte[] arr = System.Text.Encoding.Default.GetBytes("Symbol '" + added_or_removed_letter + "' removed in position " + (possition + 1) + " time: " + time.ToString() + "\n");
                    stream.Write(arr, 0, arr.Length);
                }
            }

            //creating a report
            if (report_builder != null)
            {
                Director my_director = new Director();
                my_director.Builder = report_builder;
                my_director.Create_report(id, added_or_removed_letter, symbol_add, possition, time);
                id++;
            }
            return added_or_removed_letter;
        }
    }
}
