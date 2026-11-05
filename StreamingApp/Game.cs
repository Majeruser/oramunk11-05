using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp
{
   public class Game : IDownloadable
    {
        private string _name;
        private int _sizeMb;
        public string Name { get { return _name; } set { _name = value; } }
        public int SizeMb { get { return _sizeMb; } set { if (value < 0) { _sizeMb = 0; } else { _sizeMb = value; } } }

        public Game(string name, int size)
        {
            Name = name;
            SizeMb = size;
        }
        public int GetSize()
        {
            return _sizeMb;
        }
        public string GetDescription()
        {
            return $"{Name}, játék";
        }
    }
}
