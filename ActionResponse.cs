using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Shared
{
    public class ActionResponse
    {
        public string Response { get; set; }
        public string Id { get; set; }

        public string ResponseMessage { get; set; }

        public string ContentType { get; set; }

        public int OrderNo { get; set; }

        public int TotalRecords { get; set; }

        public string StatusCode { get; set; }

    }
}
