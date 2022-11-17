using PacienteDLL.SqlConn;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacienteDLL.Patients
{
    internal class PatientDAO
    {
        public List<Patient> GetPatients()
        {
            List<Patient> patients;

            using (var cn = new SqlServerConn())
            {
                patients = cn.Patients.ToList();
            }

            return patients;
        }

        public void SavePatients(List<Patient> listaPacientes)
        {
            using (var cn = new SqlServerConn())
            {


                foreach(Patient patient in listaPacientes)
                {
                    cn.Patients.Add(patient);
                }
            }
        }
    }
}
