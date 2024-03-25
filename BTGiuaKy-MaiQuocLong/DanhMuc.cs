using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTGiuaKy_MaiQuocLong
{
    public class DanhMuc
    {
        public List<TaiLieu> TaiLieus { get; set; }

        public DanhMuc()
        {
            TaiLieus = new List<TaiLieu>();
        }

        public void ThemTaiLieu(TaiLieu taiLieu)
        {
            TaiLieus.Add(taiLieu);
        }

        public List<TaiLieu> TimTheoLoai<T>() where T : TaiLieu
        {
            return TaiLieus.FindAll(t => t.GetType() == typeof(T));
        }

        public List<Bao> TimBaoTheoThangNam(int thang, int nam)
        {
            return TaiLieus.FindAll(t => t.GetType() == typeof(Bao) && ((Bao)t).NgayPhatHanh.Month == thang && ((Bao)t).NgayPhatHanh.Year == nam).ConvertAll(t => (Bao)t);
        }
    }
}
