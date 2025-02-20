using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using Wabbajack.Common;

namespace Wabbajack
{
    /// <summary>
    /// Interaction logic for LinksView.xaml
    /// </summary>
    public partial class LinksView : UserControl
    {
        public LinksView()
        {
            InitializeComponent();
        }

        private void GitHub_Click(object sender, RoutedEventArgs e)
        {
            UIUtils.OpenWebsite(new Uri("https://modhq.org/"));
        }

        private void Discord_Click(object sender, RoutedEventArgs e)
        {
            UIUtils.OpenWebsite(new Uri("https://rpghq.org/forums/index.php"));
        }

        private void Patreon_Click(object sender, RoutedEventArgs e)
        {
            UIUtils.OpenWebsite(new Uri("https://rpghq.org/forums/viewtopic.php?t=414-acquiring-hq-platinum"));
        }
    }
}
