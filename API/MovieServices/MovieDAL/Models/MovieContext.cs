using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace MovieServices.MovieDAL.Models
{
    public partial class MovieContext : DbContext,IDisposable
    {
	
		public void Dispose()
		{
			bool IsTransactionCOmpleted = false;
			var data = Thread.GetData(Thread.GetNamedDataSlot("IsTransactionCOmpleted"));
			if (data != null)
			{
				IsTransactionCOmpleted = (bool)data;
			}
			if (this.Database.CurrentTransaction != null && !IsTransactionCOmpleted)
			{
				return;
			}
			Thread.SetData(Thread.GetNamedDataSlot("Context"), null);
		}

		public virtual DbSet<Actor> Actor { get; set; }
		public virtual DbSet<Producer> Producer { get; set; }

		public virtual DbSet<Movie> Movie { get; set; }

		public virtual DbSet<MovieActorMapping> MovieActorMapping { get; set; }
		
	}
}
