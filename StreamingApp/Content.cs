using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp
{
    public abstract class Content
    {
        private string _title;
        private int _releaseYear;
        private int _watchedMin;

        public int WatchedMin { get { return _watchedMin; } set { _watchedMin = value; } }
        public string Title { get { return _title; } set { _title = value; } }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                if (value >= 1900 && value <= 2026)
                {
                    _releaseYear = value;
                }
                else
                {
                    _releaseYear = 0;
                }
            }
        }

        public Content(string title, int year) 
        {
            Title = title;
            ReleaseYear = year;
        }

        public abstract int TotalMinutes();

        public string LengthText()
        {
            int min = TotalMinutes();
            return $"{(int)(min/60)} óra, {(min%60)} perc";
        }

        public virtual string GetDescription()
        {
            return $"{Title} " +
                $"({(ReleaseYear == 0 ? "ismeretlen év" : ReleaseYear)})";
        }
        public bool IsFinished()
        {
            return _watchedMin == TotalMinutes();
        }
        public virtual bool Watch(int minutes)
        {
            if (minutes < 0 || IsFinished())
                return false;
            if (WatchedMin + minutes > TotalMinutes())
            {
                _watchedMin = TotalMinutes();
            }
            {
                _watchedMin += minutes;
            }
               
            return true;
        }
    }
}
