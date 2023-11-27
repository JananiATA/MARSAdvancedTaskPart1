using AventStack.ExtentReports;
using MARSAdvancedTaskPart1.AssertionHelpers;
using MARSAdvancedTaskPart1.JSONObjectClasses;
using MARSAdvancedTaskPart1.Pages.Components.HomePageComponent;
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
    public class SearchSkillTests : CommonDriver
    {
        LoginSteps loginSteps = new LoginSteps();
        JSONReader jsonReader;
        LoginAssertion loginAssertion = new LoginAssertion();
        ShareSkillSteps shareSkillSteps = new ShareSkillSteps();
        SearchSkillSteps searchSkillSteps = new SearchSkillSteps();
        SearchSkillAssertion searchSkillAssertion = new SearchSkillAssertion();

        [Test, Order(1)]
        public void SearchSkillByCategoryTest()
        {
            test = extent.CreateTest("Search Skill by Category");
            test.Log(Status.Info, "Search Skill by Category");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }

            string searchSkillFilePath = ProjectPathHelper.projectPath + "\\TestData\\SearchSkillsInputFile\\SearchSkill.json";
            jsonReader = new JSONReader(searchSkillFilePath);
            List<SearchSkill> searchSkill = new List<SearchSkill>();
            searchSkill = jsonReader.ReadSearchSkillFile();
            foreach (var skill in searchSkill)
            {
                shareSkillSteps.ShareSkill(skill.Title, skill.Description, skill.Category, skill.SubCategory, skill.Tags, skill.ServiceType, skill.LocationType,
                    skill.StartDate, skill.EndDate, skill.SkillTrade, skill.SkillExchange, skill.Amount, skill.ActiveStatus);
                searchSkillSteps.SearchSkillByCategory(skill.Category, skill.SubCategory);
                searchSkillAssertion.AssertSearchSkill(skill.Title);
            }


        }

        [Test, Order(2)]
        public void SearchSkillByFilterTest()
        {
            test = extent.CreateTest("Search Skill by Filter");
            test.Log(Status.Info, "Search Skill by Filter");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }

            string searchSkillFilePath = ProjectPathHelper.projectPath + "\\TestData\\SearchSkillsInputFile\\SearchSkill.json";
            jsonReader = new JSONReader(searchSkillFilePath);
            List<SearchSkill> searchSkill = new List<SearchSkill>();
            searchSkill = jsonReader.ReadSearchSkillFile();
            foreach (var skill in searchSkill)
            {
                shareSkillSteps.ShareSkill(skill.Title, skill.Description, skill.Category, skill.SubCategory, skill.Tags, skill.ServiceType, skill.LocationType,
                    skill.StartDate, skill.EndDate, skill.SkillTrade, skill.SkillExchange, skill.Amount, skill.ActiveStatus);
                searchSkillSteps.SearchSkillByFilter(skill.LocationType);
                searchSkillAssertion.AssertSearchSkill(skill.Title);
            }
        }
    }
}
