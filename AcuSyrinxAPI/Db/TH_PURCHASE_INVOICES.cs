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
    
    public partial class TH_PURCHASE_INVOICES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TH_PURCHASE_INVOICES()
        {
            this.TH_PURCHASE_INV_LINES = new HashSet<TH_PURCHASE_INV_LINES>();
        }
    
        public int PIV_ID { get; set; }
        public Nullable<System.DateTime> PIV_INV_DATE { get; set; }
        public string PIV_INV_NUMBER { get; set; }
        public string PIV_STATUS { get; set; }
        public string PIV_INV_TYPE { get; set; }
        public Nullable<int> PIV_SUPPLIER_ID { get; set; }
        public bool PIV_POSTED_FLAG { get; set; }
        public Nullable<int> PIV_NONBATCH_POSTING_ID { get; set; }
        public string PIV_INTERNAL_NOTES { get; set; }
        public Nullable<int> PIV_DEPOT_ID { get; set; }
        public Nullable<int> PIV_USERID_CREATED { get; set; }
        public string PIV_POST_TO_ACCOUNT { get; set; }
        public Nullable<int> PIV_ORDER_ID { get; set; }
        public Nullable<System.DateTime> PIV_DATE_CREATED { get; set; }
        public Nullable<int> PIV_USERID_CANCELLED { get; set; }
        public Nullable<System.DateTime> PIV_DATE_CANCELLED { get; set; }
        public Nullable<System.DateTime> PIV_PY_DATE { get; set; }
        public string PIV_PY_ACCOUNT { get; set; }
        public string PIV_PY_REF { get; set; }
        public Nullable<decimal> PIV_PY_AMOUNT { get; set; }
        public Nullable<System.DateTime> PIV_POSTING_DATE { get; set; }
        public string PIV_USER_NUMBER { get; set; }
        public Nullable<int> PIV_DISPUTE_REASON_ID { get; set; }
        public Nullable<int> PIV_CURRENCY_ID { get; set; }
        public Nullable<float> PIV_EXCH_RATE { get; set; }
        public Nullable<int> PIV_EVENT_ID { get; set; }
        public string PIV_ACCOUNTS_CODE { get; set; }
        public Nullable<bool> PIV_IS_TO_BE_CONFIRMED { get; set; }
        public Nullable<System.DateTime> PIV_FROM_DATE { get; set; }
        public Nullable<System.DateTime> PIV_TO_DATE { get; set; }
        public Nullable<int> PIV_ASSIGN_TO_USER_ID { get; set; }
        public bool PIV_IS_AUTHORISED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TH_PURCHASE_INV_LINES> TH_PURCHASE_INV_LINES { get; set; }
    }
}
