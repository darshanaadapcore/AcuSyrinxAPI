using AcuSyrinxAPI.Repositories;
using System;
using System.Web.Http;

namespace AcuSyrinxAPI.Controllers
{
    public class SalesInvoicesController : ApiController
    {
        private readonly static string _salesInvoiceType = "SALES";

        private readonly IHireInvoiceRepository _HireInvoiceRepository;

        public SalesInvoicesController(IHireInvoiceRepository HireInvoiceRepository)
        {
            _HireInvoiceRepository = HireInvoiceRepository;
        }


        [HttpGet]
        public IHttpActionResult Get(
            [FromUri] DateTime? fromDate = null,
            [FromUri] string sortBy = null,
            [FromUri] int page = 1,
            [FromUri] int pageSize = 0)
        {
            return Ok(_HireInvoiceRepository.GetAllInvoices(fromDate, _salesInvoiceType, sortBy, page, pageSize));
        }

        // GET api/HireInvoices/{id}
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            // Fetch the invoice by ID from the repository
            var invoice = _HireInvoiceRepository.GetInvoiceById(id, _salesInvoiceType);

            // Check if the invoice exists
            if (invoice == null)
                return NotFound();
            
            return Ok(invoice); 
        }
    }
}