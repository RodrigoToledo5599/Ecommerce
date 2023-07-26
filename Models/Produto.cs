using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string? Descricao { get; set; }

        public float Price { get; set; }

        [StringLength(255)]
        public string? Categoria { get; set; }


    }
}