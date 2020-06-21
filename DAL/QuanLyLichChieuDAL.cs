using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuanLyLichChieuDAL
    {
        public List<LichChieuDTO> DanhSachLichChieu()
        {
			try
			{
				using (var context = new QLRPContext())
				{
					var list = context.LichChieus.Select(lc => lc).AsEnumerable().Select(lc => new LichChieuDTO
					{
						MaLichChieu = lc.MaLichChieu,
						MaPhim = lc.MaPhim,
						MaPhong = lc.MaPhong,
						NgayGioChieu = lc.NgayGioChieu,
						RowVersion = BitConverter.ToUInt64(lc.RowVersion, 0).ToString()
					}).ToList();
					return list;
				}
			}
			catch (Exception)
			{
				throw;
			}
        }
    }
}
