using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheMedicine.Models;

namespace TheMedicine.Data
{
    public class DBObjects
    {
        public static void Initial(ApplicationContext context)
        {
            if (!context.Patients.Any())
            {
                context.Patients.AddRange(PatientsAll.Select(c => c.Value));
            }
            context.SaveChanges();
        }
        private static Dictionary<string, PatientModel> valuePairs;
        public static Dictionary<string, PatientModel> PatientsAll
        {
            get
            {
                if (valuePairs == null)
                {
                    var list = new PatientModel[]
                    {
                        new PatientModel { Surname = "Карташова", Name = "Марина", Patronymic = "Владимировна", DateOfBirth = new DateTime(2001, 02, 19), Gender = 1, Phone = "89198345266" },
                        new PatientModel { Surname = "Семенова", Name = "Елизавета", Patronymic = "Андреевна", DateOfBirth = new DateTime(2001, 05, 05), Gender = 1, Phone = "89195689944" },
                        new PatientModel { Surname = "Гаврилова", Name = "Александра", Patronymic = "Евгеньева", DateOfBirth = new DateTime(2002, 04, 06), Gender = 1, Phone = "89198345555" },
                        new PatientModel { Surname = "Симонова", Name = "Анна", Patronymic = "Владимировна", DateOfBirth = new DateTime(2001, 11, 03), Gender = 1, Phone = "89198344566" },
                        new PatientModel { Surname = "Костюкевич", Name = "Татьяна", Patronymic = "Алексеевна", DateOfBirth = new DateTime(2001, 01, 25), Gender = 1, Phone = "8917895266" }
                    };
                    valuePairs = new Dictionary<string, PatientModel>();
                    foreach (PatientModel pm in list)
                        valuePairs.Add(pm.Surname, pm);
                }
                return valuePairs;
            }
        }
    }
}
