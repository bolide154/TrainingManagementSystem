using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class CourseToTraineeBLL
    {
        private int _traineeId;
        private int _courseId;

        public int TraineeId
        {
            get { return _traineeId; }
            set { _traineeId = value; }
        }
        public int CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        public CourseToTraineeBLL(int TraineeId, int CourseId)
        {
            _traineeId = TraineeId;
            _courseId = CourseId;
        }
        public CourseToTraineeBLL() { }
    }
}
