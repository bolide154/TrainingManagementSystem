using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class CourseDAL
    {
        public static Connection _conndb = new Connection();
        public static CourseBLL getCourse(int categoryId)
        {
            string sql = "SELECT * FROM [courses] WHERE categoryid=" + categoryId;
            DataTable dt = new DataTable();
            dt = CategoriesDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new CourseBLL(Int32.Parse(row["categoryid"].ToString()),Int32.Parse(row["courseid"].ToString()),row["coursename"].ToString(),row["coursedescription"].ToString());
            }
            return null;
        }
        //
        public static CourseBLL getCourseById(int courseId)
        {
            string sql = "SELECT * FROM [courses] where courseid=" + courseId;
            DataTable dt = new DataTable();
            dt = CourseDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new CourseBLL(Int32.Parse(row["categoryid"].ToString()), Int32.Parse(row["courseid"].ToString()), row["coursename"].ToString(), row["coursedescription"].ToString());
            }
            return null;
        }
        //

        public static List<CourseBLL> getCourseList()
        {
            string sql = "SELECT * FROM [courses]";
            DataTable dt = new DataTable();
            dt = CategoriesDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                List<CourseBLL> coursesList = new List<CourseBLL>();
                foreach (DataRow row in dt.Rows)
                {
                    coursesList.Add(new CourseBLL( Int32.Parse(row["courseid"].ToString()), Int32.Parse(row["categoryid"].ToString()), row["coursename"].ToString(), row["coursedescription"].ToString()));
                }
                return coursesList;
            }
            return null;
        }
        public static void addCourse(CourseBLL courseBLL)
        {
            String sql = "INSERT INTO [courses] (categoryid,coursename,coursedescription) VALUES ("+courseBLL.Categoryid+", N'" +courseBLL.Coursename + "',N'" + courseBLL.Coursedescription + "')";
            CourseDAL._conndb.ExecuteNonQuery(sql);
        }
        public static void saveCourse(CourseBLL courseBLL)
        {
            string sql = "UPDATE [courses] SET coursename= N'" + courseBLL.Coursename + "' ,coursedescription = N'" + courseBLL.Coursedescription + "'Where courseid = " + courseBLL.Courseid;
            CourseDAL._conndb.ExecuteNonQuery(sql);
        }
        public static void deleteCourse(CourseBLL courseBLL)
        {
            string sql = "DELETE FROM [courses] where courseid =" + courseBLL.Courseid;
            CourseDAL._conndb.ExecuteNonQuery(sql);
        }
        public static List<CourseBLL> search(string key, string value)
        {
            string sql = "SELECT * FROM [courses] WHERE " + key + " LIKE N'%" + value + "%'";
            DataTable dt = CourseDAL._conndb.getDataTable(sql);
            List<CourseBLL> courseBLLList = new List<CourseBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    CourseBLL courseBLL = new CourseBLL(Int32.Parse(row["courseid"].ToString()), Int32.Parse(row["categoryid"].ToString()),  row["coursename"].ToString(), row["coursedescription"].ToString());
                    courseBLLList.Add(courseBLL);

                }
                return courseBLLList;
            }
            return null;
        }
    }
}
