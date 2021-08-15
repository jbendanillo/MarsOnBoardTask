using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace MarsQA_1.Pages
{
    public static class ProfileDetailsPage
    {
        private static IWebElement ProfileTab => Driver.driver.FindElement(By.LinkText("Profile"));

        private static IWebElement AvailabilityButton => Driver.driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/span[1]/i[1]"));
        private static IWebElement HourButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        private static IWebElement EarnTargetButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));

        public static void UserIsInProfilePage()
        {
            ProfileTab.Click();
        }

        public static void UserClicksOnAvailability()
        {
            Thread.Sleep(3000);
            AvailabilityButton.Click();
        }

        public static void UserSelectsOptionFromAvailabilityDropdown()
        {
            var availability = Driver.driver.FindElement(By.Name("availabiltyType"));
            var selectElementh = new SelectElement(availability);
            selectElementh.SelectByValue("1");
            Thread.Sleep(3000);
        }

        public static void UserClicksOnHoursField()
        {
            Thread.Sleep(3000);
            HourButton.Click();
        }

        public static void UserSelectsOptionFromHoursDropdown()
        {
            Thread.Sleep(3000);
            var hour = Driver.driver.FindElement(By.Name("availabiltyHour"));
            var selectElement = new SelectElement(hour);
            selectElement.SelectByValue("1");
            Thread.Sleep(3000);
        }

        public static void UserClicksOnEarnTargetField()
        {
            Thread.Sleep(3000);
            EarnTargetButton.Click();
        }

        public static void UserSelectsOptionEarnTargetDropdown()
        {
            var earnTarget = Driver.driver.FindElement(By.Name("availabiltyTarget"));
            var selectElementt = new SelectElement(earnTarget);
            selectElementt.SelectByValue("1");
            Thread.Sleep(3000);
        }
    }
}