using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController() { }

        private readonly SmartContext _context;
        public ProfessorController(SmartContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Professores);
        }

        [HttpGet("ById/{id}")]
        public IActionResult GetById(int id)
        {

            var Professor = _context.Professores.FirstOrDefault(a => a.Id == id);
            if (Professor == null) return BadRequest("Professor não foi encontrado");

            return Ok(Professor);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome){

            var Professor = _context.Professores.FirstOrDefault(a =>
                a.Nome.Contains(nome)
            );

            if (Professor == null) return BadRequest("Professor não foi encontrado");

            return Ok(Professor);
        }

        [HttpPost]
        public IActionResult Post(Professor Professor)
        {
            _context.Add(Professor);
            _context.SaveChanges();
            return Ok(Professor);
        }

        [HttpPut]
        public IActionResult Put(int id, Professor Professor)
        {

            var prof = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (prof == null) return BadRequest("Professor não foi encontrado");

            _context.Update(Professor);
            _context.SaveChanges();
            return Ok(Professor);

        }

        [HttpPatch]
        public IActionResult Patch(int id)
        {

            var Professor = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (Professor == null) return BadRequest("Professor não foi encontrado");

            _context.Update(Professor);
            _context.SaveChanges();
            return Ok(Professor);
        }

        [HttpDelete]
        public IActionResult Delete(int id, Professor professor)
        {

            var prof = _context.Professores.FirstOrDefault(a => a.Id == id);
            if (prof == null) return BadRequest("Professor não foi encontrado");

            _context.Remove(professor);
            _context.SaveChanges();
            return Ok(_context.Professores);
        }

    }
}