using AcuSyrinxAPI.Db;
using AcuSyrinxAPI.DTO;
using AcuSyrinxAPI.Helpers;
using AcuSyrinxAPI.Mappers;
using AcuSyrinxAPI.Models;
using System;
using System.Linq;

namespace AcuSyrinxAPI.Repositories
{
    public class HireInvoiceRepository : IHireInvoiceRepository
    {
        private readonly DataContext _context;

        public HireInvoiceRepository(DataContext context)
        {
            _context = context;
        }

        // Get all invoices
        public PagedResult<HireInvoice> GetAllInvoices(
            DateTime? fromDate = null,
            string invoiceType = null,
            string sortBy = null,
            int page = 1,
            int pageSize = 0)
        {
            var query = _context.TH_HIRE_INVOICES.AsQueryable();

            if (fromDate.HasValue)
                query = query.Where(i => i.IVC_INVOICE_DATE >= fromDate.Value);

            if (!string.IsNullOrEmpty(invoiceType))
                query = query.Where(i => i.IVC_INVOICE_TYPE.Equals(invoiceType, StringComparison.OrdinalIgnoreCase));

            // Apply sorting if provided 
            if (!string.IsNullOrEmpty(sortBy))
                query = query.ApplySorting(sortBy);
            else
                query = query.OrderBy(i => i.IVC_INVOICE_DATE); // Default sorting by IVC_INVOICE_DATE

            // Apply pagination (Skip and Take should be applied after sorting)b
            var pagedResult = query.ApplyPagination(page, pageSize);

            // Map the entities to DTOs
            var mappedResult = pagedResult.Data.Select(HireInvoiceMapper.MapToDto).ToList();

            // Return the paged result with mapped data
            return new PagedResult<HireInvoice>
            {
                PageId = pagedResult.PageId,
                TotalPages = pagedResult.TotalPages,
                PageSize = pagedResult.PageSize,
                TotalRecords = pagedResult.TotalRecords,
                Data = mappedResult.AsQueryable() // Return the mapped result as IQueryable for flexibility
            };
        }

        // Get a specific invoice by ID
        public HireInvoice GetInvoiceById(int id, string type)
        {
            TH_HIRE_INVOICES invoice = null;

            if (string.IsNullOrEmpty(type))
            {
                invoice = _context.TH_HIRE_INVOICES
                .Where(i => i.IVC_INVOICE_NUMBER == id)
                .FirstOrDefault();
            }
            else
            {
                invoice = _context.TH_HIRE_INVOICES
                   .Where(i => i.IVC_INVOICE_NUMBER == id)
                   .FirstOrDefault();
            }
            if (invoice == null)
                return null;

            return HireInvoiceMapper.MapToDto(invoice);
        }

    }
}