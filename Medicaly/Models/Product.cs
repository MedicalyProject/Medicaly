//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Medicaly.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    public partial class Product
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Deskripsi { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public Nullable<int> PharmacyId { get; set; }
        public string ProductFoto { get; set; }
        public HttpPostedFileBase ImageUpload { get; set; }
        public virtual Pharmacy Pharmacy { get; set; }
    }
}
