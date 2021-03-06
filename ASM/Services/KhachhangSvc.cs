using ASM.Helper;
using ASM.Models;
using ASM.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Services
{
    public interface IKhachhangSvc
    {
        List<Khachhang> GetKhachhangAll();
        Khachhang GetKhachhang(int id);
        int AddKhachhang(Khachhang khachhang);
        int EditKhachhang(int id, Khachhang khachhang);
        Khachhang Login(ViewWebLogin vieWebLogin);
    }
    public class KhachhangSvc : IKhachhangSvc
    {
        protected DataContext _context;
        protected IMahoaHelper _mahoaHelper;
        public KhachhangSvc(DataContext context, IMahoaHelper mahoaHelper)
        {
            _context = context;
            _mahoaHelper = mahoaHelper;
        }

        public List<Khachhang> GetKhachhangAll()
        {
            List<Khachhang> list = new List<Khachhang>();
            list = _context.Khachhangs.ToList();
            return list;
        }
        public Khachhang GetKhachhang(int id)
        {
            Khachhang khachhang = null;
            khachhang = _context.Khachhangs.Find(id);
            return khachhang;
        }
        public int AddKhachhang(Khachhang khachhang)
        {
            int ret = 0; 
            try
            {
                khachhang.Password = _mahoaHelper.Mahoa(khachhang.Password);
                khachhang.ConfirmPassword = khachhang.Password;

                _context.Add(khachhang);
                _context.SaveChanges();
                ret = khachhang.KhachhangID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public int EditKhachhang(int id, Khachhang khachhang)
        {
            int ret = 0;
            try
            {
                Khachhang _khachhang = null;
                _khachhang = _context.Khachhangs.Find(id);

                _khachhang.FullName = khachhang.FullName;
                _khachhang.NgaySinh = khachhang.NgaySinh;
                _khachhang.PhoneNumber = khachhang.PhoneNumber;
                _khachhang.Address = khachhang.Address;
                if(_khachhang.Password != null){
                    khachhang.Password = _mahoaHelper.Mahoa(khachhang.Password);
                    _khachhang.Password = khachhang.Password;
                    _khachhang.ConfirmPassword = khachhang.Password;
                }
                _khachhang.Mota = khachhang.Mota;

                _context.Update(_khachhang);
                _context.SaveChanges();
                ret = _khachhang.KhachhangID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public Khachhang Login(ViewWebLogin viewWebLogin)
        {
            var u = _context.Khachhangs.Where(
                p => p.Email.Equals(viewWebLogin.Email) &&
                p.Password.Equals(_mahoaHelper.Mahoa(viewWebLogin.Password))
                ).FirstOrDefault();
            return u;
        }
    }
}
