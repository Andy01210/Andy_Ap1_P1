using Microsoft.EntityFrameworkCore;
using Parcial1.Models;
using Aplicada1.Core;
using Parcial1.Contexts;
namespace Parcial1.Services;
using System.Linq.Expressions;

public class AutorServices(IDbContextFactory<Contexto> contextFactory) : IService<Autor, int>
{
     public async Task<bool> Guardar(Autor entidad)
    {
        if(!await Existe(entidad.IdAutor))
        {
            return await Insertar(entidad);
        }
        else
        {
            return await Modificar(entidad);
        }
    }

    public async Task<bool> Modificar(Autor autor)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        contexto.Update(autor);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Insertar(Autor autor)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        contexto.Add(autor);
        return await contexto.SaveChangesAsync() > 0;
    }
   
   public async Task<bool> Existe(int autorId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autor.AnyAsync(a => a.IdAutor == autorId);
    }

    public async Task<bool> Eliminar(int autoriId)
    {
       await using var contexto = await contextFactory.CreateDbContextAsync();
       return await contexto.Autor.Where(d => d.IdAutor == autoriId).ExecuteDeleteAsync() >0;
       
    }

    public async Task<Autor?> Buscar(int autorId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autor.AsNoTracking().FirstOrDefaultAsync(d => d.IdAutor== autorId);
    }

    public async Task<List<Autor>> ListarTodo()
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autor.AsNoTracking().ToListAsync();
    }


    public async Task<List<Autor>> GetList(Expression<Func<Autor, bool>> criterio)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autor.AsNoTracking().Where(criterio).ToListAsync();
        
    }

   
}
