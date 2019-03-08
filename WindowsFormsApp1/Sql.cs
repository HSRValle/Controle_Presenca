using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    static class Sql
    {
        public static bool classDecision(string IP)
        {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c ping "+IP);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();

            // *** Read the streams ***
            // Warning: This approach can lead to deadlocks, see Edit #2
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            exitCode = process.ExitCode;

            Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
            Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
            Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
            Console.ReadLine();
            process.Close();

            if (output.Contains("TTL="))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static String Conection()
        {
            if (Sql.classDecision("192.168.15.34") == true)
            {
                return "server=192.168.15.34;uid=omni;pwd=omnipassword;database=new_schema";
            }
            else
            {
                return "server=192.168.15.33;uid=omni;pwd=omnipassword;database=new_schema";
            }

            
        }
    }
}
