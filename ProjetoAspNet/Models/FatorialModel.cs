using System.ComponentModel.DataAnnotations;

namespace ProjetoAspNet.Models
{
    public class FatorialModel
    {
        [Required(ErrorMessage = "Esse campo é obrigatorio.", AllowEmptyStrings = false)]
        [Range(0, int.MaxValue, ErrorMessage = "O número deve ser não negativo.")]
        public int? Numero { get; set; }
    }
}
