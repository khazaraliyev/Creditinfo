using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IRepository<T>
    {
        public T Add(T entity);
    }
}
