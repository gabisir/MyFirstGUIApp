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
        void ReturnBase(int numberBase)
        {
            if (numberBase == 1)
                radioButton1.IsChecked = true;
            else if (numberBase == 2)
                radioButton2.IsChecked = true;
            else if (numberBase == 3)
                radioButton3.IsChecked = true;
            else if (numberBase == 4)
                radioButton4.IsChecked = true;
        }
        public MainPage()
        {
            this.InitializeComponent();
            textBox1.Text="";
            textBox2.Text="";
        }
        int result=0, first=0, second=0;
        int numberBase = 1;
        bool baseChange = false;
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
            if (baseChange == true)
                numberBase = 1;
            radioButton1.IsChecked = true;
            first = Int32.Parse(textBox1.Text);
            second = Int32.Parse(textBox2.Text);
            result = first + second;
            textBlockAns.Text=result.ToString();
            ReturnBase(numberBase);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            //subtraction
            if (baseChange == true)
                numberBase = 1;
            radioButton1.IsChecked = true;
            first = Int32.Parse(textBox1.Text);
            second = Int32.Parse(textBox2.Text);
            result = first - second;
            textBlockAns.Text = result.ToString();
            ReturnBase(numberBase);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            //multiplication
            if (baseChange == true)
                numberBase = 1;
            radioButton1.IsChecked = true;
            first = Int32.Parse(textBox1.Text);
            second = Int32.Parse(textBox2.Text);
            result = first * second;
            textBlockAns.Text = result.ToString();
            ReturnBase(numberBase);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            //division
            if (baseChange == true)
                numberBase = 1;
            radioButton1.IsChecked = true;
            first = Int32.Parse(textBox1.Text);
            second = Int32.Parse(textBox2.Text);
            if (second == 0)
                textBlockAns.Text = "∞";
            else
            {
                result = first / second;
                textBlockAns.Text = result.ToString();
            }
            ReturnBase(numberBase);
        }
        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            //decimal
            if (baseChange == true)
                numberBase = 1;
            if(radioButton1.IsChecked==true)
            {
                textBlockAns.Text = Convert.ToString(result, 10);
                textBox1.Text = Convert.ToString(first, 10);
                textBox2.Text = Convert.ToString(second, 10);
            }
            baseChange = true;
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            //binary
            numberBase = 2;
            if (radioButton2.IsChecked == true)
            {
                textBlockAns.Text = Convert.ToString(result, 2);
                textBox1.Text = Convert.ToString(first, 2);
                textBox2.Text = Convert.ToString(second, 2);
                baseChange = false;
            }
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            //hexadecimal
            numberBase = 3;
            if (radioButton3.IsChecked == true)
            {
                textBlockAns.Text = Convert.ToString(result, 16);
                textBox1.Text = Convert.ToString(first, 16);
                textBox2.Text = Convert.ToString(second, 16);
                baseChange = false;
            }
        }

        private void radioButton4_Checked(object sender, RoutedEventArgs e)
        {
            //octal
            numberBase = 4;
            if (radioButton4.IsChecked == true)
            {
                textBlockAns.Text = Convert.ToString(result, 8);
                textBox1.Text = Convert.ToString(first, 8);
                textBox2.Text = Convert.ToString(second, 8);
                baseChange = false;
            }
        }
    }
}
