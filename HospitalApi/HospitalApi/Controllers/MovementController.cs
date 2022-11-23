using HospitalApi.Data;
using HospitalApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MovementController : Controller
    {
        private readonly Context _context;

        public MovementController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/movement")]
        public async Task<ActionResult> GetMovement()
        {
            return Ok(await _context.Movements.ToListAsync());
        }

        [HttpPost]
        [Route("/movement")]
        public async Task<ActionResult> CreateMovement(Movement movement)
        {
            await _context.Movements.AddAsync(movement);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                data = movement,
                success = true,
                message = "Movimentação cadastrada com sucesso"
            });
        }

        [HttpPut]
        [Route("/movement")]
        public async Task<ActionResult> UpdateMovement(Movement movement)
        {
            var dbMovement = await _context.Movements.FindAsync(movement.codMovimentacao);

            if (dbMovement == null) return NotFound();

            await _context.SaveChangesAsync();

            dbMovement.codPacienteMov = movement.codPacienteMov;
            dbMovement.nomePacienteMov = movement.nomePacienteMov;
            dbMovement.dataNascimentoMov = movement.dataNascimentoMov;
            dbMovement.nomeMaePacienteMov = movement.nomeMaePacienteMov;
            dbMovement.dataMovimentacao = movement.dataMovimentacao;
            dbMovement.horaMovimentacao = movement.horaMovimentacao;
            dbMovement.motivo = movement.motivo;
            dbMovement.localizacao = movement.localizacao;
            dbMovement.leitoMov = movement.leitoMov;
            dbMovement.centroCustoMov = movement.centroCustoMov;
            dbMovement.medicoMov = movement.medicoMov;
            dbMovement.crmMov = movement.crmMov;

            return Ok(new
            {
                data = movement,
                success = true,
                message = "Dados da movimentação editados com sucesso"
            });
        }

        [HttpDelete]
        [Route("/movement")]
        public async Task<ActionResult> DeleteMovement(Guid codMovimentacao)
        {
            var dbMovement = await _context.Movements.FindAsync(codMovimentacao);

            if (dbMovement == null) return NotFound();

            await _context.SaveChangesAsync();

            _context.Movements.Remove(dbMovement);

            return Ok(new
            {
                success = true,
                message = "Dados da movimentação editados com sucesso"
            });
        }
    }
}
