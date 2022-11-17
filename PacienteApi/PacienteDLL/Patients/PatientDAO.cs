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

            using (var cn = new SqlConnection(SqlServerConn.StrCon))
            {
                patients = cn.Patients.ToList();
            }

            return patients;
        }
    }
}
