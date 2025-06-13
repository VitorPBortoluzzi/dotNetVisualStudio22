

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPrimeiraCriacao.Models
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "O preço do produto é obrigatório")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "O preço do produto é obrigatório")]
        [Range(0.01, 9999.99, ErrorMessage = "O preço deve estar entre 0.01 e 999.99")]
        [Column(TypeName = "decimal(10,2)")] //definindo o tipo do campo no banco de dados
        public decimal preço;
    }
}
