using System;

using System.Collections;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Software_Engineering_2
{
    public partial class Form1 : Form
    {
        String path = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                Save_as(textBox.Text);
            }
            else
            {
                String Main_Text = textBox.Text;
                using (FileStream stream = new FileStream(path, FileMode.Truncate))
                {
                    byte[] arr = System.Text.Encoding.Default.GetBytes(Main_Text);
                    stream.Write(arr, 0, arr.Length);
                }
            }
        }

        private void save_as_Click(object sender, EventArgs e)
        {
            Save_as(textBox.Text);
        }

        private void Save_as(String text)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text|*.txt|Html|*.html|Binary files|*.bin|All Files|*.*";
            saveFileDialog1.ShowDialog();
            path = saveFileDialog1.InitialDirectory + saveFileDialog1.FileName;
            if (path == "")
            {
                return;
            }
            else if (saveFileDialog1.FilterIndex == 1)
            {
                CreatorTXT TXT_Creator = new CreatorTXT();
                var TXT_new = TXT_Creator.FactoryMethod1(path);
                TXT_new.SaveMyFile(text);
            }
            else if (saveFileDialog1.FilterIndex == 2)
            {
                CreatorHTML HTML_Creator = new CreatorHTML();
                var HTML_new = HTML_Creator.FactoryMethod1(path);
                HTML_new.SaveMyFile(text);
            }
            else if (saveFileDialog1.FilterIndex == 3)
            {
                CreatorBIN BIN_Creator = new CreatorBIN();
                var BIN_new = BIN_Creator.FactoryMethod1(path);
                BIN_new.SaveMyFile(text);
            }
            else
            {
                CreatorTXT TXT_Creator = new CreatorTXT();
                var TXT_new = TXT_Creator.FactoryMethod1(path);
                TXT_new.SaveMyFile(text);
            }
        }

        private void upload_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text|*.txt|Html|*.html|Binary files|*.bin|All Files|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            if (path == "")
            {
                return;
            }
            else if (openFileDialog1.FilterIndex == 1)
            {
                CreatorTXT TXT_Creator = new CreatorTXT();
                var TXT_new = TXT_Creator.FactoryMethod2(path);
                textBox.Text = TXT_new.DownloadMyFile();
            }
            else if (openFileDialog1.FilterIndex == 2)
            {
                CreatorHTML HTML_Creator = new CreatorHTML();
                var HTML_new = HTML_Creator.FactoryMethod2(path);
                textBox.Text = HTML_new.DownloadMyFile();
            }
            else if (openFileDialog1.FilterIndex == 3)
            {
                CreatorBIN BIN_Creator = new CreatorBIN();
                var BIN_new = BIN_Creator.FactoryMethod2(path);
                textBox.Text = BIN_new.DownloadMyFile();
            }
            else
            {
                using (FileStream stream = File.OpenRead(path))
                {
                    byte[] arr = new byte[stream.Length];
                    stream.Read(arr, 0, arr.Length);
                    String Main_Text = System.Text.Encoding.Default.GetString(arr);
                    textBox.Text = Main_Text;
                }
            }
        }

        private void size_in_kilobytes_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                MessageBox.Show("Please save the file!", "File not saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileInfo file = new FileInfo(path);
                const double Kilobytes = 1024;
                double KiloLength = Convert.ToDouble(file.Length) / Kilobytes;
                MessageBox.Show("File size is " + file.Length + "byte!\n That's about " + KiloLength + " kilobytes!", "File size", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void number_of_characters_button_Click(object sender, EventArgs e)
        {
            String Main_Text = textBox.Text;
            MessageBox.Show("There are currently " + Main_Text.Length + " characters in the document!", "The number of characters in the document", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void number_of_paragraphs_Click(object sender, EventArgs e)
        {
            int num_of_paragraphs = 0;
            bool lineStart = true;
            int spaceCount = 0;
            String Main_Text = textBox.Text;
            int i = 0;
            while (i < Main_Text.Length)
            {
                if (Main_Text[i] == '\n')
                {
                    lineStart = true;
                    spaceCount = 0;
                }
                else if (Main_Text[i] == '\t')
                {
                    if (lineStart)
                    {
                        num_of_paragraphs++;
                        lineStart = false;
                    }
                }
                else if (Main_Text[i] == ' ')
                {
                    if (lineStart)
                    {
                        spaceCount++;
                        if (spaceCount == 5)
                        {
                            num_of_paragraphs++;
                            lineStart = false;
                        }
                    }
                }
                else
                {
                    lineStart = false;
                }
                i++;
            }
            MessageBox.Show("There are " + num_of_paragraphs + " paragraphs in the document!", "The number of paragraphs in the document.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Number_of_empty_lines_Click(object sender, EventArgs e)
        {
            int num_of_empty_lines = 0;
            int lineStart = 0;
            int CharCount = 0;
            String Main_Text = textBox.Text;
            int i = 0;
            while (i < Main_Text.Length)
            {
                if (Main_Text[i] == '\n')
                {
                    lineStart++;
                    CharCount = 0;
                    if ((lineStart >= 2) && (CharCount == 0))
                    {
                        lineStart = 0;
                        num_of_empty_lines++;
                    }
                }
                else
                {
                    CharCount++;
                }
                i++;
            }
            MessageBox.Show("There are " + num_of_empty_lines + " empty lines in the document!", "The number of empty lines in the document.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Number_of_authors_pages_Click(object sender, EventArgs e)
        {
            int num_of_authors_pages = 0;
            String Main_Text = textBox.Text;
            const int author_page = 1800;
            num_of_authors_pages = (Main_Text.Length / author_page);
            MessageBox.Show("There are " + num_of_authors_pages + " author pages in the document!", "The number of author pages in the document.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Number_of_digits_Click(object sender, EventArgs e)
        {
            int num_of_digits = 0;
            String Main_Text = textBox.Text;
            int i = 0;
            while (i < Main_Text.Length)
            {
                if ((Main_Text[i] >= 48) && (Main_Text[i] <= 57))
                {
                    num_of_digits++;
                }
                i++;
            }
            MessageBox.Show("There are " + num_of_digits + " digits in the document!", "The number of digits in the document.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Number_of_Cyrillic_letters_Click(object sender, EventArgs e)
        {
            int number_of_vowels = 0;
            int number_of_consonants = 0;
            int number_of_all_Cyrillic_letters = 0;
            String Main_Text = textBox.Text;
            int i = 0;
            Encoding.GetEncoding("windows-1251");
            while (i < Main_Text.Length)
            {
                if (((Main_Text[i] >= 1040) && (Main_Text[i] <= 1103)) || (Main_Text[i] == 1105) || (Main_Text[i] == 1108) || (Main_Text[i] == 1110) || (Main_Text[i] == 1111) || (Main_Text[i] == 1168) || (Main_Text[i] == 1169)) //  для великих літер(1105 - Ґ; 1111 - Ї; 1168 - І; 1169 - Є)
                {
                    if ((Main_Text[i] == 1140) || (Main_Text[i] == 1045) || (Main_Text[i] == 1048) || (Main_Text[i] == 1054) || (Main_Text[i] == 1059) || (Main_Text[i] == 1067) || (Main_Text[i] == 1069) || (Main_Text[i] == 1072) || (Main_Text[i] == 1077) || (Main_Text[i] == 1080) || (Main_Text[i] == 1086) || (Main_Text[i] == 1091) || (Main_Text[i] == 1099) || (Main_Text[i] == 1101) || (Main_Text[i] == 1110) || (Main_Text[i] == 1111) || (Main_Text[i] == 1108))
                    {
                        number_of_vowels++;
                    }
                    else
                    {
                        number_of_consonants++;
                    }
                    number_of_all_Cyrillic_letters++;
                }
                i++;
            }
            MessageBox.Show("There are " + number_of_vowels + " vowels and " + number_of_consonants + " consonants in the document! The document contains " + number_of_all_Cyrillic_letters + " Cyrillic letters!", "The number of letters in the document.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Number_of_Latin_letters_Click(object sender, EventArgs e)
        {
            int number_of_vowels = 0;
            int number_of_consonants = 0;
            int num_of_all_Latin_letters = 0;
            String Main_Text = textBox.Text;
            int i = 0;
            while (i < Main_Text.Length)
            {
                if (((Main_Text[i] >= 65) && (Main_Text[i] <= 90)))
                {
                    if ((Main_Text[i] == 65) || (Main_Text[i] == 69) || (Main_Text[i] == 73) || (Main_Text[i] == 79) || (Main_Text[i] == 85) || (Main_Text[i] == 89))
                    {
                        number_of_vowels++;
                    }
                    else
                    {
                        number_of_consonants++;
                    }
                    num_of_all_Latin_letters++;
                }
                else if ((Main_Text[i] >= 97) && (Main_Text[i] <= 122))
                {
                    if ((Main_Text[i] == 97) || (Main_Text[i] == 101) || (Main_Text[i] == 105) || (Main_Text[i] == 111) || (Main_Text[i] == 117) || (Main_Text[i] == 121))
                    {
                        number_of_vowels++;
                    }
                    else
                    {
                        number_of_consonants++;
                    }
                    num_of_all_Latin_letters++;
                }
                i++;
            }
            MessageBox.Show("There are " + number_of_vowels + " vowels and " + number_of_consonants + " consonants in the document! The document contains " + num_of_all_Latin_letters + " Latin letters!", "The number of letters in the document.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Number_of_special_characters_Click(object sender, EventArgs e)
        {
            int num_of_special_characters = 0;
            String Main_Text = textBox.Text;
            int i = 0;
            while (i < Main_Text.Length)
            {
                if (((Main_Text[i] >= 33) && (Main_Text[i] <= 47)) || ((Main_Text[i] >= 58) && (Main_Text[i] <= 63)))
                {
                    num_of_special_characters++;
                }
                i++;
            }
            MessageBox.Show("There are " + num_of_special_characters + " special characters in the document!", "The number of special characters in the document.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Number_of_punctuation_marks_Click(object sender, EventArgs e)
        {
            int num_of_special_characters = 0;
            String Main_Text = textBox.Text;
            int i = 0;
            while (i < Main_Text.Length)
            {
                if ((Main_Text[i] == 33) || (Main_Text[i] == 46) || (Main_Text[i] == 58) || (Main_Text[i] == 59) || (Main_Text[i] == 63))
                {
                    num_of_special_characters++;
                }
                i++;
            }
            MessageBox.Show("There are " + num_of_special_characters + " punctuation marks in the document now!", "The number of punctuation marks in the document.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void save_new_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                Save_as(textBox1.Text);
            }
            else
            {
                String Main_Text = textBox1.Text;
                using (FileStream stream = new FileStream(path, FileMode.Truncate))
                {
                    byte[] arr = System.Text.Encoding.Default.GetBytes(Main_Text);
                    stream.Write(arr, 0, arr.Length);
                }
            }
        }

        private void removing_minor_mistakes_Click(object sender, EventArgs e)
        {
            String Main_Text = textBox.Text;
            int i = 0;
            bool mistake;
            textBox1.Text = "";
            while (i < (Main_Text.Length - 1))
            {
                if (Main_Text[i].Equals(' ') && Main_Text[i + 1].Equals(' '))
                {
                    mistake = true;
                }
                else if (Main_Text[i].Equals(' ') && Main_Text[i + 1].Equals('\n'))
                {
                    mistake = true;
                }
                else if (Main_Text[i].Equals('\n') && Main_Text[i + 1].Equals('\n'))
                {
                    mistake = true;
                }
                else if (Main_Text[i].Equals('\t') && Main_Text[i + 1].Equals('\n'))
                {
                    mistake = true;
                }
                else
                {
                    mistake = false;
                }
                if (!mistake)
                {
                    textBox1.Text = textBox1.Text + Main_Text[i];
                }
                i++;
            }
            textBox1.Text = textBox1.Text + Main_Text[Main_Text.Length - 1];
        }

        private void Search_names_Click(object sender, EventArgs e)
        {
            String Main_Text = textBox.Text;
            Regex regex = new Regex(@"[A-Z][a-z]+ [A-Z][a-z]+[!.? ]");
            Match match = regex.Match(Main_Text);
            if (match.Success)
            {
                MessageBox.Show("Name " + match.Value, "Full name.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No matches found", "Full name.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void How_many_times_the_word_occurs_in_the_text_Click(object sender, EventArgs e)
        {
            String new_word = "";
            ArrayList word = new ArrayList();
            ArrayList word_count = new ArrayList();
            String Main_Text = textBox.Text;
            Main_Text = Main_Text.ToLower();
            int i = 0;
            while (i < (Main_Text.Length))
            {
                if ((Main_Text[i] == ' ') || (Main_Text[i] == '!') || (Main_Text[i] == '?') || (Main_Text[i] == '.') || (Main_Text[i] == ','))
                {
                    if ((word.Contains(new_word)) && (new_word != ""))
                    {
                        int num = word.IndexOf(new_word);
                        word_count[num] = Convert.ToInt32(word_count[num]) + 1;
                    }
                    else if ((!word.Contains(new_word)) && (new_word != ""))
                    {
                        word.Add(new_word);
                        word_count.Add(1);
                    }
                    new_word = "";
                }
                else    //copy the word into the new_word variable
                {
                    new_word = new_word + Main_Text[i];
                }
                i++;
            }
            if (word.Count == 0)
            {
                MessageBox.Show("Words not found!", "How many times the word occurs in the text.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            for (int j = 0; j < word.Count; j++)
            {
                MessageBox.Show("The word " + word[j] + " occurs " + word_count[j] + " times!", "How many times the word occurs in the text.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void event_logging_Text_Chenging(object sender, EventArgs e)
        {
            Event_Logging Event_Logging_Instance = Event_Logging.GetInstance();
            char lost_letter = Event_Logging_Instance.Difference(textBox.Text);
            Event_Logging_Instance.snapshot(textBox.Text, DateTime.Now);

            string Main_Text = textBox.Text;
            if (lost_letter == '\r')
            {
                StreamWriter writer = new StreamWriter("save_paragraph.txt");
                writer.WriteLine(Main_Text);
                writer.Close();
                MessageBox.Show("The data in the file has been updated!", "The file has been updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                My_Text Text = My_Text.GetInstance();
                Text.Find_New_Surname_Initials(Main_Text);
            }
        }

        public void Update(My_Text subject)
        {
            String surname_and_initials_in_paragraph1 = "";
            for (int i = 0; i < subject.surname_and_initials_in_paragraph.Count; i++)
            {
                if (i == subject.surname_and_initials_in_paragraph.Count - 1)
                {
                    surname_and_initials_in_paragraph1 = surname_and_initials_in_paragraph1 + subject.surname_and_initials_in_paragraph[i];
                }
                else
                {
                    surname_and_initials_in_paragraph1 = surname_and_initials_in_paragraph1 + subject.surname_and_initials_in_paragraph[i] + ", ";
                }
            }
            MessageBox.Show("The following new surnames and initials are found in this paragraph " + surname_and_initials_in_paragraph1, "New surnames and initials", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Create_ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form_2 = new Form2();
            form_2.Show();
        }
    }
    //
    public abstract class SaveFile
    {
        public abstract void SaveMyFile(string Main_Text);
    }

    public class SaveFileTXT : SaveFile
    {
        private string path;

        public SaveFileTXT(string path)
        {
            this.path = path;
        }

        public override void SaveMyFile(string Main_Text)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(Main_Text);
            writer.Close();
        }
    }

    public class SaveFileHTML : SaveFile
    {
        private string path;
        public SaveFileHTML(string path)
        {
            this.path = path;
        }

        public override void SaveMyFile(string Main_Text)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine("<html>");
            writer.WriteLine("  <head>");
            writer.WriteLine("      <title>HTML-Document</title>");
            writer.WriteLine("      <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            writer.WriteLine("  </head>");
            writer.WriteLine("  <body>");
            String[] Paragraphs = Main_Text.Split('\n');
            Regex regex = new Regex(@"\r");
            for (int i = 0; i < Paragraphs.Length; i++)
            {
                Paragraphs[i] = regex.Replace(Paragraphs[i], "");
                writer.WriteLine("      <p>" + Paragraphs[i] + "</p>");
            }
            writer.WriteLine("  </body>");
            writer.WriteLine("</html>");
            writer.Close();
        }
    }

    public class SaveFileBIN : SaveFile
    {
        private string path;

        public SaveFileBIN(string path)
        {
            this.path = path;
        }

        public override void SaveMyFile(string Main_Text)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(Main_Text);
            }
        }
    }
    //
    public abstract class DownloadFile
    {
        public abstract String DownloadMyFile();
    }

    public class DownloadFileTXT : DownloadFile
    {
        private string path;

        public DownloadFileTXT(string path)
        {
            this.path = path;
        }
        public override String DownloadMyFile()
        {
            string Main_Text = "";
            using (StreamReader reader = new StreamReader(path))
            {
                Main_Text = reader.ReadToEnd();
            }
            return Main_Text;
        }
    }

    public class DownloadFileHTML : DownloadFile
    {
        private string path;
        public DownloadFileHTML(string path)
        {
            this.path = path;
        }
        public override String DownloadMyFile()
        {
            string Main_Text = "";
            string Text = "";
            using (StreamReader reader = new StreamReader(path))
            {
                Text = reader.ReadToEnd();
            }
            Regex regex = new Regex(@"<p>.*?</p>", RegexOptions.Singleline);
            MatchCollection matches = regex.Matches(Text);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Main_Text = Main_Text + match.Value;
            }
            else
            {
                Console.WriteLine("No matches found");
            }

            Regex regex2 = new Regex(@"<p>");
            Main_Text = regex2.Replace(Main_Text, "");
            Regex regex3 = new Regex(@"</p>|<br>");
            Main_Text = regex3.Replace(Main_Text, "\r\n");
            return Main_Text;
        }
    }

    public class DownloadFileBIN : DownloadFile
    {
        private string path;

        public DownloadFileBIN(string path)
        {
            this.path = path;
        }
        public override String DownloadMyFile()
        {
            String Main_Text;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                Main_Text = reader.ReadString();
            }
            return Main_Text;
        }
    }
    //

    public interface Creator
    {
        SaveFile FactoryMethod1(String path);
        DownloadFile FactoryMethod2(String path);
    }

    class CreatorTXT : Creator
    {
        public SaveFile FactoryMethod1(String path)
        {
            return new SaveFileTXT(path);
        }
        public DownloadFile FactoryMethod2(String path)
        {
            return new DownloadFileTXT(path);
        }
    }

    class CreatorHTML : Creator
    {
        public SaveFile FactoryMethod1(String path)
        {
            return new SaveFileHTML(path);
        }
        public DownloadFile FactoryMethod2(String path)
        {
            return new DownloadFileHTML(path);
        }
    }

    class CreatorBIN : Creator
    {
        public SaveFile FactoryMethod1(String path)
        {
            return new SaveFileBIN(path);
        }
        public DownloadFile FactoryMethod2(String path)
        {
            return new DownloadFileBIN(path);
        }
    }

}