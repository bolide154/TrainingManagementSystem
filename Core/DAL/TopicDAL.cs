using Core.BLL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class TopicDAL
    {
        public static Connection _conndb = new Connection();
        public static List<TopicBLL> getTopicList()
        {
            string sql = "SELECT * FROM [topics]";
            DataTable dt = new DataTable();
            dt = TopicDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                List<TopicBLL> topicList = new List<TopicBLL>();
                foreach (DataRow row in dt.Rows)
                {
                    topicList.Add(new TopicBLL(Int32.Parse(row["topicid"].ToString()), Int32.Parse(row["courseid"].ToString()), row["topicname"].ToString(), row["topicdescription"].ToString()));
                }
                return topicList;
            }
            return null;
        }
        //
       
        //
        public static void addTopic(TopicBLL topicBLL)
        {
            String sql = "INSERT INTO [topics] (courseid,topicname,topicdescription) VALUES ("+topicBLL.CourseId+", N'" + topicBLL.TopicName + "',N'" + topicBLL.TopicDescription + "')";
            TopicDAL._conndb.ExecuteNonQuery(sql);
        }
    }
}
