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

    public partial class Pharmacy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pharmacy()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int Id { get; set; }
        public string NamaPharmacy { get; set; }
        public string EmailPharmacy { get; set; }
        public string Alamat { get; set; }
        public string NoTelephone { get; set; }
        public string NamaPIC { get; set; }
        public string EmailPIC { get; set; }
        public string Password { get; set; }
        public string FotoPharmacy { get; set; }

        public HttpPostedFileBase ImageUpload { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
