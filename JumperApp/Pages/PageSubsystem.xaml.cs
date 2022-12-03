using JumperApp.AppDataFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JumperApp.Pages
{
    /// <summary>
    /// Interaction logic for PageSubsystem.xaml
    /// </summary>
    public partial class PageSubsystem : Page
    {
        public PageSubsystem()
        {
            InitializeComponent();
        }

        private void BtnAgents_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageAgents());
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageProduct());
        }

        private void BtnManufacture_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageManufacture());
        }

        private void BtnAddAgent_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageAddEditAgent());
        }

        private void BtnWarehouseMaterials_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageWarehouseMaterials());
        }

        private void BtnEmployees_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageEmployees());
        }
    }
}
