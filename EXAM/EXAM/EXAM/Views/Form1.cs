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
           
        }

        private void btn_allDrives_Click(object sender, EventArgs e)
        {
            foreach (var d in drives.DrivesInfo())
            {
                lB_allDrives.Items.Add(d);
            }

        }

        private void btn_subdir_Click(object sender, EventArgs e)
        {
            foreach (var d in drives.GetDirectories())
            {
                lB_subdir.Items.Add(d);
            }

            foreach (var d in drives.GetRecursFiles((string)lB_subdir.Items[1]))
            {
                lB_allDrives.Items.Add(d);
            }
            
            try
            {
                for (int i = 0; i < drives.countDrive; i++)
                {
                    string[] dirs = Directory.GetDirectories((string)lB_subdir.Items[i]);

                    foreach (string dir in dirs)
                    {
                        lB_subdir.Items.Add(dir);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_add_wards_Click(object sender, EventArgs e)
        {
            
            lB_wards.Items.Add(tB_words.Text);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }
    }
}