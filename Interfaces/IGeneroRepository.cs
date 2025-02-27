using API_filmes_senai.Controllers;
using API_filmes_senai.Domains;

namespace API_filmes_senai.Interface
{/// <summary>
/// Interface para genero : Contrato
/// Toda classe que herdar(implementar) essa interface, 
/// deverá implementar todos os métodos definidos aqui dentro.
/// </summary>
    public interface IGeneroRepository
    {
        ///CRUD = Métodos
        ///C = Create = Cadastrar um novo Objeto.
        ///R = Read = Listar todos oss objetos.
        ///U = Update = Alterar um objeto.
        ///D = Delete = Deleto ou excluo um objeto.

        ///Método = TipoDeRetorno NomeDoMétodo(Argumentos ou parametros).


        void Cadastrar(Generos novoGenero);

        List<Generos> Listar();

        void Atualizar(Guid id, Generos genero);

        void Deletar(Guid id);

        Generos BuscarPorID(Guid id);
        
     
    }
}
