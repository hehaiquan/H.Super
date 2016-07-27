using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.WinForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnGenerateQrCode_Click(object sender, EventArgs e)
        {
            var stream = new MemoryStream();
            var success = H.Super.Utility.QrCodeService.GenerateQRCode(txtContent.Text, stream, int.Parse(txtSize.Text));
            if (success)
            {
                picBoxQRImage.Image = System.Drawing.Image.FromStream(stream);
            }
            else
            {
                MessageBox.Show("生成失败！");
            }
        }
    }
}
