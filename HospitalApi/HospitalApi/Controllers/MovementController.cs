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

        [HttpGet]
        [Route("/movement/{codMovimentacao}")]
        public async Task<ActionResult> GetMovementById(int codMovimentacao)
        {
            var dbGetById = await _context.Movements.FindAsync(codMovimentacao);

            if (dbGetById == null)
            {
                return NotFound();
            }

            return Ok(dbGetById);
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
        [Route("/movement/{codMovimentacao}")]
        public async Task<ActionResult> UpdateMovement(Movement movement)
        {
            _context.Entry(movement).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                data = movement,
                success = true,
                message = "Dados da movimentação editados com sucesso"
            });
        }

        [HttpDelete]
        [Route("/movement")]
        public async Task<ActionResult> DeleteMovement(int codMovimentacao)
        {
            var dbMovement = await _context.Movements.FindAsync(codMovimentacao);

            if (dbMovement == null) return NotFound();

            _context.Movements.Remove(dbMovement);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "Dados da movimentação editados com sucesso"
            });
        }
    }
}
