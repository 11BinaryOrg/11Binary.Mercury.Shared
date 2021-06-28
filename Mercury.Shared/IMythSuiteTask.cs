using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Shared
{
    public interface IMythSuiteTask
    {
        Task<bool> Start();
        Task<bool> Stop();
    }
}
