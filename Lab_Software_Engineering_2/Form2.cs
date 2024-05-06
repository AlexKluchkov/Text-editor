using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Software_Engineering_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Builder_XML my_xml = new Builder_XML();
                Event_Logging Event_Logging_Instance1 = Event_Logging.GetInstance();
                Event_Logging_Instance1.Builder = my_xml;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Builder_JSON my_json = new Builder_JSON();
                Event_Logging Event_Logging_Instance2 = Event_Logging.GetInstance();
                Event_Logging_Instance2.Builder = my_json;
            }
        }
    }
}
