﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://192.168.99.100:5000";

        //ScreenshotPath
        public static string ScreenshotPath = "@/MarsQA-1/TestReports/Screenshots/ProfileTests";

        //ExtentReportsPath
        public static string ReportsPath = "@/MarsQA-1/TestReports/Reports";

        //ExcelData Sheet Path
        public static string ExcelPath = CommonMethods.GetCodeDirectory() + @"\SpecflowTests\Data\TestData.xlsx";

        //ReportXML Path
        public static string ReportXMLPath = "";
    }
}