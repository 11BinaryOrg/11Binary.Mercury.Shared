using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Shared
{
    public static class ConnectionTypes
    {
        
        public enum ConnType
        {
            Redis = 0, 
            SBTopic = 2,
            SBQueue =1, 
            SBEventBus = 3
        }

         public enum Location {
            Local = 0,
            Remote = 1
        }
         public enum Connect {
            Manage = 0,
            Listen = 1,
            Send = 2
        }


    }
}
