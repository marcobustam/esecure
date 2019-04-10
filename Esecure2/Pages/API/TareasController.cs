using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Planificacion;
using EsecureModel.Exam;

namespace EsecureWebApp.Pages.API
{
    //[Route("api/[controller]/[Action]")]
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TareasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Tareas
        [HttpGet]
        [ActionName("GetTarea")]
        public IEnumerable<Tarea> GetTarea()
        {
            return _context.Tarea;
        }

        // GET: api/Tareas/5
        [HttpGet("{id}")]
        [ActionName("GetTarea")]
        public async Task<IActionResult> GetTarea([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tarea = await _context.Tarea.FindAsync(id);

            if (tarea == null)
            {
                return NotFound();
            }

            return Ok(tarea);
        }
        // GET: api/Tareas/5
        [HttpGet("{id}/{et}")]
        [ActionName("GetEstado")]
        public async Task<IActionResult> GetEstado([FromRoute] int id, [FromRoute] EstadoTarea et)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tarea = await _context.Tarea.FindAsync(id);

            if (tarea == null)
            {
                return NotFound();
            }
            var historicotarea = new HistoricoTarea(tarea, et);
            await _context.HistoricoTarea.AddAsync(historicotarea);
            tarea.EstadoID = et;
            await _context.SaveChangesAsync();
            return Ok(tarea);
        }

        [ActionName("GetCambiaEstado")]
        public async Task<IActionResult> GetCambiaEstado(int emid, int plid, int taid, EstadoTarea esid )
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                //var tarea = await _context.Tarea.Include(ta=>ta.Checklist).Where(ta=>ta.TareaID==taid).ToListAsync();
                var tarea = await _context.Tarea.Where(ta => ta.TareaID == taid).FirstAsync();

                if (tarea == null)
                {
                    return NotFound();
                }
                switch (esid) {
                    case EstadoTarea.Nueva:
                        break;
                    case EstadoTarea.Planificada:
                        break;
                    case EstadoTarea.Iniciada:
                        tarea.FechaEjecucionReal = DateTime.Now;
                        break;
                    case EstadoTarea.Realizada:
                        tarea.FechaFinEjecucionReal = DateTime.Now;
                        break;
                    default:
                        break;
                }
                tarea.FechaUltimaModificacion = DateTime.Now;
                var historicotarea = new HistoricoTarea(tarea, esid);
                await _context.HistoricoTarea.AddAsync(historicotarea);
                tarea.EstadoID = esid;
                /****/
                /*
                var exam = new Examination(tarea[0]);
                // exam.Prueba = await _context.Test.FindAsync(tarea.ActividadVerificacionID);
                await _context.Examination.AddAsync(exam);
                /****/
                await _context.SaveChangesAsync();
                return Ok(tarea);
            }
            catch (Exception)
            {
                return RedirectToPage("/Planes/Prevencion/Planificaciones/Details", new { emid, plid, taid }); ;
            }
            
        }
        [HttpGet]
        [ActionName("GetCambiaEstado2")]
        public async Task<IActionResult> GetCambiaEstado2(int emid, int plid, int taid, EstadoTarea esid )
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                //var tarea = await _context.Tarea.Include(ta=>ta.Checklist).Where(ta=>ta.TareaID==taid).ToListAsync();
                var tarea = await _context.Tarea.Where(ta => ta.TareaID == taid).FirstAsync();

                if (tarea == null)
                {
                    return NotFound();
                }
                switch (esid) {
                    case EstadoTarea.Nueva:
                        break;
                    case EstadoTarea.Planificada:
                        break;
                    case EstadoTarea.Iniciada:
                        tarea.FechaEjecucionReal = DateTime.Now;
                        break;
                    case EstadoTarea.Realizada:
                        tarea.FechaFinEjecucionReal = DateTime.Now;
                        break;
                    default:
                        break;
                }
                tarea.FechaUltimaModificacion = DateTime.Now;
                var historicotarea = new HistoricoTarea(tarea, esid);
                await _context.HistoricoTarea.AddAsync(historicotarea);
                tarea.EstadoID = esid;
                /****/
                /*
                var exam = new Examination(tarea[0]);
                // exam.Prueba = await _context.Test.FindAsync(tarea.ActividadVerificacionID);
                await _context.Examination.AddAsync(exam);
                /****/
                await _context.SaveChangesAsync();
                return RedirectToPage("/Planes/Prevencion/Planificaciones/Details", new { emid, plid, taid });
            }
            catch (Exception)
            {
                return RedirectToPage("/Planes/Prevencion/Planificaciones/Details", new { emid, plid, taid });
            }
            
        }

        // PUT: api/Tareas/5
        [HttpPut("{id}")]
        [ActionName("PutTarea")]
        public async Task<IActionResult> PutTarea([FromRoute] int id, [FromBody] Tarea tarea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tarea.TareaID)
            {
                return BadRequest();
            }

            _context.Entry(tarea).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TareaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Tareas
        [HttpPost]
        [ActionName("PostTarea")]
        public async Task<IActionResult> PostTarea([FromBody] Tarea tarea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Tarea.Add(tarea);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTarea", new { id = tarea.TareaID }, tarea);
        }

        // DELETE: api/Tareas/5
        [HttpDelete("{id}")]
        [ActionName("DeleteTarea")]
        public async Task<IActionResult> DeleteTarea([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tarea = await _context.Tarea.FindAsync(id);
            if (tarea == null)
            {
                return NotFound();
            }

            _context.Tarea.Remove(tarea);
            await _context.SaveChangesAsync();

            return Ok(tarea);
        }

        private bool TareaExists(int id)
        {
            return _context.Tarea.Any(e => e.TareaID == id);
        }
    }
}