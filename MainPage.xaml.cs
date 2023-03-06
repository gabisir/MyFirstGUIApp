using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyFirstGUIApp
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
        int result=0, first=0, second=0;

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //addition
            first = Int32.Parse(textBox1.Text);
            second = Int32.Parse(textBox2.Text);
            result = first + second;
            textBlockAns.Text=result.ToString();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            //subtraction
            first = Int32.Parse(textBox1.Text);
            second = Int32.Parse(textBox2.Text);
            result = first - second;
            textBlockAns.Text = result.ToString();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            //multiplication
            first = Int32.Parse(textBox1.Text);
            second = Int32.Parse(textBox2.Text);
            result = first * second;
            textBlockAns.Text = result.ToString();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            //division
            first = Int32.Parse(textBox1.Text);
            second = Int32.Parse(textBox2.Text);
            if (second == 0)
                textBlockAns.Text = "∞";
            else
            {
                result = first / second;
                textBlockAns.Text = result.ToString();
            }
        }
        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            //decimal
            if(radioButton1.IsChecked==true)
            {
                textBlockAns.Text = Convert.ToString(result, 10);
            }
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            //binary
            if (radioButton2.IsChecked == true)
            {
                textBlockAns.Text = Convert.ToString(result, 2);
            }
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            //hexadecimal
            if (radioButton3.IsChecked == true)
            {
                textBlockAns.Text = Convert.ToString(result, 16);
            }
        }

        private void radioButton4_Checked(object sender, RoutedEventArgs e)
        {
            //octal
            if (radioButton4.IsChecked == true)
            {
                textBlockAns.Text = Convert.ToString(result, 8);
            }
        }
    }
}
