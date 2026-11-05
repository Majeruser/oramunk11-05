using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp
{
    public class Phone
    {
        private int _freeSpaceMb;
        private List<IDownloadable> _download;
        private bool _isOnWifi;
        public int FreeSpaceMb { get { return _freeSpaceMb; } set { _freeSpaceMb = value; } }
        public List<IDownloadable> Download { get { return _download; } }
        public bool IsOnWifi { get { return _isOnWifi; } set { _isOnWifi = value; } }
        public Phone(int freeSpace)
        {
            _freeSpaceMb = freeSpace;
            _download = new List<IDownloadable>();
        }
        public bool Downloadn(IDownloadable item)
        {
            if (FreeSpaceMb > item.GetSize())
                return false;
            _freeSpaceMb -= item.GetSize();
            _download.Add(item);
            return true;
        }
    }
}
