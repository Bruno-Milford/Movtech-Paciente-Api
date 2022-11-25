using HospitalApi.Data;
using HospitalApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CostCentController : Controller
    {
        private readonly Context _context;

        public CostCentController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/costcenter")]
        public async Task<ActionResult> GetCostCenter()
        {
            return Ok(await _context.costCenters.ToArrayAsync());
        }

        [HttpPost]
        [Route("/costcenter")]
        public async Task<ActionResult> CreateCostCenter(CostCenter costCenter)
        {
            await _context.costCenters.AddAsync(costCenter);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                data = costCenter,
                success = true,
                message = "Centro de custo cadastrado com sucesso"
            });
        }

        [HttpPut]
        [Route("/costcenter")]
        public async Task<ActionResult> UpdateCostCenter(CostCenter costCenter)
        {
            var dbCostCenter = await _context.costCenters.FindAsync(costCenter.codCentroCusto);

            if (dbCostCenter == null) return NotFound();

            dbCostCenter.nomeCentroCusto = costCenter.nomeCentroCusto;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                data = costCenter,
                success = true,
                message = "Dados do centro de custo editados com sucesso"
            });
        }

        [HttpDelete]
        [Route("/costcenter")]
        public async Task<ActionResult> DeleteCostCenter(Guid codCentroCusto)
        {
            var dbCostCenter = await _context.costCenters.FindAsync(codCentroCusto);

            if (dbCostCenter == null) return NotFound();

            _context.costCenters.Remove(dbCostCenter);

            return Ok(new
            {
                success = true,
                message = "Centro de custo excluido com sucesso"
            });
        }
    }
}
