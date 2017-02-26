using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPChatClient.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPChatClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NicknameChanged(object sender, TextChangedEventArgs e)
        {
            if(sender != null)
            {
                var t = ((TextBox)sender).Text;
                if (t.Length > 4) connectButton.IsEnabled = true;
                else connectButton.IsEnabled = false;
            }
        }

        private void Connect(object sender, RoutedEventArgs e)
        {
            var u = new User(nicknameBox.Text);
            var json = JsonConvert.SerializeObject(u, Formatting.Indented);
        }
    }
}
