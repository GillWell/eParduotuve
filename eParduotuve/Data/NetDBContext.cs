using eParduotuve.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eParduotuve.Data
{
	public class NetDBContext : IdentityDbContext
	{
		public NetDBContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Admin> shopAdmin { get; set; }
	}
}
