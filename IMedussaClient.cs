using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Shared
{
    public interface IMedussaClient
    {

        event GlobalDelegates.DataAvailableEventHandler OnDataAvailable;
        event GlobalDelegates.SimpleMessageEventHandler OnSuccess;
        event GlobalDelegates.SimpleMessageEventHandler OnFailure;
        event EventHandler<Exception> OnExceptionThrown;
        Task<bool> Start();
        Task<string> PublishMessage(string channel, ReceivedMessage rm, ConnectionTypes.ConnType type);
    }
}
