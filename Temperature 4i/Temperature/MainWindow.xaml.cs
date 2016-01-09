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

namespace Temperature
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static class ConvertiT
        {
            public static double ToCelsius(double t, int i)
            {
                double Temp;
                if (i == 0) 
                    return Temp = t;
                else if(i==1)
                    return Temp = t - 273.15;
                else
                    return Temp = (t-32) / 1.8;
            }
            public static double ToKelvin(double t, int i)
            {
                double Temp;
                if (i == 1)
                    return Temp = t;
                else if (i == 0)
                    return Temp = t + 273.15;
                else
                    return Temp = ((t + 459.67) / 1.8);
            }
            public static double ToFahrenheit(double t, int i)
            {
                double Temp;
                if (i == 2)
                    return Temp = t;
                else if (i == 0)
                    return Temp = (t * 1.8) + 32;
                else
                    return Temp = (t * 1.8) - 459.67;
            }
            
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, RoutedEventArgs e)
        {
            double TempConv;
            double t = double.Parse(txt_1.Text);
            if (cmb_2.SelectedIndex == 0)
                TempConv = ConvertiT.ToCelsius(t, cmb_1.SelectedIndex);
            else if (cmb_2.SelectedIndex == 1)
                TempConv = ConvertiT.ToKelvin(t, cmb_1.SelectedIndex);
            else
                TempConv = ConvertiT.ToFahrenheit(t, cmb_1.SelectedIndex);
            lbl_ris.Content = TempConv;
        }
    }
}
