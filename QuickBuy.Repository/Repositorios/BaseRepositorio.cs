using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Contracts;
using QuickBuy.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace QuickBuy.Repository.Repositorios
{
    class BaseRepositorio<TEntity> : IBaseRepository<TEntity> where TEntity : class

    {
        private readonly QuickBuyContext _quickBuyContext;

        public BaseRepositorio(QuickBuyContext quickBuyContext) 
        {
            _quickBuyContext = quickBuyContext;
        }
        public void Adicionar(TEntity entity)
        {
            _quickBuyContext.Set<TEntity>().Add(entity);
            _quickBuyContext.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            _quickBuyContext.Set<TEntity>().Update(entity);
            _quickBuyContext.SaveChanges();
        }

        public TEntity ObterPorId(int Id)
        {
            return _quickBuyContext.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _quickBuyContext.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            _quickBuyContext.Set<TEntity>().Remove(entity);
            _quickBuyContext.SaveChanges();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
