using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace RusHydro
{
  
    [TestFixture]
    public class VotingQuestionCreationTests : TestBase
    {

        [Test]
        public void VotingQuestionCreationTest()
        {
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountData("TestD_RGS","nbtsap"));
            navigationHelper.GoToVotingQuestionCZK();
            questionHelper.InitQuestionCreation();
            questionHelper.FillQuestionForm(new QuestionData("TestD_question_01"));
            questionHelper.SubmitQuestionCreation();
            loginHelper.Logout();
        }

    }

}
