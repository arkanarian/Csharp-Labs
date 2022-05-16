using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Interfaces;

namespace ModelsLibrary.Entities
{
    public class Log
    {
        public String FileName { get; set; }
        private StreamWriter LogFileStream { get; }
        public List<String> LogList = new List<String>();

        public Log(String logFileName)
        {
            FileName = logFileName + DateTime.Now.Day.ToString() + "d_" + DateTime.Now.Hour.ToString() + "h_" + DateTime.Now.Minute.ToString() + "m_" + DateTime.Now.Second.ToString() + "s" + ".txt";

            LogFileStream = File.CreateText(FileName);

            WriteLog("System", "New application session started");
        }

        public void WriteLog(String logtype, String message)
        {
            LogList.Add(DateTime.Now.ToString() + ": " + String.Format("{0,-30}", logtype) + message);
            LogFileStream.WriteLine(DateTime.Now.ToString() + ": " + String.Format("{0,-30}",logtype) + message);
        }

        public void CloseLog()
        {
            LogFileStream.WriteLine(DateTime.Now.ToString() + ": " + "Log file closed");
            LogFileStream.Close();
        }
        public StreamWriter GetLogs()
        {
            return LogFileStream;
        }
    }
}
