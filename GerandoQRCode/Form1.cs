using System;
using System.Drawing;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace GerandoQRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                QRCodeEncoder encoder = new QRCodeEncoder();
                QRCodeDecoder decoder = new QRCodeDecoder();

                encoder.QRCodeBackgroundColor = System.Drawing.Color.White;
                encoder.QRCodeForegroundColor = System.Drawing.Color.Black;
                encoder.CharacterSet = "UTF-8";
                encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                encoder.QRCodeScale = 6;
                encoder.QRCodeVersion = 0;
                encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;

                Image QRCode = encoder.Encode(txtConteudo.Text);
                picQrCode.Image = QRCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
