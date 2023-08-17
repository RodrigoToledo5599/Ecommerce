using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class ProdutoVM
    {
        public Produto produto { get; set; }
        public Category? category { get; set; }

    }
}
