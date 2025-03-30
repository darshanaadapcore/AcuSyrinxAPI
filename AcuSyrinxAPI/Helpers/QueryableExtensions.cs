using AcuSyrinxAPI.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AcuSyrinxAPI.Helpers
{
    public static class QueryableExtensions
    {
        public static readonly int DefaultPageSize = 20; // Read-only default page size

        public static IQueryable<T> ApplySorting<T>(this IQueryable<T> query, string sortBy)
        {
            if (string.IsNullOrEmpty(sortBy))
            {
                return query; // No sorting applied
            }

            var parameter = Expression.Parameter(typeof(T), "x");
            var property = typeof(T).GetProperty(sortBy);

            if (property == null)
            {
                throw new ArgumentException($"Property '{sortBy}' not found on type {typeof(T).Name}");
            }

            var propertyAccess = Expression.MakeMemberAccess(parameter, property);
            var lambda = Expression.Lambda(propertyAccess, parameter);

            var method = typeof(Queryable).GetMethods()
                .First(m => m.Name == "OrderBy" && m.GetParameters().Length == 2)
                .MakeGenericMethod(typeof(T), property.PropertyType);

            return (IQueryable<T>)method.Invoke(null, new object[] { query, lambda });
        }

        public static PagedResult<T> ApplyPagination<T>(this IQueryable<T> query, int page, int pageSize = 0)
        {
            if (page < 1) page = 1;
            if (pageSize <= 0) pageSize = DefaultPageSize; // Use default if not provided

            int totalRecords = query.Count();
            int totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

            var data = query.Skip((page - 1) * pageSize).Take(pageSize);

            return new PagedResult<T>
            {
                PageId = page,
                TotalPages = totalPages,
                PageSize = pageSize,
                TotalRecords = totalRecords,
                Data = data
            };
        }
    }
}
