﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Repositories.Base
{
    public interface IRepository<T> where T : class 
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
