using HospitalApi.Data;
using HospitalApi.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PatientController : Controller
    {
        private readonly Context _context;

        public PatientController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/patients")]
        public async Task<ActionResult> GetPatients()
        {
            return Ok(await _context.Patients.ToListAsync());
        }

        [HttpGet]
        [Route("/patients/{codPaciente}")]
        public async Task<ActionResult> GetPatientById(int codPaciente)
        {
            var dbGetbyId = await _context.Patients.FindAsync(codPaciente);

            if (dbGetbyId == null) return NotFound();

            return Ok(dbGetbyId);
        }

        [HttpPost]
        [Route("/patients")]
        public async Task<ActionResult> CreatePatient(Patient patient)
        {
            await _context.Patients.AddAsync(patient);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                data = patient,
                success = true,
                message = "Paciente cadastrado com sucesso"
            });
        }

        [HttpPut]
        [Route("/patients/{codPaciente}")]
        public async Task<IActionResult> UpdatePatient(Patient patient)
        {
            _context.Entry(patient).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                data = patient,
                success = true,
                message = "Dados do paciente editados com sucesso"
            });
        }

        [HttpDelete]
        [Route("/patients")]
        public async Task<ActionResult> DeletePatient(int codPaciente)
        {
            var dbPatient = await _context.Patients.FindAsync(codPaciente);

            if (dbPatient == null) return NotFound();

            _context.Patients.Remove(dbPatient);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "Paciente excluido com sucesso" 
            });
        }
    }
}
