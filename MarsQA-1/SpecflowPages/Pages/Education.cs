using MarsQA_1.Helpers;
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
    public static class Education
    {

        private static IWebElement EducationButton => Driver.driver.FindElement(By.CssSelector("a[data-tab='third']"));
        private static IWebElement AddNew => Driver.driver.FindElement(By.CssSelector("div[class='ui bottom attached tab segment tooltip-target active'] div[class='ui teal button ']"));
        private static IWebElement CollegeUniversityName => Driver.driver.FindElement(By.CssSelector("input[placeholder='College/University Name']"));
        private static IWebElement CountryOfCollege => Driver.driver.FindElement(By.CssSelector("select[name='country']"));
        private static IWebElement Title => Driver.driver.FindElement(By.CssSelector("select[name='title']"));
        private static IWebElement Degree => Driver.driver.FindElement(By.CssSelector("input[placeholder='Degree']"));
        private static IWebElement YearOfGraduation => Driver.driver.FindElement(By.CssSelector("select[name='yearOfGraduation']"));
        private static IWebElement AddButton => Driver.driver.FindElement(By.CssSelector("input[value='Add']"));



        public static void EducationStep()
        {


            EducationButton.Click();

            AddNew.Click();
            Thread.Sleep(2000);
            //CollegeUniversityName.SendKeys("abc");
            CollegeUniversityName.SendKeys(ExcelLibHelper.ReadData(2, "CollegeORUniversityName"));

            Thread.Sleep(2000);
            //CountryOfCollege.SendKeys("canada");
            CountryOfCollege.SendKeys(ExcelLibHelper.ReadData(2, "Country"));

            Thread.Sleep(2000);
            //Title.SendKeys("B.A");
            Title.SendKeys(ExcelLibHelper.ReadData(2, "Title"));

            Thread.Sleep(2000);
            //Degree.SendKeys("abc");
            Degree.SendKeys(ExcelLibHelper.ReadData(2, "Degree"));

            Thread.Sleep(2000);
            // YearOfGraduation.SendKeys("2021");
            YearOfGraduation.SendKeys(ExcelLibHelper.ReadData(2, "YearOfGraduation"));

            Thread.Sleep(2000);
            AddButton.Click();


        }


        public static void EducationSteps()
        {
            //click education button
            Driver.driver.FindElement(By.CssSelector("a[data-tab='third']")).Click();

            //click add new button
            Driver.driver.FindElement(By.CssSelector("div[class='ui bottom attached tab segment tooltip-target active'] div[class='ui teal button ']")).Click();

            //enter the data
            Driver.driver.FindElement(By.CssSelector("input[placeholder='College/University Name']")).SendKeys("");

            //select the country
            Driver.driver.FindElement(By.CssSelector("select[name='country']")).SendKeys("");

            //select the title 
            Driver.driver.FindElement(By.CssSelector("select[name='title']")).SendKeys("");

            //enter the degree
            Driver.driver.FindElement(By.CssSelector("input[placeholder='Degree']")).SendKeys("");

            //select the year of graduation
            Driver.driver.FindElement(By.CssSelector("select[name='yearOfGraduation']")).SendKeys("");

            //click the add button
            Driver.driver.FindElement(By.CssSelector("input[value='Add']")).Click();



        }

        private static IWebElement EditIcon => Driver.driver.FindElement(By.CssSelector("tbody tr td:nth-child(6) span:nth-child(1) i:nth-child(1)"));
        private static IWebElement EditCollegeUniversityName => Driver.driver.FindElement(By.CssSelector("input[placeholder='College/University Name']"));
        private static IWebElement EditCountryOfCollege => Driver.driver.FindElement(By.CssSelector("select[name='country']"));
        private static IWebElement EditTitle => Driver.driver.FindElement(By.CssSelector("select[name='title']"));
        private static IWebElement EditDegree => Driver.driver.FindElement(By.CssSelector("input[placeholder='Degree']"));
        private static IWebElement EditYearOfGraduation => Driver.driver.FindElement(By.CssSelector("select[name='yearOfGraduation']"));
        private static IWebElement UpdateButton => Driver.driver.FindElement(By.CssSelector("input[value='Update']"));


        public static void UpdateEducationStep()
        {


            EditIcon.Click();
            Thread.Sleep(2000);
            EditCollegeUniversityName.Clear();
            Thread.Sleep(2000);

            // EditCollegeUniversityName.SendKeys("abcd");
            EditCollegeUniversityName.SendKeys(ExcelLibHelper.ReadData(4, "CollegeORUniversityName"));

            Thread.Sleep(2000);
            EditCountryOfCollege.Click();
            Thread.Sleep(2000);
            // EditCountryOfCollege.SendKeys("india");
            EditCountryOfCollege.SendKeys(ExcelLibHelper.ReadData(4, "Country"));

            Thread.Sleep(2000);
            EditTitle.Click();
            Thread.Sleep(2000);
            // EditTitle.SendKeys("M.A");
            EditTitle.SendKeys(ExcelLibHelper.ReadData(4, "Title"));


            Thread.Sleep(2000);
            EditDegree.Clear();
            Thread.Sleep(2000);
            // EditDegree.SendKeys("abcd");
            EditDegree.SendKeys(ExcelLibHelper.ReadData(4, "Degree"));



            Thread.Sleep(2000);
            EditYearOfGraduation.Click();
            Thread.Sleep(2000);
            // EditYearOfGraduation.SendKeys("2022");
            EditYearOfGraduation.SendKeys(ExcelLibHelper.ReadData(4, "YearOfGraduation"));

            Thread.Sleep(2000);
            UpdateButton.Click();
            Thread.Sleep(2000);


        }


        public static void UpdateEducationSteps()
        {

            Driver.driver.FindElement(By.CssSelector("tbody tr td:nth-child(6) span:nth-child(1) i:nth-child(1)"));

            Driver.driver.FindElement(By.CssSelector("input[placeholder='College/University Name']")).SendKeys("");

            Driver.driver.FindElement(By.CssSelector("select[name='country']")).SendKeys("");


            Driver.driver.FindElement(By.CssSelector("select[name='title']")).SendKeys("");

            Driver.driver.FindElement(By.CssSelector("input[placeholder='Degree']")).SendKeys("");

            Driver.driver.FindElement(By.CssSelector("select[name='yearOfGraduation']")).SendKeys("");

            Driver.driver.FindElement(By.CssSelector("input[value='Update']")).Click();


        }


        private static IWebElement DeleteIcon => Driver.driver.FindElement(By.CssSelector("tbody tr td:nth-child(6) span:nth-child(2) i:nth-child(1)"));

        public static void DeleteEducationStep()
        {

            Thread.Sleep(5000);
            DeleteIcon.Click();
            Thread.Sleep(2000);
        }

        public static void DeleteEducationSteps()
        {

            Driver.driver.FindElement(By.CssSelector("tbody tr td:nth-child(6) span:nth-child(1) i:nth-child(1)")).Click();

        }

    }
}