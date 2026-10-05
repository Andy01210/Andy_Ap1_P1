using Microsoft.EntityFrameworkCore;
using Parcial1.Models;
using Aplicada1.Core;
using Parcial1.Contexts;
namespace Parcial1.Services;
using System.Linq.Expressions;

public class ExamenServices(IDbContextFactory<Contexto> contextFactory)//: IService<Examen, int>
{

    //public async Task<bool> Guardar(Examen examen){}

    //public async Task<bool> Modificar(Examen examen){}

    //public async Task<bool> Insertar(Examen examen){}

    //public async Task<bool> Existe(int examenId){}

    //public async Task<bool> Eliminar(int libroId){ }

    //public async Task<Examen?> Buscar(int libroId){}

    //public async Task<List<Examen>> ListarTodo(){}

    //public async Task<List<Examen>> GetList(Expression<Func<Examen,bool>> criterio){}
}
