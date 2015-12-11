using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservation
{
    public class Logger
    {     
        //This method is used for calculating method time in each class.
        public void GetMethodLog(string clsname , string methodname)
        {
            // get the base directory
            string baseDir = "C:/Users/anusha/Desktop/AirLine/Log";

            // search the file below the current directory
            string retFilePath = baseDir + "//" + "MethodLogFile.txt";

            // Create a writer and open the file:
            StreamWriter log;

            if (!File.Exists(retFilePath))
            {
                log = new StreamWriter(retFilePath);
            }
            else
            {
                log = File.AppendText(retFilePath);
            }

            string strclsname = "Class Name  : " + clsname ;
            string strmethodname = "Method Name : " + methodname ;
            string time = "Time : " + DateTime.Now.ToString();
            string eol = "^^---------------------------------------------------------^^";

            // Write log entries to the file:
            log.WriteLine(strclsname);
            log.WriteLine(strmethodname);
            log.WriteLine(time);
            log.WriteLine(eol); 
          
            // Close the stream:
            log.Close();          
        }

        public void GetActionLog(string screen, string action)
        {
            // get the base directory
            string baseDir = "C:/Users/anusha/Desktop/AirLine/Log";

            // search the file below the current directory
            string retFilePath = baseDir + "//" + "ActionLogFile.txt";

            // Create a writer and open the file:
            StreamWriter log;

            if (!File.Exists(retFilePath))
            {
                log = new StreamWriter(retFilePath);
            }
            else
            {
                log = File.AppendText(retFilePath);
            }

            string strwindowName = "Window Name  : " + screen;
            string strAction = "Action Performed : " + action;
            string time = "Time : " + DateTime.Now.ToString();
            string eol = "^^---------------------------------------------------------^^";

            // Write log entries to the file:
            log.WriteLine(strwindowName);
            log.WriteLine(strAction);
            log.WriteLine(time);
            log.WriteLine(eol);

            // Close the stream:
            log.Close();
        }
    
    }
}
