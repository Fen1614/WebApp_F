using System;
using System.Data.SqlClient;

namespace WebApp_F {
    public partial class ch8_2_1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string s_ConnS = "";
            s_ConnS += "server=localhost;";
            s_ConnS += "database=Test;";
            s_ConnS += "user id=sa;";
            s_ConnS += "password=a74123698;";

            SqlConnection o_Conn = new SqlConnection(s_ConnS);
            o_Conn.Open();
            //各種資料庫操作
            Response.Write("Connecction");
            o_Conn.Close();
        }
    }
}