using System.Collections.Generic;

namespace Sharpsibo.Models
{
    public class Pods
    {
        public string status { get; set; } 
        public List<Pod> Result { get; set; }
    }
}