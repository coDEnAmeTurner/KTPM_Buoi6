using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Buoi5
{
    public partial class Form1 : Form
    {

        ChromeDriver driver;

        public Form1()
        {
            InitializeComponent();

            //Cau D:
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            driver = new ChromeDriver(chrome);
        }

        //Cau A:
        private void buttonOpenURL_Click(object sender, EventArgs e)
        {

            driver.Navigate().GoToUrl(textBoxURL.Text);
        }

        //Cau B:
        private void buttonOpenURL_Click2(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("http://vnexpress.net");
            textBoxURL.Text = driver.Url;
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);
            textBoxURL.Text = driver.Title;
            Console.WriteLine(driver.PageSource);

            driver.Navigate().Back();
            Thread.Sleep(1000);
            driver.Navigate().Refresh();

        }

        private void buttonOpenURL_Click3(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("http://google.com");
            var element = driver.FindElement(By.Name("q"));
            element.SendKeys(textBoxURL.Text);
        }

        private void buttonOpenURL_Click4(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("http://github.com/login");
            var elementEmail = driver.FindElement(By.Name("login"));
            var elementPass = driver.FindElement(By.Name("password"));
            elementEmail.SendKeys("hahaha@gmail.com");
            elementPass.SendKeys("3256g4erzsa");
        }


        //Cau C:
        private void buttonDong_Click(object sender, EventArgs e)
        {
            driver.Close();
        }

        private void buttonDong_Click2(object sender, EventArgs e)
        {
            driver.Quit();
        }

    }
}
