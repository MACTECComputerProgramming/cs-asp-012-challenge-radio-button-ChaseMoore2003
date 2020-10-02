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

namespace CS_ASP_012CheckBoxChallange
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Radio_pencil.IsChecked == true)
            {
                Label_answer.Content = "Pencil, Very reliable";
                pencil_image.Opacity = 100;
                pen_image.Opacity = 0;
                phone_image.Opacity = 0;
                pad_image.Opacity = 0;

            }
            else
            {
                Label_answer.Content = "Must Pick one ";

            }
            if (Radio_pen.IsChecked == true)
            {
                Label_answer.Content = "Pen, Nice choice";
                pencil_image.Opacity = 0;
                pen_image.Opacity = 100;
                phone_image.Opacity = 0;
                pad_image.Opacity = 0;


            }
            if (Radio_phone.IsChecked == true)
            {
                Label_answer.Content = "Phone, must be from the future";
                pen_image.Opacity = 0;
                pencil_image.Opacity = 0;
                phone_image.Opacity = 100;
                pad_image.Opacity = 0;

            }
            if (Radio_ipad.IsChecked == true)
            {
                Label_answer.Content = "Ipad, Welcome To 2020";
                pencil_image.Opacity = 0;
                pen_image.Opacity = 0;
                phone_image.Opacity = 0;
                pad_image.Opacity = 100;


            }


        }
    }
}
