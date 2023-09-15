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
	public class AccountConfiguration : IEntityTypeConfiguration<Account>
	{
		
		public void Configure(EntityTypeBuilder<Account> builder)
		{
			builder.ToTable("Contas");
			builder.HasKey(x => x.Id);

			
		}
	}
}
