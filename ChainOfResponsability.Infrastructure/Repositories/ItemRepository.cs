﻿using ChainOfResponsability.Domain.Models;
using ChainOfResponsability.Infrastructure.Contexts.Application;
using ChainOfResponsability.Infrastructure.Repositories.Contracts;

namespace ChainOfResponsability.Infrastructure.Repositories
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public ItemRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
