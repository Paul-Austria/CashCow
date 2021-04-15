using CashCow.Logic.Entities.CashCow;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashCow.Contracts.Persistance.CashCow;
using CashCow.Contracts.Persistence.CashCow;
using CashCow.Logic.Entitites.CashCow;

namespace CashCow.Logic.DataContext
{
    partial class CashCowDbContext
    {
        public DbSet<CashEvent> Event { get; set; }
		public DbSet<Member> Member { get; set; }
		public DbSet<Payment> Payment { get; set; }
 
		partial void GetDbSet<C, E>(ref DbSet<E> dbset) where E : class
		{
			if (typeof(C) == typeof(ICashEvent))
			{
				dbset = Event as DbSet<E>;
			}
		}

		partial void BeforeOnModelCreating(ModelBuilder modelBuilder, ref bool handled)
		{
			var genreBuilder = modelBuilder.Entity<Entities.CashCow.CashEvent>();

			genreBuilder.HasKey(p => p.Id);
			genreBuilder.Property(p => p.RowVersion).IsRowVersion();
			genreBuilder.Property(p => p.Category)
						 .IsRequired()
						 .HasMaxLength(256);
			genreBuilder.HasIndex(p => p.Title)
						 .IsUnique();
		}

	}
}
