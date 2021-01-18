using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClass;
using MyClass.Model;

namespace MyClass.DAO
{
  public  class CategoryDAO
    {
        MyDBContext db = new MyDBContext();

        public List<LoaiGiay> getList()
        {
            List<LoaiGiay> list = db.LoaiGiays.ToList();
            return list;
        }
    }
}
