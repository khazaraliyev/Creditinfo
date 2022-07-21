using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL_DB.Persistence
{
    public class IndividualRepository : IIndividualRepository
    {
        private readonly ApplicationContext context;

        public IndividualRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public Individual Add(Individual entity)
        {
            context.Individuals.Add(entity);

            context.SaveChanges();

            return entity;
        }

        public Individual GetById(int id)
        {
            return context.Individuals.Where(i => i.NationalId == id).FirstOrDefault();
        }
    }
}
