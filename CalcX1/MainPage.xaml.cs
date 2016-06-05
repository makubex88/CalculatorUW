using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CalcX1
{
    
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int first;
        int second;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_s(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            txtInput.Text += b.Content.ToString();
        }

        

        private void btnEq_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                Result.Text = "Error!";
            }
        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                txtInput.Text = "Error!";
            }
        }

        private void result()
        {
            String op;
            int iOp = 0;
            if (txtInput.Text.Contains("+"))
            {
                iOp = txtInput.Text.IndexOf("+");
            }
            else if (txtInput.Text.Contains("-"))
            {
                iOp = txtInput.Text.IndexOf("-");
            }
            else if (txtInput.Text.Contains("*"))
            {
                iOp = txtInput.Text.IndexOf("*");
            }
            else if (txtInput.Text.Contains("/"))
            {
                iOp = txtInput.Text.IndexOf("/");
            }
            else
            {
                //error 
            }

            op = txtInput.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(txtInput.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(txtInput.Text.Substring(iOp + 1, txtInput.Text.Length - iOp - 1));

            if (op == "+")
            {
                txtInput.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                txtInput.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                txtInput.Text += "=" + (op1 * op2);
            }
            else
            {
                txtInput.Text += "=" + (op1 / op2);
            }
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = "";
        }
    }
}
