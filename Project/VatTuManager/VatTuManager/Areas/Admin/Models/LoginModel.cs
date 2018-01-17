using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VatTuManager.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Hãy nhập tên người dùng.")]
        public string userName { set; get; }
        [Required(ErrorMessage = "Hãy nhập mật khẩu.")]
        public string passWork { set; get; }
        public string remember { set; get; }
    }
}