using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Shared.Helpers
{
    public static class LogHelper
    {
        private static readonly string _logPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            GlobalConst.AppDataFolder, "runtime.Log");

        public static void Info(string content)
        {
            WriteLog($"[INFO] {DateTime.Now:yyyy-MM-dd HH:mm:ss} {content}");
        }

        public static void Error(string content, Exception ex)
        {
            WriteLog($"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss} {content} | 异常：{ex.Message}\n{ex.StackTrace}");
        }

        private static void WriteLog(string msg)
        {
            lock (_logPath)
            {
                string dir = Path.GetDirectoryName(_logPath);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                File.AppendAllText(_logPath, msg + Environment.NewLine, Encoding.UTF8);
            }
        }
    }
}
