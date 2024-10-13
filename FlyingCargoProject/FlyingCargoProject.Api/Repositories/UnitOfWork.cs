using FlyingCargoProject.Api.Repositories.Interfaces;
using FlyingCargoProject.Api.Repositories.Managers;
using FlyingCargoProject.Models;
using System;

namespace FlyingCargoProject.Api.Repositories
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        Task CompleteAsync();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FlyingCargoContext _context;
        public IProductRepository Products { get; }

        // Ensure that the context is passed correctly
        public UnitOfWork(FlyingCargoContext context, IProductRepository productRepository)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Products = productRepository;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
