using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Shared
{
    public class PropInfo 
    {
        public String PropName { get; set; }

        public String PropCaption { get; set; }

        public dynamic PropValue { get; set; }

        public Type PropType { get; set; }

        public String PropVersion { get; set; }
    }
}
