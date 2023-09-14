using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class MainPageDTO
    {
        public Account? conta { get; set; }
        [Required]
        public IEnumerable<Produto>? produto { get; set; }
        public IEnumerable<Category>? category { get; set; }

    }
}
