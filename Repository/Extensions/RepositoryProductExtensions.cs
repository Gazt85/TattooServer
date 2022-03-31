using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Repository.Extensions
{
    public static class RepositoryProductExtensions
    {
        public static IQueryable<Product> FilterProducts(this IQueryable<Product> products, uint minPrice, uint maxPrice) =>
            products.Where(p => (p.Price >= minPrice && p.Price <= maxPrice));


        public static IQueryable<Product> Search(this IQueryable<Product> products, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return products;

            var lowerCaseTerm = searchTerm.Trim().ToLower();

            return products.Where(p => p.Name.ToLower().Contains(lowerCaseTerm));
        }
    }
}
