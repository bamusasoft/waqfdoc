using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDM.Domain
{
    public class Document
    {
        public string DocNo { get; set; }
        public string DocDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DocStatus Status { get; set; }
    }
}
