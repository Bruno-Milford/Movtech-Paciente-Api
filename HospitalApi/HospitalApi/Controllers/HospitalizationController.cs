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

        [HttpGet]
        [Route("/hospitalization/{codInternacao}")]
        public async Task<ActionResult> GetHospitalizationById(int codInternacao)
        {
            var dbGetById = await _context.Hospitalizations.FindAsync(codInternacao);

            if (dbGetById == null) return NotFound();

            return Ok(dbGetById);
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
        [Route("/hospitalization/{codInternacao}")]
        public async Task<ActionResult> UpdateHospitalization(Hospitalization hospitalization)
        {
            _context.Entry(hospitalization).State = EntityState.Modified;

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
        public async Task<ActionResult> DeleteHospitalization(int codInternacao)
        {
            var dbHospitalization = await _context.Hospitalizations.FindAsync(codInternacao);

            if (dbHospitalization == null) return NotFound();

            _context.Hospitalizations.Remove(dbHospitalization);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "Internação excluido com sucesso"
            });
        }
    }
}
