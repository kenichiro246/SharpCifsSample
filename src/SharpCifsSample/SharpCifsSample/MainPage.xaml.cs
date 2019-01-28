using SharpCifs.Smb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SharpCifsSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        string _username = "";
        string _password = "";
        string _server = "192.168.xx.xx";
        string _sharedfoldername = "TestShared";

        private void Button1_Clicked(object sender, EventArgs e)
        {
            var folder = new SmbFile($"smb://{_username}:{_password}@{_server}/{_sharedfoldername}/"); //<-need last'/' in directory
            foreach (var item in folder.ListFiles())
            {
                Console.WriteLine($"Name: {item.GetName()}, isDir?: {item.IsDirectory()}");
            }
        }
    }
}
