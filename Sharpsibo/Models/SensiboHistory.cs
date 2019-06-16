using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Sharpsibo.Models
{
    public class SensiboHistory
    {
        public string Status { get; set; }
        public List<Temperature> Result { get; set; }
    }
}
