using System;
using TechTalk.SpecFlow;
using LoginUser;
using NUnit.Framework;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private string userName;
        private string password;
        private string loginResult;
        private readonly ScenarioContext scenarioContext;
        private readonly LoginUsers loginuser;
        public LoginStepDefinitions(ScenarioContext sc)
        {
            this.scenarioContext = sc;
            loginuser = new LoginUser.LoginUsers();
        }
        [Given(@"a user with valid username ""([^""]*)"" and password ""([^""]*)""")]
        public void GivenAUserWithValidUsernameAndPassword(string p0, string p1)
        {
            //throw new PendingStepException();
            userName = p0;
            password = p1;
        }

        [When(@"the Login method is called")]
        public void WhenTheLoginMethodIsCalled()
        {
            //throw new PendingStepException();
            
            loginResult = loginuser.Login(userName, password);
        }

        [Then(@"the result should Login Success")]
        public void ThenTheResultShouldLoginSuccess()
        {
            //  throw new PendingStepException();
            Assert.AreEqual("Login Success", loginResult);
        }

        [Given(@"a user with invalid username ""([^""]*)"" and invalid password ""([^""]*)""")]
        public void GivenAUserWithInvalidUsernameAndInvalidPassword(string p0, string invalid)
        {
            //  throw new PendingStepException();
            userName = p0;
            userName = invalid;
        }

        [Then(@"the result should Login Failed")]
        public void ThenTheResultShouldLoginFailed()
        {
            // throw new PendingStepException();
            Assert.AreEqual("Login Failed", loginResult);
        }
    }
}
