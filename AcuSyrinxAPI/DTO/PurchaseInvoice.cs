using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcuSyrinxAPI.DTO
{
    public class PurchaseInvoice
    {
        [JsonProperty("invoiceId")]
        public int PIV_ID { get; set; }

        [JsonProperty("invoiceDate")]
        public DateTime? PIV_INV_DATE { get; set; }

        [JsonProperty("invoiceNumber")]
        public string PIV_INV_NUMBER { get; set; }

        [JsonProperty("status")]
        public string PIV_STATUS { get; set; }

        [JsonProperty("invoiceType")]
        public string PIV_INV_TYPE { get; set; }

        [JsonProperty("supplierId")]
        public int? PIV_SUPPLIER_ID { get; set; }

        [JsonProperty("postedFlag")]
        public bool PIV_POSTED_FLAG { get; set; }

        [JsonProperty("nonBatchPostingId")]
        public int? PIV_NONBATCH_POSTING_ID { get; set; }

        [JsonProperty("internalNotes")]
        public string PIV_INTERNAL_NOTES { get; set; }

        [JsonProperty("depotId")]
        public int? PIV_DEPOT_ID { get; set; }

        [JsonProperty("userIdCreated")]
        public int? PIV_USERID_CREATED { get; set; }

        [JsonProperty("postToAccount")]
        public string PIV_POST_TO_ACCOUNT { get; set; }

        [JsonProperty("orderId")]
        public int? PIV_ORDER_ID { get; set; }

        [JsonProperty("dateCreated")]
        public DateTime? PIV_DATE_CREATED { get; set; }

        [JsonProperty("userIdCancelled")]
        public int? PIV_USERID_CANCELLED { get; set; }

        [JsonProperty("dateCancelled")]
        public DateTime? PIV_DATE_CANCELLED { get; set; }

        [JsonProperty("paymentDate")]
        public DateTime? PIV_PY_DATE { get; set; }

        [JsonProperty("paymentAccount")]
        public string PIV_PY_ACCOUNT { get; set; }

        [JsonProperty("paymentReference")]
        public string PIV_PY_REF { get; set; }

        [JsonProperty("paymentAmount")]
        public decimal? PIV_PY_AMOUNT { get; set; }

        [JsonProperty("postingDate")]
        public DateTime? PIV_POSTING_DATE { get; set; }

        [JsonProperty("userNumber")]
        public string PIV_USER_NUMBER { get; set; }

        [JsonProperty("disputeReasonId")]
        public int? PIV_DISPUTE_REASON_ID { get; set; }

        [JsonProperty("currencyId")]
        public int? PIV_CURRENCY_ID { get; set; }

        [JsonProperty("exchangeRate")]
        public float? PIV_EXCH_RATE { get; set; }

        [JsonProperty("eventId")]
        public int? PIV_EVENT_ID { get; set; }

        [JsonProperty("accountsCode")]
        public string PIV_ACCOUNTS_CODE { get; set; }

        [JsonProperty("isToBeConfirmed")]
        public bool? PIV_IS_TO_BE_CONFIRMED { get; set; }

        [JsonProperty("fromDate")]
        public DateTime? PIV_FROM_DATE { get; set; }

        [JsonProperty("toDate")]
        public DateTime? PIV_TO_DATE { get; set; }

        [JsonProperty("assignedToUserId")]
        public int? PIV_ASSIGN_TO_USER_ID { get; set; }

        [JsonProperty("isAuthorised")]
        public bool PIV_IS_AUTHORISED { get; set; }

        [JsonProperty("invoiceLines")]
        public List<PurchaseInvoiceLine> InvoiceLines { get; set; }
    }

}