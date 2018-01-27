using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Far_Manager
{
    class Layer
    {
        public DirectoryInfo dirInfo;
        public string path;
        public int ind;
        public List<FileSystemInfo> items;

        public Layer(string path, int ind)
        {
            this.path = path;
            this.ind = ind;
            this.dirInfo = new DirectoryInfo(path);

            items = new List<FileSystemInfo>();
            items.AddRange(dirInfo.GetDirectories());
            items.AddRange(dirInfo.GetFiles());
        }

        public void Process(int q)
        {
            this.ind += q;
            if (this.ind < 0) this.ind = items.Count() - 1;
            if (this.ind > items.Count - 1) this.ind = 0;
        }

        public string GetSelectedItemInfo()
        {
            return this.items[ind].FullName;
        }
    }
}
