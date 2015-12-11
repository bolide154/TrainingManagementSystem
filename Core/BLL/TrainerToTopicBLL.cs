using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class TrainerToTopicBLL
    {
        private int _trainerid;
        private int _topicid;

        public int TrainerId
        {
            get { return _trainerid; }
            set { _trainerid = value; }
        }
        public int TopicId
        {
            get { return _topicid; }
            set { _topicid = value; }
        }

        public  TrainerToTopicBLL(int trainerid, int topicid)
        {
            _trainerid = trainerid;
            _topicid = topicid;
        }
        public TrainerToTopicBLL() { }
    }
}
