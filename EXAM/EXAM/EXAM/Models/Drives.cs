using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EXAM.Models
{
    public class Drives
    {
        public int countDirectories { get; set; }
        public int countFolders { get; set; }

        public static Guid guid = Guid.NewGuid();

        Random rnd = new Random();

        private int _randomValue;
        
        private DriveInfo[] _allDirectories;
        public static List<string> _subDir { get; set; } = new List<string>();
        public List<string> _getDirectories { get; set; }

        public static List<string> ls { get; set; } = new List<string>();

        public static long Length { get; set; }

        private static object block = new object();

        public string _start_path { get; set; }

        public Dictionary<string, int> mywords = new Dictionary<string, int>();

       public void GetRecursFiles(string start_path)
        {
            try
            {
                
                string[] folders = Directory.GetDirectories(start_path);
                foreach (string folder in folders)
                {
                    //ls.Add(folder);
                    //ls.AddRange(GetRecursFiles(folder));
                   
                    GetRecursFiles(folder);
                }
                string[] files = Directory.GetFiles(start_path);
                foreach (string filename in files)
                {
                    
                    //
                    //
                    if(Path.GetExtension(filename) == ".txt" && filename.Length < 1000000000)
                   // if (Path.GetExtension(filename) == ".txt")
                    {
                       // ls.Add(filename);
                        SearchWords(filename);
                    }
                        
                }
            }
            catch (System.Exception e)
            {
                // MessageBox.Show(e.Message);
            }

            
            //return ls;
        }

        public void SearchWords1()
        {
            countDirectories--;

            try
            {
                //string[] folders = Directory.GetDirectories(_start_path);
                GetRecursFiles(_getDirectories[countDirectories]);
            }
            catch (System.Exception e)
            {
                // MessageBox.Show(e.Message);
            }
        }


        public List<string> DrivesInfo()
        {
            _allDirectories = DriveInfo.GetDrives();
            _getDirectories = new List<string>();
            foreach (DriveInfo d in _allDirectories)
            {
                if (d.IsReady == true)
                {
                    _getDirectories.Add(d.Name);
                    countDirectories++;
                }
            }

            return _getDirectories;

        }

        public List<string> GetDirectories()
        {
            _allDirectories = DriveInfo.GetDrives();
            _getDirectories = new List<string>();
            foreach (DriveInfo d in _allDirectories)
            {
                if (d.IsReady == true)
                {
                    _getDirectories.Add(d.Name);
                    countDirectories++;
                }
            }

            return _getDirectories;
        }
        
        public void SearchWords(string filename)
        {

            try
            {
                int count = 0;
 
                string poisk = File.ReadAllText(filename);

                char[] separators = { ';',' ','.',',','\'','\"',')','(','-'}; //создаём массив символов, служащих разделителями слова

                string[] words = poisk.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                
                
                //string slovo = "fhdddf3445dfg";

                foreach (string slovo in mywords.Keys)
                {
                    if (words.Contains($"{slovo}"))
                    {
                        lock (block)
                        {
                            Length++;
                            mywords[slovo]++;
                        }

                        ls.Add(filename);
                        //File.Copy(filename, @"C:\dir2\", true);
                        _randomValue = rnd.Next(0, 11110);
                        File.Copy(filename, @"C:\dir2\" + _randomValue + ". " + Path.GetFileName(filename), true);

                        //MessageBox.Show($"было найдено \n {filename}");
                    }
                }
                
                //else
                //{
                //    //MessageBox.Show("не было найдено");
                //}
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
    }
}
