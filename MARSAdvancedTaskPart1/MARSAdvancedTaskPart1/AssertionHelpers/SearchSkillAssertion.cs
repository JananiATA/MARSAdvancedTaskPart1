using MARSAdvancedTaskPart1.Pages.Components.HomePageComponent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSAdvancedTaskPart1.AssertionHelpers
{
    public class SearchSkillAssertion
    {
        SearchSkillComponent searchSkillComponent = new SearchSkillComponent();

        public void AssertSearchSkill(string title)
        {
            string expectedTitle = searchSkillComponent.SharedSkillTitle();
            Assert.That(expectedTitle == title, "Search skill found successfully");
        }
    }
}
