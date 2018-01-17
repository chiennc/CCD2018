namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMucVatTu")]
    public partial class DanhMucVatTu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMucVatTu()
        {
            HangMuc_VatTu = new HashSet<HangMuc_VatTu>();
        }

        [Key]
        [StringLength(50)]
        public string Ma { get; set; }

        [StringLength(250)]
        public string Ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangMuc_VatTu> HangMuc_VatTu { get; set; }
    }
}
