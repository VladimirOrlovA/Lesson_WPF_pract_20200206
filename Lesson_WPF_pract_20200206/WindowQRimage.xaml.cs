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
using System.Windows.Shapes;

namespace Lesson_WPF_pract_20200206
{
    /// <summary>
    /// Логика взаимодействия для WindowQRimage.xaml
    /// </summary>
    public partial class WindowQRimage : Window
    {
        public WindowQRimage(byte[] buffer, int height, int width)
        {
            InitializeComponent();
        }


    }
}
