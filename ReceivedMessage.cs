using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercury.Shared
{
    

    public class ReceivedMessage
    {
        public string Application { get; set; }
        public string Tenant { get; set; }
        public string MessageId { get; set; }
        public string Caller { get; set; }
        public string Token { get; set; }
        public string Action { get; set; }
        public string NameSpace { get; set; }
        public string Version { get;set;}

        public string Originator { get; set; }
        public string ConnectionId { get; set; }

        public string CorelationId { get; set; }
        public string SessionId { get; set; }
        public string Direction { get; set; }
        public string Entity { get; set; }
        public string CreatedDt { get; set; }
        public string To { get; set; }
        public string ReplyTo { get; set; }
        public dynamic Message { get; set; }

        public Guid WorkflowID { get; set; }
        public String WorkflowName { get; set; }
        public Guid WorkflowInstanceID { get; set; }

    }
}
