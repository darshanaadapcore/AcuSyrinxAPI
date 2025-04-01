using AcuSyrinxAPI.Repositories;
using System;
using System.Web.Http;

namespace AcuSyrinxAPI.Controllers
{
    [Authorize]
    public class PurchaseInvoicesController : ApiController
    {
        private readonly IPurchaseInvoiceRepository _purchaseInvoiceRepository;

        public PurchaseInvoicesController(IPurchaseInvoiceRepository purchaseInvoiceRepository)
        {
            _purchaseInvoiceRepository = purchaseInvoiceRepository;
        }


        [HttpGet]
       
        public IHttpActionResult Get(
            [FromUri] DateTime? fromDate = null,
            [FromUri] string invoiceType = null,
            [FromUri] string sortBy = null,
            [FromUri] int page = 1,
            [FromUri] int pageSize = 0)
        {
            return Ok(_purchaseInvoiceRepository.GetAllInvoices(fromDate, invoiceType, sortBy, page, pageSize));
        }

        // GET api/purchaseinvoices/{id}
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            // Fetch the invoice by ID from the repository
            var invoice = _purchaseInvoiceRepository.GetInvoiceById(id);

            // Check if the invoice exists
            if (invoice == null)
                return NotFound();
            
            return Ok(invoice); 
        }
    }
}