namespace NXHoaDonV2.View
{
    partial class HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_NameProduct = new System.Windows.Forms.TextBox();
            this.tb_PriceName = new System.Windows.Forms.TextBox();
            this.tb_NameBuy = new System.Windows.Forms.TextBox();
            this.tb_NameSell = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Deleted = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_ExportExecl = new System.Windows.Forms.Button();
            this.DGV_List = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguoiMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguoiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_List)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 599);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ExportExecl);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Controls.Add(this.btn_Deleted);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.tb_NameSell);
            this.panel2.Controls.Add(this.tb_NameBuy);
            this.panel2.Controls.Add(this.tb_PriceName);
            this.panel2.Controls.Add(this.tb_NameProduct);
            this.panel2.Controls.Add(this.tb_Id);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 584);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(377, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 96);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(377, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(854, 82);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(380, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(836, 74);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DGV_List);
            this.panel6.Location = new System.Drawing.Point(380, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(851, 501);
            this.panel6.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Hóa Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Người Mua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên Người Bán";
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(28, 106);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.ReadOnly = true;
            this.tb_Id.Size = new System.Drawing.Size(282, 26);
            this.tb_Id.TabIndex = 1;
            // 
            // tb_NameProduct
            // 
            this.tb_NameProduct.Location = new System.Drawing.Point(28, 187);
            this.tb_NameProduct.Name = "tb_NameProduct";
            this.tb_NameProduct.Size = new System.Drawing.Size(282, 26);
            this.tb_NameProduct.TabIndex = 6;
            this.tb_NameProduct.TextChanged += new System.EventHandler(this.tb_NameProduct_TextChanged);
            // 
            // tb_PriceName
            // 
            this.tb_PriceName.Location = new System.Drawing.Point(28, 248);
            this.tb_PriceName.Name = "tb_PriceName";
            this.tb_PriceName.Size = new System.Drawing.Size(282, 26);
            this.tb_PriceName.TabIndex = 7;
            this.tb_PriceName.TextChanged += new System.EventHandler(this.tb_PriceName_TextChanged);
            // 
            // tb_NameBuy
            // 
            this.tb_NameBuy.Location = new System.Drawing.Point(28, 317);
            this.tb_NameBuy.Name = "tb_NameBuy";
            this.tb_NameBuy.Size = new System.Drawing.Size(282, 26);
            this.tb_NameBuy.TabIndex = 8;
            this.tb_NameBuy.TextChanged += new System.EventHandler(this.tb_NameBuy_TextChanged);
            // 
            // tb_NameSell
            // 
            this.tb_NameSell.Location = new System.Drawing.Point(30, 384);
            this.tb_NameSell.Name = "tb_NameSell";
            this.tb_NameSell.Size = new System.Drawing.Size(282, 26);
            this.tb_NameSell.TabIndex = 9;
            this.tb_NameSell.TextChanged += new System.EventHandler(this.tb_NameSell_TextChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(28, 432);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(284, 41);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm Hóa Đơn";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Deleted
            // 
            this.btn_Deleted.Location = new System.Drawing.Point(30, 479);
            this.btn_Deleted.Name = "btn_Deleted";
            this.btn_Deleted.Size = new System.Drawing.Size(134, 50);
            this.btn_Deleted.TabIndex = 10;
            this.btn_Deleted.Text = "Xóa Hóa Đơn";
            this.btn_Deleted.UseVisualStyleBackColor = true;
            this.btn_Deleted.Click += new System.EventHandler(this.btn_Deleted_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(178, 479);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(134, 50);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Chỉnh Sửa Hóa Đơn";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_ExportExecl
            // 
            this.btn_ExportExecl.Location = new System.Drawing.Point(28, 535);
            this.btn_ExportExecl.Name = "btn_ExportExecl";
            this.btn_ExportExecl.Size = new System.Drawing.Size(284, 41);
            this.btn_ExportExecl.TabIndex = 12;
            this.btn_ExportExecl.Text = "Xuất Ra Execl";
            this.btn_ExportExecl.UseVisualStyleBackColor = true;
            this.btn_ExportExecl.Click += new System.EventHandler(this.btn_ExportExecl_Click);
            // 
            // DGV_List
            // 
            this.DGV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TenSanPham,
            this.GiaSanPham,
            this.TenNguoiMua,
            this.TenNguoiBan});
            this.DGV_List.Location = new System.Drawing.Point(6, 8);
            this.DGV_List.Name = "DGV_List";
            this.DGV_List.RowHeadersWidth = 62;
            this.DGV_List.RowTemplate.Height = 28;
            this.DGV_List.Size = new System.Drawing.Size(842, 490);
            this.DGV_List.TabIndex = 0;
            this.DGV_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_List_CellClick);
            this.DGV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_List_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Mã Hóa Đơn";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên Sản Phẩm";
            this.TenSanPham.MinimumWidth = 8;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Width = 150;
            // 
            // GiaSanPham
            // 
            this.GiaSanPham.DataPropertyName = "GiaSanPham";
            this.GiaSanPham.HeaderText = "Giá Sản Phẩm";
            this.GiaSanPham.MinimumWidth = 8;
            this.GiaSanPham.Name = "GiaSanPham";
            this.GiaSanPham.Width = 150;
            // 
            // TenNguoiMua
            // 
            this.TenNguoiMua.DataPropertyName = "TenNguoiMua";
            this.TenNguoiMua.HeaderText = "Ten Người Mua";
            this.TenNguoiMua.MinimumWidth = 8;
            this.TenNguoiMua.Name = "TenNguoiMua";
            this.TenNguoiMua.Width = 150;
            // 
            // TenNguoiBan
            // 
            this.TenNguoiBan.DataPropertyName = "TenNguoiBan";
            this.TenNguoiBan.HeaderText = "Tên Người Bán";
            this.TenNguoiBan.MinimumWidth = 8;
            this.TenNguoiBan.Name = "TenNguoiBan";
            this.TenNguoiBan.Width = 150;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 613);
            this.Controls.Add(this.panel1);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView DGV_List;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ExportExecl;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Deleted;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_NameSell;
        private System.Windows.Forms.TextBox tb_NameBuy;
        private System.Windows.Forms.TextBox tb_PriceName;
        private System.Windows.Forms.TextBox tb_NameProduct;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoiMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoiBan;
    }
}