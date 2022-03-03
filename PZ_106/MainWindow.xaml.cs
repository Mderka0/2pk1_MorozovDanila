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

namespace PZ_106
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
        double defWinWidth;
        double defFontSize;
        private void windowLoaded_Loaded(object sender, RoutedEventArgs e)
        {
            defWinWidth = calcWindow.Width;
            defFontSize = textBlock.FontSize;
            textBlock.FontSize = defFontSize;
        }


        private void onChangeSizeWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            textBlock.FontSize = calcWindow.Width / defWinWidth * defFontSize;
        }

    }
}
