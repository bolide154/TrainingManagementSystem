using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class StaffBLL
    {
        private int _staffId;
        private string _role;
        private int _trainerId;
        private string _password;
        private string _displayName;

        public int StaffId
        {
            get { return _staffId; }
            set { _staffId = value; }
        }

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public int TrainerId
        {
            get { return _trainerId; }
            set { _trainerId = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }

        public StaffBLL(int staffId, string role, int trainerId, string password, string displayName)
        {
            this._staffId = staffId;
            this._role = role;
            this._trainerId = trainerId;
            this._password = password;
            this._displayName = displayName;
        }

        public StaffBLL() { }
    }
}
