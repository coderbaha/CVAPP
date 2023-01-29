using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Helper
{
    public static class ExceptionLogHelper
    {
        static string savePath = AppDomain.CurrentDomain.BaseDirectory + @"\logs";
        public static void LogFile(HttpContext context, Exception exception, IHostingEnvironment hostingEnvironment)
        {
            checkedPath(savePath);
            var now = DateTime.UtcNow;
            var fileName = $"{now.ToString("yyyy_MM_dd")}-TryCatch.log";
            var filePath = Path.Combine(savePath, fileName);

            using StreamWriter logFile =
                new(filePath, append: true);
            logFile.WriteLineAsync($"{now.ToString("HH:mm:ss")} {context.Request.Path}");
            logFile.WriteLineAsync(exception.Message);
        }
        private static void checkedPath(string path)
        {
            bool Kontrol = Directory.Exists(path);
            if (!Kontrol)
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
