using System;
using System.Collections.Generic;
using AcuSyrinxAPI.Db;
using Newtonsoft.Json;

namespace AcuSyrinxAPI.DTO
{
    public class HireInvoice
    {
        [JsonProperty("invoiceNumber")]
        public int IVC_INVOICE_NUMBER { get; set; }

        [JsonProperty("customerNumber")]
        public int IVC_CUSTOMER_NUMBER { get; set; }

        [JsonProperty("siteId")]
        public int? IVC_SITE_ID { get; set; }

        [JsonProperty("depotId")]
        public int? IVC_DEPOT_ID { get; set; }

        [JsonProperty("invoiceAddressId")]
        public int? IVC_INV_ADR_ID { get; set; }

        [JsonProperty("batchNumber")]
        public int? IVC_BATCH_NUMBER { get; set; }

        [JsonProperty("nonBatchPostingId")]
        public int? IVC_NONBATCH_POSTING_ID { get; set; }

        [JsonProperty("userInvoiceNumber")]
        public string IVC_USER_INVOICE_NUMBER { get; set; }

        [JsonProperty("invoiceType")]
        public string IVC_INVOICE_TYPE { get; set; }

        [JsonProperty("invoiceSource")]
        public string IVC_INVOICE_SOURCE { get; set; }

        [JsonProperty("hasLines")]
        public bool IVC_HAS_LINES { get; set; }

        [JsonProperty("invoiceWhen")]
        public int? IVC_INVOICE_WHEN { get; set; }

        [JsonProperty("isInternal")]
        public bool IVC_IS_INTERNAL { get; set; }

        [JsonProperty("invoiceDate")]
        public DateTime? IVC_INVOICE_DATE { get; set; }

        [JsonProperty("bottomTitle")]
        public string IVC_BOTTOM_TITLE { get; set; }

        [JsonProperty("cashStatus")]
        public string IVC_CASH_STATUS { get; set; }

        [JsonProperty("cashPaidFlag")]
        public bool? IVC_CASH_PAID_FLAG { get; set; }

        [JsonProperty("cashRequiresPostingFlag")]
        public bool IVC_CASH_REQUIRES_POSTING_FLAG { get; set; }

        [JsonProperty("totalAmount")]
        public decimal? IVC_TOTAL_AMOUNT { get; set; }

        [JsonProperty("invoiceFooterId")]
        public int? IVC_INVOICE_FOOTER_ID { get; set; }

        [JsonProperty("invoiceDueDate")]
        public DateTime? IVC_INVOICE_DUE_DATE { get; set; }

        [JsonProperty("markPaidUserId")]
        public int? IVC_MARK_PAID_USERID { get; set; }

        [JsonProperty("markPaidUsername")]
        public string IVC_MARK_PAID_USERNAME { get; set; }

        [JsonProperty("markPaidDate")]
        public DateTime? IVC_MARK_PAID_DATE { get; set; }

        [JsonProperty("postToAccount")]
        public string IVC_POST_TO_ACCOUNT { get; set; }

        [JsonProperty("factorPosted")]
        public bool IVC_FACTOR_POSTED { get; set; }

        [JsonProperty("customerName")]
        public string IVC_CUSTOMER_NAME { get; set; }

        [JsonProperty("posted")]
        public bool IVC_POSTED { get; set; }

        [JsonProperty("unpaidTransactionId")]
        public int? IVC_UNPAID_TX_ID { get; set; }

        [JsonProperty("salespersonId")]
        public int? IVC_SALESPERSON_ID { get; set; }

        [JsonProperty("batchCashContractId")]
        public int? IVC_BATCH_CASH_CONTRACT_ID { get; set; }

        [JsonProperty("currencyId")]
        public int? IVC_CURRENCY_ID { get; set; }

        [JsonProperty("exchangeRate")]
        public float? IVC_EXCH_RATE { get; set; }

        [JsonProperty("confirmedDate")]
        public DateTime? IVC_CONFIRMED_DATE { get; set; }

        [JsonProperty("confirmedUserId")]
        public int? IVC_CONFIRMED_USERID { get; set; }

        [JsonProperty("invoiceDeliveryRequiresExport")]
        public bool? IVC_INV_DELIVERY_REQUIRES_EXPORT { get; set; }

        [JsonProperty("invoiceDeliveryExportId")]
        public int? IVC_INV_DELIVERY_EXPORT_ID { get; set; }

        [JsonProperty("eventId")]
        public int? IVC_EVENT_ID { get; set; }

        [JsonProperty("raisedDate")]
        public DateTime? IVC_RAISED_DATE { get; set; }

        [JsonProperty("unpaidStatusNotes")]
        public string IVC_UNPAID_STATUS_NOTES { get; set; }

        [JsonProperty("selected")]
        public bool IVC_SELECTED { get; set; }

        [JsonProperty("customerTaxRefNo")]
        public string IVC_CUSTOMER_TAX_REF_NO { get; set; }

        [JsonProperty("selectForRunset")]
        public bool IVC_SELECT_FOR_RUNSET { get; set; }

        [JsonProperty("spExported")]
        public bool IVC_SP_EXPORTED { get; set; }

        [JsonProperty("emailSentFlag")]
        public bool? IVC_EMAIL_SENT_FLAG { get; set; }

        [JsonProperty("hireInvoiceLines")]
        public List<HireInvoiceLine> TH_HIRE_INV_LINES { get; set; }
    }
}