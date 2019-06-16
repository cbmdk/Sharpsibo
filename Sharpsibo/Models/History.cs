using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpsibo.Models
{
    public class History
    {
        public string status { get; set; }
        public List<Temperature> Result { get; set; }
    }
}
