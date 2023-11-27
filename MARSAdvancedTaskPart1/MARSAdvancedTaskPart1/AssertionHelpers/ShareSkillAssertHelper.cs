using MARSAdvancedTaskPart1.Pages.Components.HomePageComponent.NavigationMenuComponent;
using MARSAdvancedTaskPart1.Pages.Components.Profile;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSAdvancedTaskPart1.AssertionHelpers
{
    public class ShareSkillAssertHelper
    {
        ShareSkillComponent shareSkillComponent = new ShareSkillComponent();
        ManageListingComponent manageListingComponent = new ManageListingComponent();

        public void AssertShareSkill(string expectedMessage,string expectedCategory, string expectedTitle, string expectedDescription)
        {
            string category = manageListingComponent.ListCategory();
            string title = manageListingComponent.ListTitle();
            string description = manageListingComponent.ListDescription();
            Assert.That(category == expectedCategory, "Category not added Successfully");
            Assert.That(title == expectedTitle, "Title not added Successfully");
            Assert.That(description == expectedDescription, "Description not added successfully");

        } 

        public void AssertShareSkillInvalidInput(string expectedMessage)
        {
            string actualMessage = shareSkillComponent.RenderShareSkillPopUpMessage();
            Assert.That(actualMessage == expectedMessage, "Invalid data added");
        }


    }
}
