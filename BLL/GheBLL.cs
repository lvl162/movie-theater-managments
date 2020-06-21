using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GheBLL
    {
		GheDAL gheDAL = new GheDAL();
		public List<GheDTO> DanhSachGhe()
		{
			try
			{
				return gheDAL.DanhSachGhe();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool ThemGhe(string tenGhe, int maPhong, string tenPhong)
		{
			try
			{
				return gheDAL.ThemGhe(new GheDTO { TenGhe = tenGhe, MaPhong = maPhong, TenPhong = tenPhong });
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public bool XoaGhe(int maGhe, string tenGhe, int maPhong)
		{
			try
			{
				return gheDAL.XoaGhe(new GheDTO { MaGhe = maGhe, TenGhe = tenGhe, MaPhong = maPhong });
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool UpdateGhe(int maGhe, string tenGhe, int maPhong, string rowVersion)
		{
			try
			{
				return gheDAL.UpdateGhe(new GheDTO { MaGhe = maGhe, TenGhe = tenGhe, MaPhong = maPhong, RowVersion = rowVersion });
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
