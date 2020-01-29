using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Contracts;

namespace QuickBuy.Repository.Repositorios
{
    class BaseRepositorio<TEntity> : IBaseRepository<TEntity> where TEntity : class

    {
        public BaseRepositorio() { }
        public void Adicionar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity ObterPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
