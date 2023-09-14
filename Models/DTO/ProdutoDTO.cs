using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class ProdutoDTO
    {
        [Required]
        public Produto produto { get; set; }
        public Category? category { get; set; }

    }
}
