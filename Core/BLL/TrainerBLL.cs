using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class TrainerBLL
    {
        private int _trainerid;
        private string _emailaddress;
        private string _trainername;
        private bool _internaltype;
        private string _workingplace;
        private string _telephone;

        public int TrainerId
        {
            get { return _trainerid; }
            set { _trainerid = value; }
        }
        public string EmailAddress
        {
            get { return _emailaddress; }
            set { _emailaddress = value; }
        }
        public string TrainerName
        {
            get { return _trainername; }
            set { _trainername = value; }
        }
        public bool InternalType
        {
            get { return _internaltype; }
            set { _internaltype = value; }
        }
        public string WorkingPlace
        {
            get { return _workingplace; }
            set { _workingplace = value; }
        }
        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public TrainerBLL(int trainerid,string email,string name, bool type,string workingplace, string telephone)
        {
            _trainerid = trainerid;
            _emailaddress = email;
            _trainername = name;
            _internaltype = type;
            _workingplace = workingplace;
            _telephone = telephone;
        }
        public TrainerBLL() { }
    }
}
