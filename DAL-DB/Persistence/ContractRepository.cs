using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_DB.Persistence
{
    public class ContractRepository : IContractRepository
    {
        private readonly ApplicationContext context;

        public ContractRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public Contract Add(Contract entity)
        {
            context.Contracts.Add(entity);

            context.SaveChanges();

            return entity;
        }
    }
}
