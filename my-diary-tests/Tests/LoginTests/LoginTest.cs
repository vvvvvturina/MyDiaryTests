// Generated by Selenium IDE

namespace my_diary_tests;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using my_diary_tests;

[TestFixture]
public class LoginTest : TestBase
{
    [Test, Order(1)]
    public void LoginWithValidData()
    { 
        appManager.Navigation.OpenHomePage();
        appManager.Authentication.Login(appManager.Authentication.userData);
        //Assert.AreEqual(true, appManager.loggedIn);
    }

    [Test]
    public void LoginWithInvalidData()
    {
        appManager.Navigation.OpenHomePage();
        appManager.Authentication.Login(new AccountData("wrong", "invalid"));
        Thread.Sleep(4000);
        appManager.Stop();
    }
}
