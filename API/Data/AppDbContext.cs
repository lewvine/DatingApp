using System;
using System.CodeDom;
using Microsoft.EntityFrameworkCore;

namespace API.Entities;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }



}
