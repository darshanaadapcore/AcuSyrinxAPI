using AcuSyrinxAPI.Db;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcuSyrinxAPI.DTO
{
    public class PurchaseInvoiceLine    
    {
        [JsonProperty("invoiceId")]
        public int PIL_INVOICE_ID { get; set; }

        [JsonProperty("sequence")]
        public int PIL_SEQ { get; set; }

        [JsonProperty("nominalCode")]
        public string PIL_NOMINAL_CODE { get; set; }

        [JsonProperty("description")]
        public string PIL_DESCRIPTION { get; set; }

        [JsonProperty("netAmount")]
        public decimal? PIL_NET_AMOUNT { get; set; }

        [JsonProperty("taxCode")]
        public string PIL_TAX_CODE { get; set; }

        [JsonProperty("taxAmount")]
        public decimal? PIL_TAX_AMOUNT { get; set; }

        [JsonProperty("eventId")]
        public int? PIL_EVENT_ID { get; set; }

        [JsonProperty("accountsDepartment")]
        public string PIL_ACCOUNTS_DEPT { get; set; }

        // Include invoice details
        //public PurchaseInvoiceDTO TH_PURCHASE_INVOICES { get; set; }
    }

}