//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MerapiGolfLogistik
{
    using System;
    using System.Collections.Generic;
    
    public partial class PembelianItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PembelianItem()
        {
            this.pengambilan_item = new HashSet<PengambilanItem>();
        }
    
        public System.Guid id { get; set; }
        public string no_nota { get; set; }
        public Nullable<System.Guid> barang_id { get; set; }
        public Nullable<double> banyak_barang { get; set; }
        public Nullable<double> harga_satuan { get; set; }
    
        public virtual Barang barang { get; set; }
        public virtual Pembelian pembelian { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PengambilanItem> pengambilan_item { get; set; }
    }
}
