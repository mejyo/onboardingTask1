using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Education
    {
        IWebElement EducationButton => Driver.driver.FindElement(By.CssSelector("a[data-tab='third']"));
        IWebElement AddNew => Driver.driver.FindElement(By.CssSelector("div[class='ui bottom attached tab segment tooltip-target active'] div[class='ui teal button ']"));
        IWebElement CollegeUniversityName => Driver.driver.FindElement(By.CssSelector("input[placeholder='College/University Name']"));
        IWebElement CountryOfCollege => Driver.driver.FindElement(By.CssSelector("select[name='country']"));
        IWebElement Title => Driver.driver.FindElement(By.CssSelector("select[name='title']"));
        IWebElement Degree => Driver.driver.FindElement(By.CssSelector("input[placeholder='Degree']"));
        IWebElement YearOfGraduation => Driver.driver.FindElement(By.CssSelector("select[name='yearOfGraduation']"));
        IWebElement AddButton => Driver.driver.FindElement(By.CssSelector("input[value='Add']"));
        //IWebElement HasBeenAddedMessage => Driver.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-error ns-show']"));

        IWebElement successMessage => Driver.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']"));

        public void EducationButtonClick()
        {
            EducationButton.Click();
        }

        public void AddNewButtonClick()
        {
            AddNew.Click();
        }

        public void EnteredGivenValuesForAdd(String universityName, String country, String title, String degree, String year)
        {
            CollegeUniversityName.SendKeys(universityName);
            CountryOfCollege.SendKeys(country);
            Title.SendKeys(title);
            Degree.SendKeys(degree);
            YearOfGraduation.SendKeys(year);
            Thread.Sleep(2000);

        }
        public void AddButtonClick()
        {
            AddButton.Click();
            Thread.Sleep(2000);
        }

        public String getActualMessage()
        {
            return successMessage.Text;
        }

        private static IWebElement EditIcon => Driver.driver.FindElement(By.CssSelector("tbody tr td:nth-child(6) span:nth-child(1) i:nth-child(1)"));
        private static IWebElement UpdateButton => Driver.driver.FindElement(By.CssSelector("input[value='Update']"));

        public void EditIconClick()
        {
            EditIcon.Click();
            Thread.Sleep(2000);
        }
        public void EnteredGivenValuesForUpdate(String universityName, String country, String title, String degree, String year)
        {
            Thread.Sleep(2000);
            CollegeUniversityName.Clear();
            Thread.Sleep(2000);
            CollegeUniversityName.SendKeys(universityName);
            Thread.Sleep(2000);
            CountryOfCollege.SendKeys(country);
            Thread.Sleep(2000);
            Title.SendKeys(title);
            Thread.Sleep(2000);
            Degree.Clear();
            Thread.Sleep(2000);
            Degree.SendKeys(degree);
            Thread.Sleep(2000);
            YearOfGraduation.SendKeys(year);
            Thread.Sleep(2000);

        }
        public void UpdateButtonClick()
        {
            UpdateButton.Click();
            Thread.Sleep(2000);
        }

        private static IWebElement DeleteIcon => Driver.driver.FindElement(By.CssSelector("tbody tr td:nth-child(6) span:nth-child(2) i:nth-child(1)"));

        public void DeleteButtonClick()
        {
            DeleteIcon.Click();
            Thread.Sleep(2000);
        }



    }

}