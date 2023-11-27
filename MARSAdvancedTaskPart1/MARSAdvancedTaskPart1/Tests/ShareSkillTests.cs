using AventStack.ExtentReports;
using MARSAdvancedTaskPart1.AssertionHelpers;
using MARSAdvancedTaskPart1.JSONObjectClasses;
using MARSAdvancedTaskPart1.Pages.Components.Profile;
using MARSAdvancedTaskPart1.Pages.Components.SignIn;
using MARSAdvancedTaskPart1.Steps;
using MARSAdvancedTaskPart1.Utilities;
using MARSNunitAutomation.JasonObjectClasses;
using MARSNunitAutomation.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSAdvancedTaskPart1.Tests
{
    [TestFixture]
    public class ShareSkillTests : CommonDriver
    {
        LoginSteps loginSteps = new LoginSteps();
        JSONReader jsonReader;
        LoginAssertion loginAssertion = new LoginAssertion();
        ShareSkillSteps shareSkillSteps = new ShareSkillSteps();
        ShareSkillAssertHelper shareSkillAssert = new ShareSkillAssertHelper();


        [Test, Order(1)]
        public void AddShareSkillTest()
        {
            test = extent.CreateTest("Share Skill");
            test.Log(Status.Info, "Skill");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);            
                
            }

            string shareSkillFilePath = ProjectPathHelper.projectPath + "\\TestData\\ShareSkillInputFiles\\ShareSkill.json";
            jsonReader = new JSONReader(shareSkillFilePath);
            List<ShareSkill> shareSkill = new List<ShareSkill>();
            shareSkill = jsonReader.ReadShareSkillFile();
            foreach(var skill in shareSkill)
            {
                shareSkillSteps.ShareSkill(skill.Title, skill.Description, skill.Category, skill.SubCategory, skill.Tags, skill.ServiceType, skill.LocationType,
                    skill.StartDate, skill.EndDate, skill.SkillTrade, skill.SkillExchange, skill.Amount, skill.ActiveStatus);
                shareSkillAssert.AssertShareSkill(skill.PopUpMessage, skill.Category,skill.Title,skill.Description);
            }

        }


        [Test, Order(2)]
        public void AddShareSkillInvalidInputTest()
        {
            test = extent.CreateTest("Share Skill");
            test.Log(Status.Info, "Skill");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }
            string shareSkillFilePath = ProjectPathHelper.projectPath + "\\TestData\\ShareSkillInputFiles\\ShareSkillInvalidInput.json";
            jsonReader = new JSONReader(shareSkillFilePath);
            List<ShareSkillInvalidInput> shareSkill = new List<ShareSkillInvalidInput>();
            shareSkill = jsonReader.ReadShareSkillInvalidInputFile();
            foreach (var skill in shareSkill)
            {
                shareSkillSteps.ShareSkill(skill.Title, skill.Description, skill.Category, skill.SubCategory, skill.Tags, skill.ServiceType, skill.LocationType,
                    skill.StartDate, skill.EndDate, skill.SkillTrade, skill.SkillExchange, skill.Amount, skill.ActiveStatus);
                shareSkillAssert.AssertShareSkillInvalidInput(skill.PopUpMessage);
            }

        }



    }
}
