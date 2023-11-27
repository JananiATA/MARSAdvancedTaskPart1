using MARSAdvancedTaskPart1.Pages.Components.HomePageComponent.AccountMenuComponent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSAdvancedTaskPart1.AssertionHelpers
{
    public class LoginAssertion
    {
        UserDetailsComponent userDetails = new UserDetailsComponent();

        public void AssertLogin(string userName)
        {
            Thread.Sleep(4000);
            string firstName = userDetails.GetFirstName();
            Assert.That(firstName == userName, "User not logged in Successfully");

        }
    }
}
