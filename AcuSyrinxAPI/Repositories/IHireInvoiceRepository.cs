using AcuSyrinxAPI.DTO;
using AcuSyrinxAPI.Models;
using System;

namespace AcuSyrinxAPI.Repositories
{
    public interface IHireInvoiceRepository
    {
        PagedResult<HireInvoice> GetAllInvoices(
            DateTime? fromDate = null,
            string invoiceType = null,
            string sortBy = null,
            int page = 1,
            int pageSize = 0);

        HireInvoice GetInvoiceById(int id, string type);
    }
}