using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class StaffDAL
    {
        public static Connection _conndb = new Connection();

        public static StaffBLL getStaffById(int staffId)
        {
            string sql = "SELECT * FROM [staffs] WHERE staffid="+staffId;
            DataTable dt = new DataTable();
            dt = StaffDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new StaffBLL(Int32.Parse(row["staffid"].ToString()), row["role"].ToString(), ((row["trainerid"].ToString().Equals(null)) ? Int32.Parse(row["trainerid"].ToString()) : 0), row["password"].ToString(), row["displayname"].ToString());
            }
            return null;
        }
    }
}
