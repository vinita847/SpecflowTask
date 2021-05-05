using System;
using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Page
    {
        private By AlertDialogBy = By.XPath("//div[@class='ns-box-inner']");
        public string getAlertDialogText()
        {
            WaitHelper.WaitVisible(Driver.driver, AlertDialogBy, 2);
            var text = WaitHelper.FindElement(Driver.driver, AlertDialogBy).Text;
            Console.WriteLine("text = " + text);
            return text;
        }
    }
}
