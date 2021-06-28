using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Shared
{
    public static class GlobalDelegates
    {
        public delegate void SimpleMessageEventHandler(object Sender, Mercury.Shared.SimpleMessageReturnArgs e);
        public delegate void DataAvailableEventHandler(object Sender, Mercury.Shared.DataReturnArgs e);
        public delegate void TokenAcquiredEventHandler(object Sender, Mercury.Shared.AuthenticationTokenReturnArgs e);

    }
}
