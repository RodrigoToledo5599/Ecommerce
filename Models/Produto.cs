﻿using System.ComponentModel.DataAnnotations;
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
        
        





        public int? CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Category? Categoria { get; set; }
        

        public ICollection<ImagensProdutos> ImagensProdutos { get; set; }

    }
}