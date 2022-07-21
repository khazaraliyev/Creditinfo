using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IIndividualRepository : IRepository<Individual>
    {
        public Individual GetById(int id);
    }
}
