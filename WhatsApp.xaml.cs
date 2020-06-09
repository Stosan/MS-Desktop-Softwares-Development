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

namespace WhatsApp_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

//methods for the minimize,maximize and restore buttons using Windows10 style

		private void OnMinimizeButtonClick(object sender, RoutedEventArgs e)
		{
			this.WindowState = WindowState.Minimized;
		}

		private void OnMaximizeRestoreButtonClick(object sender, RoutedEventArgs e)
		{
			if (this.WindowState == WindowState.Maximized)
			{
				this.WindowState = WindowState.Normal;
				maximizeButton.Visibility = Visibility.Visible;
				restoreButton.Visibility = Visibility.Collapsed;
			}
			else
			{
				this.WindowState = WindowState.Maximized;
				maximizeButton.Visibility = Visibility.Collapsed;
				restoreButton.Visibility = Visibility.Visible;
			}
		}

		private void OnCloseButtonClick(object sender, RoutedEventArgs e)
		{
			this.Close();
		}


		private void RefreshMaximizeRestoreButton()
		{
			if (this.WindowState == WindowState.Maximized)
			{
				maximizeButton.Visibility = Visibility.Collapsed;
				restoreButton.Visibility = Visibility.Visible;
				MessageBox.Show("mazimixed working");
			}
			else
			{
				maximizeButton.Visibility = Visibility.Visible;
				restoreButton.Visibility = Visibility.Collapsed;
				MessageBox.Show("restore working");
			}
		}


		private void Window_StateChanged(object sender, EventArgs e)
		{
			this.RefreshMaximizeRestoreButton();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			restoreButton.Visibility = Visibility.Collapsed;
		}
	}

}
