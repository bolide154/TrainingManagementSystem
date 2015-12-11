using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class TraineeDAL
    {
        public static Connection _conndb = new Connection();
        public static List<TraineeBLL> getTraineeList()
        {
            string sql = "SELECT * FROM [trainees]";
            DataTable dt = new DataTable();
            dt = TraineeDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                List<TraineeBLL> traineeList = new List<TraineeBLL>();
                foreach (DataRow row in dt.Rows)
                {
                   traineeList.Add(new TraineeBLL(Int32.Parse(row["traineeid"].ToString()), row["traineename"].ToString(), DateTime.Parse(row["dateofbirth"].ToString()), Int32.Parse(row["toeicscore"].ToString()),row["programlanguage"].ToString(),row["experiencedetails"].ToString(),row["department"].ToString(),row["location"].ToString()) );
                }
                return traineeList;
            }
            return null; 
        }
        //
        public static TraineeBLL getTraineeById(int traineeId)
        {
            string sql = "SELECT * FROM [trainees] where traineeid=" + traineeId;
            DataTable dt = new DataTable();
            dt = TraineeDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new TraineeBLL(Int32.Parse(row["traineeid"].ToString()), row["traineename"].ToString(), DateTime.Parse(row["dateofbirth"].ToString()), Int32.Parse(row["toeicscore"].ToString()), row["programlanguage"].ToString(), row["experiencedetails"].ToString(), row["department"].ToString(), row["location"].ToString());
            }
            return null;
        }
        //
        public static void addTrainee(TraineeBLL traineeBLL)
        {
            String sql = "INSERT INTO [trainees] (traineename,dateofbirth,toeicscore,programlanguage,experiencedetails,department,location) VALUES ( N'" + traineeBLL.TraineeName + "', '" + traineeBLL.DateOfBirth + "',"+ traineeBLL.ToeicScore+",N'"+traineeBLL.ProgramLanguage+"',N'"+traineeBLL.ExperienceDetails+"',N'"+traineeBLL.Department+"',N'"+traineeBLL.Location+"')";
            TraineeDAL._conndb.ExecuteNonQuery(sql);
        }
        public static void saveTrainee(TraineeBLL traineeBLL)
        {
            string sql= "UPDATE [trainees] SET traineename= N'" + traineeBLL.TraineeName + "',dateofbirth= '" + traineeBLL.DateOfBirth + "',toeicscore=" + traineeBLL.ToeicScore + ",programlanguage = N'" + traineeBLL.ProgramLanguage + "',experiencedetails=N'" + traineeBLL.ExperienceDetails + "',department=N'" + traineeBLL.Department + "',location=N'" + traineeBLL.Location + "' Where traineeid =" + traineeBLL.TraineeId ;
            TraineeDAL._conndb.ExecuteNonQuery(sql);
        }
        public static void deteleTrainee(TraineeBLL traineeBLL)
        {
            string sql = "DELETE FROM [trainees] where traineeid =" + traineeBLL.TraineeId;
            TraineeDAL._conndb.ExecuteNonQuery(sql);
        }

        public static TraineeBLL getTraineeItem(TraineeBLL traineeBLL)
        {
            string sql= "SELECT * FROM where traineeid =" + traineeBLL.TraineeId;
            DataTable dt = new DataTable();
            dt = TraineeDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new TraineeBLL(Int32.Parse(row["traineeid"].ToString()), row["traineename"].ToString(), DateTime.Parse(row["dateofbirth"].ToString()), Int32.Parse(row["toeicscore"].ToString()), row["programlanguage"].ToString(), row["experiencedetails"].ToString(), row["department"].ToString(), row["location"].ToString());
            }
            return null;
        }
        public static List<TraineeBLL> search(string key, string value)
        {
            string sql = "SELECT * FROM [trainees] WHERE " + key + " LIKE N'%" + value + "%'";
            DataTable dt = TraineeDAL._conndb.getDataTable(sql);
            List<TraineeBLL> traineeBLLList = new List<TraineeBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    TraineeBLL traineeBLL = new TraineeBLL(Int32.Parse(row["traineeid"].ToString()), row["traineename"].ToString(), DateTime.Parse(row["dateofbirth"].ToString()), Int32.Parse(row["toeicscore"].ToString()), row["programlanguage"].ToString(), row["experiencedetails"].ToString(), row["department"].ToString(), row["location"].ToString());
                    traineeBLLList.Add(traineeBLL);

                }
                return traineeBLLList;
            }
             return null;
        }
    }
}
