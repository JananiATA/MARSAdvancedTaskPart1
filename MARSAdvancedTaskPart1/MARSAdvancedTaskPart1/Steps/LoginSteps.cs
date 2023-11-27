﻿using MARSAdvancedTaskPart1.Pages.Components.SignIn;
using MARSAdvancedTaskPart1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MARSAdvancedTaskPart1.Pages.Components.Profile;

namespace MARSAdvancedTaskPart1.Steps
{
    public class LoginSteps
    {
        SplashPage loginPage;
        LoginComponent loginComponent;
        
        public LoginSteps()
        {
            loginPage = new SplashPage();
            loginComponent = new LoginComponent();

        }
        
        public void Login(string emailId, string password)
        {
            loginPage.ClickSignInButton();
            loginComponent.DoLogin(emailId, password);
            
        }
    }
}
