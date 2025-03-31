//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcuSyrinxAPI.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class TH_HIRE_INVOICES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TH_HIRE_INVOICES()
        {
            this.TH_HIRE_INV_LINES = new HashSet<TH_HIRE_INV_LINES>();
        }
    
        public int IVC_INVOICE_NUMBER { get; set; }
        public int IVC_CUSTOMER_NUMBER { get; set; }
        public Nullable<int> IVC_SITE_ID { get; set; }
        public Nullable<int> IVC_DEPOT_ID { get; set; }
        public Nullable<int> IVC_INV_ADR_ID { get; set; }
        public Nullable<int> IVC_BATCH_NUMBER { get; set; }
        public Nullable<int> IVC_NONBATCH_POSTING_ID { get; set; }
        public string IVC_USER_INVOICE_NUMBER { get; set; }
        public string IVC_INVOICE_TYPE { get; set; }
        public string IVC_INVOICE_SOURCE { get; set; }
        public bool IVC_HAS_LINES { get; set; }
        public Nullable<int> IVC_INVOICE_WHEN { get; set; }
        public bool IVC_IS_INTERNAL { get; set; }
        public Nullable<System.DateTime> IVC_INVOICE_DATE { get; set; }
        public string IVC_BOTTOM_TITLE { get; set; }
        public string IVC_CASH_STATUS { get; set; }
        public Nullable<bool> IVC_CASH_PAID_FLAG { get; set; }
        public bool IVC_CASH_REQUIRES_POSTING_FLAG { get; set; }
        public Nullable<decimal> IVC_TOTAL_AMOUNT { get; set; }
        public Nullable<int> IVC_INVOICE_FOOTER_ID { get; set; }
        public Nullable<System.DateTime> IVC_INVOICE_DUE_DATE { get; set; }
        public byte[] upsize_ts { get; set; }
        public Nullable<int> IVC_MARK_PAID_USERID { get; set; }
        public string IVC_MARK_PAID_USERNAME { get; set; }
        public Nullable<System.DateTime> IVC_MARK_PAID_DATE { get; set; }
        public string IVC_POST_TO_ACCOUNT { get; set; }
        public bool IVC_FACTOR_POSTED { get; set; }
        public string IVC_CUSTOMER_NAME { get; set; }
        public bool IVC_POSTED { get; set; }
        public Nullable<int> IVC_UNPAID_TX_ID { get; set; }
        public Nullable<int> IVC_SALESPERSON_ID { get; set; }
        public Nullable<int> IVC_BATCH_CASH_CONTRACT_ID { get; set; }
        public Nullable<int> IVC_CURRENCY_ID { get; set; }
        public Nullable<float> IVC_EXCH_RATE { get; set; }
        public Nullable<System.DateTime> IVC_CONFIRMED_DATE { get; set; }
        public Nullable<int> IVC_CONFIRMED_USERID { get; set; }
        public Nullable<bool> IVC_INV_DELIVERY_REQUIRES_EXPORT { get; set; }
        public Nullable<int> IVC_INV_DELIVERY_EXPORT_ID { get; set; }
        public Nullable<int> IVC_EVENT_ID { get; set; }
        public Nullable<System.DateTime> IVC_RAISED_DATE { get; set; }
        public string IVC_UNPAID_STATUS_NOTES { get; set; }
        public bool IVC_SELECTED { get; set; }
        public string IVC_CUSTOMER_TAX_REF_NO { get; set; }
        public bool IVC_SELECT_FOR_RUNSET { get; set; }
        public bool IVC_SP_EXPORTED { get; set; }
        public Nullable<bool> IVC_EMAIL_SENT_FLAG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TH_HIRE_INV_LINES> TH_HIRE_INV_LINES { get; set; }
    }
}
