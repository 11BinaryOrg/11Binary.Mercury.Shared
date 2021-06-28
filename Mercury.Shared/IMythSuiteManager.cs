using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Reactive;
//using System.Reactive.Linq;

namespace Mercury.Shared
{
    public interface IMythSuiteManager
    {
        System.IObservable<ReceivedMessage> ZeusObservable { get; set; }

        System.IObserver<ReceivedMessage> ZeusObserver { get; set; }
        IMedussaClient Medussa {get;set;}

        Task<bool> Start();
    }
}
