using ASM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Services
{
    public interface IMonAnSvc
    {
        List<MonAn> GetMonAnAll();

        MonAn GetMonAn(int id);

        int AddMonAn(MonAn monan);

        int EditMonAn(int id, MonAn monan);

    }
    public class MonAnSvc : IMonAnSvc
    {
        protected DataContext _context;
        public MonAnSvc(DataContext context)
        {
            _context = context;
        }
        public List<MonAn> GetMonAnAll()
        {
            List<MonAn> list = new List<MonAn>();
            list = _context.MonAns.ToList();
            return list;
        }
        public MonAn GetMonAn(int id)
        {
            MonAn monAn = null;
            monAn = _context.MonAns.Find(id);
            return monAn;
        }
        public int AddMonAn(MonAn monAn)
        {
            int ret = 0;
            try
            {
                _context.Add(monAn);

                _context.SaveChanges();

                ret = monAn.MonAnID;
            }
            catch
            {
               ret = 0;
            }
            return ret;
        }
        public int EditMonAn(int id, MonAn monAn)
        {
            int ret = 0;
            try
            {
                MonAn _monAn = null;

                _monAn = _context.MonAns.Find(id);

                _monAn.Name = monAn.Name;

                _monAn.Gia = monAn.Gia;

                _monAn.Phanloai = monAn.Phanloai;

                _monAn.Hinh = monAn.Hinh;

                _monAn.Mota = monAn.Mota;

                _monAn.Trangthai = monAn.Trangthai;

                _context.Update(_monAn);

                _context.SaveChanges();

                ret = monAn.MonAnID;

            }
            catch
            {
               ret = 0;
            }
            return ret;
        }   
    }
}
