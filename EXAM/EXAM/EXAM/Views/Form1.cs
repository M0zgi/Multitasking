using System.ComponentModel;
using System.Data;
using EXAM.Models;

namespace EXAM
{
    public partial class Form1 : Form
    {
        Drives drives = new Drives();

        public Form1()
        {
            InitializeComponent();
            try
            {
                Directory.CreateDirectory(@"C:\dir2\");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void MySearch(object s)
        { 
            pool.WaitOne();
            drives.SearchWords1();
            pool.Release();
        }

        private void btn_allDrives_Click(object sender, EventArgs e)
        {
            foreach (var d in drives.DrivesInfo())
            {
                lB_allDrives.Items.Add(d);
            }

        }

        public static Semaphore pool;
        

        private void btn_subdir_Click(object sender, EventArgs e)
        {
            drives.countFolders = 0;
            //lB_allDrives.Items.Clear();
            //lB_subdir.Items.Clear();

            foreach (var d in drives.GetDirectories())
            {
                Drives._subDir.Add(d);
                
                //lB_subdir.Items.Add(d);
            }

            pool = new Semaphore(drives._getDirectories.Count, drives._getDirectories.Count + 2, Drives.guid.ToString());


            for (int i = 0; i < Drives._subDir.Count; i++)
            {
                drives._start_path = Drives._subDir[i];
                new Thread(MySearch).Start(i);
            }
        }

        private void btn_add_wards_Click(object sender, EventArgs e)
        {
            
            lB_wards.Items.Add(tB_words.Text);
            drives.mywords[tB_words.Text] = 0;
            //MessageBox.Show(Drives.Length.ToString());
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            
            listBox1.Items.Clear();
            lB_popular.Items.Clear();

            foreach (var item in Drives.ls)
            {
                listBox1.Items.Add(item); 
            }

            foreach (var popular in drives.mywords)
            {
                lB_popular.Items.Add(popular.Key + ": " + popular.Value);
            }
        }
    }
}