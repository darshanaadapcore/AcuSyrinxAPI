using AcuSyrinxAPI.Db;
using AcuSyrinxAPI.DTO;
using AcuSyrinxAPI.Helpers;
using AcuSyrinxAPI.Mappings;
using AcuSyrinxAPI.Models;
using System;
using System.Linq;

namespace AcuSyrinxAPI.Repositories
{
    public class PurchaseInvoiceRepository : IPurchaseInvoiceRepository
    {
        private readonly DataContext _context;

        public PurchaseInvoiceRepository(DataContext context)
        {
            _context = context;
        }

        // Get all invoices
        public PagedResult<PurchaseInvoice> GetAllInvoices(
            DateTime? fromDate = null,
            string invoiceType = null,
            string sortBy = null,
            int page = 1,
            int pageSize = 0)
        {
            var query = _context.TH_PURCHASE_INVOICES.AsQueryable();

            if (fromDate.HasValue)
                query = query.Where(i => i.PIV_INV_DATE >= fromDate.Value);

            if (!string.IsNullOrEmpty(invoiceType))
                query = query.Where(i => i.PIV_INV_TYPE.Equals(invoiceType, StringComparison.OrdinalIgnoreCase));

            // Apply sorting if provided 
            if (!string.IsNullOrEmpty(sortBy))
                query = query.ApplySorting(sortBy);
            else
                query = query.OrderBy(i => i.PIV_ID); // Default sorting by PIV_ID

            // Apply pagination (Skip and Take should be applied after sorting)b
            var pagedResult = query.ApplyPagination(page, pageSize);

            // Map the entities to DTOs
            var mappedResult = pagedResult.Data.Select(EntityMapper.MapToPurchaseInvoice).ToList();

            // Return the paged result with mapped data
            return new PagedResult<PurchaseInvoice>
            {
                PageId = pagedResult.PageId,
                TotalPages = pagedResult.TotalPages,
                PageSize = pagedResult.PageSize,
                TotalRecords = pagedResult.TotalRecords,
                Data = mappedResult.AsQueryable() // Return the mapped result as IQueryable for flexibility
            };
        }

        // Get a specific invoice by ID
        public PurchaseInvoice GetInvoiceById(int id)
        {
            var invoice = _context.TH_PURCHASE_INVOICES
                .Where(i => i.PIV_ID == id)
                .FirstOrDefault();

            if (invoice == null)
                return null; 

            return EntityMapper.MapToPurchaseInvoice(invoice);
        }

    }
}