using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class TopicBLL
    {
        private int _topicid;
        private int _courseid;
        private string _topicname;
        private string _topicdescription;

        public int TopicId
        {
            get{ return _topicid; }
            set { _topicid = value; }
        }
        public int CourseId
        {
            get { return _courseid; }
            set { _courseid = value; }
        }
        public string TopicName
        {
            get { return _topicname; }
            set { _topicname = value; }
        }
        public string TopicDescription
        {
            get { return _topicdescription; }
            set { _topicdescription = value; }
        }
        public TopicBLL(int topicid, int courseid, string topicname, string topicdescription)
        {
            _topicid = topicid;
            _courseid = courseid;
            _topicname = topicname;
            _topicdescription = topicdescription;
        }
        public TopicBLL() { }
    }
}
