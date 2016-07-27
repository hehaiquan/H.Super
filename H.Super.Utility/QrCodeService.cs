using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.Super.Utility
{
    public class QrCodeService
    {
        public static bool GenerateQRCode(string strContent, MemoryStream ms, int ModuleSize = 12)
        {

            ErrorCorrectionLevel Ecl = ErrorCorrectionLevel.M; //误差校正水平,越高,二维码的有效像素点就越多
            QuietZoneModules QuietZones = QuietZoneModules.Four;  //空白区域 
            var encoder = new QrEncoder(Ecl);

            QrCode qr;
            if (encoder.TryEncode(strContent, out qr))//对内容进行编码，并保存生成的矩阵
            {
                var render = new GraphicsRenderer(new FixedModuleSize(ModuleSize, QuietZones));
                render.WriteToStream(qr.Matrix, ImageFormat.Png, ms);
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
