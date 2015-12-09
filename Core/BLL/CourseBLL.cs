using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class CourseBLL
    {
        private int _courseid;
        private int _categoryid;
        private string _coursename;
        private string _coursedescription;

        public int Courseid
        {
            get{return _courseid;}
            set{ _courseid = value;}
        }
        public int Categoryid
        {
            get { return _categoryid; }
            set { _categoryid = value; }
        }
        public string Coursename
        {
            get { return _coursename; }
            set { _coursename = value; }
        }
        public string Coursedescription
        {
            get { return _coursedescription; }
            set { _coursedescription = value; }
        }
        
        public CourseBLL(int CourseId, int CategoryId, string CourseName, string CourseDescription)
        {
            _courseid = CourseId;
            _categoryid = CategoryId;
            _coursename = CourseName;
            _coursedescription = CourseDescription;
        }
        public CourseBLL() { }
    }
}
