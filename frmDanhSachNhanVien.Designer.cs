namespace Quan_li_diem_HS_tieu_hoc
{
    partial class frmDanhSachNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.gridThongTin = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridThongTin
            // 
            this.gridThongTin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaNV,
            this.colHoTen,
            this.colGT,
            this.colNS,
            this.colMaLop,
            this.colSDT,
            this.colCMND,
            this.colCHUCVU});
            this.gridThongTin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridThongTin.GridColor = System.Drawing.SystemColors.ControlText;
            this.gridThongTin.Location = new System.Drawing.Point(0, 155);
            this.gridThongTin.Name = "gridThongTin";
            this.gridThongTin.Size = new System.Drawing.Size(859, 291);
            this.gridThongTin.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MANV";
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HOTEN";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colGT
            // 
            this.colGT.DataPropertyName = "GIOITINH";
            this.colGT.HeaderText = "Giới tính";
            this.colGT.Name = "colGT";
            this.colGT.ReadOnly = true;
            // 
            // colNS
            // 
            this.colNS.DataPropertyName = "NGAYSINH";
            this.colNS.HeaderText = "Ngày sinh";
            this.colNS.Name = "colNS";
            this.colNS.ReadOnly = true;
            // 
            // colMaLop
            // 
            this.colMaLop.DataPropertyName = "MALOPPHUTRACH";
            this.colMaLop.HeaderText = "MaLopPhuTrach";
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.ReadOnly = true;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDT";
            this.colSDT.HeaderText = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.ReadOnly = true;
            // 
            // colCMND
            // 
            this.colCMND.DataPropertyName = "CMND";
            this.colCMND.HeaderText = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.ReadOnly = true;
            // 
            // colCHUCVU
            // 
            this.colCHUCVU.DataPropertyName = "CHUCVU";
            this.colCHUCVU.HeaderText = "Chức vụ";
            this.colCHUCVU.Name = "colCHUCVU";
            this.colCHUCVU.ReadOnly = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThemMoi,
            this.btnSua,
            this.btnXoa,
            this.btnDong});
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemMoi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Caption = "Thêm mới thông tin";
            this.btnThemMoi.Id = 1;
            this.btnThemMoi.ImageOptions.Image = global::Quan_li_diem_HS_tieu_hoc.Properties.Resources.Actions_contact_new_icon__21_;
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemMoi_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa thông tin";
            this.btnSua.Id = 2;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa thông tin";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = global::Quan_li_diem_HS_tieu_hoc.Properties.Resources.Actions_application_exit_icon__32_;
            this.btnXoa.Name = "btnXoa";
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 4;
            this.btnDong.ImageOptions.Image = global::Quan_li_diem_HS_tieu_hoc.Properties.Resources.Windows_Turn_Off_icon__32_;
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(859, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 446);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(859, 43);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 446);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(859, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 446);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // frmDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridThongTin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDanhSachNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCHUCVU;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThemMoi;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}