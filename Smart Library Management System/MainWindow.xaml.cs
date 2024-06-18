﻿using System;
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

namespace Smart_Library_Management_System
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

        private void cbShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            tbPasswordCheck.Text = pbPassword.Password;
            tbPasswordCheck.Visibility = Visibility.Visible;
            pbPassword.Visibility = Visibility.Collapsed;
        }

        private void cbShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            pbPassword.Password = tbPasswordCheck.Text;
            pbPassword.Visibility=Visibility.Visible;
            tbPasswordCheck.Visibility=Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User_Homepage UH = new User_Homepage();
            UH.Show();
            this.Close();
        }
    }
}
