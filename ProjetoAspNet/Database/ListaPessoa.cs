using ProjetoAspNet.Models;

namespace ProjetoAspNet.Database
{
    public class ListaPessoa
    {
        private static List<Pessoa> lista = new List<Pessoa>();

        public static void AdicionarPessoa(PessoaModel pessoa)
        {
            lista.Add(new Pessoa(pessoa.Nome, (int) pessoa.Idade, pessoa.Email));
        }


        public static List<Pessoa> RecuperarLista()
        {
            return lista;
        }
    }
}
