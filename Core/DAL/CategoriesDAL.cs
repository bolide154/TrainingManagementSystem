using Core.BLL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class CategoriesDAL
    {
        public static Connection _conndb = new Connection();
        public static List<CategoriesBLL> getCategoriesList()
        {
            string sql = "SELECT * FROM [categories]";
            DataTable dt = new DataTable();          
            dt = CategoriesDAL._conndb.getDataTable(sql);           
            if (dt.Rows.Count > 0)
            {
                List<CategoriesBLL> categoriesList = new List<CategoriesBLL>();
                foreach (DataRow row in dt.Rows)
                {
                    categoriesList.Add(new CategoriesBLL(Int32.Parse(row["categoryid"].ToString()), row["categoryname"].ToString(), row["categorydescription"].ToString()));
                }
                return categoriesList;
            }
            return null;
        }
        //
        public static CategoriesBLL getCategoryById(int categoryId)
        {
            string sql = "SELECT * FROM [categories] where categoryId=" + categoryId;
            DataTable dt = new DataTable();
            dt = CategoriesDAL._conndb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new CategoriesBLL(Int32.Parse(row["categoryid"].ToString()), row["categoryname"].ToString(), row["categorydescription"].ToString());
            }
            return null;
        }
        //

        public static void addCategories(CategoriesBLL categoriesBLL)
        {
            String sql = "INSERT INTO [categories] (categoryname,categorydescription) VALUES ( N'" + categoriesBLL.Categoryname + "',N'" + categoriesBLL.Categorydescription + "')";
            CategoriesDAL._conndb.ExecuteNonQuery(sql);
        }
        public static void saveCategories(CategoriesBLL categoriesBLL)
        {
            string sql = "UPDATE [categories] SET categoryname= N'" + categoriesBLL.Categoryname + "' ,categorydescription = N'" + categoriesBLL.Categorydescription + "'Where categoryid = "+categoriesBLL.Categoryid ;
            CategoriesDAL._conndb.ExecuteNonQuery(sql);
        }
        public static void deleteCategories(CategoriesBLL categoriesBLL)
        {
            string sql = "DELETE FROM [categories] where categoryid =" + categoriesBLL.Categoryid;
            CategoriesDAL._conndb.ExecuteNonQuery(sql);
        }
        public static List<CategoriesBLL> search(string key, string value)
        {
            string sql = "SELECT * FROM [categories] WHERE " + key + " LIKE N'%" + value + "%'";
            DataTable dt = CategoriesDAL._conndb.getDataTable(sql);
            List<CategoriesBLL> categoryBLLList = new List<CategoriesBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    CategoriesBLL categoriesBLL = new CategoriesBLL(Int32.Parse(row["categoryid"].ToString()), row["categoryname"].ToString(), row["categorydescription"].ToString());
                    categoryBLLList.Add(categoriesBLL);

                }
                return categoryBLLList;
            }
            return null;
        }
    }
}
