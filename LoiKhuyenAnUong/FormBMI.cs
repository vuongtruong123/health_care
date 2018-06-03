using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoiKhuyenAnUong
{
    public partial class FormBMI : Form
    {
        public FormBMI()
        {
            InitializeComponent();
        }


        // chỉ cho nhập số trong textbox cân nặng
        private void txtCanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // chỉ cho nhập số trong textbox chiều caos
        private void txtChieuCao_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            
        }

        // hàm hiện kết quả
        private void HienKetQua(double ChiSoBMI)
        {
            
        }

        private void btnLoiKhuyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FormBMI_Load(object sender, EventArgs e)
        {

        }
    }
}
