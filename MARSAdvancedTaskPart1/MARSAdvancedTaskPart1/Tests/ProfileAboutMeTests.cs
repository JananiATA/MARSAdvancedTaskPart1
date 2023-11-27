﻿using AventStack.ExtentReports;
using MARSAdvancedTaskPart1.AssertionHelpers;
using MARSAdvancedTaskPart1.JSONObjectClasses;
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
    public class ProfileAboutMeTests : CommonDriver
    {
        LoginSteps loginSteps = new LoginSteps();
        JSONReader jsonReader;
        LoginAssertion loginAssertion = new LoginAssertion();
        ProfileInfoSteps profileInfoSteps = new ProfileInfoSteps();
        ProfileAboutMeAssertion profileAboutMeAssertion = new ProfileAboutMeAssertion();


        [Test]
        public void UpdateProfileAboutMeTest()
        {
            test = extent.CreateTest("Update Profile AboutMe Section");
            test.Log(Status.Info, "Profile About Me");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }
            string profileAboutMeFilePath = ProjectPathHelper.projectPath + "\\TestData\\ProfileAboutMe\\ProfileAboutMe.json";
            jsonReader = new JSONReader(profileAboutMeFilePath);
            List<ProfileAboutMe> profile = new List<ProfileAboutMe>();
            profile = jsonReader.ReadProfileAboutMeInputFile();
            foreach( var availability in profile)
            {
                profileInfoSteps.ProfileInfo(availability.Availability, availability.Hours, availability.EarnTarget);
                profileAboutMeAssertion.AssertAboutMe(availability.Availability, availability.Hours,availability.EarnTarget);
            }
        }
    }
}
