using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Shared
{
    internal class ZeusSubscriberFactoryBase : IZeusSubscriber
    {
        public IZeusConnection Connection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event GlobalDelegates.DataAvailableEventHandler OnDataAvailable;

        public event GlobalDelegates.SimpleMessageEventHandler OnSuccess;

        public event GlobalDelegates.SimpleMessageEventHandler OnFailure;

        public event EventHandler<Exception> OnExceptionThrown;

        

        public virtual  Task<bool> Start(IZeusConnection az)
        {
            throw new NotImplementedException();
        }

        public virtual  Task<bool> Stop()
        {
            throw new NotImplementedException();
        }

        public virtual  Task<bool> Subscribe()
        {
            throw new NotImplementedException();
        }

        public virtual  Task<bool> Unsubscribe()
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Publish(Mercury.Shared.ReceivedMessage rm)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Receive()
        {
            throw new NotImplementedException();
        }
    }
}
