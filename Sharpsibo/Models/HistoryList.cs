using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpsibo.Models
{
    public class HistoryList
    {
        public List<Temperature> temperature { get; set; }
        public List<Humidity> humidity { get; set; }
    }
}
