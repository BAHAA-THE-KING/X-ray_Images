using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.Design.AxImporter;


namespace X_ray_Images.Views.Share
{
    public partial class Whatsapp_Share : ServiceBase
    {
        [DllImport("user32.dll", SetLastError = true)]      
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private const uint WM_CLOSE = 0x0010;

        Thread mainServiceThread = null;
        ServiceController sc = new ServiceController("Whatsapp_Share");
        ManualResetEvent eventForConsoleStart = new ManualResetEvent(false);
        IWebDriver driver;
        ChromeOptions options;
        public static string logininfo = "";
        public bool fileSent = false;
        public string FilePath { get; set; }
        public bool IsDoc { get; set; } = false;

        public event Action FileSent; // Event to signal file sent
        public event Action WaitingForSelectChat;


        public Whatsapp_Share()
        {
            InitializeComponent();
        }

        public void Main()
        {
            options = new ChromeOptions();
            options.AddArgument("--user-data-dir=C:/Users/Abdulrahman KH/AppData/Local/Google/Chrome/User Data/Profile 3");
            options.AddArgument("--disable-extensions");
            driver = new ChromeDriver(options);


            while (true)
            {
                run();
            }
        }
        public void run()
        {
            if (driver != null && driver.Url != null)
            {
                try

                {
                    var currenturl = driver.Url;
                    if (currenturl.Contains("web.whatsapp.com") == false)
                    {
                        driver.Navigate().GoToUrl("https://web.whatsapp.com");
                    }

                    Console.WriteLine("Login to WhatsApp Web Scan The QR CODE From Browser");
                    if (logininfo != "LOGIN")
                    {
                        CheckLoggedIn();
                    }
                    else if (logininfo == "LOGIN")
                    {
                        if (!fileSent)
                        {
                            SendFile(FilePath);
                            fileSent = true;
                            FileSent?.Invoke();
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in run method: " + ex.Message);
                    // Exit the loop if an exception occurs
                }
            }
        }


        public void CheckLoggedIn()
        {
            Thread.Sleep(5000);
            var checked1 = driver.FindElements(By.XPath("//*[@id='app']/div/div/div[2]/div[1]/div/div[2]/div")).SingleOrDefault();
            if (checked1 == null)
            {
                logininfo = "LOGIN";
            }
            else
            {
                logininfo = "NOTLOGIN";
            }
        }


        private static void CloseFileDialog()
        {
            Thread.Sleep(2000); // Wait for the file dialog to open

            // Find the file dialog window
            IntPtr hWnd = FindWindow("#32770", "Open");

            if (hWnd != IntPtr.Zero)
            {
                // Send the WM_CLOSE message to the file dialog
                SendMessage(hWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            }
        }


        public void SendFile(string filePath)
        {
            if (driver == null) return;
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement parentElement = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div[3]/div[1]/div/div"));

            // Find all child elements within the parent element
            IList<IWebElement> childElements = parentElement.FindElements(By.XPath("./*"));

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            // Iterate over each child element
            foreach (IWebElement child in childElements)
            {
                // Attach click event listener using JavaScript
                js.ExecuteScript(@"
                arguments[0].addEventListener('click', function() {
                    // JavaScript click event handler
                    window.__selenium_element_clicked = true;
                });
            ", child);
            }
            WaitingForSelectChat?.Invoke();
            // Wait for an element to be clicked
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            wait.Until(d => (bool)(js.ExecuteScript("return window.__selenium_element_clicked || false;")));

            // Find and click the paperclip icon
            IWebElement paperclipButton = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[4]/div/footer/div[1]/div/span[2]/div/div[1]/div[2]/div/div"));
            paperclipButton.Click();

            // Choose the correct upload option based on file type
            IWebElement uploadOption;
            if (IsDoc)
            {
                uploadOption = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[4]/div/footer/div[1]/div/span[2]/div/div[1]/div[2]/div/span/div/ul/div/div[1]/li/div"));
            }

            else
            {
                uploadOption = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[4]/div/footer/div[1]/div/span[2]/div/div[1]/div[2]/div/span/div/ul/div/div[2]/li/div"));
            }
            uploadOption.Click();
            Thread.Sleep(2000);
            IWebElement fileInput = driver.FindElement(By.CssSelector("input[type='file']"));
            var pdfFilePath = Path.GetFullPath(filePath);
            if (!File.Exists(pdfFilePath))
            {
                Console.WriteLine("File not found: " + pdfFilePath);
                return;
            }
            else
            {
                fileInput.SendKeys(pdfFilePath);
                 Thread.Sleep(1000);
                CloseFileDialog();
                Thread.Sleep(1000);
                try
                {
                    IWebElement sendButton = driver.FindElement(By.XPath("//span[@data-icon='send']"));
                    sendButton.Click();
                    Thread.Sleep(6000);
                    OnStop();
                }
                catch (Exception ex)
                {
                   Console.WriteLine("Error occurred: " + ex.Message);
                }
                finally
                {
                if (driver != null)
                    {
                        driver.Quit();
                    }
                }
            }
        }




        public void OnDebug()
        {
            OnStart(null);
            mainServiceThread.Join();
        }

        protected override void OnStart(string[] args)
        {
            mainServiceThread = new Thread(Main);
            mainServiceThread.IsBackground = false;
            mainServiceThread.Start();
        }

        protected override void OnStop()
        {
            try
            {
                if (driver != null)
                {
                    driver.Quit();
                    driver = null; // Ensure driver is set to null after quitting
                }

                sc.Stop();
                var timeout = new TimeSpan(0, 0, 3);
                sc.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Whatsapp service: " + ex.Message);
            }
            finally
            {
                //Set(): Sets the event, allowing any waiting threads to proceed.
                eventForConsoleStart.Set();
            }
        }
    }
}
