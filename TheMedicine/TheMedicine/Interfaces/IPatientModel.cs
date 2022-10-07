using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheMedicine.Models;

namespace TheMedicine.Interfaces
{
    public interface IPatientModel
    {
        IEnumerable<PatientModel> AllPatient { get; }
        int AddPatient(PatientModel patientModel);
        PatientModel GetPatientById(int id);
        IEnumerable<PatientModel> GetPatientByName(string sur);
        void DeletePatient(int id);
    }
}
