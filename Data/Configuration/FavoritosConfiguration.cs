using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configuration
{
	public class FavoritosConfiguration : IEntityTypeConfiguration<Favoritos>
	{
		public void Configure(EntityTypeBuilder<Favoritos> builder)
		{
			builder.ToTable("Favoritos");





			
		}
	}
}
