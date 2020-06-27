using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class LichSuBanVe : Form
    {
        DatVeBLL datVeBLL = new DatVeBLL();
        List<DatVeDTO> list = new List<DatVeDTO>();
        public LichSuBanVe()
        {
            InitializeComponent();
            dgvLichSuBanVe.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
            dgvLichSuBanVe.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
            cbOptions.SelectedIndex = 0;
        }

        private void LichSuBanVe_Load(object sender, EventArgs e)
        {
            try
            {
                list = datVeBLL.LichSuBanVe();
                dgvLichSuBanVe.AutoGenerateColumns = false;
                dgvLichSuBanVe.DataSource = list;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbOptions.SelectedIndex == 0)
            {
                
                dgvLichSuBanVe.DataSource = list.Where(l => l.TenPhim.Contains(txtSearch.Text) || convertToUnSign(l.TenPhim).ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            }
            if (cbOptions.SelectedIndex == 1)
            {
                dgvLichSuBanVe.DataSource = list.Where(l => l.NgayGioChieu.ToString("dd/MM/yyyy hh:mm tt").Contains(txtSearch.Text)).ToList();
            }
            if (cbOptions.SelectedIndex == 2)
            {
                dgvLichSuBanVe.DataSource = list.Where(l => l.TenPhong.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            }
            if (cbOptions.SelectedIndex == 3)
            {
                dgvLichSuBanVe.DataSource = list.Where(l => l.TenGhe.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            }
            if (cbOptions.SelectedIndex == 4)
            {
                dgvLichSuBanVe.DataSource = list.Where(l => l.NguoiBan.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            }
            if (cbOptions.SelectedIndex == 5)
            {
                dgvLichSuBanVe.DataSource = list.Where(l => l.ThoiGianBan.ToString("dd/MM/yyyy hh:mm tt").Contains(txtSearch.Text)).ToList();
            }
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        public static string convertToUnSign(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
}
