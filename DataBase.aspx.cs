using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    public string list;
    protected void Page_Load(object sender, EventArgs e)
    {

        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from users", DalBll.GetConnection());
        da.Fill(ds, "users");
        DataTable dt = ds.Tables["users"];

        list += "<table border=1 cellspacing=5 bgcolor=white>";
        list += "<tr>";
        list += "<td>ID </td>";
        list += "<td>fname</td>";
        list += "<td>email</td>";
        list += "<td>occupation</td>";
        list += "<td>quantity</td>";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            list += "<tr>";
            list += "<td>" + dt.Rows[i]["ID"] + "</td>";
            list += "<td>" + dt.Rows[i]["fname"] + "</td>";
            list += "<td>" + dt.Rows[i]["email"] + "</td>";
            list += "<td>" + dt.Rows[i]["occupation"] + "</td>";
            list += "<td>" + dt.Rows[i]["quantity"] + "</td>";

                list += "<td><a href='Delete.aspx?user=" + dt.Rows[i]["ID"] +"'>Delete</td>";



            list += "</tr>";
        }
        list += "</table>";

    }
}