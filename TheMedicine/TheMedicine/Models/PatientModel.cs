using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheMedicine.Models
{
    public class PatientModel
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string Phone { get; set; }
    }
}
