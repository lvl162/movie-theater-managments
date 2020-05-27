using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QuanLyRapPhim
{
    public partial class DatVeForm : Form
    {
        DatVeBLL datVeBLL = new DatVeBLL();
        public DatVeForm()
        {
            InitializeComponent();
        }

        private void DatVeForm_Load(object sender, EventArgs e)
        {
            datVeBLL.getListPhim(cbListPhim);
        }

        private void cbListPhim_SelectedValueChanged(object sender, EventArgs e)
        {
            String selectedPhim = cbListPhim.SelectedValue.ToString();
            //datVeBLL.getListLichChieu(selectedPhim);
            MessageBox.Show(selectedPhim, "OK", MessageBoxButtons.OK);
        }
    }
}
