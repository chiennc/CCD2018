namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VatTuDbContex : DbContext
    {
        public VatTuDbContex()
            : base("name=VatTuDbContex")
        {
        }

        public virtual DbSet<DanhMucCongTrinh> DanhMucCongTrinhs { get; set; }
        public virtual DbSet<DanhMucGoiThau> DanhMucGoiThaus { get; set; }
        public virtual DbSet<DanhMucHangMuc> DanhMucHangMucs { get; set; }
        public virtual DbSet<DanhMucNguoiDung> DanhMucNguoiDungs { get; set; }
        public virtual DbSet<DanhMucVatTu> DanhMucVatTus { get; set; }
        public virtual DbSet<HangMuc_VatTu> HangMuc_VatTu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhMucCongTrinh>()
                .HasMany(e => e.DanhMucHangMucs)
                .WithOptional(e => e.DanhMucCongTrinh)
                .HasForeignKey(e => e.MaCongTrinh);

            modelBuilder.Entity<DanhMucGoiThau>()
                .HasMany(e => e.DanhMucHangMucs)
                .WithOptional(e => e.DanhMucGoiThau)
                .HasForeignKey(e => e.MaGoiThau);

            modelBuilder.Entity<DanhMucHangMuc>()
                .HasMany(e => e.HangMuc_VatTu)
                .WithOptional(e => e.DanhMucHangMuc)
                .HasForeignKey(e => e.MaHangMuc);

            modelBuilder.Entity<DanhMucVatTu>()
                .HasMany(e => e.HangMuc_VatTu)
                .WithOptional(e => e.DanhMucVatTu)
                .HasForeignKey(e => e.MaVatTu);
        }
    }
}
