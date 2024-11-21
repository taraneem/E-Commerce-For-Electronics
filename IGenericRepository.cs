﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Entities.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        //_context.catogories.tolist()
         IEnumerable<T> GetAll(Expression<Func<T,bool>>? predicate =null,string ? IncludeWord=null);

        T GetFirstOrDefault(Expression<Func<T, bool>>? predicate=null, string? IncludeWord=null);

        void Add(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

    }
}
