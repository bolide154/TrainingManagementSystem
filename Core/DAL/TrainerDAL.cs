using Core.BLL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
   public static class TrainerDAL
    {
        public static Connection _conndb = new Connection();
        public static TrainerBLL getTrainerById(StaffBLL staffBLL)
        {
            string sql = "SELECT * FROM [trainers] t INNER JOIN [staffs] s ON t.trainerid=s.trainerid WHERE s.staffid=" + staffBLL.StaffId;
            DataTable dt = new DataTable();
            dt = TrainerDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new TrainerBLL(Int32.Parse(row["trainerid"].ToString()), row["emailaddress"].ToString(), row["trainername"].ToString(), Convert.ToBoolean(row["internaltype"]), row["workingplace"].ToString(), row["telephone"].ToString());
            }
            return null;
        }
        //
        //public static TrainerBLL getTrainertopicById(int trainerId)
        //{
        //    string sql = "SELECT * FROM [trainers] where trainerid=" + trainerId;
        //    DataTable dt = new DataTable();
        //    dt = TrainerDAL._conndb.getDataTable(sql);
        //    if (dt.Rows.Count > 0)
        //    {
        //        DataRow row = dt.Rows[0];
        //        return new TrainerBLL(Int32.Parse(row["trainerid"].ToString()), row["emailaddress"].ToString(), row["trainername"].ToString(),Boolean.Parse(row["internaltype"].ToString()), row["workingplace"].ToString(), row["telephone"].ToString()); 
        //    }
        //    return null;
        //}
        //
        public static void saveTrainerinfomation(TrainerBLL trainerBLL)
        {
            string sql = "UPDATE [trainers] SET emailaddress= N'" + trainerBLL.EmailAddress + "',trainername= N'" + trainerBLL.TrainerName + "',internaltype='" + trainerBLL.InternalType + "',workingplace = N'" + trainerBLL.WorkingPlace + "',telephone='" + trainerBLL.Telephone +   "' Where trainerid =" + trainerBLL.TrainerId;
            TrainerDAL._conndb.ExecuteNonQuery(sql);
        }
    }
}
