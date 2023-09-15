using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Models
{
	[Keyless]
	public class ItemCarrinho
	{

		[ForeignKey("Usuario")]
		public int UsuarioId { get; set; }
		public Account Usuario { get; set; }





		[ForeignKey("Produto")]
		public int ProdutoId { get; set; }
		public Produto Produto { get; set; }
	}
}
