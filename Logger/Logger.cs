using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger
{
    public class Logger : BaseLog
    {
        private string FilePath { get; set; }
        private string FileName { get; set; }
        private string FullLogPath { get; set; }

        public Logger()
        {
            this.FilePath = @"C:\DevDocs\";
            this.FileName = $@"Log{DateTime.Now.ToString("yyyMMdd")}.txt";
            this.FullLogPath = this.FilePath + this.FileName;
        }

        public override void Log(string messsage)
        {
            try
            {
                // Create directory if it does not exist
                Directory.CreateDirectory(Path.GetDirectoryName(FullLogPath));

                // Create file containing the log information
                using (StreamWriter writer = File.AppendText(this.FullLogPath))
                {
                    writer.Write("\r\nLog Date Time: ");
                    writer.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                    writer.WriteLine("{0}", messsage);
                    writer.WriteLine("---------------------------------------------------------------------------");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\n\nAn error has occured trying to create the log directory for {0} \n Error: {1}", FullLogPath, e);
            }
        }
    }
}