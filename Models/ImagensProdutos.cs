using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class ImagensProdutos
	{
		public int Id { get; set; }
		public string Imagem { get; set; }



		public int? ProdutoId { get; set; }
		[ForeignKey("ProdutoId")]
		public Produto? Produto { get; set; }

	}
}
