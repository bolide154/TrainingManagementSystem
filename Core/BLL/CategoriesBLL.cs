using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class CategoriesBLL
    {
        private int _categoryid;
        private string _categoryname;
        private string _categorydescription;

        public int Categoryid
        {
            get { return _categoryid; }
            set { _categoryid = value; }
        }
        public string Categoryname
        {
            get { return _categoryname; }
            set { _categoryname = value; }
        }
        public string Categorydescription
        {
            get { return _categorydescription; }
            set { _categorydescription = value; }
        }

        public CategoriesBLL(string categoryName,string categoryDescription)
        {
            
            _categoryname = categoryName;
            _categorydescription = categoryDescription;
        }
        public CategoriesBLL(int categoryId, string categoryName, string categoryDescription)
        {
            this._categoryid = categoryId;
            _categoryname = categoryName;
            _categorydescription = categoryDescription;
        }
        public CategoriesBLL() { }
    }
}
