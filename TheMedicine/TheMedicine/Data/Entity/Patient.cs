using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheMedicine.Interfaces;
using TheMedicine.Models;

namespace TheMedicine.Data.Entity
{
    public class Patient : IPatientModel
    {
        private readonly ApplicationContext appDBContent;

        public Patient(ApplicationContext context)
        {
            this.appDBContent = context;
        }
        public IEnumerable<PatientModel> AllPatient => appDBContent.Patients;

        public int AddPatient(PatientModel patientModel)
        {
            return 0;
        }

        public void DeletePatient(int id)
        {
        }

        public PatientModel GetPatientById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PatientModel> GetPatientByName(string sur)
        {
            throw new NotImplementedException();
        }
    }
}
