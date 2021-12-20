using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://localhost:5000";

        public static string CurrentPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

        //ScreenshotPath
        public static string ScreenshotPath = CurrentPath + @"MarsQA-1\TestReports\Screenshots\";
        //ExtentReportsPath
        public static string ReportsPath = CurrentPath + @"MarsQA-1\TestReports\Test_files\" + "TestRunReport.html";

        //ReportXML Path
        public static string ReportXMLPath = CurrentPath + @"MarsQA-1\TestReports" + "ExtentReport_Config.xml";
    }
}