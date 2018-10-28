using System;
using System.IO;
using System.Windows;
using CefSharp;


namespace TestGoogleMapsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // loadFile();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            var script = string.Format("addMarker({0}, {1});", LatitudeTextBox.Text, LongtitudeTextBox.Text);
            ChromiumWebBrowser.EvaluateScriptAsync(script);
          

        }




       
    }
}
