using System;
using Ardalis.Specification.EntityFrameworkCore;
using Application.Interfaces;
using Persistance.Contexts;

namespace Persistance.Repository
{
    public class MyRepositoryAsync<T> : RepositoryBase<T>,IRepositoryAsync<T> where T: class
    {
        private readonly ApplicationDbContext dbContext;
        public MyRepositoryAsync(ApplicationDbContext dbContext): base(dbContext)
        {
            this.dbContext = dbContext;
        }
            }
}

