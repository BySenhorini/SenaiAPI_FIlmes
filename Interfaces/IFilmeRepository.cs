using API_filmes_senai.Controllers;
using API_filmes_senai.Domains;
using api_filmes_senai1.Controllers;

namespace API_filmes_senai.Interface
{
    public interface IFilmeRepository
    {
        void Cadastrar(Filmes novoFilme);

        List<Filmes> Listar();

        void Atualizar(Guid id, Filmes filme);

        Filmes BuscarPorId(Guid id);
        List<Filmes> ListaPorGenero(Guid idGenero);
        void Deletar(Guid id);
        void Atualizar(Guid id, FilmeController filme);
    }
}
