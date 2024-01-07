using Microsoft.EntityFrameworkCore;
using entityProject.entities;
using System;
namespace entityProject.data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions options): base(options)
		{
		}
		public DbSet<AppUser> Users { get; set; }
	}
}

