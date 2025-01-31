﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Task4.DAL.Repositories.Contracts
{
    public interface IRepository : IDisposable
    { 
        IEnumerable<TEntity> Get<TEntity>() where TEntity : class;

        IEnumerable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;

        void Add<TEntity>(TEntity entity) where TEntity : class;

        void Add<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;

        void Remove<TEntity>(TEntity entity) where TEntity : class;

        void Attach<TEntity>(TEntity entity) where TEntity : class;

        void Reload<TEntity>(TEntity entity) where TEntity : class;
    }
}
