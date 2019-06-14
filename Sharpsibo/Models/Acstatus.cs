using System.Collections.Generic;

namespace Sharpsibo.Models
{
    public class AcStatus
    {
        public string Status { get; set; }
        public bool MoreResults { get; set; }
        public List<Result> Result { get; set; }
    }
}