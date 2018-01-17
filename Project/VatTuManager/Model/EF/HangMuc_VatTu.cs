namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HangMuc_VatTu
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string MaHangMuc { get; set; }

        [StringLength(50)]
        public string MaVatTu { get; set; }

        public virtual DanhMucHangMuc DanhMucHangMuc { get; set; }

        public virtual DanhMucVatTu DanhMucVatTu { get; set; }
    }
}
