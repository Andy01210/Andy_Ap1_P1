using Microsoft.EntityFrameworkCore;
using Parcial1.Models;
using Aplicada1.Core;
using Parcial1.Contexts;
namespace Parcial1.Services;
using System.Linq.Expressions;

public class ModelServices(IDbContextFactory<Contexto> contextFactory) : IService<Model1, int>

{
    public Task<Model1?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Model1>> GetList(Expression<Func<Model1, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Model1 entidad)
    {
        throw new NotImplementedException();
    }
}
