using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Acoes.Models
{

    [Table("Acoes")]
    public class Acao
    {
        [Key]
        public int AcaoId { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
        public string Codigo { get; set; }
        public string Empresa { get; set; }
        public string Logo { get; set; }
        public decimal Valor { get; set; }
    }
}