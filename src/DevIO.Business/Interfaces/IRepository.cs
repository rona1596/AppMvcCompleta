using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    //Injeção de independência
    //Repositório genérico - Serve para qualquer entidade
    //Para passar dados é necessario herdar de entity
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        //Sempre métodos assincronos
        //Qualquer entidade filha de entity
        Task Adicionar(TEntity entity);

        //Retorna a entidade ou a lista
        Task<TEntity> ObterPorId(Guid id);
        
        Task<List<TEntity>> ObterTodos();
        
        Task Atualizar(TEntity entity);
        
        Task Remover(Guid id);

        // Passando uma expressão lambda que vai trabalhar com uma function e comparar qualquer entidade desde que ela traga um boolean
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
        
        Task<int> SaveChanges();

    }
}
