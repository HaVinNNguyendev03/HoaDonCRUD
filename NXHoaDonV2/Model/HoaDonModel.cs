using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXHoaDonV2.Model
{
    internal class HoaDonModel
    {
       
            public int Id { get; set; }
            public string TenSanPham { get; set; }
            public decimal GiaSanPham { get; set; }
            public string TenNguoiMua { get; set; }
            public string TenNguoiBan { get; set; }
        
    }
}
