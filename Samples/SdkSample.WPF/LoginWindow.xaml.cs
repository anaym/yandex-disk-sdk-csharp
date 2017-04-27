using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Windows;

using Disk.SDK;
using Disk.SDK.Provider;

namespace SdkSample.WPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        /// TODO: Register your application https://oauth.yandex.ru/client/new and set here your application ID and return URL.

        private const string CLIENT_ID = "c5881d81b6ae4313801d7a839041f7c8";
        private const string RETURN_URL = "https://oauth.yandex.ru/verification_code";

        private readonly IDiskSdkClient sdkClient;

        public LoginWindow()
        {
            this.InitializeComponent();
        }

        public LoginWindow(IDiskSdkClient sdkClient)
            : this()
        {
            this.sdkClient = sdkClient;

            var cpath = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
            NativeMethods.SuppressCookiePersist();
            this.sdkClient.AuthorizeAsync(new WebBrowserWrapper(browser), CLIENT_ID, RETURN_URL, this.CompleteCallback);
        }

        private void CompleteCallback(object sender, GenericSdkEventArgs<string> e)
        {
            if (this.AuthCompleted != null)
            {
                this.AuthCompleted(this, new GenericSdkEventArgs<string>(e.Result));
            }

            this.Close();
        }

        public event EventHandler<GenericSdkEventArgs<string>> AuthCompleted;
    }

    public static class NativeMethods
    {
        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption,
                                                     IntPtr lpBuffer, int lpdwBufferLength);

        public static void SuppressCookiePersist()
        {
            int dwOption = 81; //INTERNET_OPTION_SUPPRESS_BEHAVIOR
            int option = 3; // INTERNET_SUPPRESS_COOKIE_PERSIST

            IntPtr optionPtr = Marshal.AllocHGlobal(sizeof(int));
            Marshal.WriteInt32(optionPtr, option);

            InternetSetOption(IntPtr.Zero, dwOption, optionPtr, sizeof(int));
            Marshal.FreeHGlobal(optionPtr);
        }
    }
}