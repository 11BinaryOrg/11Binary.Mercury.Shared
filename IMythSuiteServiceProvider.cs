using System;

namespace Mercury.Shared
{
    public interface IMythSuiteServiceProvider
    {
        bool Register();
        bool Start();
        bool Subscribe();
        bool Unsubscribe();
        bool Stop();
    }
}
