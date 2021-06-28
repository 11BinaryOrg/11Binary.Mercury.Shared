using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Shared
{
    public class DataReturnArgs
    {
        public string Message { get; set; }
        public string SessionID { get; set; }
        public string CorelationID { get; set; }
        public ReceivedMessage ReceivedMessage { get; set; }

    }
}
