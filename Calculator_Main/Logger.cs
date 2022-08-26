using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Main
{
    class Logger
    {
        public static void Log(string message, string actionType)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            try
            {
                File.AppendAllText("C:\\calculator_loggs\\log.txt", $"[{time}] - {actionType} - {message}\n");
            }

            catch
            {
                Directory.CreateDirectory("C:\\calculator_loggs");
                File.WriteAllText("C:\\calculator_loggs\\log.txt", $"[{time}] - create - log.txt created on the path C:\\calculator_loggs\n");
                File.AppendAllText("C:\\calculator_loggs\\log.txt", $"[{time}] - {actionType} - {message}\n");
            }
        }
    }
}
