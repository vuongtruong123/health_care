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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int CanNang = Convert.ToInt32(txtCanNang.Text);
                double ChieuCao = Convert.ToDouble(txtChieuCao.Text) / 100;
                double bmi = Math.Round(CanNang / (ChieuCao * ChieuCao), 1);
                HienKetQua(bmi);
            }
            catch (Exception )
            {
                MessageBox.Show("Vui lòng nhập đủ cân nặng và chiều cao");
            }
        }

        // hàm hiện kết quả
        private void HienKetQua(double ChiSoBMI)
        {
            String TheTrang = "";

            if (ChiSoBMI < 18.5)
            {
                TheTrang = "Gầy";
            }
            else if (ChiSoBMI >= 18.5 && ChiSoBMI <= 24.9)
            {
                TheTrang = "Bình Thường";
            }
            else if (ChiSoBMI >= 25.0 && ChiSoBMI <= 29.9)
            {
                TheTrang = "Hơi Béo";
            }
            else if (ChiSoBMI >= 30.0 && ChiSoBMI <= 34.9)
            {
                TheTrang = "Béo Phì Cấp Độ 1";
            }
            else if (ChiSoBMI >= 35.0 && ChiSoBMI <= 39.9)
            {
                TheTrang = "Béo Phì Cấp Độ 2";
            }
            else
            {
                TheTrang = "Béo Phì Cấp Độ 3";
            }

            lbChiSo.Text = "Chỉ số BMI: " + Convert.ToString(ChiSoBMI) + "\nTình trạng cơ thể: " + TheTrang;
        }

        private void btnLoiKhuyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoiKhuyen formLoiKhuyen = new FormLoiKhuyen();
            formLoiKhuyen.ShowDialog();
        }

        private void FormBMI_Load(object sender, EventArgs e)
        {

        }
    }
}
