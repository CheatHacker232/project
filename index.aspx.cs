using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    public string msg = " ";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["submit"] != null)
        {
            string user_id = Request.Form["id"];
            string sql = "select * from users where id='" + user_id + "'";

                sql = "select count(id) from USERS";
                SqlDataReader sqd=DalBll.SelectQuery(sql);
                sqd.Read();
                int id = sqd.GetInt32(0);
                string fname = Request.Form["fname"];
                string email = Request.Form["email"];
                string occupation = Request.Form["occupation"];
                string quantity = Request.Form["quantity"];
                sql = "INSERT into USERS(id,fname,email,occupation,quantity) values(";
                sql += id.ToString() + ",";
                sql += "'" + fname + "',";
                sql += "'" + email + "',";
                sql += "'" + occupation + "',";
                sql += "'" + quantity + "');";
                DalBll.DoQuery(sql);
                msg = "Enjoy your sandwich!";

            }
        }
    }