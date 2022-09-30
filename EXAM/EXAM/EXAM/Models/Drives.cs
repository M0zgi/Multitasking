using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM.Models
{
    public class Drives
    {
        public int countDrive { get; set; }
        public int countDirectories { get; set; }
       
        private DriveInfo[] _allDrives;
        private DriveInfo[] _allDirectories;

        public List<string> _allDrivesList { get; set; }
        public List<string> _getDirectories { get; set; }

        public List<string> GetRecursFiles(string start_path)
        {
            List<string> ls = new List<string>();
            List<string> fl = new List<string>();
            try
            {
                string[] folders = Directory.GetDirectories(start_path);
                foreach (string folder in folders)
                {
                    //ls.Add(folder);
                    ls.AddRange(GetRecursFiles(folder));
                }
                string[] files = Directory.GetFiles(start_path);
                foreach (string filename in files)
                {
                    ls.Add(filename);
                }
            }
            catch (System.Exception e)
            {
               // MessageBox.Show(e.Message);
            }
            return ls;
        }


        public List<string> DrivesInfo()
        {
            _allDrives = DriveInfo.GetDrives();
            _allDrivesList = new List<string>();
            foreach (DriveInfo d in _allDrives)
            {
                if (d.IsReady == true)
                {
                    _allDrivesList.Add(d.Name + d.VolumeLabel);
                    countDrive++;
                }
            }

            return _allDrivesList;
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
    }
}
