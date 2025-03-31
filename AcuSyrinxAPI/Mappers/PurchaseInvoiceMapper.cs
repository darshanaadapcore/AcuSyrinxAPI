using AcuSyrinxAPI.Db;
using AcuSyrinxAPI.DTO;
using System.Linq;

namespace AcuSyrinxAPI.Mappers
{
    public static class PurchaseInvoiceMapper
    {
        public static PurchaseInvoice MapToDto(TH_PURCHASE_INVOICES entity)
        {
            if (entity == null)
                return null;

            return new PurchaseInvoice
            {
                PIV_ID = entity.PIV_ID,
                PIV_INV_DATE = entity.PIV_INV_DATE,
                PIV_INV_NUMBER = entity.PIV_INV_NUMBER,
                PIV_STATUS = entity.PIV_STATUS,
                PIV_INV_TYPE = entity.PIV_INV_TYPE,
                PIV_SUPPLIER_ID = entity.PIV_SUPPLIER_ID,
                PIV_POSTED_FLAG = entity.PIV_POSTED_FLAG,
                PIV_NONBATCH_POSTING_ID = entity.PIV_NONBATCH_POSTING_ID,
                PIV_INTERNAL_NOTES = entity.PIV_INTERNAL_NOTES,
                PIV_DEPOT_ID = entity.PIV_DEPOT_ID,
                PIV_USERID_CREATED = entity.PIV_USERID_CREATED,
                PIV_POST_TO_ACCOUNT = entity.PIV_POST_TO_ACCOUNT,
                PIV_ORDER_ID = entity.PIV_ORDER_ID,
                PIV_DATE_CREATED = entity.PIV_DATE_CREATED,
                PIV_USERID_CANCELLED = entity.PIV_USERID_CANCELLED,
                PIV_DATE_CANCELLED = entity.PIV_DATE_CANCELLED,
                PIV_PY_DATE = entity.PIV_PY_DATE,
                PIV_PY_ACCOUNT = entity.PIV_PY_ACCOUNT,
                PIV_PY_REF = entity.PIV_PY_REF,
                PIV_PY_AMOUNT = entity.PIV_PY_AMOUNT,
                PIV_POSTING_DATE = entity.PIV_POSTING_DATE,
                PIV_USER_NUMBER = entity.PIV_USER_NUMBER,
                PIV_DISPUTE_REASON_ID = entity.PIV_DISPUTE_REASON_ID,
                PIV_CURRENCY_ID = entity.PIV_CURRENCY_ID,
                PIV_EXCH_RATE = entity.PIV_EXCH_RATE,
                PIV_EVENT_ID = entity.PIV_EVENT_ID,
                PIV_ACCOUNTS_CODE = entity.PIV_ACCOUNTS_CODE,
                PIV_IS_TO_BE_CONFIRMED = entity.PIV_IS_TO_BE_CONFIRMED,
                PIV_FROM_DATE = entity.PIV_FROM_DATE,
                PIV_TO_DATE = entity.PIV_TO_DATE,
                PIV_ASSIGN_TO_USER_ID = entity.PIV_ASSIGN_TO_USER_ID,
                PIV_IS_AUTHORISED = entity.PIV_IS_AUTHORISED,

                InvoiceLines = entity.TH_PURCHASE_INV_LINES?
                    .Select(MapToDto)
                    .ToList()
            };
        }

        public static PurchaseInvoiceLine MapToDto(TH_PURCHASE_INV_LINES entity)
        {
            if (entity == null)
                return null;

            return new PurchaseInvoiceLine
            {
                PIL_INVOICE_ID = entity.PIL_INVOICE_ID,
                PIL_SEQ = entity.PIL_SEQ,
                PIL_NOMINAL_CODE = entity.PIL_NOMINAL_CODE,
                PIL_DESCRIPTION = entity.PIL_DESCRIPTION,
                PIL_NET_AMOUNT = entity.PIL_NET_AMOUNT,
                PIL_TAX_CODE = entity.PIL_TAX_CODE,
                PIL_TAX_AMOUNT = entity.PIL_TAX_AMOUNT,
                PIL_EVENT_ID = entity.PIL_EVENT_ID,
                PIL_ACCOUNTS_DEPT = entity.PIL_ACCOUNTS_DEPT
            };
        }
    }
}
