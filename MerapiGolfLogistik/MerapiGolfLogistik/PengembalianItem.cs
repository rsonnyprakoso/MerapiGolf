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
    
    public partial class PengembalianItem
    {
        public System.Guid id { get; set; }
        public string no_nota { get; set; }
        public System.Guid id_pengambilan_barang { get; set; }
        public Nullable<double> banyak_dikembalikan { get; set; }
    
        public virtual PengambilanItem pengambilan_item { get; set; }
        public virtual Pengembalian pengembalian { get; set; }
    }
}
