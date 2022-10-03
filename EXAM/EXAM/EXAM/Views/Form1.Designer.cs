namespace EXAM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_allDrives = new System.Windows.Forms.Button();
            this.lB_allDrives = new System.Windows.Forms.ListBox();
            this.btn_subdir = new System.Windows.Forms.Button();
            this.btn_add_wards = new System.Windows.Forms.Button();
            this.lB_wards = new System.Windows.Forms.ListBox();
            this.tB_words = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lB_popular = new System.Windows.Forms.ListBox();
            this.l_statistic = new System.Windows.Forms.Label();
            this.l_dir = new System.Windows.Forms.Label();
            this.l_disk = new System.Windows.Forms.Label();
            this.l_addedwords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_allDrives
            // 
            this.btn_allDrives.Location = new System.Drawing.Point(12, 34);
            this.btn_allDrives.Name = "btn_allDrives";
            this.btn_allDrives.Size = new System.Drawing.Size(107, 23);
            this.btn_allDrives.TabIndex = 0;
            this.btn_allDrives.Text = "Показать диски";
            this.btn_allDrives.UseVisualStyleBackColor = true;
            this.btn_allDrives.Click += new System.EventHandler(this.btn_allDrives_Click);
            // 
            // lB_allDrives
            // 
            this.lB_allDrives.Enabled = false;
            this.lB_allDrives.FormattingEnabled = true;
            this.lB_allDrives.ItemHeight = 15;
            this.lB_allDrives.Location = new System.Drawing.Point(362, 34);
            this.lB_allDrives.Name = "lB_allDrives";
            this.lB_allDrives.Size = new System.Drawing.Size(812, 94);
            this.lB_allDrives.TabIndex = 1;
            // 
            // btn_subdir
            // 
            this.btn_subdir.Location = new System.Drawing.Point(12, 83);
            this.btn_subdir.Name = "btn_subdir";
            this.btn_subdir.Size = new System.Drawing.Size(107, 23);
            this.btn_subdir.TabIndex = 3;
            this.btn_subdir.Text = "Начать поиск";
            this.btn_subdir.UseVisualStyleBackColor = true;
            this.btn_subdir.Click += new System.EventHandler(this.btn_subdir_Click);
            // 
            // btn_add_wards
            // 
            this.btn_add_wards.Location = new System.Drawing.Point(12, 168);
            this.btn_add_wards.Name = "btn_add_wards";
            this.btn_add_wards.Size = new System.Drawing.Size(107, 23);
            this.btn_add_wards.TabIndex = 4;
            this.btn_add_wards.Text = "Добавить слова";
            this.btn_add_wards.UseVisualStyleBackColor = true;
            this.btn_add_wards.Click += new System.EventHandler(this.btn_add_wards_Click);
            // 
            // lB_wards
            // 
            this.lB_wards.FormattingEnabled = true;
            this.lB_wards.ItemHeight = 15;
            this.lB_wards.Location = new System.Drawing.Point(362, 168);
            this.lB_wards.Name = "lB_wards";
            this.lB_wards.Size = new System.Drawing.Size(812, 109);
            this.lB_wards.TabIndex = 5;
            // 
            // tB_words
            // 
            this.tB_words.Location = new System.Drawing.Point(137, 168);
            this.tB_words.Name = "tB_words";
            this.tB_words.Size = new System.Drawing.Size(216, 23);
            this.tB_words.TabIndex = 6;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(12, 304);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(107, 23);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Статистика";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(362, 311);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(812, 229);
            this.listBox1.TabIndex = 8;
            // 
            // lB_popular
            // 
            this.lB_popular.FormattingEnabled = true;
            this.lB_popular.ItemHeight = 15;
            this.lB_popular.Location = new System.Drawing.Point(362, 572);
            this.lB_popular.Name = "lB_popular";
            this.lB_popular.Size = new System.Drawing.Size(812, 124);
            this.lB_popular.TabIndex = 9;
            // 
            // l_statistic
            // 
            this.l_statistic.AutoSize = true;
            this.l_statistic.Location = new System.Drawing.Point(361, 554);
            this.l_statistic.Name = "l_statistic";
            this.l_statistic.Size = new System.Drawing.Size(120, 15);
            this.l_statistic.TabIndex = 10;
            this.l_statistic.Text = "Топ найденных слов";
            // 
            // l_dir
            // 
            this.l_dir.AutoSize = true;
            this.l_dir.Location = new System.Drawing.Point(363, 291);
            this.l_dir.Name = "l_dir";
            this.l_dir.Size = new System.Drawing.Size(89, 15);
            this.l_dir.TabIndex = 11;
            this.l_dir.Text = "Путь к файлам";
            // 
            // l_disk
            // 
            this.l_disk.AutoSize = true;
            this.l_disk.Location = new System.Drawing.Point(362, 11);
            this.l_disk.Name = "l_disk";
            this.l_disk.Size = new System.Drawing.Size(105, 15);
            this.l_disk.TabIndex = 12;
            this.l_disk.Text = "Поиск по дискам:";
            // 
            // l_addedwords
            // 
            this.l_addedwords.AutoSize = true;
            this.l_addedwords.Location = new System.Drawing.Point(363, 148);
            this.l_addedwords.Name = "l_addedwords";
            this.l_addedwords.Size = new System.Drawing.Size(105, 15);
            this.l_addedwords.TabIndex = 13;
            this.l_addedwords.Text = "Слова для поиска";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 709);
            this.Controls.Add(this.l_addedwords);
            this.Controls.Add(this.l_disk);
            this.Controls.Add(this.l_dir);
            this.Controls.Add(this.l_statistic);
            this.Controls.Add(this.lB_popular);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tB_words);
            this.Controls.Add(this.lB_wards);
            this.Controls.Add(this.btn_add_wards);
            this.Controls.Add(this.btn_subdir);
            this.Controls.Add(this.lB_allDrives);
            this.Controls.Add(this.btn_allDrives);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_allDrives;
        private ListBox lB_allDrives;
        private Button btn_subdir;
        private Button btn_add_wards;
        private ListBox lB_wards;
        private TextBox tB_words;
        private Button btn_search;
        private ListBox listBox1;
        private ListBox lB_popular;
        private Label l_statistic;
        private Label l_dir;
        private Label l_disk;
        private Label l_addedwords;
    }
}