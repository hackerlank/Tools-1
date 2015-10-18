using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tools
{
    class clsDatabase
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        string connectionstring = "";   
        SqlConnection SqlCon;
        SqlCommand SqlCom;
        SqlDataAdapter SqlDta;

        public bool OpenCon()
        {
            try
            {
                if (Server.Trim() == "" || Database.Trim() == "" || User.Trim() == "" || Password.Trim() == "")
                {
                    return false;
                }
                else
                {
                    connectionstring = "Server=" + Server + ";Database=" + Database + ";User Id=" + User + ";Password=" + Password + ";";
                    if (SqlCon == null)
                        SqlCon = new SqlConnection(connectionstring);
                    else
                    {
                        if (SqlCon.State == ConnectionState.Open)
                            SqlCon.Close();
                        SqlCon.ConnectionString = connectionstring;
                    }
                       
                    if(SqlCon.State == ConnectionState.Closed)
                        SqlCon.Open();
                    return true;
                }
                
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Lỗi trong Open connection : " + ex.Message);
                return false;
            }
        } 
        public bool CloseCon()
        {
            try
            {
                if (SqlCon != null)
                {
                    if (SqlCon.State == ConnectionState.Open)
                        SqlCon.Close();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi trong Close connection : " + ex.Message);
                return false;
            }
        }

        public List<string> lstValue(string query, string returnName)
        {
            try
            {
                List<string> result = new List<string>();
                OpenCon();
                SqlCom = SqlCon.CreateCommand();
                SqlCom.CommandText= query;
                SqlDataReader reader = SqlCom.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(reader[returnName].ToString());
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                CloseCon();
                return null;
            }
        }
        public DataSet GetData(string Query)
        {
            try
            {
                OpenCon();
                SqlCom = SqlCon.CreateCommand();
                SqlCom.CommandText = Query;                  
                DataSet ds = new DataSet();
                SqlDta = new SqlDataAdapter(SqlCom);
                SqlDta.Fill(ds);                 

                CloseCon();
                return ds;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                CloseCon();
                return null;
            }
        }
        public DataSet GetData(string SPName, string[] Paras, string[] Values)
        {
            try
            {
                if(Paras.Length != Values.Length)
                {
                    System.Windows.Forms.MessageBox.Show("Tham số truyền vào không khớp.");
                    return null;
                }
                OpenCon();
                SqlCom = SqlCon.CreateCommand();
                SqlCom.CommandType = CommandType.StoredProcedure;
                SqlCom.CommandText = SPName;
                if (Paras.Length > 0)
                {
                    for (int i = 0; i < Paras.Length; i++)
                    {
                        SqlParameter para = new SqlParameter(Paras[i], Values[i]);
                        SqlCom.Parameters.Add(para);
                    }
                }

                DataSet ds = new DataSet();
                SqlDta = new SqlDataAdapter(SqlCom);
                SqlDta.Fill(ds);    
            

                CloseCon();
                return ds;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                CloseCon();
                return null;
            }
        }

    }
}
