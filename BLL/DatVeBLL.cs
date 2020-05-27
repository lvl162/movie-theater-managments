using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class DatVeBLL
    {
        DatVeDAL datVeDAL = new DatVeDAL();
        public void getListPhim(ComboBox cb)
        {
            cb.DataSource = datVeDAL.getListPhim();
        }
    }
}
