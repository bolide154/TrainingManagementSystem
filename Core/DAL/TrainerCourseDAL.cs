using Core.BLL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class TrainerCourseDAL
    {
        public static Connection _conndb = new Connection();
        public static List<CourseBLL> getTrainerList(StaffBLL staffBLL)
        {
             
            string sql = "SELECT * FROM [staffs] s INNER JOIN [trainers] tn  ON s.trainerid=tn.trainerid INNER JOIN [trainer_topic] tt ON tn.trainerid=tt.trainerid INNER JOIN [topics] tp ON tt.topicid=tp.topicid INNER JOIN [courses] c ON tp.courseid=c.courseid  WHERE s.staffid=" + staffBLL.StaffId;
            DataTable dt = new DataTable();
            dt = TrainerCourseDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                List<CourseBLL> coursesListTrainer = new List<CourseBLL>(); 
                foreach (DataRow row in dt.Rows)
                {
                    coursesListTrainer.Add(new CourseBLL(Int32.Parse(row["courseid"].ToString()), Int32.Parse(row["categoryid"].ToString()), row["coursename"].ToString(), row["coursedescription"].ToString()));
                }
                return coursesListTrainer;
            }
            return null;
        }
    }
}
