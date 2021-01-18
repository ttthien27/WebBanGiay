using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClass;
using MyClass.Model;

namespace MyClass.DAO
{
   public class ProductDAO
    {
        MyDBContext db = new MyDBContext();

     

        public Giay getRow(String slug)
        {
            Giay row = db.Giays.Where(m => m.slug == slug).FirstOrDefault();
            return row;
        }

        //public List<Giay> getList(int km)
        //{
        //    List<Giay> list = db.Giays.Where(m => Convert.ToInt32(m.KhuyenMais) == km).ToList();
        //    return list;
        //}
    }
}
