using System;
using System;
using System.Data;
using System.Data.SqlClient;

namespace WebApp_F {
    public partial class ch8_3_3 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string s_ConnS = "";

            s_ConnS = "Data Source=(localdb)\\ProjectsV13;" +
                "Initial Catalog=Test;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False;" +
                "User ID = sa; Password = 12345";

            try
            {
                SqlConnection o_Conn = new SqlConnection(s_ConnS);
                o_Conn.Open();
                SqlDataAdapter o_A = new SqlDataAdapter();
                
                SqlCommand o_Cmd = new SqlCommand("Insert into Users (Id, Name, Birthday) " +
                                        "values(@Id, @Name, @DateTime)", o_Conn);
                o_Cmd.Parameters.Add("@Id", SqlDbType.Int);
                o_Cmd.Parameters["@Id"].Value = 3;
                o_Cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                o_Cmd.Parameters["@Name"].Value = "雅美每";
                o_Cmd.Parameters.Add("@DateTime", SqlDbType.DateTime);
                o_Cmd.Parameters["@DateTime"].Value = "2021/11/11";                
                o_A.InsertCommand = o_Cmd;
                o_Conn.Close();


                o_A = null;
                o_Conn.Open();
                o_A = new SqlDataAdapter("Select * from Users", o_Conn);
                DataSet o_D = new DataSet();
                o_A.Fill(o_D, "ds_Res");
                gv_DataShow.DataSource = o_D;
                gv_DataShow.DataBind();
                o_Conn.Close();

            }
            catch (Exception o_Exc){
                Response.Write(o_Exc.ToString());
            }

        }
    }
}