using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDM.Domain
{
    public class DocumentReponse
    {
        public string Id { get; set; }
        public string DocNo { get; set; }
        public string ResponseDate { get; set; }
        public string OutboxNo { get; set; }
        public string OutboxDate { get; set; }
        public string Subject { get; set; }
    }
}
