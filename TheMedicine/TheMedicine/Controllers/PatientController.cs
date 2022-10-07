using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheMedicine.Interfaces;
using TheMedicine.ViewModels;

namespace TheMedicine.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientModel patient;

        public PatientController(IPatientModel _patient)
        {
            patient = _patient;

        }

        public ViewResult List()
        {
            ViewBag.Title = "Пациенты";
            PatientListViewModel obj = new PatientListViewModel();
            obj.allPatient = patient.AllPatient;
            return View(obj);
        }
    }
}
