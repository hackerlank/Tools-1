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
        clsDatabase cls = new clsDatabase();
        private void LoadDatabase()
        {
            try
            {
                string query = "Select name from Sys.Databases"; // sẽ tối ưu hơn khi loại bỏ database của system.
                cmbDatabase.DataSource = cls.lstValue(query, "name");  
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
        private void Tools_Load(object sender, EventArgs e)
        {
            cls.Server = "DMC-PC";
            cls.Database = "georgetown_TayHo";
            cls.User = "sa";
            cls.Password = "dmc3star";
            LoadDatabase();
            LoadDistrict();
        }

        //ds1.Tables[0].Merge(ds2.Tables[0]);
    }
}
