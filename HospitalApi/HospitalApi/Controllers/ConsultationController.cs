using HospitalApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ConsultationController : Controller
    {
        private readonly Context _context;

        public ConsultationController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/consultation")]
        public async Task<ActionResult> GetConsultation()
        {
            var query = (from patient in _context.Patients
                         join hospitalization in _context.Hospitalizations on patient.codPaciente equals hospitalization.codPaciente

                         select new
                         {
                             nome = patient.nomePaciente,
                             mae = patient.nomeMaePaciente,
                             cpf = patient.cpfPaciente,
                             rg = patient.rgPaciente,
                             cep = patient.cep,
                             endereco = patient.endereco,
                             celular = patient.celular,
                             email = patient.email,
                             obs = patient.observacao,

                             dataEntrada = hospitalization.dataEntradaInternacao,
                             dataSaida = hospitalization.dataSaidaInternacao,
                             clinicaMedica = hospitalization.ClinicaMedica,
                             localizacao = hospitalization.localizacao,
                             leito = hospitalization.leito,
                             centroCusto = hospitalization.centroCusto,
                             medico = hospitalization.medico,
                             crm = hospitalization.crm
                         });

            return Ok(await query.ToListAsync());
        }

        /*
        [HttpGet]
        [Route("/consultation/{codPaciente}")]
        public async Task<ActionResult> GetConsultationById(int codPaciente)
        {
            var dbGetById = await _context.Patients.FindAsync(codPaciente);

            if(dbGetById == null)
            {
                return NotFound();
            }
            else
            {
                var query = (from patient in _context.Patients
                             join hospitalization in _context.Hospitalizations on patient.cns equals hospitalization.cns

                             select new
                             {
                                 nome = patient.nomePaciente,
                                 mae = patient.nomeMaePaciente,
                                 cpf = patient.cpfPaciente,
                                 rg = patient.rgPaciente,
                                 cep = patient.cep,
                                 endereco = patient.endereco,
                                 celular = patient.celular,
                                 email = patient.email,
                                 obs = patient.observacao,

                                 dataEntrada = hospitalization.dataEntradaInternacao,
                                 dataSaida = hospitalization.dataSaidaInternacao,
                                 clinicaMedica = hospitalization.ClinicaMedica,
                                 localizacao = hospitalization.localizacao,
                                 leito = hospitalization.leito,
                                 centroCusto = hospitalization.centroCusto,
                                 medico = hospitalization.medico,
                                 crm = hospitalization.crm
                             });
            }

            return Ok(dbGetById);
        }*/
    }
}
