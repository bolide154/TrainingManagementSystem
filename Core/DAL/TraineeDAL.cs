﻿using Core.BLL;
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
        public static void addTrainee(TraineeBLL traineeBLL)
        {
            String sql = "INSERT INTO [trainees] (traineename,dateofbirth,toeicscore,programlanguage,experiencedetails,department,location) VALUES ( N'" + traineeBLL.TraineeName + "', '" + traineeBLL.DateOfBirth + "',"+ traineeBLL.ToeicScore+",N'"+traineeBLL.ProgramLanguage+"',N'"+traineeBLL.ExperienceDetails+"',N'"+traineeBLL.Department+"',N'"+traineeBLL.Location+"')";
            TraineeDAL._conndb.ExecuteNonQuery(sql);
        }
    }
}