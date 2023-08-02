using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{

    public class ProdutoVM
    {
        
        public ProdutoVM(Produto produto) 
        {
            Id = produto.Id;
            Name = produto.Name;
            Descricao = produto.Descricao;
            Price = produto.Price;
            CategoriaId = produto.CategoriaId;

        }
        public int Id { get;}
        public string Name { get;}
        public string? Descricao { get;}
        public float Price { get;}
        public int? CategoriaId { get;}
    }
}
