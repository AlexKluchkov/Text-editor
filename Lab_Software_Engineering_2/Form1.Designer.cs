
namespace Lab_Software_Engineering_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.фToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.upload_file = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиЗвітToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistics = new System.Windows.Forms.ToolStripMenuItem();
            this.size_in_kilobytes = new System.Windows.Forms.ToolStripMenuItem();
            this.number_of_characters_button = new System.Windows.Forms.ToolStripMenuItem();
            this.number_of_paragraphs = new System.Windows.Forms.ToolStripMenuItem();
            this.Number_of_empty_lines = new System.Windows.Forms.ToolStripMenuItem();
            this.Number_of_authors_pages = new System.Windows.Forms.ToolStripMenuItem();
            this.кількістьГолоснихТаПриголоснихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Number_of_Cyrillic_letters = new System.Windows.Forms.ToolStripMenuItem();
            this.Number_of_Latin_letters = new System.Windows.Forms.ToolStripMenuItem();
            this.Number_of_digits = new System.Windows.Forms.ToolStripMenuItem();
            this.Number_of_special_characters = new System.Windows.Forms.ToolStripMenuItem();
            this.Number_of_punctuation_marks = new System.Windows.Forms.ToolStripMenuItem();
            this.How_many_times_the_word_occurs_in_the_text = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.removing_minor_mistakes = new System.Windows.Forms.ToolStripMenuItem();
            this.save_new = new System.Windows.Forms.ToolStripMenuItem();
            this.видаленняНезначнихПрогалинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Search_names = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукПризвищеІмяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            resources.ApplyResources(this.textBox, "textBox");
            this.textBox.Name = "textBox";
            this.textBox.TextChanged += new System.EventHandler(this.event_logging_Text_Chenging);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // фToolStripMenuItem
            // 
            this.фToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save,
            this.save_as,
            this.upload_file,
            this.створитиЗвітToolStripMenuItem});
            this.фToolStripMenuItem.Name = "фToolStripMenuItem";
            resources.ApplyResources(this.фToolStripMenuItem, "фToolStripMenuItem");
            // 
            // save
            // 
            this.save.Name = "save";
            resources.ApplyResources(this.save, "save");
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // save_as
            // 
            this.save_as.Name = "save_as";
            resources.ApplyResources(this.save_as, "save_as");
            this.save_as.Click += new System.EventHandler(this.save_as_Click);
            // 
            // upload_file
            // 
            this.upload_file.Name = "upload_file";
            resources.ApplyResources(this.upload_file, "upload_file");
            this.upload_file.Click += new System.EventHandler(this.upload_file_Click);
            // 
            // створитиЗвітToolStripMenuItem
            // 
            this.створитиЗвітToolStripMenuItem.Name = "створитиЗвітToolStripMenuItem";
            resources.ApplyResources(this.створитиЗвітToolStripMenuItem, "створитиЗвітToolStripMenuItem");
            this.створитиЗвітToolStripMenuItem.Click += new System.EventHandler(this.Create_ReportToolStripMenuItem_Click);
            // 
            // statistics
            // 
            this.statistics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.size_in_kilobytes,
            this.number_of_characters_button,
            this.number_of_paragraphs,
            this.Number_of_empty_lines,
            this.Number_of_authors_pages,
            this.кількістьГолоснихТаПриголоснихToolStripMenuItem,
            this.Number_of_digits,
            this.Number_of_special_characters,
            this.Number_of_punctuation_marks,
            this.How_many_times_the_word_occurs_in_the_text});
            this.statistics.Name = "statistics";
            resources.ApplyResources(this.statistics, "statistics");
            // 
            // size_in_kilobytes
            // 
            this.size_in_kilobytes.Name = "size_in_kilobytes";
            resources.ApplyResources(this.size_in_kilobytes, "size_in_kilobytes");
            this.size_in_kilobytes.Click += new System.EventHandler(this.size_in_kilobytes_Click);
            // 
            // number_of_characters_button
            // 
            this.number_of_characters_button.Name = "number_of_characters_button";
            resources.ApplyResources(this.number_of_characters_button, "number_of_characters_button");
            this.number_of_characters_button.Click += new System.EventHandler(this.number_of_characters_button_Click);
            // 
            // number_of_paragraphs
            // 
            this.number_of_paragraphs.Name = "number_of_paragraphs";
            resources.ApplyResources(this.number_of_paragraphs, "number_of_paragraphs");
            this.number_of_paragraphs.Click += new System.EventHandler(this.number_of_paragraphs_Click);
            // 
            // Number_of_empty_lines
            // 
            this.Number_of_empty_lines.Name = "Number_of_empty_lines";
            resources.ApplyResources(this.Number_of_empty_lines, "Number_of_empty_lines");
            this.Number_of_empty_lines.Click += new System.EventHandler(this.Number_of_empty_lines_Click);
            // 
            // Number_of_authors_pages
            // 
            this.Number_of_authors_pages.Name = "Number_of_authors_pages";
            resources.ApplyResources(this.Number_of_authors_pages, "Number_of_authors_pages");
            this.Number_of_authors_pages.Click += new System.EventHandler(this.Number_of_authors_pages_Click);
            // 
            // кількістьГолоснихТаПриголоснихToolStripMenuItem
            // 
            this.кількістьГолоснихТаПриголоснихToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Number_of_Cyrillic_letters,
            this.Number_of_Latin_letters});
            this.кількістьГолоснихТаПриголоснихToolStripMenuItem.Name = "кількістьГолоснихТаПриголоснихToolStripMenuItem";
            resources.ApplyResources(this.кількістьГолоснихТаПриголоснихToolStripMenuItem, "кількістьГолоснихТаПриголоснихToolStripMenuItem");
            // 
            // Number_of_Cyrillic_letters
            // 
            this.Number_of_Cyrillic_letters.Name = "Number_of_Cyrillic_letters";
            resources.ApplyResources(this.Number_of_Cyrillic_letters, "Number_of_Cyrillic_letters");
            this.Number_of_Cyrillic_letters.Click += new System.EventHandler(this.Number_of_Cyrillic_letters_Click);
            // 
            // Number_of_Latin_letters
            // 
            this.Number_of_Latin_letters.Name = "Number_of_Latin_letters";
            resources.ApplyResources(this.Number_of_Latin_letters, "Number_of_Latin_letters");
            this.Number_of_Latin_letters.Click += new System.EventHandler(this.Number_of_Latin_letters_Click);
            // 
            // Number_of_digits
            // 
            this.Number_of_digits.Name = "Number_of_digits";
            resources.ApplyResources(this.Number_of_digits, "Number_of_digits");
            this.Number_of_digits.Click += new System.EventHandler(this.Number_of_digits_Click);
            // 
            // Number_of_special_characters
            // 
            this.Number_of_special_characters.Name = "Number_of_special_characters";
            resources.ApplyResources(this.Number_of_special_characters, "Number_of_special_characters");
            this.Number_of_special_characters.Click += new System.EventHandler(this.Number_of_special_characters_Click);
            // 
            // Number_of_punctuation_marks
            // 
            this.Number_of_punctuation_marks.Name = "Number_of_punctuation_marks";
            resources.ApplyResources(this.Number_of_punctuation_marks, "Number_of_punctuation_marks");
            this.Number_of_punctuation_marks.Click += new System.EventHandler(this.Number_of_punctuation_marks_Click);
            // 
            // How_many_times_the_word_occurs_in_the_text
            // 
            this.How_many_times_the_word_occurs_in_the_text.Name = "How_many_times_the_word_occurs_in_the_text";
            resources.ApplyResources(this.How_many_times_the_word_occurs_in_the_text, "How_many_times_the_word_occurs_in_the_text");
            this.How_many_times_the_word_occurs_in_the_text.Click += new System.EventHandler(this.How_many_times_the_word_occurs_in_the_text_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фToolStripMenuItem,
            this.statistics,
            this.removing_minor_mistakes,
            this.Search_names});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // removing_minor_mistakes
            // 
            this.removing_minor_mistakes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save_new,
            this.видаленняНезначнихПрогалинToolStripMenuItem});
            this.removing_minor_mistakes.Name = "removing_minor_mistakes";
            resources.ApplyResources(this.removing_minor_mistakes, "removing_minor_mistakes");
            // 
            // save_new
            // 
            this.save_new.Name = "save_new";
            resources.ApplyResources(this.save_new, "save_new");
            this.save_new.Click += new System.EventHandler(this.save_new_Click);
            // 
            // видаленняНезначнихПрогалинToolStripMenuItem
            // 
            this.видаленняНезначнихПрогалинToolStripMenuItem.Name = "видаленняНезначнихПрогалинToolStripMenuItem";
            resources.ApplyResources(this.видаленняНезначнихПрогалинToolStripMenuItem, "видаленняНезначнихПрогалинToolStripMenuItem");
            this.видаленняНезначнихПрогалинToolStripMenuItem.Click += new System.EventHandler(this.removing_minor_mistakes_Click);
            // 
            // Search_names
            // 
            this.Search_names.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пошукПризвищеІмяToolStripMenuItem});
            this.Search_names.Name = "Search_names";
            resources.ApplyResources(this.Search_names, "Search_names");
            // 
            // пошукПризвищеІмяToolStripMenuItem
            // 
            this.пошукПризвищеІмяToolStripMenuItem.Name = "пошукПризвищеІмяToolStripMenuItem";
            resources.ApplyResources(this.пошукПризвищеІмяToolStripMenuItem, "пошукПризвищеІмяToolStripMenuItem");
            this.пошукПризвищеІмяToolStripMenuItem.Click += new System.EventHandler(this.Search_names_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "Новий файл";
            this.saveFileDialog1.FilterIndex = 2;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem фToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem save_as;
        private System.Windows.Forms.ToolStripMenuItem statistics;
        private System.Windows.Forms.ToolStripMenuItem size_in_kilobytes;
        private System.Windows.Forms.ToolStripMenuItem number_of_characters_button;
        private System.Windows.Forms.ToolStripMenuItem number_of_paragraphs;
        private System.Windows.Forms.ToolStripMenuItem Number_of_empty_lines;
        private System.Windows.Forms.ToolStripMenuItem Number_of_authors_pages;
        private System.Windows.Forms.ToolStripMenuItem кількістьГолоснихТаПриголоснихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Number_of_Cyrillic_letters;
        private System.Windows.Forms.ToolStripMenuItem Number_of_Latin_letters;
        private System.Windows.Forms.ToolStripMenuItem Number_of_digits;
        private System.Windows.Forms.ToolStripMenuItem Number_of_special_characters;
        private System.Windows.Forms.ToolStripMenuItem Number_of_punctuation_marks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removing_minor_mistakes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem upload_file;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem Search_names;
        private System.Windows.Forms.ToolStripMenuItem save_new;
        private System.Windows.Forms.ToolStripMenuItem видаленняНезначнихПрогалинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem How_many_times_the_word_occurs_in_the_text;
        private System.Windows.Forms.ToolStripMenuItem пошукПризвищеІмяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиЗвітToolStripMenuItem;
    }
}

