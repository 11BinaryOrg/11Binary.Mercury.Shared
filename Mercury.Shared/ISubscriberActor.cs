using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Shared
{
    public interface ISubscriberActor
    {
        bool Start();
        bool Subscribe();
        bool Unsubscribe();
        bool Stop();
        bool Execute(ReceivedMessage rm);
    }
}
