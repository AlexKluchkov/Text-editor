using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Software_Engineering_2
{
    class Director
    {
        private Reports_builder _builder;
        public Reports_builder Builder
        {
            set { _builder = value; }
        }
        public void Create_report(int id, char lost_letter, bool symbol_add, int possition, DateTime time)
        {
            _builder.Create_file();
            _builder.Start_recording(id);
            _builder.Add_char(lost_letter);
            _builder.Add_added_or_removed_symbol(symbol_add);
            _builder.Add_position(possition + 1);
            _builder.Add_time(time.ToString());
            _builder.End_recording();
            _builder.Save_file();
        }
    }
}
