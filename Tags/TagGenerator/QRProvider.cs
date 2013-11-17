using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagGenerator
{
    public class QRProvider
    {
        public static Image Generate(string value, Action<MainForm.GenerateProgressReport> reportProgress)
        {
            System.Drawing.Image qr_code = null;

            try
            {
                var writer = new ZXing.BarcodeWriter
                {
                    Format = ZXing.BarcodeFormat.QR_CODE,
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Height = 300,
                        Width = 300
                    },
                    Renderer = (ZXing.Rendering.IBarcodeRenderer<Bitmap>)
                               Activator.CreateInstance(typeof(ZXing.Rendering.BitmapRenderer))
                };

                writer.Options.Hints.Add(
                    ZXing.EncodeHintType.ERROR_CORRECTION,
                    ZXing.QrCode.Internal.ErrorCorrectionLevel.H);

                qr_code = writer.Write(value);
            }
            catch (Exception exc)
            {
                reportProgress(new MainForm.GenerateProgressReport()
                {
                    UpdateMsg = true,
                    Msg = String.Format("Error during QR Code generation: {0}", exc.Message)
                });
            }

            return qr_code;
        }
    }
}
