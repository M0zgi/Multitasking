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
            lB_allDrives.Items.Clear();
            lB_subdir.Items.Clear();

            foreach (var d in drives.GetDirectories())
            {
                lB_subdir.Items.Add(d);
            }

            pool = new Semaphore(drives._getDirectories.Count, drives._getDirectories.Count + 2, Drives.guid.ToString());
            
            for (int i = 0; i < lB_subdir.Items.Count; i++)
            {
                drives._start_path = lB_subdir.Items[i].ToString();
                new Thread(MySearch).Start(i);
            }

            //for (int i = 0; i < lB_subdir.Items.Count; i++)
            //{
            //    //Thread thr = ();
            //    lB_allDrives.Items.Clear();

            //    foreach (var d in drives.GetRecursFiles((string)lB_subdir.Items[i]))
            //    {
            //        lB_allDrives.Items.Add(d);
            //        drives.countFolders++;
            //    }
            //}

            

            //// MessageBox.Show(drives.countFolders.ToString());

            //try
            //{
            //    for (int i = 0; i < drives.countDrive; i++)
            //    {
            //        string[] dirs = Directory.GetDirectories((string)lB_subdir.Items[i]);

            //        foreach (string dir in dirs)
            //        {
            //            lB_subdir.Items.Add(dir);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

            
        }

        private void btn_add_wards_Click(object sender, EventArgs e)
        {
            
            lB_wards.Items.Add(tB_words.Text);
            drives.mywords.Add(tB_words.Text);
            //MessageBox.Show(Drives.Length.ToString());

            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            
            listBox1.Items.Clear();

            foreach (var item in Drives.ls)
            {
                listBox1.Items.Add(item); 
            }
            

            //var folder = lB_subdir.Items[1].ToString();


            //try
            //{
            //    var results = Directory.GetFiles(folder, "*.txt", SearchOption.AllDirectories)
            //        .AsParallel()
            //        .SelectMany(x=>drives.GetFilieredLines(x, "public class"));
            //}
            //catch (System.Exception ex)
            //{
            //    // MessageBox.Show(e.Message);
            //}


        }
    }
}