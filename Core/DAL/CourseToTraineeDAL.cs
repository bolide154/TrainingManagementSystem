using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    
    public static class CourseToTraineeDAL
    {
        public static Connection _conndb = new Connection();
        public static CourseToTraineeBLL getCourseOfTrainee(int traineeId)
        {
            string sql = "SELECT * FROM [course_trainee] WHERE traineeid=" + traineeId;
            DataTable dt = new DataTable();
            dt = TraineeDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new CourseToTraineeBLL(Int32.Parse(row["traineeid"].ToString()), Int32.Parse(row["courseid"].ToString()));
            }
            return null;
        }
        public static CourseToTraineeBLL getCourseOfTrainee1(int courseId)
        {
            string sql = "SELECT * FROM [course_trainee] WHERE courseid=" + courseId;
            DataTable dt = new DataTable();
            dt = CourseDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new CourseToTraineeBLL(Int32.Parse(row["traineeid"].ToString()), Int32.Parse(row["courseid"].ToString()));
            }
            return null;
        }
        public static List<CourseToTraineeBLL> getCourseToTraineeList(TraineeBLL trainerBLL)
        {
            
        string sql = "SELECT * FROM [course_trainee] WHERE traineeid=" + trainerBLL.TraineeId;
            DataTable dt = new DataTable();
            dt = CourseToTraineeDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                List<CourseToTraineeBLL> coursestotraineeList = new List<CourseToTraineeBLL>();
                foreach (DataRow row in dt.Rows)
                {
                    coursestotraineeList.Add(new CourseToTraineeBLL(Int32.Parse(row["traineeid"].ToString()), Int32.Parse(row["courseid"].ToString())));
                }
                return coursestotraineeList;
            }
            return null;
        }
        public static void addCourseToTrainee(CourseToTraineeBLL coursetotraineeBLL)
        {
            String sql = "INSERT INTO [course_trainee] (traineeid,courseid) VALUES (" + coursetotraineeBLL.TraineeId + ", " + coursetotraineeBLL.CourseId + ")";
            CourseToTraineeDAL._conndb.ExecuteNonQuery(sql);
        }
    }
}
