//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MicroERP.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoodsOrderInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoodsOrderInfo()
        {
            this.FundsGoodsInfo = new HashSet<FundsGoodsInfo>();
            this.GoodsConfirmInfo = new HashSet<GoodsConfirmInfo>();
            this.GoodsRejectedOrderInfo = new HashSet<GoodsRejectedOrderInfo>();
        }
    
        public int OrderID { get; set; }
        public Nullable<int> GoodsID { get; set; }
        public long GoodsQuantity { get; set; }
        public string GoodsTarget { get; set; }
        public int GoodsUnitPrice { get; set; }
        public int GoodsSellerID { get; set; }
        public Nullable<System.DateTime> OrderTime { get; set; }
        public Nullable<int> GoodsConfirmID { get; set; }
        public string SaleNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FundsGoodsInfo> FundsGoodsInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsConfirmInfo> GoodsConfirmInfo { get; set; }
        public virtual GoodsConfirmInfo GoodsConfirmInfo1 { get; set; }
        public virtual UserSelfInfo UserSelfInfo { get; set; }
        public virtual GoodsResourceInfo GoodsResourceInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsRejectedOrderInfo> GoodsRejectedOrderInfo { get; set; }
    }
}
