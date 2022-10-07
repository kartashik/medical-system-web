using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheMedicine.Models
{
    public class ProtocolModel
    {
        public int Id { get; set; }
        public int idPatient { get; set; }
        public DateTime date { get; set; }
        public string anamnesis { get; set; }
    }
}
