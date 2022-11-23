using HospitalApi.Data;
using HospitalApi.Models;
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
        [Route("/patients")]
        public async Task<ActionResult> UpdatePatient(Patient patient)
        {
            var dbPatient = await _context.Patients.FindAsync(patient.codPaciente);

            if (dbPatient == null) return NotFound();

            dbPatient.nomePaciente = patient.nomePaciente;
            dbPatient.sexoPaciente = patient.sexoPaciente;
            dbPatient.dataNascimento = patient.dataNascimento;
            dbPatient.nomeMaePaciente = patient.nomeMaePaciente;
            dbPatient.cpfPaciente = patient.cpfPaciente;
            dbPatient.rgPaciente = patient.rgPaciente;
            dbPatient.cns = patient.cns;
            dbPatient.corPaciente = patient.corPaciente;
            dbPatient.nacionalidade = patient.nacionalidade;
            dbPatient.naturalidade = patient.naturalidade;
            dbPatient.grauInstrucaoPaciente = patient.grauInstrucaoPaciente;
            dbPatient.profissaoPaciente = patient.profissaoPaciente;
            dbPatient.responsavelPaciente = patient.responsavelPaciente;
            dbPatient.cep = patient.cep;
            dbPatient.bairro = patient.bairro;
            dbPatient.cidade = patient.cidade;
            dbPatient.uf = patient.uf;
            dbPatient.telefone = patient.telefone;
            dbPatient.celular = patient.celular;
            dbPatient.contato = patient.contato;
            dbPatient.telefoneContato = patient.telefoneContato;
            dbPatient.email = patient.email;
            dbPatient.observacao = patient.observacao;

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
        public async Task<ActionResult> DeletePatient(Guid codPaciente)
        {
            var dbPatient = await _context.Patients.FindAsync(codPaciente);

            if (dbPatient == null) return NotFound();

            _context.Patients.Remove(dbPatient);

            return Ok(new
            {
                success = true,
                message = "Paciente excluido com sucesso" 
            });
        }
    }
}
