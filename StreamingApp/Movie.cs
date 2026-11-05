using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp
{
    public class Movie : Content
    {
        private int _durationMinutes;

        public int DurationMinutes
        {
            get { return _durationMinutes; }
            set
            {
                if (value <= 0)
                {
                    _durationMinutes = 0;
                }
                else
                {
                    _durationMinutes = value;
                }
            }
        }

        public Movie(string title, int year, int duration) : base(title,year) 
        {
            DurationMinutes = duration;
        }

        public override int TotalMinutes()
        {
            return _durationMinutes;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $" film, {base.LengthText()}";
        }
        public int GetSizeMb()
        {
            return TotalMinutes() * 25;
        }
    }
}
