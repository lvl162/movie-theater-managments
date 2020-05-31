using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class QuanLyLoginUser : Form
    {
        int RowEnter = 0;
        LoginUserBLL userBLL = new LoginUserBLL();
        public QuanLyLoginUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userName, password;
            int maNV;
            userName = txtUserName.Text;
            password = txtPassword.Text;
            maNV = int.Parse(txtMaNV.Text);
            if (userBLL.ThemUser(userName, password, maNV)) QuanLyLoginUser_Load(sender, e);
        }

        private void QuanLyLoginUser_Load(object sender, EventArgs e)
        {
            userBLL.DanhSachUser(dgvLoginUser);
        }

        private void dgvLoginUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowEnter = e.RowIndex;
            txtUserName.Text = dgvLoginUser.Rows[RowEnter].Cells[0].Value.ToString();
            txtPassword.Text = dgvLoginUser.Rows[RowEnter].Cells[1].Value.ToString();
            txtMaNV.Text = dgvLoginUser.Rows[RowEnter].Cells[2].Value.ToString();
        }
    }
}
