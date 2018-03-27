using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDM.Domain
{
    public class DocumentAppointment
    {
        public string Id { get; set; }
        public string DocNo { get; set; }
        public string AppointmentDate { get; set; }
        public string Destination { get; set; }
       
    }
}
