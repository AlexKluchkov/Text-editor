using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_Software_Engineering_2
{
    class Builder_JSON : Reports_builder
    {
        public void Create_file()
        {
            string report_file_json = @"Event_Logging.json";
            if (!File.Exists(report_file_json))
            {
                using (FileStream stream = new FileStream("Event_Logging.json", FileMode.Append))
                {
                    byte[] arr = System.Text.Encoding.Default.GetBytes("[\n");
                    stream.Write(arr, 0, arr.Length);
                }
            }
            else
            {
                string Main_Text;
                using (FileStream fstream = File.OpenRead(report_file_json))
                {
                    //read data from the file
                    byte[] buffer = new byte[fstream.Length];
                    fstream.Read(buffer, 0, buffer.Length);
                    Main_Text = Encoding.Default.GetString(buffer);
                    //delete the closing line of the file
                    Regex regex = new Regex(@"]\n");
                    Main_Text = regex.Replace(Main_Text, "");
                }
                //write the line in a new file
                File.Delete(report_file_json);
                using (FileStream stream = new FileStream("Event_Logging.json", FileMode.Create))
                {
                    byte[] arr = System.Text.Encoding.Default.GetBytes(Main_Text);
                    stream.Write(arr, 0, arr.Length);
                }
            }
        }
        public void Start_recording(int id)
        {
            using (FileStream stream = new FileStream("Event_Logging.json", FileMode.Append))
            {
                byte[] arr = System.Text.Encoding.Default.GetBytes("  {\n");
                stream.Write(arr, 0, arr.Length);
            }
        }
        public void Add_char(char new_char)
        {
            using (FileStream stream = new FileStream("Event_Logging.json", FileMode.Append))
            {
                byte[] arr = System.Text.Encoding.Default.GetBytes("    \"char\": \"" + new_char + "\",\n");
                stream.Write(arr, 0, arr.Length);
            }
        }
        public void Add_added_or_removed_symbol(bool symbol_added)
        {
            if (symbol_added)
            {
                using (FileStream stream = new FileStream("Event_Logging.json", FileMode.Append))
                {
                    byte[] arr = System.Text.Encoding.Default.GetBytes("    \"added_or_removed\": \"add\",\n");
                    stream.Write(arr, 0, arr.Length);
                }
            }
            else
            {
                using (FileStream stream = new FileStream("Event_Logging.json", FileMode.Append))
                {
                    byte[] arr = System.Text.Encoding.Default.GetBytes("    \"added_or_removed\": \"delete\",\n");
                    stream.Write(arr, 0, arr.Length);
                }
            }
        }
        public void Add_position(int position)
        {
            using (FileStream stream = new FileStream("Event_Logging.json", FileMode.Append))
            {
                byte[] arr = System.Text.Encoding.Default.GetBytes("    \"position\": \"" + Convert.ToString(position) + "\",\n");
                stream.Write(arr, 0, arr.Length);
            }
        }
        public void Add_time(String time)
        {
            using (FileStream stream = new FileStream("Event_Logging.json", FileMode.Append))
            {
                byte[] arr = System.Text.Encoding.Default.GetBytes("    \"date\": \"" + time + "\"\n");
                stream.Write(arr, 0, arr.Length);
            }
        }
        public void End_recording()
        {
            using (FileStream stream = new FileStream("Event_Logging.json", FileMode.Append))
            {
                byte[] arr = System.Text.Encoding.Default.GetBytes("  },\n");
                stream.Write(arr, 0, arr.Length);
            }
        }
        public void Save_file()
        {
            using (FileStream stream = new FileStream("Event_Logging.json", FileMode.Append))
            {
                byte[] arr = System.Text.Encoding.Default.GetBytes("]\n");
                stream.Write(arr, 0, arr.Length);
            }
        }
    }
}
