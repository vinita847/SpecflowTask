using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;


namespace MarsQA_1.Helpers
{
    public class CommonMethods
    {
    

        public class SaveScreenShotClass
        {
            
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }

        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports Extent;



        public static void ExtentReports()
        {
            Extent = new ExtentReports(ConstantHelpers.ReportsPath, true, DisplayOrder.NewestFirst);
            Extent.LoadConfig(ConstantHelpers.ReportXMLPath);
        }
        #region getcodedirectory
        public static string GetCodeDirectory()
        {
            string BasePath = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("BaseDirectory = " + BasePath);
            return FormatFilePath(BasePath);
        }

        public static string FormatFilePath(string FilePath)
        {
            if (FilePath == null || FilePath.Length == 0)
                return String.Empty;
            string CodeDirectoryPath = "";
            string slash = @"\";

            for (int index = 0; index <= 2; index++)
            {
                CodeDirectoryPath = FilePath.Substring(0, FilePath.LastIndexOf(slash));
                FilePath = CodeDirectoryPath;
            }
            Console.WriteLine("CodeDirectoryPath = " + CodeDirectoryPath);
            return CodeDirectoryPath;
        }
        #endregion
    }
    #endregion


}


