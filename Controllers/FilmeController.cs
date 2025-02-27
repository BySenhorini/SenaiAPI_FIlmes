using API_filmes_senai.Domains;
using API_filmes_senai.Interface;
using Microsoft.AspNetCore.Mvc;

namespace api_filmes_senai1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class FilmeController : ControllerBase
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeController(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;

        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Filmes> listaDeFilmes = _filmeRepository.Listar();

                return Ok(listaDeFilmes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Filmes novofilme)
        {
            try
            {
                _filmeRepository.Cadastrar(novofilme);

                return Created();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("BuscarPorId/{id}")]
        public IActionResult getById(Guid id)
        {
            try
            {
                Filmes filmeBuscado = _filmeRepository.BuscarPorId(id);

                return Ok(filmeBuscado);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpDelete("{id}")]
        public IActionResult delete(Guid id)
        {
            try
            {
                _filmeRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Filmes filme)
        {
            try
            {
                _filmeRepository.Atualizar(id, filme);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        //criar endpoint para o genero
    }
}
