﻿using CoffeBlend.Application.Features.Mediator.Results.ProductResults;
using CoffeBlend.Application.Interfaces.ProductInterfaces;
using CoffeBlend.Domain.Entites;
using CoffeBlend.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBlend.Persistance.Repositories.ProductRepositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CoffeBlendContext _context;

        public ProductRepository(CoffeBlendContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetLast5CoffeProductListAsync()
        {
            var values = await _context.Products.Include(y => y.Category).Where(t => t.Category.Name == "Kahve").OrderByDescending(t => t.ProductId).Take(4).ToListAsync();
            return values;
        }

        public async Task<List<Product>> GetLast5ProductListAsync()
        {
            var values = await _context.Products.Include(y => y.Category).Where(t => t.Category.Name != "Kahve").OrderByDescending(t => t.ProductId).Take(4).ToListAsync();
            return values;
        }

        public async Task<List<Product>> GetProductListWithCategoryAsync()
        {
            var value = await _context.Products.Include(t => t.Category).ToListAsync();
            return value;
        }

        public async Task<GetProductPriceByProductIdQueryResult> GetProductPriceByProductIdQuery(int id)
        {
            var value = await _context.Products.FindAsync(id);
            return new GetProductPriceByProductIdQueryResult
            {
                Price = value.Price,
            };
        }
    }
}
