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
            this.lB_subdir = new System.Windows.Forms.ListBox();
            this.btn_subdir = new System.Windows.Forms.Button();
            this.btn_add_wards = new System.Windows.Forms.Button();
            this.lB_wards = new System.Windows.Forms.ListBox();
            this.tB_words = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_allDrives
            // 
            this.btn_allDrives.Location = new System.Drawing.Point(12, 12);
            this.btn_allDrives.Name = "btn_allDrives";
            this.btn_allDrives.Size = new System.Drawing.Size(75, 23);
            this.btn_allDrives.TabIndex = 0;
            this.btn_allDrives.Text = "button1";
            this.btn_allDrives.UseVisualStyleBackColor = true;
            this.btn_allDrives.Click += new System.EventHandler(this.btn_allDrives_Click);
            // 
            // lB_allDrives
            // 
            this.lB_allDrives.FormattingEnabled = true;
            this.lB_allDrives.ItemHeight = 15;
            this.lB_allDrives.Location = new System.Drawing.Point(362, 12);
            this.lB_allDrives.Name = "lB_allDrives";
            this.lB_allDrives.Size = new System.Drawing.Size(812, 94);
            this.lB_allDrives.TabIndex = 1;
            // 
            // lB_subdir
            // 
            this.lB_subdir.FormattingEnabled = true;
            this.lB_subdir.ItemHeight = 15;
            this.lB_subdir.Location = new System.Drawing.Point(362, 129);
            this.lB_subdir.Name = "lB_subdir";
            this.lB_subdir.Size = new System.Drawing.Size(812, 94);
            this.lB_subdir.TabIndex = 2;
            // 
            // btn_subdir
            // 
            this.btn_subdir.Location = new System.Drawing.Point(12, 129);
            this.btn_subdir.Name = "btn_subdir";
            this.btn_subdir.Size = new System.Drawing.Size(75, 23);
            this.btn_subdir.TabIndex = 3;
            this.btn_subdir.Text = "button1";
            this.btn_subdir.UseVisualStyleBackColor = true;
            this.btn_subdir.Click += new System.EventHandler(this.btn_subdir_Click);
            // 
            // btn_add_wards
            // 
            this.btn_add_wards.Location = new System.Drawing.Point(18, 259);
            this.btn_add_wards.Name = "btn_add_wards";
            this.btn_add_wards.Size = new System.Drawing.Size(75, 23);
            this.btn_add_wards.TabIndex = 4;
            this.btn_add_wards.Text = "add_words";
            this.btn_add_wards.UseVisualStyleBackColor = true;
            this.btn_add_wards.Click += new System.EventHandler(this.btn_add_wards_Click);
            // 
            // lB_wards
            // 
            this.lB_wards.FormattingEnabled = true;
            this.lB_wards.ItemHeight = 15;
            this.lB_wards.Location = new System.Drawing.Point(368, 259);
            this.lB_wards.Name = "lB_wards";
            this.lB_wards.Size = new System.Drawing.Size(806, 94);
            this.lB_wards.TabIndex = 5;
            // 
            // tB_words
            // 
            this.tB_words.Location = new System.Drawing.Point(130, 259);
            this.tB_words.Name = "tB_words";
            this.tB_words.Size = new System.Drawing.Size(195, 23);
            this.tB_words.TabIndex = 6;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(18, 315);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tB_words);
            this.Controls.Add(this.lB_wards);
            this.Controls.Add(this.btn_add_wards);
            this.Controls.Add(this.btn_subdir);
            this.Controls.Add(this.lB_subdir);
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
        private ListBox lB_subdir;
        private Button btn_subdir;
        private Button btn_add_wards;
        private ListBox lB_wards;
        private TextBox tB_words;
        private Button btn_search;
    }
}