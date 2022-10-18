using System.Text;
using ZXing.QrCode;

namespace SirooWebAPP.UI.Helpers
{
    public static class HelperFunctions
    {
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
        public static DateTime JavaTimeStampToDateTime(double javaTimeStamp)
        {
            // Java timestamp is milliseconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddMilliseconds(javaTimeStamp).ToLocalTime();
            return dateTime;
        }
        public static void SetCookie(string key, string value, int? expireTime,HttpResponse response)
        {
            CookieOptions option = new CookieOptions();
            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddDays(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);
            response.Cookies.Append(key, value, option);
        }

        public static string GetCookie(string v, HttpRequest request)
        {
            return request.Cookies[v];
        }

        public static void RemoveCookie(string v,HttpRequest request, HttpResponse response)
        {
            if (GetCookie(v,request) != null)
            {
                response.Cookies.Delete(v);
            }
        }


        public static string UploadFileToDateBasedFolder(string filename_prefix,IFormFile formFile,IWebHostEnvironment _environment)
        {
            string strYear = DateTime.Now.Year.ToString();
            string strMonth = DateTime.Now.Month.ToString();

            bool exists = System.IO.Directory.Exists(_environment.WebRootPath + "/uploads/" + strYear);

            if (!exists)
                System.IO.Directory.CreateDirectory(_environment.WebRootPath + "/uploads/" + strYear);

            exists = System.IO.Directory.Exists(_environment.WebRootPath + "/uploads/" + strYear + "/" + strMonth);

            if (!exists)
                System.IO.Directory.CreateDirectory(_environment.WebRootPath + "/uploads/" + strYear + "/" + strMonth);

            
            string FileName = filename_prefix + formFile.FileName;
            var path = Path.Combine(_environment.WebRootPath, "uploads/" + strYear + "/" + strMonth, FileName);
            var stream = new FileStream(path, FileMode.Create);
            formFile.CopyToAsync(stream);
            return "uploads/" + strYear + "/" + strMonth + "/" + FileName;
        }

        public static string CreateQR(string textToQR)
        {
            string QrText="";
            var QrcodeContent = textToQR;
            var alt = "sarparast";
            var width = 250; // width of the Qr Code    
            var height = 250; // height of the Qr Code    
            var margin = 0;
            var qrCodeWriter = new ZXing.BarcodeWriterPixelData
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Height = height,
                    Width = width,
                    Margin = margin
                }
            };
            var pixelData = qrCodeWriter.Write(QrcodeContent);
            // creating a bitmap from the raw pixel data; if only black and white colors are used it makes no difference    
            // that the pixel data ist BGRA oriented and the bitmap is initialized with RGB    
            using (var bitmap = new System.Drawing.Bitmap(pixelData.Width, pixelData.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb))
            using (var ms = new MemoryStream())
            {
                var bitmapData = bitmap.LockBits(new System.Drawing.Rectangle(0, 0, pixelData.Width, pixelData.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                try
                {
                    // we assume that the row stride of the bitmap is aligned to 4 byte multiplied by the width of the image    
                    System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length);
                }
                finally
                {
                    bitmap.UnlockBits(bitmapData);
                }
                // save to stream as PNG    
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                QrText = String.Format("data:image/png;base64,{0}", Convert.ToBase64String(ms.ToArray()));

            }
            return QrText;
        }
        public static string SanitizeQuery(string dirtyString)
        {
            HashSet<char> removeChars = new HashSet<char>(" ?&^$#@!()+-,:;<>’\'-_*=");
            StringBuilder result = new StringBuilder(dirtyString.Length);
            foreach (char c in dirtyString)
                if (!removeChars.Contains(c))
                    result.Append(c);
            return result.ToString();
        }
    }
}
