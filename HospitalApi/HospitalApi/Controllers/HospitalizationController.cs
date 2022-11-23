using HospitalApi.Data;
using HospitalApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HospitalizationController : Controller
    {
        private readonly Context _context;

        public HospitalizationController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/hospitalization")]
        public async Task<ActionResult> GetHospitalization()
        {
            return Ok(await _context.Hospitalizations.ToListAsync());
        }

        [HttpPost]
        [Route("/hospitalization")]
        public async Task<ActionResult> CreateHospitalization(Hospitalization hospitalization)
        {
            await _context.Hospitalizations.AddAsync(hospitalization);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                data = hospitalization,
                success = true,
                message = "Internação criada com sucesso"
            });
        }

        [HttpPut]
        [Route("/hospitalization")]
        public async Task<ActionResult> UpdateHospitalization(Hospitalization hospitalization)
        {
            var dbHospitalization = await _context.Hospitalizations.FindAsync(hospitalization.codInternacao);

            if (dbHospitalization == null) return NotFound();

            dbHospitalization.codPaciente = hospitalization.codPaciente;
            dbHospitalization.Paciente = hospitalization.Paciente;
            dbHospitalization.Nascimento = hospitalization.Nascimento;
            dbHospitalization.MaePaciente = hospitalization.MaePaciente;
            dbHospitalization.dataEntradaInternacao = hospitalization.dataEntradaInternacao;
            dbHospitalization.horaEntradaInternacao = hospitalization.horaEntradaInternacao;
            dbHospitalization.dataSaidaInternacao = hospitalization.dataSaidaInternacao;
            dbHospitalization.horaSaidaInternacao = hospitalization.horaSaidaInternacao;
            dbHospitalization.cns = hospitalization.cns;
            dbHospitalization.ClinicaMedica = hospitalization.ClinicaMedica;
            dbHospitalization.localizacao = hospitalization.localizacao;
            dbHospitalization.leito = hospitalization.leito;
            dbHospitalization.centroCusto = hospitalization.centroCusto;
            dbHospitalization.hipoteseDiagnostica = hospitalization.hipoteseDiagnostica;
            dbHospitalization.medico = hospitalization.medico;
            dbHospitalization.crm = hospitalization.crm;
            dbHospitalization.diagnostico = hospitalization.diagnostico;
            dbHospitalization.situacao = hospitalization.situacao;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                data = hospitalization,
                success = true,
                message = "Dados do paciente editados com sucesso"
            });
        }

        [HttpDelete]
        [Route("/hospitalization")]
        public async Task<ActionResult> DeleteHospitalization(Guid codInternacao)
        {
            var dbHospitalization = await _context.Hospitalizations.FindAsync(codInternacao);

            if (dbHospitalization == null) return NotFound();

            _context.Hospitalizations.Remove(dbHospitalization);

            return Ok(new
            {
                success = true,
                message = "Internação excluido com sucesso"
            });
        }
    }
}
