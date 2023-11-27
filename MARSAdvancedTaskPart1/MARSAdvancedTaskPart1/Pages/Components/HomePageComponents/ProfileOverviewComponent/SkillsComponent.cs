using MARSNunitAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSAdvancedTaskPart1.Pages.Components.HomePageComponent.ProfileOverviewComponent
{
    public class SkillsComponent : CommonDriver
    {

        private IWebElement addNewButton;
        private IWebElement addButton;
        private IWebElement skillTextBox;
        private IWebElement skillLevelDropdown;
        private IWebElement skillTab;
        private IWebElement popUpMessage;
        private IWebElement updateButton;
        private IWebElement editIcon;
        private IWebElement deleteIcon;
        private IWebElement closePopUpMessage;



        public void RenderSkillsTab()
        {
            skillTab = driver.FindElement(By.XPath("//*[@class='item' and text()='Skills']"));
        }

        public void GoToSkillsTab()
        {
            RenderSkillsTab();
            skillTab.Click();
        }

        public void RenderClosePopUp()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@class='ns-close']", 5);
            closePopUpMessage = driver.FindElement(By.XPath("//*[@class='ns-close']"));
        }

        public void RenderAddNewButton()
        {
            addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        }
                                                          
        public void RenderSkillComponents()
        {
            skillTextBox = driver.FindElement(By.Name("name"));

            skillLevelDropdown = driver.FindElement(By.Name("level"));


        }

        public void RenderAddButton()
        {
            addButton = driver.FindElement(By.XPath("//*[@value ='Add']"));
        }


        public void RenderEditIcon()
        {
            editIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        }

        public void RenderUpdateButton()
        {
            updateButton = driver.FindElement(By.XPath("//*[@value ='Update']"));
        }


        public void RenderDeleteIcon()
        {
            deleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
        }



        public void ResetSkillTable()
        {
            int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr")).Count;

            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")).Click();
                    Thread.Sleep(1000);
                }
            }

            ClosePopUp();

        }


        public void RenderPopUpMessage()

        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@class='ns-box-inner']", 5);
            popUpMessage = driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
        }

        public void ClosePopUp()
        {
            RenderClosePopUp();
            closePopUpMessage.Click();
        }

        public string PopUpMessage()
        {
          
            Wait.WaitToBeVisible(driver, "XPath", "//*[@class='ns-box-inner']", 5);
            RenderPopUpMessage();
            return popUpMessage.Text;
           
        }



        public void AddNewSkill(string skill, string skillLevel)
        {

            RenderAddNewButton();
            addNewButton.Click();
            RenderSkillComponents();
            skillTextBox.SendKeys(skill);
            SelectElement level = new SelectElement(skillLevelDropdown);
            level.SelectByValue(skillLevel);
            RenderAddButton();
            addButton.Click();
            Thread.Sleep(2000);
            

        }


        public void EditSkill(string skill, string skillLevel)
        {
            RenderEditIcon();
            editIcon.Click();
            RenderSkillComponents();
            skillTextBox.Clear();
            skillTextBox.SendKeys(skill);
            SelectElement level = new SelectElement(skillLevelDropdown);
            level.SelectByValue(skillLevel);
            RenderUpdateButton();
            updateButton.Click();
            Thread.Sleep(1000);
        }


        public void DeleteSkill()
        {
            RenderDeleteIcon();
            deleteIcon.Click();
            Thread.Sleep(1000);

        }
    }
}
