using System.ComponentModel.DataAnnotations;

namespace ProjetoAspNet.Models
{
    public class PessoaModel
    {
        [Required(ErrorMessage = "Esse campo é obrigatorio.")]
        [MinLength(3, ErrorMessage = "Esse campo precisa ter no minimo 3 caracteres.")]
        public string Nome {  get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser no minimo 1.")]
        public int? Idade { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatorio.")]
        [EmailAddress(ErrorMessage = "Informe um email valido.")]
        public string Email { get; set; }


    }

    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public string Email;

        public Pessoa(string nome, int idade, string email)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
        }
    }
}
