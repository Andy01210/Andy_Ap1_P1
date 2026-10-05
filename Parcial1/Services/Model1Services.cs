using Microsoft.EntityFrameworkCore;
using Parcial1.Models;
using Aplicada1.Core;
using Parcial1.Contexts;
namespace Parcial1.Services;
using System.Linq.Expressions;

public class ModelServices(IDbContextFactory<Contexto> contextFactory) : IService<Autor, int>

{
    public Task<Autor?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Autor>> GetList(Expression<Func<Autor, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Autor entidad)
    {
        throw new NotImplementedException();
    }
}
