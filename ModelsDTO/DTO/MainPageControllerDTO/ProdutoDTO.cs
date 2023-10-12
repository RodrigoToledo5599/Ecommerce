using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDTO.DTO.MainPageControllerDTO
{
	public class ProdutoDTO
	{
		public string Name { get; set; }
		public string? Descricao { get; set; }
		public int? CategoriaId { get; set; }
		public float Price { get; set; }
	}
}
