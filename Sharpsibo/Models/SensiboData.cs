using System.Collections.Generic;

namespace Sharpsibo.Models
{
    public class SensiboData
    {
        public string Status { get; set; }
        public List<Measurements> Result { get; set; }
    }
}