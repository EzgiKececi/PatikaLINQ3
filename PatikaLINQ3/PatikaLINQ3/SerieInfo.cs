using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PatikaLINQ3
{
    public class SerieInfo
    {
        public string SerieName { get; set; }
        public string SerieType { get; set; }
        public string Director { get; set; }

        public SerieInfo(string _serieName, string _serieType, string _director)
        {
            SerieName = _serieName;
            SerieType = _serieType;           
            Director = _director;
            
        }
    }
}
