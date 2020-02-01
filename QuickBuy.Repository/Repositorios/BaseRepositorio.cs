using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Contracts;
using QuickBuy.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace QuickBuy.Repository.Repositorios
{
   public class BaseRepositorio<TEntity> : IBaseRepository<TEntity> where TEntity : class

    {
        protected readonly QuickBuyContext QuickBuyContext;

        public BaseRepositorio(QuickBuyContext quickBuyContext) 
        {
            QuickBuyContext = quickBuyContext;
        }
        public void Adicionar(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Add(entity);
            QuickBuyContext.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Update(entity);
            QuickBuyContext.SaveChanges();
        }

        public TEntity ObterPorId(int Id)
        {
            return QuickBuyContext.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return QuickBuyContext.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Remove(entity);
            QuickBuyContext.SaveChanges();
        }
        public void Dispose()
        {
            QuickBuyContext.Dispose();
        }
    }
}
