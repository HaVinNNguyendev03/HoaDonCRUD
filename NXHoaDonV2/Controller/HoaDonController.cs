using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using NXHoaDonV2.Model;


namespace NXHoaDonV2.Controller
{
    internal class HoaDonController
    {
        public List<HoaDonModel> GetAllHoaDon()
        {
            using (var HoaDondbcontext = new HoaDonDBContext())
            {
                return HoaDondbcontext.HoaDonModels.ToList();
            }
        }
        public void AddHoaDon(string tensanpham, decimal giasanpham, string tennguoimua, string tennguoiban)
        {
            try
            {
                HoaDonModel NewHoaDon = new HoaDonModel
                {
                    TenSanPham = tensanpham,
                    GiaSanPham = giasanpham,
                    TenNguoiMua = tennguoimua,
                    TenNguoiBan = tennguoiban
                };
                using (var HoaDon = new HoaDonDBContext())
                {
                    HoaDon.HoaDonModels.Add(NewHoaDon);
                    HoaDon.SaveChanges();
                }
                MessageBox.Show("Thêm hóa đơn thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error add newhoadon" + ex);
            }
        }
        public void UpdateHoaDon(int Id, string tensanpham, decimal giasanpham, string tennguoimua, string tennguoiban)
        {
            try
            {
                using(var HoaDon = new HoaDonDBContext())
                {
                    var updateHoaDon = HoaDon.HoaDonModels.FirstOrDefault(ds => ds.Id == Id);
                    if(updateHoaDon != null)
                    {
                        updateHoaDon.TenSanPham = tensanpham;
                        updateHoaDon.GiaSanPham = giasanpham;
                        updateHoaDon.TenNguoiMua = tennguoimua;
                        updateHoaDon.TenNguoiBan = tennguoiban;
                        HoaDon.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Update Hoa Don" + ex);
            }                    
         }
        public void DeleteHoaDon(int Id)
        {
            try
            {
                using(var HoaDon = new HoaDonDBContext())
                {
                    var DeleteHoaDon = HoaDon.HoaDonModels.FirstOrDefault(ds => ds.Id == Id);
                    if (DeleteHoaDon != null)
                    {
                        HoaDon.HoaDonModels.Remove(DeleteHoaDon);
                        HoaDon.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errors Delete Hoa Don" + ex);
            }
        }
    }
}
    

