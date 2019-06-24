using System.Collections.Generic;

namespace Sharpsibo.Models
{
    public class AcStatus
    {
        public string status { get; set; }
        public bool moreResults { get; set; }
        public List<Result> result { get; set; }
    }
}