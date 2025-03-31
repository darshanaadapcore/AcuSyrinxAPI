using AcuSyrinxAPI.Db;
using AcuSyrinxAPI.DTO;
using System.Linq;

namespace AcuSyrinxAPI.Mappers
{
    public static class HireInvoiceMapper
    {
        public static HireInvoice MapToDto(TH_HIRE_INVOICES entity)
        {
            if (entity == null)
                return null;

            return new HireInvoice
            {
                IVC_INVOICE_NUMBER = entity.IVC_INVOICE_NUMBER,
                IVC_CUSTOMER_NUMBER = entity.IVC_CUSTOMER_NUMBER,
                IVC_SITE_ID = entity.IVC_SITE_ID,
                IVC_DEPOT_ID = entity.IVC_DEPOT_ID,
                IVC_INV_ADR_ID = entity.IVC_INV_ADR_ID,
                IVC_BATCH_NUMBER = entity.IVC_BATCH_NUMBER,
                IVC_NONBATCH_POSTING_ID = entity.IVC_NONBATCH_POSTING_ID,
                IVC_USER_INVOICE_NUMBER = entity.IVC_USER_INVOICE_NUMBER,
                IVC_INVOICE_TYPE = entity.IVC_INVOICE_TYPE,
                IVC_INVOICE_SOURCE = entity.IVC_INVOICE_SOURCE,
                IVC_HAS_LINES = entity.IVC_HAS_LINES,
                IVC_INVOICE_WHEN = entity.IVC_INVOICE_WHEN,
                IVC_IS_INTERNAL = entity.IVC_IS_INTERNAL,
                IVC_INVOICE_DATE = entity.IVC_INVOICE_DATE,
                IVC_BOTTOM_TITLE = entity.IVC_BOTTOM_TITLE,
                IVC_CASH_STATUS = entity.IVC_CASH_STATUS,
                IVC_CASH_PAID_FLAG = entity.IVC_CASH_PAID_FLAG,
                IVC_CASH_REQUIRES_POSTING_FLAG = entity.IVC_CASH_REQUIRES_POSTING_FLAG,
                IVC_TOTAL_AMOUNT = entity.IVC_TOTAL_AMOUNT,
                IVC_INVOICE_FOOTER_ID = entity.IVC_INVOICE_FOOTER_ID,
                IVC_INVOICE_DUE_DATE = entity.IVC_INVOICE_DUE_DATE,
                IVC_MARK_PAID_USERID = entity.IVC_MARK_PAID_USERID,
                IVC_MARK_PAID_USERNAME = entity.IVC_MARK_PAID_USERNAME,
                IVC_MARK_PAID_DATE = entity.IVC_MARK_PAID_DATE,
                IVC_POST_TO_ACCOUNT = entity.IVC_POST_TO_ACCOUNT,
                IVC_FACTOR_POSTED = entity.IVC_FACTOR_POSTED,
                IVC_CUSTOMER_NAME = entity.IVC_CUSTOMER_NAME,
                IVC_POSTED = entity.IVC_POSTED,
                IVC_UNPAID_TX_ID = entity.IVC_UNPAID_TX_ID,
                IVC_SALESPERSON_ID = entity.IVC_SALESPERSON_ID,
                IVC_BATCH_CASH_CONTRACT_ID = entity.IVC_BATCH_CASH_CONTRACT_ID,
                IVC_CURRENCY_ID = entity.IVC_CURRENCY_ID,
                IVC_EXCH_RATE = entity.IVC_EXCH_RATE,
                IVC_CONFIRMED_DATE = entity.IVC_CONFIRMED_DATE,
                IVC_CONFIRMED_USERID = entity.IVC_CONFIRMED_USERID,
                IVC_INV_DELIVERY_REQUIRES_EXPORT = entity.IVC_INV_DELIVERY_REQUIRES_EXPORT,
                IVC_INV_DELIVERY_EXPORT_ID = entity.IVC_INV_DELIVERY_EXPORT_ID,
                IVC_EVENT_ID = entity.IVC_EVENT_ID,
                IVC_RAISED_DATE = entity.IVC_RAISED_DATE,
                IVC_UNPAID_STATUS_NOTES = entity.IVC_UNPAID_STATUS_NOTES,
                IVC_SELECTED = entity.IVC_SELECTED,
                IVC_CUSTOMER_TAX_REF_NO = entity.IVC_CUSTOMER_TAX_REF_NO,
                IVC_SELECT_FOR_RUNSET = entity.IVC_SELECT_FOR_RUNSET,
                IVC_SP_EXPORTED = entity.IVC_SP_EXPORTED,
                IVC_EMAIL_SENT_FLAG = entity.IVC_EMAIL_SENT_FLAG,

                TH_HIRE_INV_LINES = entity.TH_HIRE_INV_LINES?
                    .Select(MapToDto)
                    .ToList()
            };
        }


