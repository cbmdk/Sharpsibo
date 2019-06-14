using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpsibo.Models
{
    public class ConnectionStatus
    {
        public bool isAlive { get; set; }
        public Time lastSeen { get; set; }
    }
}
