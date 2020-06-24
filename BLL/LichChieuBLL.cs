using DAL;
using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LichChieuBLL
    {
		LichChieuDAL lichChieuDAL = new LichChieuDAL();
		
		
        public List<LichChieuDTO> DanhSachLichChieu()
        {
			try
			{
				return lichChieuDAL.DanhSachLichChieu();
			}
			catch (Exception)
			{
				throw;
			}
        }
		public List<PhongChieuDTO> getPhongs()
		{
			try
			{
				return lichChieuDAL.getPhongs();
			}
			catch (Exception)
			{

				throw;
			}
		}
		public List<PhimDTO> getPhims()
		{
			try
			{
				return lichChieuDAL.getPhims();
			}
			catch (Exception)
			{

				throw;
			}
		}

		public bool ThemLichChieu(int maPhim, int maPhong, DateTime ngayGioChieu)
		{
			try
			{
				return lichChieuDAL.ThemLichChieu(new LichChieuDTO
				{
					MaPhim = maPhim,
					MaPhong = maPhong,
					NgayGioChieu =
					ngayGioChieu
				});
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool UpdateLichChieu(int maPhim, int maPhong, DateTime gioLichChieu, int malc_old, string rowVer)
		{
			try
			{
				return lichChieuDAL.UpdateLichChieu(new LichChieuDTO
				{
					MaPhim = maPhim,
					MaLichChieu = malc_old,
					MaPhong = maPhong,
					NgayGioChieu = gioLichChieu,
					RowVersion = rowVer
				});
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool XoaLichChieu(int malc_delete)
		{
			try
			{
				return LichChieuDAL.XoaLichChieu(malc_delete);
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
