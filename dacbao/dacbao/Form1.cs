using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dacbao
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		DataTable tblKHACHHANG, tblPHIEUDATBAO, tblCTDATBAO, tblTAPCHI;
		SqlDataAdapter daPDB, daCTDB, daKH, daTC;

        
        BindingManagerBase bindPDB, bindCTDB;
		bool capNhat;
		private void loadDSDT()
		{
			cbSDT.DataSource = tblKHACHHANG;
			cbSDT.ValueMember = "MaKH";
			cbSDT.DisplayMember = "DienThoai";//  Field  hiển  thị  cbo
			cbSDT.AutoCompleteMode = AutoCompleteMode.Suggest;  //  Cho  phép  tìm với  kí  tự  bắt  đầu
			cbSDT.AutoCompleteSource = AutoCompleteSource.ListItems;  
		}
		private void cbSDT_SelectedIndexChanged(object sender, EventArgs e)
		{
			 int index = cbSDT.SelectedIndex;
			  if (index >= 0)
				  {
				  txtTenKH.Text = tblKHACHHANG.Rows[index]["TenKH"].ToString();
				  txtDiaChi.Text = tblKHACHHANG.Rows[index]["DiaChi"].ToString();

				  }
			  else
				 {
				txtTenKH.Text = "";
				txtDiaChi.Text = "";
			}

		}
		private void loadTAPCHI()
	{
	cbTapChi.DataSource  =  tblTAPCHI;
	cbTapChi.ValueMember  =   "MaTC";
	cbTapChi.DisplayMember  =   "TenTC";
	cbTapChi.AutoCompleteMode  =   AutoCompleteMode.Suggest;
	cbTapChi.AutoCompleteSource  =   AutoCompleteSource.ListItems;
	cbTapChi.SelectedIndex  =  -1;   //Bỏ  chọn 58	
	}
		private void addColCTDATBAO()
		{
			// Tao DS
			DataSet ds = new DataSet();
			ds.Tables.AddRange(new DataTable[]  {  tblTAPCHI,  tblCTDATBAO
});
			// Tao qh
			DataRelation qh = new DataRelation("FRK_TAPCHI_CTDATBAO", tblTAPCHI.Columns["MaTC"], tblCTDATBAO.Columns["MaTC"]);
			ds.Relations.Add(qh);
			//Tao  cot  phu
			DataColumn cot_TenTC = new DataColumn("TenTC", Type.GetType("System.String"), "Parent(FRK_TAPCHI_CTDATBAO).TenTC");
			DataColumn cot_DonGiaThang = new DataColumn("DonGiaThang", Type.GetType("System.String"), "Parent (FRK_TAPCHI_CTDATBAO).DonGiaThang");
			DataColumn cot_ThanhTien = new DataColumn("ThanhTien", Type.GetType("System.String"), "Parent (FRK_TAPCHI_CTDATBAO).DonGiaThang  *  SoLuong  *(ThangKT   -  ThangBD+ 1) ");
			tblCTDATBAO.Columns.Add(cot_TenTC);
			tblCTDATBAO.Columns.Add(cot_DonGiaThang);
			tblCTDATBAO.Columns.Add(cot_ThanhTien);
		}

        private void loadCTDATBAO()
		{
			bindCTDB  =    this.BindingContext[tblCTDATBAO];
			dgvChiTiet.AutoGenerateColumns =   false;
			dgvChiTiet.DataSource  =  tblCTDATBAO;
		}

       

        private void bdPDB_PositionChanged(object sender, EventArgs e) 
		{
	tblCTDATBAO.DefaultView.RowFilter  =   "SoPhieu='"  +  txtSoPhieu.Text + "'";
	int s = 0;
	foreach  (DataRowView r  in  tblCTDATBAO.DefaultView)
	{
	s  +=  int.Parse(  r["ThanhTien"].ToString());
	}
			txtTong.Text = s.ToString();
		}

       
        private void loadDSDATBAO()
	{
	//Tao  lien  ket  tblPHIEUDATBAO  voi  cac  control
	txtSoPhieu.DataBindings.Add("text",  tblPHIEUDATBAO,  "SoPhieu", true);
	dtNgayDat.DataBindings.Add("value",  tblPHIEUDATBAO,  "NgayDat", true);
	cbSDT.DataBindings.Add("SelectedValue",  tblPHIEUDATBAO,  "MaKH", true);
	bindPDB  =     this.BindingContext[tblPHIEUDATBAO];
	//Đăng  Ký  Event  PositionChanged  xu  ly  bởi  bdPDB_PositionChanged (object sender, EventArgs e)
	bindPDB.PositionChanged  +=   new EventHandler(bdPDB_PositionChanged);
	}

        

        private void ennableButton()
{
	btnNewDB.Enabled  =  !capNhat;
	bntSua.Enabled  =  !capNhat;
	btnDeleteDB.Enabled  =  !capNhat;
	bntGhi.Enabled = capNhat;
	bntKhongGhi.Enabled  =  capNhat;
	bntThemCT.Enabled  =  capNhat;
	bntXoaCT.Enabled  =  capNhat;
	dgvCTDatBao.Enabled  =  capNhat;
		}

        

        private void MH_Dat_Bao_Load(object sender, EventArgs e)
	{
	tblKHACHHANG  =   new DataTable();
	tblPHIEUDATBAO  =   new DataTable();
	tblCTDATBAO  =   new DataTable();
	tblTAPCHI  =  new DataTable();
	daKH  =  new SqlDataAdapter("Select  *  from  KHACHHANG" , model.cnnStr);
	daPDB  =  new SqlDataAdapter("Select  *  from  PHIEUDATBAO", model.cnnStr);
	daCTDB  =  new SqlDataAdapter("Select  *  from  CTDATBAO" , model.cnnStr);
	daTC  =  new SqlDataAdapter("Select  *  from  TAPCHI", model.cnnStr); 
	try
 

	{
	daKH.Fill(tblKHACHHANG);
	daPDB.Fill(tblPHIEUDATBAO);
	daCTDB.Fill(tblCTDATBAO);
	daTC.Fill(tblTAPCHI);
	SqlCommandBuilder cmdPDB = new SqlCommandBuilder(daPDB); 
	SqlCommandBuilder cmdCTDB = new SqlCommandBuilder(daCTDB);
	
	}
	catch  (SqlException ex)
	{
	MessageBox.Show(ex.ToString());
	}
	loadDSDT();
	loadTAPCHI();
	addColCTDATBAO();
	loadCTDATBAO();
	loadDSDATBAO();
	bdPDB_PositionChanged(sender, e);
	capNhat  =  false;
	ennableButton();
	}

       

        private void dgvChiTiet_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewRow r in dgvChiTiet.Rows)
				r.Cells[0].Value = r.Index + 1;

		}

       

        private void btnFirst_Click(object sender, EventArgs e)
		{
			bindPDB.Position = 0;
		}

       

        private void btnPrevious_Click(object sender, EventArgs e)
		{
			if (bindPDB.Position > 0)
				bindPDB.Position = 1;
		}

        

        private void btnNext_Click(object sender, EventArgs e)
		{
			if (bindPDB.Position < bindPDB.Count - 1)
				bindPDB.Position += 1;
		}

       

        private void btnLast_Click(object sender, EventArgs e)
		{
			bindPDB.Position = bindPDB.Count - 1;
		}

        

        private void btnexit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

       

        private void bntThemCT_Click(object sender, EventArgs e)
		{
			if(cbTapChi.SelectedIndex==-1)
            {
				MessageBox.Show("chưa chọn tạp chí!!!!");
				return;
            }
			int count = tblCTDATBAO.Select("SoPhieu  =  '" + txtSoPhieu.Text +"'  and  MaTC='" + cbTapChi.SelectedValue + "'").Count();
			if (count > 0)
            {
				MessageBox.Show("tạp chí đã tồn tại, vui lòng chọn tạp chí khác");
				return;
			}
			DataRow r = tblCTDATBAO.NewRow();
			r["MaTC"]=cbTapChi.SelectedValue;
			r["SoPhieu"]= txtSoPhieu.Text;
			r["SoLuong"] = nudsl.Value;
			r["ThangBD"] = nudbd.Value;
			r["ThangKT"] = nudkt.Value;
			tblCTDATBAO.Rows.Add(r);
			bdPDB_PositionChanged(sender, e);

		}
		private void bntXoaCT_Click(object sender, EventArgs e)
		{
			int index = bindCTDB.Position;
			if (index >= 0)
				bindCTDB.RemoveAt(index);
		}
		private void bntKhongGhi_Click(object sender, EventArgs e)
		{
			bindCTDB.CancelCurrentEdit();
			tblCTDATBAO.RejectChanges();
			bindPDB.CancelCurrentEdit();
			tblPHIEUDATBAO.RejectChanges();
			bdPDB_PositionChanged(sender, e);
			capNhat = false;
			ennableButton();
		}
		private void btnNewDB_Click(object sender, EventArgs e)
		{
			bindPDB.AddNew();
			dtNgayDat.Value = DateTime.Now;
            try
            {
				SqlCommand cmm = new SqlCommand("select dbo.fn_createMaPDB()", model.cnn);
				model.cnn.Open();
				txtSoPhieu.Text = cmm.ExecuteScalar().ToString();
				capNhat = true;
				ennableButton();
            }
			catch(SqlException ex)
            {
				MessageBox.Show(ex.ToString());
            }
			model.cnn.Close();
		}
		private void bntGhi_Click(object sender, EventArgs e)
		{
			if( cbSDT.SelectedIndex==-1)
            {
				MessageBox.Show("chia chon khach hang ");
				return;
            }
            try
            {
				bindPDB.EndCurrentEdit();
				daPDB.Update(tblCTDATBAO);
				tblCTDATBAO.AcceptChanges();
				MessageBox.Show("cập nhật thành công");
				capNhat = false;
				ennableButton();
            }
			catch(SqlException ex)
            {
				tblCTDATBAO.RejectChanges();
				tblPHIEUDATBAO.RejectChanges();
				MessageBox.Show(ex.ToString());
            }
		}
		private void bntSua_Click(object sender, EventArgs e)
		{
			capNhat = true;
			ennableButton();
		}
		private void btnDeleteDB_Click(object sender, EventArgs e)
		{
			try
            {
				var row =tblCTDATBAO.Select("SoPhieu='" + txtSoPhieu.Text + "'");
				foreach (DataRow r in row)
					r.Delete();
				daCTDB.Update(tblCTDATBAO);
				tblCTDATBAO.AcceptChanges();
				bindPDB.RemoveAt(bindPDB.Position);
				daPDB.Update(tblPHIEUDATBAO);
				tblPHIEUDATBAO.AcceptChanges();
				MessageBox.Show("Thanh cong!!!");
            }
			catch(SqlException ex)
            {
				tblCTDATBAO.RejectChanges();
				tblPHIEUDATBAO.RejectChanges();
				MessageBox.Show(ex.ToString());
            }
		}
	}
}
