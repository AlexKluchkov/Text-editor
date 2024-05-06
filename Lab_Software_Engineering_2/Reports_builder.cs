using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Software_Engineering_2
{
    public interface Reports_builder
    {
        void Create_file();
        void Start_recording(int id);
        void Add_char(char new_char);
        void Add_added_or_removed_symbol(bool symbol_added);
        void Add_position(int position);
        void Add_time(String time);
        void End_recording();
        void Save_file();
    }
}
