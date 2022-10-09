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
    }
}
