using MARSAdvancedTaskPart1.Pages.Components.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSAdvancedTaskPart1.Steps
{
    public class ProfileInfoSteps
    {
        ProfileAboutMeComponent profileAboutMeComponent;

        public ProfileInfoSteps()
        {
            profileAboutMeComponent = new ProfileAboutMeComponent();
        }

        public void ProfileInfo(string availability, string hours, string earnTarget)
        {
           
            profileAboutMeComponent.UpdateProfileInfo(availability, hours, earnTarget);

        }
    }
}
