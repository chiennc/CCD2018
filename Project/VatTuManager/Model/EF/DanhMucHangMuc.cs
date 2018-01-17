namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMucHangMuc")]
    public partial class DanhMucHangMuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMucHangMuc()
        {
            HangMuc_VatTu = new HashSet<HangMuc_VatTu>();
        }

        [Key]
        [StringLength(50)]
        public string Ma { get; set; }

        [StringLength(250)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string MaCongTrinh { get; set; }

        [StringLength(50)]
        public string MaGoiThau { get; set; }

        public virtual DanhMucCongTrinh DanhMucCongTrinh { get; set; }

        public virtual DanhMucGoiThau DanhMucGoiThau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangMuc_VatTu> HangMuc_VatTu { get; set; }
    }
}