        public static HireInvoiceLine MapToDto(TH_HIRE_INV_LINES entity)
        {
            if (entity == null)
                return null;

            return new HireInvoiceLine
            {
                IVL_INVOICE_NUMBER = entity.IVL_INVOICE_NUMBER,
                IVL_SEQ = entity.IVL_SEQ,
                IVL_DETAILS = entity.IVL_DETAILS,
                IVL_NOMINAL_LEDGER_CODE = entity.IVL_NOMINAL_LEDGER_CODE,
                IVL_TAX_CODE = entity.IVL_TAX_CODE,
                IVL_LINE_SITE_ID = entity.IVL_LINE_SITE_ID,
                IVL_ADVNOTE_HIRE_CONTRACT_ID = entity.IVL_ADVNOTE_HIRE_CONTRACT_ID,
                IVL_CONTRACT_NUMBER = entity.IVL_CONTRACT_NUMBER,
                IVL_DATE_FROM = entity.IVL_DATE_FROM,
                IVL_DATE_TO = entity.IVL_DATE_TO,
                IVL_CUSTOMER_REFERENCE = entity.IVL_CUSTOMER_REFERENCE,
                IVL_CHARGE = entity.IVL_CHARGE,
                IVL_LINE_TAX_RATE = entity.IVL_LINE_TAX_RATE,
                IVL_TAX_AMOUNT = entity.IVL_TAX_AMOUNT,
                IVL_GENERATED_CHARGE = entity.IVL_GENERATED_CHARGE,
                IVL_EXCLUDE = entity.IVL_EXCLUDE,
                IVL_DISCOUNT_PCT = entity.IVL_DISCOUNT_PCT,
                IVL_PRE_DISCOUNT_CHARGE = entity.IVL_PRE_DISCOUNT_CHARGE,
                IVL_SECTION_NO = entity.IVL_SECTION_NO,
                IVL_QUANTITY = entity.IVL_QUANTITY,
                IVL_UNIT_PRICE = entity.IVL_UNIT_PRICE,
                IVL_NOTES = entity.IVL_NOTES,
                upsize_ts = entity.upsize_ts,
                IVL_NOTES2 = entity.IVL_NOTES2,
                IVL_SOURCEDOC_ID = entity.IVL_SOURCEDOC_ID,
                IVL_SOURCEDOC_LINE_SEQ = entity.IVL_SOURCEDOC_LINE_SEQ,
                IVL_LOCAL_TAX_CODE = entity.IVL_LOCAL_TAX_CODE,
                IVL_LOCAL_TAX_RATE = entity.IVL_LOCAL_TAX_RATE,
                IVL_LOCAL_TAX_AMOUNT = entity.IVL_LOCAL_TAX_AMOUNT,
                IVL_STOCK_NO = entity.IVL_STOCK_NO,
                IVL_PRICE_PER = entity.IVL_PRICE_PER,
                IVL_HIRE_DURATION_PERIODS = entity.IVL_HIRE_DURATION_PERIODS,
                IVL_HIRE_DURATION_ADD_DAYS = entity.IVL_HIRE_DURATION_ADD_DAYS,
                IVL_1DAY_RATE = entity.IVL_1DAY_RATE,
                IVL_HIRE_STATUS = entity.IVL_HIRE_STATUS,
                IVL_HIRE_OFFHIRE_DATE = entity.IVL_HIRE_OFFHIRE_DATE,
                IVL_USER_MODIFIED = entity.IVL_USER_MODIFIED,
                IVL_CURR_EQUIPMENT_CODE = entity.IVL_CURR_EQUIPMENT_CODE,
                IVL_CURR_STOCKNO = entity.IVL_CURR_STOCKNO,
                IVL_IS_FIRST_HIRE_INV = entity.IVL_IS_FIRST_HIRE_INV
            };
        }
    }
}