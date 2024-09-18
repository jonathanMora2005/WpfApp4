﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
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
        private void ActivarCampCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            CampExtraTextBox.Visibility = Visibility.Visible;
        }

        private void ActivarCampCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            CampExtraTextBox.Visibility = Visibility.Collapsed;
        }

    }
}