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
    
    public partial class Pengambilan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pengambilan()
        {
            this.pengambilan_item = new HashSet<PengambilanItem>();
        }
    
        public string id { get; set; }
        public Nullable<System.Guid> user_id { get; set; }
        public Nullable<System.DateTime> tanggal { get; set; }
        public string keterangan { get; set; }
        public string nama_pengambil { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PengambilanItem> pengambilan_item { get; set; }
        public virtual User user { get; set; }
    }
}
