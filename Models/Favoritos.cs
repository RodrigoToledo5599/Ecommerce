using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Models
{
	public class Favoritos
	{
		[Key]
		public int Id { get; set; }
		
		[ForeignKey("Usuario")]
		public int UsuarioId { get; set; }
		public Account Usuario { get; set; }



		

		[ForeignKey("Produto")]
		public int ProdutoId { get; set; }
		public Produto Produto { get; set; }

	}
}
