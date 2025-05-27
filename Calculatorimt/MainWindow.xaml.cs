using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Calculatorimt
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

        private void CountB_Click(object sender, RoutedEventArgs e)
        {

            if (!double.TryParse(WeightTB.Text, out double weight) || weight <= 0)
            {
                if (!double.TryParse(LengthTB.Text, out double length) || length <= 0)
                {
                    double imt = 0;

                    imt = weight / length/100 * length / 100;
                    if (imt > 19 && imt < 25)
                    {
                        MessageBox.Show($"Ваш ИМТ: {imt} - Нормальный вес");
                    }
                    else
                    {

                        MessageBox.Show($"Ваш ИМТ: {imt} - Ненормальный вес");
                    }
                }
                    
            }
        }
    }
}
