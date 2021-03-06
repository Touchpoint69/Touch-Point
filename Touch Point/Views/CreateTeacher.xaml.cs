﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Touch_Point.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateTeacher : Page
    {
        public CreateTeacher()
        {
            this.InitializeComponent();
        }

        private void _CourseButton__Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CreateCourse));
        }
        private void _StudentButton__Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CreateStudent));
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void _AdminButton__Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
