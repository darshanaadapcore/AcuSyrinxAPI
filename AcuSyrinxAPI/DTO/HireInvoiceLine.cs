using Newtonsoft.Json;
using System;

public class HireInvoiceLine
{
    [JsonProperty("invoiceNumber")]
    public int IVL_INVOICE_NUMBER { get; set; }

    [JsonProperty("sequence")]
    public int IVL_SEQ { get; set; }

    [JsonProperty("details")]
    public string IVL_DETAILS { get; set; }

    [JsonProperty("nominalLedgerCode")]
    public string IVL_NOMINAL_LEDGER_CODE { get; set; }

    [JsonProperty("taxCode")]
    public string IVL_TAX_CODE { get; set; }

    [JsonProperty("lineSiteId")]
    public int? IVL_LINE_SITE_ID { get; set; }

    [JsonProperty("advnoteHireContractId")]
    public int? IVL_ADVNOTE_HIRE_CONTRACT_ID { get; set; }

    [JsonProperty("contractNumber")]
    public int? IVL_CONTRACT_NUMBER { get; set; }

    [JsonProperty("dateFrom")]
    public DateTime? IVL_DATE_FROM { get; set; }

    [JsonProperty("dateTo")]
    public DateTime? IVL_DATE_TO { get; set; }

    [JsonProperty("customerReference")]
    public string IVL_CUSTOMER_REFERENCE { get; set; }

    [JsonProperty("charge")]
    public decimal? IVL_CHARGE { get; set; }

    [JsonProperty("lineTaxRate")]
    public float? IVL_LINE_TAX_RATE { get; set; }

    [JsonProperty("taxAmount")]
    public decimal? IVL_TAX_AMOUNT { get; set; }

    [JsonProperty("generatedCharge")]
    public decimal? IVL_GENERATED_CHARGE { get; set; }

    [JsonProperty("exclude")]
    public bool IVL_EXCLUDE { get; set; }

    [JsonProperty("discountPct")]
    public float? IVL_DISCOUNT_PCT { get; set; }

    [JsonProperty("preDiscountCharge")]
    public decimal? IVL_PRE_DISCOUNT_CHARGE { get; set; }

    [JsonProperty("sectionNo")]
    public int? IVL_SECTION_NO { get; set; }

    [JsonProperty("quantity")]
    public string IVL_QUANTITY { get; set; }

    [JsonProperty("unitPrice")]
    public decimal? IVL_UNIT_PRICE { get; set; }

    [JsonProperty("notes")]
    public string IVL_NOTES { get; set; }

    [JsonProperty("upsizeTimestamp")]
    public byte[] upsize_ts { get; set; }

    [JsonProperty("notes2")]
    public string IVL_NOTES2 { get; set; }

    [JsonProperty("sourceDocId")]
    public int? IVL_SOURCEDOC_ID { get; set; }

    [JsonProperty("sourceDocLineSeq")]
    public int? IVL_SOURCEDOC_LINE_SEQ { get; set; }

    [JsonProperty("localTaxCode")]
    public string IVL_LOCAL_TAX_CODE { get; set; }

    [JsonProperty("localTaxRate")]
    public float? IVL_LOCAL_TAX_RATE { get; set; }

    [JsonProperty("localTaxAmount")]
    public decimal? IVL_LOCAL_TAX_AMOUNT { get; set; }

    [JsonProperty("stockNo")]
    public string IVL_STOCK_NO { get; set; }

    [JsonProperty("pricePer")]
    public string IVL_PRICE_PER { get; set; }

    [JsonProperty("hireDurationPeriods")]
    public int? IVL_HIRE_DURATION_PERIODS { get; set; }

    [JsonProperty("hireDurationAddDays")]
    public float? IVL_HIRE_DURATION_ADD_DAYS { get; set; }

    [JsonProperty("oneDayRate")]
    public decimal? IVL_1DAY_RATE { get; set; }

    [JsonProperty("hireStatus")]
    public int? IVL_HIRE_STATUS { get; set; }

    [JsonProperty("hireOffhireDate")]
    public DateTime? IVL_HIRE_OFFHIRE_DATE { get; set; }

    [JsonProperty("userModified")]
    public bool IVL_USER_MODIFIED { get; set; }

    [JsonProperty("currentEquipmentCode")]
    public string IVL_CURR_EQUIPMENT_CODE { get; set; }

    [JsonProperty("currentStockNo")]
    public string IVL_CURR_STOCKNO { get; set; }

    [JsonProperty("isFirstHireInvoice")]
    public bool? IVL_IS_FIRST_HIRE_INV { get; set; }
}
