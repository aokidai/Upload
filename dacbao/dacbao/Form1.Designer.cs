namespace dacbao
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.grpBu = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.cbSDT = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.bntKhongGhi = new System.Windows.Forms.Button();
            this.bntGhi = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.btnDeleteDB = new System.Windows.Forms.Button();
            this.btnNewDB = new System.Windows.Forms.Button();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntThemCT = new System.Windows.Forms.Button();
            this.bntXoaCT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTapChi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudsl = new System.Windows.Forms.NumericUpDown();
            this.nudbd = new System.Windows.Forms.NumericUpDown();
            this.nudkt = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.dgvCTDatBao = new System.Windows.Forms.GroupBox();
            this.grpThongTin.SuspendLayout();
            this.grpBu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudbd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudkt)).BeginInit();
            this.dgvCTDatBao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(247, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU ĐẶT BÁO";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.grpBu);
            this.grpThongTin.Controls.Add(this.dtNgayDat);
            this.grpThongTin.Controls.Add(this.cbSDT);
            this.grpThongTin.Controls.Add(this.txtDiaChi);
            this.grpThongTin.Controls.Add(this.txtTenKH);
            this.grpThongTin.Controls.Add(this.txtSoPhieu);
            this.grpThongTin.Controls.Add(this.label7);
            this.grpThongTin.Controls.Add(this.label4);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Controls.Add(this.label5);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Location = new System.Drawing.Point(26, 58);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpThongTin.Size = new System.Drawing.Size(643, 200);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tinh phiếu đặt báo";
            // 
            // grpBu
            // 
            this.grpBu.Controls.Add(this.btnLast);
            this.grpBu.Controls.Add(this.btnNext);
            this.grpBu.Controls.Add(this.btnPrevious);
            this.grpBu.Controls.Add(this.btnFirst);
            this.grpBu.Location = new System.Drawing.Point(17, 135);
            this.grpBu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpBu.Name = "grpBu";
            this.grpBu.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpBu.Size = new System.Drawing.Size(608, 49);
            this.grpBu.TabIndex = 4;
            this.grpBu.TabStop = false;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(127, 18);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(36, 29);
            this.btnLast.TabIndex = 0;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(86, 18);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 29);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(46, 18);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(36, 29);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(5, 18);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(36, 29);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Location = new System.Drawing.Point(335, 43);
            this.dtNgayDat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(275, 20);
            this.dtNgayDat.TabIndex = 3;
            // 
            // cbSDT
            // 
            this.cbSDT.FormattingEnabled = true;
            this.cbSDT.Location = new System.Drawing.Point(68, 75);
            this.cbSDT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbSDT.Name = "cbSDT";
            this.cbSDT.Size = new System.Drawing.Size(194, 21);
            this.cbSDT.TabIndex = 2;
            this.cbSDT.SelectedIndexChanged += new System.EventHandler(this.cbSDT_SelectedIndexChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(335, 69);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(275, 54);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(68, 107);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(194, 20);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(68, 42);
            this.txtSoPhieu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(194, 20);
            this.txtSoPhieu.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số dt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phiếu";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(781, 171);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(60, 29);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // bntKhongGhi
            // 
            this.bntKhongGhi.Location = new System.Drawing.Point(781, 136);
            this.bntKhongGhi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bntKhongGhi.Name = "bntKhongGhi";
            this.bntKhongGhi.Size = new System.Drawing.Size(60, 29);
            this.bntKhongGhi.TabIndex = 0;
            this.bntKhongGhi.Text = "Không ghi";
            this.bntKhongGhi.UseVisualStyleBackColor = true;
            this.bntKhongGhi.Click += new System.EventHandler(this.bntKhongGhi_Click);
            // 
            // bntGhi
            // 
            this.bntGhi.Location = new System.Drawing.Point(781, 99);
            this.bntGhi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bntGhi.Name = "bntGhi";
            this.bntGhi.Size = new System.Drawing.Size(60, 29);
            this.bntGhi.TabIndex = 0;
            this.bntGhi.Text = "Ghi";
            this.bntGhi.UseVisualStyleBackColor = true;
            this.bntGhi.Click += new System.EventHandler(this.bntGhi_Click);
            // 
            // bntSua
            // 
            this.bntSua.Location = new System.Drawing.Point(696, 136);
            this.bntSua.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(60, 29);
            this.bntSua.TabIndex = 0;
            this.bntSua.Text = "Sửa";
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.Location = new System.Drawing.Point(696, 171);
            this.btnDeleteDB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(60, 29);
            this.btnDeleteDB.TabIndex = 0;
            this.btnDeleteDB.Text = "Xóa";
            this.btnDeleteDB.UseVisualStyleBackColor = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
            // 
            // btnNewDB
            // 
            this.btnNewDB.Location = new System.Drawing.Point(696, 101);
            this.btnNewDB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNewDB.Name = "btnNewDB";
            this.btnNewDB.Size = new System.Drawing.Size(60, 29);
            this.btnNewDB.TabIndex = 0;
            this.btnNewDB.Text = "Thêm";
            this.btnNewDB.UseVisualStyleBackColor = true;
            this.btnNewDB.Click += new System.EventHandler(this.btnNewDB_Click);
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.TenTC,
            this.ThangBD,
            this.ThangKT,
            this.SoLuong,
            this.MaTC,
            this.SoTien});
            this.dgvChiTiet.Location = new System.Drawing.Point(16, 164);
            this.dgvChiTiet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.Size = new System.Drawing.Size(895, 195);
            this.dgvChiTiet.TabIndex = 2;
            this.dgvChiTiet.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvChiTiet_DataBindingComplete);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // TenTC
            // 
            this.TenTC.DataPropertyName = "TenTC";
            this.TenTC.HeaderText = "Tên tập chí";
            this.TenTC.MinimumWidth = 6;
            this.TenTC.Name = "TenTC";
            this.TenTC.Width = 250;
            // 
            // ThangBD
            // 
            this.ThangBD.DataPropertyName = "ThangBD";
            this.ThangBD.HeaderText = "Tháng bắt đầu";
            this.ThangBD.MinimumWidth = 6;
            this.ThangBD.Name = "ThangBD";
            this.ThangBD.Width = 125;
            // 
            // ThangKT
            // 
            this.ThangKT.DataPropertyName = "ThangKT";
            this.ThangKT.HeaderText = "Tháng kết thúc";
            this.ThangKT.MinimumWidth = 6;
            this.ThangKT.Name = "ThangKT";
            this.ThangKT.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // MaTC
            // 
            this.MaTC.DataPropertyName = "DonGiaThang";
            this.MaTC.HeaderText = "Đơn Giá Tháng";
            this.MaTC.MinimumWidth = 6;
            this.MaTC.Name = "MaTC";
            this.MaTC.Width = 125;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "ThanhTien";
            this.SoTien.HeaderText = "Thành Tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.Width = 125;
            // 
            // bntThemCT
            // 
            this.bntThemCT.Location = new System.Drawing.Point(622, 88);
            this.bntThemCT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bntThemCT.Name = "bntThemCT";
            this.bntThemCT.Size = new System.Drawing.Size(92, 29);
            this.bntThemCT.TabIndex = 0;
            this.bntThemCT.Text = "Thêm chi tiết";
            this.bntThemCT.UseVisualStyleBackColor = true;
            this.bntThemCT.Click += new System.EventHandler(this.bntThemCT_Click);
            // 
            // bntXoaCT
            // 
            this.bntXoaCT.Location = new System.Drawing.Point(736, 87);
            this.bntXoaCT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bntXoaCT.Name = "bntXoaCT";
            this.bntXoaCT.Size = new System.Drawing.Size(82, 29);
            this.bntXoaCT.TabIndex = 0;
            this.bntXoaCT.Text = "Xóa chi tiết";
            this.bntXoaCT.UseVisualStyleBackColor = true;
            this.bntXoaCT.Click += new System.EventHandler(this.bntXoaCT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên Tạp Chí";
            // 
            // cbTapChi
            // 
            this.cbTapChi.FormattingEnabled = true;
            this.cbTapChi.Location = new System.Drawing.Point(129, 80);
            this.cbTapChi.Name = "cbTapChi";
            this.cbTapChi.Size = new System.Drawing.Size(121, 21);
            this.cbTapChi.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số Lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tháng BD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(500, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tháng KT";
            // 
            // nudsl
            // 
            this.nudsl.Location = new System.Drawing.Point(335, 85);
            this.nudsl.Name = "nudsl";
            this.nudsl.Size = new System.Drawing.Size(47, 20);
            this.nudsl.TabIndex = 6;
            // 
            // nudbd
            // 
            this.nudbd.Location = new System.Drawing.Point(446, 87);
            this.nudbd.Name = "nudbd";
            this.nudbd.Size = new System.Drawing.Size(47, 20);
            this.nudbd.TabIndex = 6;
            // 
            // nudkt
            // 
            this.nudkt.Location = new System.Drawing.Point(561, 87);
            this.nudkt.Name = "nudkt";
            this.nudkt.Size = new System.Drawing.Size(47, 20);
            this.nudkt.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Tổng Tiền";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(129, 116);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(121, 20);
            this.txtTong.TabIndex = 8;
            // 
            // dgvCTDatBao
            // 
            this.dgvCTDatBao.Controls.Add(this.txtTong);
            this.dgvCTDatBao.Controls.Add(this.label12);
            this.dgvCTDatBao.Controls.Add(this.nudkt);
            this.dgvCTDatBao.Controls.Add(this.nudbd);
            this.dgvCTDatBao.Controls.Add(this.nudsl);
            this.dgvCTDatBao.Controls.Add(this.label11);
            this.dgvCTDatBao.Controls.Add(this.label9);
            this.dgvCTDatBao.Controls.Add(this.label8);
            this.dgvCTDatBao.Controls.Add(this.cbTapChi);
            this.dgvCTDatBao.Controls.Add(this.label6);
            this.dgvCTDatBao.Controls.Add(this.bntXoaCT);
            this.dgvCTDatBao.Controls.Add(this.dgvChiTiet);
            this.dgvCTDatBao.Controls.Add(this.bntThemCT);
            this.dgvCTDatBao.Location = new System.Drawing.Point(12, 264);
            this.dgvCTDatBao.Name = "dgvCTDatBao";
            this.dgvCTDatBao.Size = new System.Drawing.Size(938, 255);
            this.dgvCTDatBao.TabIndex = 9;
            this.dgvCTDatBao.TabStop = false;
            this.dgvCTDatBao.Text = "Chi tiết đặt báo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1093, 610);
            this.Controls.Add(this.dgvCTDatBao);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.bntGhi);
            this.Controls.Add(this.bntKhongGhi);
            this.Controls.Add(this.btnDeleteDB);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnNewDB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MH_Dat_Bao_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpBu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudbd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudkt)).EndInit();
            this.dgvCTDatBao.ResumeLayout(false);
            this.dgvCTDatBao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpBu;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button bntKhongGhi;
        private System.Windows.Forms.Button bntGhi;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button btnDeleteDB;
        private System.Windows.Forms.Button btnNewDB;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.ComboBox cbSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Button bntThemCT;
        private System.Windows.Forms.Button bntXoaCT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTapChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudsl;
        private System.Windows.Forms.NumericUpDown nudbd;
        private System.Windows.Forms.NumericUpDown nudkt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.GroupBox dgvCTDatBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
    }
}

