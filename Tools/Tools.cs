using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools
{
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }
        string DiaChiXMLMayDich = Application.StartupPath + @"\DatabaseDest.xml";
        private string _Server="";
        private string _Database = "";
        private string _User = "";
        private string _Pass = "";

        string DiaChiXMLMayNguon = Application.StartupPath + @"\DatabaseSource.xml";
        private string curServer = "";
        private string curDatabase = "";
        private string curUser = "";
        private string curPass = "";
        private string curTenQuan = "";
        private string curMaxID_DV1 = "";
        private string curMaxID_DV2 = "";
        private string curMaxID_DV3 = "";
        private bool curDV1 = false;
        private bool curDV2 = false;
        private bool curDV3 = false;
        private string curThoiDiemTao = "";


        clsDatabase cls = new clsDatabase();
        clsXML xml = new clsXML();

        
        private void Tools_Load(object sender, EventArgs e)
        {
            LayThongTinMayChuLuuDuLieu();
            LoadServer();
            LoadDatabase();
            LoadDistrict();
            LoadThoiDiemTao();
            LoadThongTinDatabaselenTreeView();
            TrangThaiBanDau();
        }


        #region "Giao Diện"
        private void LoadServer()
        {
            try
            {
                cmbServer.DataSource = xml.getListServer(DiaChiXMLMayNguon);
            }
            catch (Exception)
            {
            }
        }
        private void LoadDatabase()
        {
            try
            {
                cmbDatabase.DataSource = xml.getListDatabase(DiaChiXMLMayNguon);
            }
            catch (Exception)
            {
                
            }
                      
        }
        private void LoadDistrict()
        {
            cmbDistrict.Items.Add("huyện Thanh Trì");
            cmbDistrict.Items.Add("quận Ba Đình");
            cmbDistrict.Items.Add("quận Cầu Giấy");
            cmbDistrict.Items.Add("quận Hoàn Kiếm");
            cmbDistrict.Items.Add("quận Hoàng Mai");
            cmbDistrict.Items.Add("quận Long Biên");
            cmbDistrict.Items.Add("quận Tây Hồ");
            cmbDistrict.Items.Add("quận Thanh Xuân");
            cmbDistrict.Items.Add("....");
        }
        private void LoadThoiDiemTao()
        {
            try
            {
                cmbThoiDiemTao.DataSource = xml.getListThoiDiemTao(DiaChiXMLMayNguon);
            }
            catch (Exception)
            {

            }
        }

        int flag = 0;
        private void TrangThaiBanDau() {
            cmbDatabase.Enabled = cmbDistrict.Enabled = cmbServer.Enabled = txtUser.Enabled = txtPassword.Enabled = btnOK.Enabled = btnCancel.Enabled = false;
            btnAddDB.Enabled = btnEditDB.Enabled = btnDeleteDB.Enabled = true;
        }
        private void TrangThaiChucNang() {
            cmbDatabase.Enabled = cmbDistrict.Enabled = cmbServer.Enabled = txtUser.Enabled = txtPassword.Enabled = btnOK.Enabled = btnCancel.Enabled = true;
            btnAddDB.Enabled = btnEditDB.Enabled = btnDeleteDB.Enabled = false;
        }
        private void TrangThaiKetThuc() {
            cmbDatabase.Enabled = cmbDistrict.Enabled = cmbServer.Enabled = txtUser.Enabled = txtPassword.Enabled = btnOK.Enabled = btnCancel.Enabled = false;
            btnAddDB.Enabled = btnEditDB.Enabled = btnDeleteDB.Enabled = true;

            flag = 0;
        }       
        private void btnAddDB_Click(object sender, EventArgs e)
        {
            flag = 1;
            TrangThaiChucNang();
            
        }
        private void btnEditDB_Click(object sender, EventArgs e)
        {
            flag = 2;
            TrangThaiChucNang();
        }
        private void btnDeleteDB_Click(object sender, EventArgs e)
        {
            flag = 3;
            TrangThaiChucNang();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                ThemThongTinDatabase();
            else if (flag == 2)
                CapNhatThongTinDatabase(cmbThoiDiemTao.Text);
            else if (flag == 3)
                XoaThongTinDatabase(cmbThoiDiemTao.Text);
            else
                MessageBox.Show("Không có hành động nào được đề xuất.");


            LoadThongTinDatabaselenTreeView();
            TrangThaiKetThuc();           
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadThongTinDatabaseToTextBox(cmbThoiDiemTao.Text);
            TrangThaiKetThuc();    
        }
        private void btnDB_Click(object sender, EventArgs e)
        {
            DB NoiLuuDuLieu = new DB();
            NoiLuuDuLieu.fileName = DiaChiXMLMayDich;
            NoiLuuDuLieu.ShowDialog();
            LayThongTinMayChuLuuDuLieu();
        }
        private void LayThongTinMayChuLuuDuLieu()
        {
            bool result = xml.GetDatabaseDestInfo(DiaChiXMLMayDich, ref _Database, ref  _Server, ref  _User, ref  _Pass);
        }

        
        private void LoadThongTinDatabaselenTreeView()
        {
            trvDatabase.Nodes.Clear();
            TreeNode root = new TreeNode("Tất cả ");
            trvDatabase.Nodes.Add(root);
            // lấy danh sách thời điểm tạo
            List<string> lstThoiDiemTao = xml.getListThoiDiemTao(DiaChiXMLMayNguon);
            lstThoiDiemTao.Sort();
            // từ từng thời điểm tạo ta lấy thông tin và tạo node cho treeview
            if (lstThoiDiemTao != null)
            {
                if(lstThoiDiemTao.Count>0)
                {
                    for (int i = 0; i < lstThoiDiemTao.Count; i++)
                    {
                        LayThongTinDatabase(lstThoiDiemTao[i]);
                        TreeNode node = new TreeNode(curDatabase);
                        node.Name = curThoiDiemTao;
                        
                        TreeNode _nodeDV1 = new TreeNode("Dịch vụ 1 (maxID: " + curMaxID_DV1 + ")");
                        TreeNode _nodeDV2 = new TreeNode("Dịch vụ 2 (maxID: " + curMaxID_DV2 + ")");
                        TreeNode _nodeDV3 = new TreeNode("Dịch vụ 3 (maxID: " + curMaxID_DV3 + ")");
                        _nodeDV1.Name = "DichVu1";
                        _nodeDV2.Name = "DichVu2";
                        _nodeDV3.Name = "DichVu3";
                        _nodeDV1.Checked = Convert.ToBoolean(curDV1);
                        _nodeDV2.Checked = Convert.ToBoolean(curDV2);
                        _nodeDV3.Checked = Convert.ToBoolean(curDV3);

                        node.Nodes.Add(_nodeDV1);
                        node.Nodes.Add(_nodeDV2);
                        node.Nodes.Add(_nodeDV3);

                        root.Nodes.Add(node);

                        setParaEmpty();
                    }
                }
            }

        }
        private void LayThongTinDatabase(string ThoiDiemTao) {
            setParaEmpty();
            curThoiDiemTao = ThoiDiemTao;
            bool success = xml.GetDatabaseSourceInfo(DiaChiXMLMayNguon, ref curDatabase, ref curServer, ref curUser, ref curPass, ref curTenQuan, ref curMaxID_DV1, ref curMaxID_DV2, ref curMaxID_DV3, ref curDV1, ref curDV2, ref curDV3, ref curThoiDiemTao);
        }
        private void LoadThongTinDatabaseToTextBox(string ThoiDiemTao)
        {
            LayThongTinDatabase(ThoiDiemTao);
            cmbDatabase.Text = curDatabase;
            cmbServer.Text = curServer;
            cmbDistrict.Text = curTenQuan;
            cmbThoiDiemTao.Text = curThoiDiemTao;
            txtUser.Text = curUser;
            txtPassword.Text = curPass;
        }
        private void cmbThoiDiemTao_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongTinDatabaseToTextBox(cmbThoiDiemTao.Text.Trim());
        }

        private void ThemThongTinDatabase()
        {
            bool success = xml.AddDatabaseSourceInfo(DiaChiXMLMayNguon, cmbDatabase.Text, cmbServer.Text, txtUser.Text, txtPassword.Text, cmbDistrict.Text, "0", "0", "0", true, true, true, DateTime.Now.ToString());
            if(success)
            {
                MessageBox.Show("Thêm thành công.");
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }

        }
        private void CapNhatThongTinDatabase(string ThoiDiemTao) {
            bool success = xml.EditDatabaseSourceInfo(DiaChiXMLMayNguon, cmbDatabase.Text, cmbServer.Text, txtUser.Text, txtPassword.Text, cmbDistrict.Text,curMaxID_DV1,curMaxID_DV2,curMaxID_DV3,curDV1,curDV2,curDV3,curThoiDiemTao);
            if (success)
            {
                MessageBox.Show("Thành công.");
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
            
        }
        private void XoaThongTinDatabase(string ThoiDiemTao) {
            bool success = xml.DeleteDatabaseSourceInfo(DiaChiXMLMayNguon, curThoiDiemTao);
            if (success)
            {
                MessageBox.Show("Thành công.");
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void trvDatabase_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if(selectedNode.Parent == trvDatabase.Nodes[0])
                LoadThongTinDatabaseToTextBox(selectedNode.Name);
        }
        private void setParaEmpty()
        {
            curServer = "";
            curDatabase = "";
            curUser = "";
            curPass = "";
            curTenQuan = "";
            curMaxID_DV1 = "";
            curMaxID_DV2 = "";
            curMaxID_DV3 = "";
            curDV1 = false;
            curDV2 = false;
            curDV3 = false;
            curThoiDiemTao = "";
        }
        #endregion 



        #region "Chạy chương trình"
        private void XoaDuLieuDaLuuTru() { 
            // xoa du lieu da luu tru
            // cap nhat lai tat ca MaxID ="0";
            
        }
        private void btnGetFullData_Click(object sender, EventArgs e)
        {
            XoaDuLieuDaLuuTru();
            ExeDichVu();
        }
        private void btnCapNhatDuLieu_Click(object sender, EventArgs e)
        {
            ExeDichVu();
        }
        private void ExeDichVu()
        {
            List<string> dsThoiDiemTao = LayDanhSachDatabaseChonTuTreeView();
            if (dsThoiDiemTao != null)
            {
                if (dsThoiDiemTao.Count > 0)
                {
                    for (int i = 0; i < dsThoiDiemTao.Count; i++)
                    {
                        ExeDichVu1(dsThoiDiemTao[i]);
                        ExeDichVu2(dsThoiDiemTao[i]);
                        ExeDichVu3(dsThoiDiemTao[i]);
                    }
                }
            }
        }
        
        private void ExeDichVu1(string ThoiDiemTao) { }
        private void ExeDichVu2(string ThoiDiemTao) { }
        private void ExeDichVu3(string ThoiDiemTao) { }


        #region "Xử lý treeview"
        private void trvDatabase_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode node = e.Node;
                if (node != null)
                    if (node.Checked == true)
                    {
                        TreenodeCheckAllChild(node);
                    }
                    else
                    {
                        if (node.Parent != null)// node không phải là node gốc (root)
                        {
                            TreenodeUnCheckAllChild(node);
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void TreenodeCheckAllChild(TreeNode parent)
        {
            
            if (parent.Nodes.Count > 0)
            {
                for (int i = 0; i < parent.Nodes.Count; i++)
                {
                    TreeNode child = parent.Nodes[i];
                    string s=child.Text;
                    if(child.Checked== false)
                        child.Checked = true;
                    TreenodeCheckAllChild(child);
                }
            }
        }
        private void TreenodeUnCheckAllChild(TreeNode parent)
        {

            if (parent.Nodes.Count > 0)
            {
                for (int i = 0; i < parent.Nodes.Count; i++)
                {
                    TreeNode child = parent.Nodes[i];
                    string s = child.Text;
                    if (child.Checked == true)
                        child.Checked = false;
                    TreenodeUnCheckAllChild(child);
                }
            }
        }

        private List<string> LayDanhSachDatabaseChonTuTreeView()
        {
            List<string> lstDatabase = new List<string>();
            TreeNode root = trvDatabase.Nodes[0];
            if (root != null)
            {
                if(root.Nodes.Count>0)
                {
                    for (int i = 0; i < root.Nodes.Count; i++)
                    {
                        if (root.Nodes[i].Checked)
                        {
                            CapNhatDichVuTrongDatabaseDaChon(root.Nodes[i]);
                            lstDatabase.Add(root.Nodes[i].Name);
                        }
                    }
                }
            }
            return lstDatabase;
           
        }
        private void CapNhatDichVuTrongDatabaseDaChon(TreeNode node)
        {
            if (node.Parent == trvDatabase.Nodes[0])
            {
                string ThoiDiemTao = node.Name;
                bool ChonDV1=false;
                bool ChonDV2=false;
                bool ChonDV3=false;

                for( int i=0; i< node.Nodes.Count;i++)
                {
                    if (node.Nodes[i].Name == "DichVu1")
                    {
                        if (node.Nodes[i].Checked)
                            ChonDV1 = true;
                        else
                            ChonDV1 = false;
                    }

                    if (node.Nodes[i].Name == "DichVu2")
                    {
                        if (node.Nodes[i].Checked)
                            ChonDV2 = true;
                        else
                            ChonDV2 = false;
                    }

                    if (node.Nodes[i].Name == "DichVu3")
                    {
                        if (node.Nodes[i].Checked)
                            ChonDV3 = true;
                        else
                            ChonDV3 = false;
                    }
                }
                bool success = xml.EditDatabaseSourceInfo(DiaChiXMLMayNguon, ChonDV1, ChonDV2, ChonDV3, ThoiDiemTao);
            }
        }
        #endregion


        private void ThongBaoHoatDong(string DichVu,string Database, string TrangThai) { }
        #endregion 

        

       
        
    }
}
