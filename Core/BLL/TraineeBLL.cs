using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class TraineeBLL
    {
        private int _traineeId;
        private string _traineeName;
        private DateTime _dateOfBirth;
        private int _toeicScore;
        private string _programLanguage;
        private string _experienceDetails;
        private string _department;
        private string _location;

        public int TraineeId
        {
            get { return _traineeId; }
            set { _traineeId = value; }
        }
        public string TraineeName
        {
            get { return _traineeName; }
            set { _traineeName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public int ToeicScore
        {
            get { return _toeicScore; }
            set { _toeicScore = value; }
        }
        public string ProgramLanguage
        {
            get { return _programLanguage; }
            set { _programLanguage = value; }
        }
        public string ExperienceDetails
        {
            get { return _experienceDetails; }
            set { _experienceDetails = value; }
        }
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public TraineeBLL(int traineeId, string traineeName, DateTime dateOfBirth, int toeicScore, string programLanguage, string experienceDetails, string department, string location)
        {
            this._traineeId = traineeId;
            this._traineeName = traineeName;
            this._dateOfBirth = dateOfBirth;
            this._toeicScore = toeicScore;
            this._programLanguage = programLanguage;
            this._experienceDetails = experienceDetails;
            this._department = department;
            this._location = location;
        }

        public TraineeBLL()
        {
        }
        
    }
}
