using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLINQ3
{
    public class Serie
    {
        public string SerieName { get; set; }
        public string SerieType { get; set; }
        public int ReleasedYear { get; set; }
        public string Director { get; set; }
        public string TvChannel { get; set; }

        public Serie(string _serieName, string _serieType, int _releasedYear, string _director, string _tvChannel) 
        {
            SerieName = _serieName;
            SerieType = _serieType;
            ReleasedYear = _releasedYear;
            Director = _director;
            TvChannel = _tvChannel;

        }

    }
}
