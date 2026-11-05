using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp
{
    public class Series : Content
    {
        private int _episode { get; set; }
        private int _episodeMinutes { get; set; }
        public int Episode { get { return _episode; } set { _episode = value; } }
        public int EpisodeMin { get { return _episodeMinutes; } set { _episodeMinutes = value; } }

        public Series(string title, int year, int ep, int epMin): base(title, year)
        {
            Episode = ep;
            EpisodeMin = epMin;
        }
        public override int TotalMinutes()
        {
            return Episode * EpisodeMin; 
        }
        public override string GetDescription()
        {
            return $"{base.GetDescription()}, sorozat, {Episode} rész, {LengthText()}";
        }
        public override bool Watch(int minutes)
        {
            if (minutes > EpisodeMin)
                return false;
            return base.Watch(minutes);
        }
        public int CurrentEpisode()
        {
            if(_episodeMinutes == 0)
            {
                return 0;
            }
            if (IsFinished())
                return _episode;
            return
                WatchedMin / _episodeMinutes + 1;
        }
        public int GetSizeMb()
        {
            return TotalMinutes() * 20;
        }
 
    }
}
