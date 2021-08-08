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

namespace ProductionInRS2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            tbStep1.ToolTip = "Выберите агрегат";
            stepMenu.Children.Clear(); //очистка меню

            StackPanel stpAgregat = new StackPanel();
            stpAgregat.Orientation = Orientation.Vertical;

            RadioButton rbStan1700 = new RadioButton();
            rbStan1700.Content = "Cтан1700";
            rbStan1700.FontSize = 20;
            rbStan1700.AddHandler(RadioButton.CheckedEvent, new RoutedEventHandler(Rbtest_Checked));
            stpAgregat.Children.Add(rbStan1700);

            RadioButton rbDsStan = new RadioButton();
            rbDsStan.Content = "Дрессировочный стан";
            rbDsStan.FontSize = 20;
            stpAgregat.Children.Add(rbDsStan);

            stepMenu.Children.Add(stpAgregat);

        }

        
        private void Rbtest_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Нажал");
        }
    }
}
