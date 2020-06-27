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
            lbHi.Text = $"Hi {Login.UserName}!";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thêm?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    string userName, password;
                    int maNV;
                    userName = txtUserName.Text;
                    password = txtPassword.Text;
                    maNV = int.Parse(txtMaNV.Text);
                    if (userBLL.ThemUser(userName, password, maNV))
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            QuanLyLoginUser_Load(sender, e);
        }

        private void QuanLyLoginUser_Load(object sender, EventArgs e)
        {
            try
            {
                dgvLoginUser.AutoGenerateColumns = false;
                dgvLoginUser.DataSource = userBLL.DanhSachUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLoginUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowEnter = e.RowIndex;
                txtUserName.Text = dgvLoginUser.Rows[RowEnter].Cells[0].Value.ToString();
                txtPassword.Text = dgvLoginUser.Rows[RowEnter].Cells[1].Value.ToString();
                txtMaNV.Text = dgvLoginUser.Rows[RowEnter].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn sửa?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    string old_user, new_user, new_password, rowVer;
                    int old_manv, new_manv;
                    old_user = dgvLoginUser.Rows[RowEnter].Cells[0].Value.ToString();
                    old_manv = int.Parse(dgvLoginUser.Rows[RowEnter].Cells[2].Value.ToString());
                    new_user = txtUserName.Text;
                    new_password = txtPassword.Text;
                    new_manv = int.Parse(txtMaNV.Text);
                    rowVer = dgvLoginUser.Rows[RowEnter].Cells[5].Value.ToString();
                    if (userBLL.UpdateUser(new_user, new_password, new_manv, old_user, old_manv, rowVer))
                        MessageBox.Show("Update thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QuanLyLoginUser_Load(sender, e);
            }
        }
    }
}
