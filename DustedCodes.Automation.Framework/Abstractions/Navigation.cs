using OpenQA.Selenium;

namespace DustedCodes.Automation.Framework.Abstractions
{
    public static class Navigation
    {
        public static void GoToUrl(string url)
        {
            Browser.GoToUrl(url);
        }

        public static void GoToRoot()
        {
            Browser.GoToRootPage();
        }

        public static void GoToHome()
        {
            Driver.Instance.FindElement(By.LinkText("DUSTED CODES")).Click();
        }

        public static void GoToBlog()
        {
            Driver.Instance.FindElement(By.LinkText("HOME")).Click();
        }

        public static void GoToTrending()
        {
            Driver.Instance.FindElement(By.LinkText("TRENDING")).Click();
        }

        public static void GoToArchive()
        {
            Driver.Instance.FindElement(By.LinkText("ARCHIVE")).Click();
        }

        public static void GoToRssFeed()
        {
            Driver.Instance.FindElement(By.LinkText("SUBSCRIBE")).Click();
        }
    }
}