using Microsoft.EntityFrameworkCore;
using Parcial1.Models;
namespace Parcial1.Contexts;

public class Contexto: DbContext{

public Contexto(DbContextOptions<Contexto> options) : base(options){

}

public DbSet<Autor> Autor{get; set;}

}
