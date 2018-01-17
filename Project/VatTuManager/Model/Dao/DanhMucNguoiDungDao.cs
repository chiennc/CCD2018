using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class DanhMucNguoiDungDao
    {
        VatTuDbContex db = null;

        public DanhMucNguoiDungDao()
        {
            db = new VatTuDbContex();
        }

        public int Insert(DanhMucNguoiDung entity)
        {
            db.DanhMucNguoiDungs.Add(entity);
            return db.SaveChanges();
        }

        public bool Login(string userName, string passWork)
        {
            int result = db.DanhMucNguoiDungs.Count(x => x.TenDangNhap.Equals(userName) && x.MatKhau.Equals(passWork));
            if(result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
