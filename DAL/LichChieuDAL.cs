using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LichChieuDAL
    {
        public List<LichChieuDTO> DanhSachLichChieu()
        {
			try
			{
				using (var context = new QLRPContext())
				{
					List<LichChieu> lichChieus = context.LichChieus.Select(p => p).ToList();
					List<LichChieuDTO> lichChieuDTOs = new List<LichChieuDTO>();
					foreach (LichChieu lc in lichChieus)
					{
						var lcDTO = new LichChieuDTO
						{
							MaLichChieu = lc.MaLichChieu,
							MaPhim = lc.MaPhim,
							MaPhong = lc.MaPhong,
							NgayGioChieu = lc.NgayGioChieu,
							RowVersion = BitConverter.ToUInt64(lc.RowVersion, 0).ToString(),
							TenPhim = lc.Phim.TenPhim,
							TenPhong = lc.PhongChieu.TenPhong
						};
						lichChieuDTOs.Add(lcDTO);
					}
					return lichChieuDTOs;
				}
			}
			catch (Exception)
			{
				throw;
			}
        }

		public bool ThemLichChieu(LichChieuDTO lichChieu)
		{
			try
			{
				using (var context = new QLRPContext())
				{
					context.LichChieus.Add(new LichChieu()
					{
						MaPhim = lichChieu.MaPhim,
						NgayTao = DateTime.Now,
						NguoiTao = CurrentUser.Username,
						NgaySua = DateTime.Now,
						NguoiSua = CurrentUser.Username,
						MaPhong = lichChieu.MaPhong,
						NgayGioChieu = lichChieu.NgayGioChieu
					});
					context.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static bool XoaLichChieu(int malc_delete)
		{
			try
			{
				using (var context = new QLRPContext())
				{
					var lc = context.LichChieus.Single(l => l.MaLichChieu == malc_delete);
					if (lc!=null)
					{
						context.LichChieus.Remove(lc);
						context.SaveChanges();
						return true;
					}
					return false;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool UpdateLichChieu(LichChieuDTO lichChieu)
		{
			try
			{
				using (var context = new QLRPContext())
				{
					var lichChieu_update = context.LichChieus.Single(p => p.MaLichChieu == lichChieu.MaLichChieu);
					if (lichChieu_update != null)
					{
						if (BitConverter.ToUInt64(lichChieu_update.RowVersion, 0).ToString().Equals(lichChieu.RowVersion))
						{
							lichChieu_update.MaPhong = lichChieu.MaPhong;
							lichChieu_update.MaPhim = lichChieu.MaPhim;
							lichChieu_update.NgayGioChieu = lichChieu.NgayGioChieu;
							lichChieu_update.NguoiSua = CurrentUser.Username;
							lichChieu_update.NgaySua = DateTime.Now;
							context.SaveChanges();
							return true;
						}
						else throw new Exception("Da co update truoc do.");
					}
					return false;
				}
			}
			catch (DbUpdateConcurrencyException ex)
			{
				throw new Exception("Update failed. Ai do cung dang up");
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
				using (var context = new QLRPContext())
				{
					var list = context.PhongChieus.Select(p => new PhongChieuDTO
					{
						MaPhong = p.MaPhong,
						TenPhong = p.TenPhong,
						SoHang = p.SoHang,
						SoCot = p.SoCot
					}).ToList();
					return list;
				}
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
				using (var context = new QLRPContext())
				{
					var list = context.Phims.Select(p => new PhimDTO
					{
						MaPhim = p.MaPhim,
						TenPhim = p.TenPhim,
						NgayKhoiChieu = p.NgayKhoiChieu,
						MoTa = p.MoTa,
						TheLoai = p.TheLoai
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
