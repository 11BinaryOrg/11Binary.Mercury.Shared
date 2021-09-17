using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Shared
{
    public class ActionRequest
    {
        public string PageNumber { get; set; }
        public string PageSize { get; set; }
        public string SortColumn { get; set; }
        public string SortDirection { get; set; }
        public string Search { get; set; }
        public string SearchProperty { get; set; }
        public dynamic Projection { get; set; }

        public object Message { get; set; }

        public string MachineName { get; set; }
    }
}
