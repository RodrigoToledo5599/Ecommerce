using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(511)]
        public string? Descricao { get; set; }

        public float Price { get; set; }
        public string? ImagemPrincipal { get; set; }
        public string? Imagem1 { get; set; }
        public string? Imagem2 { get; set; }
        public string? Imagem3 { get; set; }
        public string? Imagem4 { get; set; }
        





        public int? CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Category? Categoria { get; set; }
        

    }
}