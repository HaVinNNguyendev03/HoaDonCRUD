using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NXHoaDonV2.Controller;
using NXHoaDonV2.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NXHoaDonV2.View
{
    public partial class HoaDon : Form
    {
        private HoaDonController hoaDonController;
        void reset()
        {
            tb_Id.Clear();
            tb_NameBuy.Clear();
            tb_NameSell.Clear();
            tb_NameProduct.Clear();
            tb_PriceName.Clear();
        }
        void ErrorMess()
        {
            MessageBox.Show("Dữ Liệu Không Hợp Lệ,Vui Lòng Nhập Lại","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public HoaDon()
        {
            InitializeComponent();
            hoaDonController = new HoaDonController();
        }

        private void DGV_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_List.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_List.SelectedRows[0];
                tb_Id.Text = selectedRow.Cells["Id"].Value.ToString();
                tb_NameProduct.Text = selectedRow.Cells["TenSanPham"].Value.ToString();
                tb_PriceName.Text = selectedRow.Cells["GiaSanPham"].Value.ToString();
                tb_NameBuy.Text = selectedRow.Cells["TenNguoiMua"].Value.ToString();
                tb_NameSell.Text = selectedRow.Cells["TenNguoiBan"].Value.ToString();
            }
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            DGV_List.DataSource = hoaDonController.GetAllHoaDon();
            DGV_List.Refresh();
        }
        private void tb_NameProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_PriceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_NameBuy_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_NameSell_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (
                !string.IsNullOrEmpty(tb_NameProduct.Text) &&
                !string.IsNullOrEmpty(tb_PriceName.Text) &&
                !string.IsNullOrEmpty(tb_NameBuy.Text) &&
                !string.IsNullOrEmpty(tb_NameSell.Text)
                )
            {
                string tensanpham = tb_NameProduct.Text;
                decimal giasanpham;
                if(!decimal.TryParse(tb_PriceName.Text, out giasanpham))
                {
                    MessageBox.Show("Dữ Liệu Giá Không Hợp Lệ");
                    return;
                }
                string tennguoimua = tb_NameBuy.Text;
                string tennguoiban = tb_NameSell.Text;
                hoaDonController.AddHoaDon(tensanpham, giasanpham,tennguoimua,tennguoiban);
                DGV_List.DataSource = hoaDonController.GetAllHoaDon();
                reset();
            }
            else
            {
                ErrorMess();
            }
        }

        private void btn_Deleted_Click(object sender, EventArgs e)
        {
            if (DGV_List.SelectedRows.Count > 0 && !string.IsNullOrEmpty(tb_Id.Text))
            {
                DataGridViewRow selectRow = DGV_List.SelectedRows[0];
                int Id = (int)selectRow.Cells["id"].Value;

                hoaDonController.DeleteHoaDon(Id);
                DGV_List.DataSource = hoaDonController.GetAllHoaDon();
                reset();
            }
            else
            {
                ErrorMess();
            }
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Id.Text))
            {
                int Id = int.Parse(tb_Id.Text);
                string tensanpham = tb_NameBuy.Text;
                decimal giasanpham = decimal.Parse(tb_PriceName.Text);
                string tennguoimua = tb_NameBuy.Text;
                string tennguoiban = tb_NameSell.Text;
                DGV_List.DataSource = hoaDonController.GetAllHoaDon();
                reset();
            }
            else
            {
                ErrorMess();
            }
        }

        private void btn_ExportExecl_Click(object sender, EventArgs e)
        {

        }

       
    }
}
