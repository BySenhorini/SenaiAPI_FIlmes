using API_filmes_senai.Context;
using API_filmes_senai.Controllers;
using API_filmes_senai.Domains;
using API_filmes_senai.Interface;
using api_filmes_senai1.Controllers;

namespace API_filmes_senai.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly Filmes_Context _context;
        public FilmeRepository(Filmes_Context context)
        {
            _context = context;
        }
        public void Atualizar(Guid id, Filmes filme)
        {
            Filmes filmesBuscado = _context.Filme.Find();
            if (filmesBuscado != null)
            

                filmesBuscado.IdGenero = filme.IdGenero;
                filmesBuscado.Titulo = filme.Titulo;

            }


        public Filmes BuscarPorId(Guid id)
        {
            try
            {
                Filmes filmeBuscado = _context.Filme.Find(id)!;
                return filmeBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Filmes novoFilme)
        {
            try
            {
                _context.Filme.Add(novoFilme);

                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void Deletar(Guid id)
        {
            try
            {
                Filmes filmeBuscado = _context.Filme.Find(id)!;

                if (filmeBuscado != null)
                {
                    _context.Filme.Remove(filmeBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Filmes> Listar()
        {
            try
            {
                List<Filmes> listaDeFilmes = _context.Filme.ToList();
                return listaDeFilmes;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
