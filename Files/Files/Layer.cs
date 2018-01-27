using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Layer
    {
        public DirectoryInfo DirInfo;
        public string path;
        public int ind;

        public Layer(string path, int ind) //constructor
        {
            this.path = path;
            this.ind = ind;
            this.DirInfo = new DirectoryInfo(path);
        }

        public void Process(int v) //changing ind
        {
            this.ind += v;
            if (this.ind < 0) this.ind = this.DirInfo.GetFileSystemInfos().Length - 1;
            if (this.ind > this.DirInfo.GetFileSystemInfos().Length) this.ind = 0;
        }

        public string GetSelectedDirInfo() //get full name of selected directory
        {
            return this.DirInfo.GetDirectories()[ind].FullName;
        }
    }
}
