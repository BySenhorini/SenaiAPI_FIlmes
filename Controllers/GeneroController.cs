using API_filmes_senai.Controllers;
using API_filmes_senai.Domains;
using API_filmes_senai.Interface;
using API_filmes_senai.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_filmes_senai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class GeneroController : ControllerBase
    {
        private readonly IGeneroRepository _generoRepository;
        public GeneroController(IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;

        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_generoRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        [HttpPost] ///enviar publicações
        public IActionResult Post(Generos novoGenero)
        {
            try
            {
                _generoRepository.Cadastrar(novoGenero);

                return Created();

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }


        }
        [HttpGet("BuscarPorId/{id}")]
        public IActionResult GetbyId(Guid id)
        {
            try
            {
                Generos generoBuscado = _generoRepository.BuscarPorID(id);
                return Ok(generoBuscado);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

       
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _generoRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
