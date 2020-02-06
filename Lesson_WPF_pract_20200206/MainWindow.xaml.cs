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

using RestSharp;
using RestSharp.Authenticators;

namespace Lesson_WPF_pract_20200206
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, RoutedEventArgs e)
        {
            string text = tbxText.Text;
            int size = 0;

            foreach(RadioButton rb in spRbList.Children)
            {
                if ((bool)rb.IsChecked)
                {
                    size = Convert.ToInt32(rb.Content);
                    break;
                }   
            }

            QrApp.lib.Qr.genQR(text, size);
        }
    }
}
