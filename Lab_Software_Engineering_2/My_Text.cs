using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_Software_Engineering_2
{
    public class My_Text: Form1
    {
        private Form1 observer = new Form1();
        // two lists
        private ArrayList surname_and_initials_in_text = new ArrayList();
        public ArrayList surname_and_initials_in_paragraph = new ArrayList();
        // to work with the same instance of the class after each change of text, I added Singleton
        private My_Text() { }
        private static My_Text Instance;
        public static My_Text GetInstance()
        {
            if (Instance == null)
            {
                Instance = new My_Text();
            }
            return Instance;
        }
        
        void Notify()
        {
            observer.Update(this);
        }

        public void Find_New_Surname_Initials(String Text)
        {
            Regex regex = new Regex(@"[A-Z][a-z]+ [A-Z]+[.]+[A-Z]+[.]");
            MatchCollection matches = regex.Matches(Text);
            ArrayList List = new ArrayList();
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    if (!surname_and_initials_in_text.Contains(match.Value))
                    {
                        surname_and_initials_in_text.Add(match.Value);
                        surname_and_initials_in_paragraph.Add(match.Value);
                    }
                }
                this.Notify();
                surname_and_initials_in_paragraph.Clear();
            }
        }
    }
}
