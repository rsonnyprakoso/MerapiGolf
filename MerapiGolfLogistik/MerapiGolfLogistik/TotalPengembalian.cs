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
    
    public partial class TotalPengembalian
    {
        public System.Guid id { get; set; }
        public System.Guid id_barang { get; set; }
        public string no_nota { get; set; }
        public string nama_barang { get; set; }
        public string satuan { get; set; }
        public Nullable<double> banyak_dikembalikan { get; set; }
        public Nullable<double> harga_satuan { get; set; }
        public Nullable<double> total { get; set; }
    }
}