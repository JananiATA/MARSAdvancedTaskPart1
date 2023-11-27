using MARSNunitAutomation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSAdvancedTaskPart1.Pages.Components.HomePageComponent.AccountMenuComponent
{
    public class UserDetailsComponent : CommonDriver
    {

        private IWebElement userNameLabel;
        public void RenderUserName()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 10);
                userNameLabel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string GetFirstName()
        {
            //Return username
            try
            {
                RenderUserName();
                return userNameLabel.Text;

            }
            catch (Exception ex)
            {
                driver.Navigate().Refresh();
                return ex.Message;
            }
        }


    }
}
