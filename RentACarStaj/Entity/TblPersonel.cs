//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentACarStaj.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblPersonel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblPersonel()
        {
            this.TblAracAlimLog = new HashSet<TblAracAlimLog>();
            this.TblAracAlimLog1 = new HashSet<TblAracAlimLog>();
        }
    
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public Nullable<int> Yetki { get; set; }
        public Nullable<bool> Durum { get; set; }
        public Nullable<int> Cinsiyet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblAracAlimLog> TblAracAlimLog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblAracAlimLog> TblAracAlimLog1 { get; set; }
        public virtual TblYetki TblYetki { get; set; }
        public virtual TblCinsiyet TblCinsiyet { get; set; }
    }
}
