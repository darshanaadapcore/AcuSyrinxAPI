using AcuSyrinxAPI.DTO;
using AcuSyrinxAPI.Models;
using System;

namespace AcuSyrinxAPI.Repositories
{
    public interface IPurchaseInvoiceRepository
    {
        PagedResult<PurchaseInvoice> GetAllInvoices(
            DateTime? fromDate = null,
            string invoiceType = null,
            string sortBy = null,
            int page = 1,
            int pageSize = 0);

        PurchaseInvoice GetInvoiceById(int id);
    }
}