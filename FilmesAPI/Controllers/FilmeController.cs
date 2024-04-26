using AutoMapper;
using FilmesApi.Data;
using FilmesAPI.Controllers.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class FilmeController: ControllerBase
    {
        public FilmeContext _context;
        private IMapper _mapper;

        public FilmeController(FilmeContext context) {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarFilme([FromBody] CreatedAtActionResult filmeDto)
        {
            Filme filme = _mapper.Map<Filme>(filmeDto);
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarPorID), new { Id = filme.Id }, filme);

        }

        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes([FromQuery]int skip= 0, [FromQuery]int take= 50)
        {
            return _context.Filmes.Skip(skip).Take(take);
        }

        [HttpGet("{Id}")]
        public IActionResult RecuperarPorID(int Id)
        {
            var filme =_context.Filmes.FirstOrDefault(filme => filme.Id == Id);
            if (filme == null) return NotFound();
            return Ok(filme);
        }

        public IActionResult AtualizaFilmes(int Id, )
        {

        }

    }
}
